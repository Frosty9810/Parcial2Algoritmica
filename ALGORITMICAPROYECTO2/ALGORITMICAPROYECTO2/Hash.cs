using System;
using System.Collections.Generic;
using System.Text;

namespace ALGORITMICAPROYECTO2
{
    class Hash
    {
        private Paciente[] tabla; //declaramos el arreglo que será la tabla  hash
        private int cantidad; //representa el tamaño del arreglo
        private int insertados; //para saber la cantidad de elementos insertados y controlar el porcentaje de lleno

        public Hash(int pTamaño)
        {
            int n = 0;
            cantidad = pTamaño;
            insertados = 0;
            tabla = new Paciente[cantidad];

            //instanciamos cada una de las celdas de la tabla
            for (n = 0; n < cantidad; n++)
                tabla[n] = new Paciente();
        }
        public int FuncionHash(int pLlave, int pIntento)
        {
            int indice = 0;

            //Sondeo Lineal
            //indice = (pLlave + pIntento) % cantidad;

            //Sondeo Cuadrático
            indice = (pLlave + pIntento * pIntento) % cantidad;

            return indice;
        }

        public void Mostrar()
        {
            int n = 0;

            for (n = 0; n < cantidad; n++)
            {
                Console.WriteLine("{0} [{1},{2}]", n, tabla[n].Llave, tabla[n].Valor);
            }
        }
        
        public void Insertar(int pLlave, string pValor)
        {
            int i = 0; //Contador de intentos

            int indice = 0;
            bool ocupado = false; //para saber si la celda está ocupada

            while (ocupado == false)
            {
                //calculamos el indice
                indice = FuncionHash(pLlave, i);

                //verificamos si está vacía la celda, si es asi la llenamos con el elemento
                if (tabla[indice].MiEstado == estado.vacio) //controlar también si el estado es "borrado"
                {
                    ocupado = true;
                    tabla[indice].Llave = pLlave;
                    tabla[indice].Valor = pValor;
                    tabla[indice].MiEstado = estado.ocupado;
                    insertados++; //para llevar la cuenta de la cantidad de elementos insertados
                }
                else //si la celda no está vaciá, incrementamos el intento con i++
                {
                    //hacemos avanzar al siguiente intento
                    i++;
                }
            }

            //Verificamos si es necesario hacer REHASH
            if (insertados >= ((double)cantidad * 0.7))
            {
                Console.WriteLine("--Es necesario  hacer REHASH, {0} de {1} ocupados", insertados, cantidad);
                ReHash(); //llamamos al método que redimensiona el arreglo
            }
        }//fin insertar
        public void Buscar(int pLlave)
        {
            int i = 0; //Contador de intentos
            bool a = true;
            int indice = 0;
           

            while (a)
            {
               
                indice = FuncionHash(pLlave, i);


                if (tabla[indice].Llave == pLlave)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("---------------PACIENTE ENCONTRADO---------------");
                    Console.ResetColor();
                    Console.WriteLine("El paciente es: {0}, la posicion en la cola es: {1}",pLlave, indice);
                    a = false;

                }

                i++;
            }
        }
        public void Eliminar(int pLlave)
        {

            int i = 0; //Contador de intentos

            int indice = 0;
            bool ocupado = true; //para saber si la celda está ocupada

            while (ocupado)
            {
                //calculamos el indice
                indice = FuncionHash(pLlave, i);

                if (tabla[indice].Llave == pLlave)
                {
                    tabla[indice].Llave = 0;
                    tabla[indice].Valor = "";
                    tabla[indice].MiEstado = estado.borrado;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("---------------PACIENTE ELIMINADO---------------");
                    Console.ResetColor();
                    Console.WriteLine("Paciente eliminado {0}, numero de CI: {1}",indice,pLlave);
                    ocupado = false;
                                                        
                }
                else
                {
                    i++;
                }

               
            }
        }
        public static int PrimoCercano(int pValor)
        {
            int primo = 0;
            bool divide = false;
            int n = 0;

            while (primo == 0)
            {
                divide = false;
                for (n = 2; n < pValor; n++)
                {
                    if (pValor % n == 0)
                    {
                        divide = true;
                        pValor++;
                        break;
                    }
                }

                if (divide == false)
                    primo = pValor;
            }

            return primo;
        }//fin PrimoCercano

        //método para hacer el redimmensionamiento Rehash
        public void ReHash()
        {
            //calculamos el nuevo tamaño
            int nCantidad = PrimoCercano(cantidad * 2); //el nuevo tamaño de la tabla
            int cantAnterior = cantidad; //variable auxiliar que me servirá para pasar los valores a la tabla nueva
            int n = 0;
            int llave = 0;  //guarda temporalmente a llave
            string valor = ""; //guarta temporalmente al valor

            int i = 0;
            int indice = 0;
            bool ocupado = false;

            Console.WriteLine("Ahora la tabla será de {0} espacios de tamaño", nCantidad);

            //creamos una nueva tabla temporal del tamaño nuevo
            Paciente[] temp = new Paciente[nCantidad];

            for (n = 0; n < nCantidad; n++)
                temp[n] = new Paciente();

            //Actualizamos cantidad para que la función hash funcione bien
            cantidad = nCantidad;

            //recorremos la tabla original y vamos insertando en la nueva tabla temp elemento a elemento
            for (n = 0; n < cantAnterior; n++)
            {
                //verificamos si hay un elemento a insertar
                if (tabla[n].MiEstado == estado.ocupado)
                {
                    llave = tabla[n].Llave; //obtengo la llave para insertarla en la nueva tabla
                    valor = tabla[n].Valor; //igual al anterior

                    ocupado = false;

                    //hacemos la inserción en la nueva tabla
                    while (ocupado == false)
                    {
                        //calculamos el índice
                        indice = FuncionHash(llave, i);

                        //verificamos si la celda está vacía
                        if (temp[indice].MiEstado == estado.vacio)
                        {
                            ocupado = true;
                            temp[indice].Llave = llave;
                            temp[indice].Valor = valor;
                            temp[indice].MiEstado = estado.ocupado;
                            insertados++;
                        }
                        else
                        {
                            //avanzamos al sgte intento
                            i++;
                        }
                    }
                }
            }

            tabla = (Paciente[])temp.Clone(); //estamos clonando temp y el destino es tabla
        }

    }
}
