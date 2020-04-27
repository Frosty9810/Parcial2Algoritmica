using System;
using System.Collections.Generic;
using System.Text;
using static ALGORITMICAPROYECTO2.LinkedList;

namespace ALGORITMICAPROYECTO2
{
    class Hash
    {

        private static LinkedList[] tabla;
        public Hash(int size)
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
        public void BusquedaBinaria(int id) {
            int indice = 0;
            indice = FuncionHash(id);
            tabla[indice].ExisteBinario(id);

        }
        //ELIMINAR POR NOMBRE 
        public void EliminarSecuencialmente(string id)
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
                        caca++;
                        Console.WriteLine(caca);
                        tabla[indice].Remove(id);
                        Console.WriteLine("El Nombre: {0} esta en el hospital y se eliminarà", id);
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
        //ELIMINAR POR CEDULA DE IDENTIDAD
        public void EliminarSecuencial(int id)
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
                        Console.WriteLine("El Nombre: {0} esta en el hospital y se eliminara", id);
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
                Console.WriteLine("");
                Console.WriteLine("["+i+"]");
                Console.WriteLine("");

                tabla[i].Imprimir();
            }
        }
        public void MostrarPacienteporCI() {


            for (int i = 0; i < tabla.Length; i++)
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("[" + i + "]");
                Console.ResetColor();
                Console.WriteLine("");

                tabla[i].ImprimirporCI();
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
