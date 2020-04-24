
using System;
using System.Collections.Generic;


namespace ALGORITMICAPROYECTO2
{
	class Program
	{



        private static Paciente[] tabla; //declaramos el arreglo que será la tabla  hash
        private static int cantidad; //representa el tamaño del arreglo
        static void Main(string[] args)
        {
           
            int n = 0;

            //inicializamos la tabla
            cantidad = 11;

            tabla = new Paciente[cantidad];

            //instanciamos cada una de las celdas de la tabla
            for (n = 0; n < cantidad; n++)
                tabla[n] = new Paciente();

            //insertamos elementos e imprimimos

            Insertar(23, "Materia");
            Insertar(51, "Algorítmica");
            Insertar(40, "Tema");
            Insertar(62, "Estructuras Hash");


            Mostrar();
            Buscar(23);
            Eliminar(62);
            Mostrar();
            Console.ReadLine();
        }

        //definis el método Mostrar() que imprime la tabla hash
        public static void Mostrar()
        {
            int n = 0;

            for (n = 0; n < cantidad; n++)
            {
                Console.WriteLine("{0} [{1},{2}]", n, tabla[n].Llave, tabla[n].Valor);
            }
        }

        //definimos la función hash que recibe la llave y en nro de intento
        public static int FuncionHash(int pLlave, int pIntento)
        {
            int indice = 0;

            //Sondeo Lineal
            indice = (pLlave + pIntento) % cantidad;

            //Sondeo Cuadrático
            //indice = (pLlave + pIntento*pIntento) % cantidad;

            return indice;
        }

        //definimos el método para insertar elementos en la tabla hash, le pasamos la llave y el valor
        public static void Insertar(int pLlave, string pValor)
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
                }
                else //si la celda no está vaciá, incrementamos el intento con i++
                {
                    //hacemos avanzar al siguiente intento
                    i++;
                }
            }
        }
        public static void Buscar(int pLlave)
        {
            int i = 0; //Contador de intentos
            bool a = true;
            int indice = 0;
            //bool ocupado = false; //para saber si la celda está ocupada


            while (a)
            {
                //calculamos el indice
                indice = FuncionHash(pLlave, i);


                if (tabla[indice].Llave == pLlave)
                {
                    Console.WriteLine("La posicion es:" + indice);
                    a = false;

                }

                i++;




            }

        }
        public static void Eliminar(int pLlave)
        {

            int i = 0; //Contador de intentos

            int indice = 0;
            bool ocupado = true; //para saber si la celda está ocupada

            while (ocupado)
            {
                //calculamos el indice
                indice = FuncionHash(pLlave, i);

                //verificamos si está vacía la celda, si es asi la llenamos con el elemento
                if (tabla[indice].Llave == pLlave) //controlar también si el estado es "borrado"
                {
                    tabla[indice].Llave = 0;
                    tabla[indice].Valor = "";
                    tabla[indice].MiEstado = estado.borrado;
                    ocupado = false;

                }
                else
                {
                    i++;
                }

                //hacemos avanzar al siguiente intento


            }
        }


    }
}
