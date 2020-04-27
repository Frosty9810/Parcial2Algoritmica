using System;
using System.Collections.Generic;
using System.Text;

namespace ALGORITMICAPROYECTO2
{
    class Hash2
    {
        private static LinkedList[] tabla;



        public Hash2(int size)
        {
            int n = 0;
            //inicializamos la tabla
            tabla = new LinkedList[size];
            //instanciamos cada una de las celdas de la tabla
            for (n = 0; n < size; n++)
            {
                tabla[n] = new LinkedList();
            }
        }

        public void Añadir(int id, string name, string Tipopaciente, string fechaingreso)
        {

            int indice = 0;
            indice = FuncionHash(id);
            Console.WriteLine(" ");
            tabla[indice].InsertarFinal(id, name, Tipopaciente, fechaingreso);


        }
      
        //ENCONTRAR POR NOMBRE
        public void BuscarSecuencial(string name)
        {
            int indice = 0;
            bool existe = true;
            try
            {
                while (existe)
                {
                    if (tabla[indice].ExisteSecuencial(name))
                    {
                        Console.WriteLine("El Nombre: {0} esta en el hospital", name);
                        existe = false;
                    }
                    else
                    {
                        indice++;
                    }
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                
                Console.WriteLine("No se encontro el nombre: {0}",name);
            }


        }

        public void EliminarCedula(int id)
        {
            int indice = 0;
            int caca = 0;
            bool existe = true;
            try
            {
                while (existe)
                {
                    if (tabla[indice].ExisteCI(id))
                    {
                        caca++;
                        Console.WriteLine(caca);
                        tabla[indice].Eliminar(id);
                        Console.WriteLine("El Nombre: {0} esta en el hospital", id);
                        existe = false;
                    }
                    else
                    {
                        indice++;
                    }
                }
            }
            catch (IndexOutOfRangeException ex)
            {

                Console.WriteLine("No se encontro el nombre: {0}", id);
            }


        }
        public void EliminarNombre(string id)
        {
            int indice = 0;
            int caca = 0;
            bool existe = true;
            try
            {
                while (existe)
                {
                    if (tabla[indice].Existe(id))
                    {
                       
                        tabla[indice].Remove(id);
                        Console.WriteLine("El Nombre: {0} esta en el hospital", id);
                        existe = false;
                    }
                    else
                    {
                        indice++;
                    }
               }
            }
            catch (IndexOutOfRangeException ex)
            {

                Console.WriteLine("No se encontro el nombre: {0}", id);
            }


        }
        
        public void MostrarPacientes()
        {
            for (int i = 0; i < tabla.Length; i++)
            {
                Console.WriteLine(" ");
                tabla[i].Imprimir();
            }
        }
        //definimos la función hash que recibe la llave y en nro de intento
        private static int FuncionHash(int pLlave)
        {
            int indice = 0;
            indice = pLlave % tabla.Length;
            return indice;
        }

    }
}
