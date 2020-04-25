using System;
using System.Collections.Generic;
using System.Text;

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
        public void MostrarPacientes()
        {
            for (int i = 0; i < tabla.Length; i++)
            {
                Console.WriteLine(" ");
                tabla[i].Imprimir();
            }
        }
        //definimos la función hash que recibe la llave y en nro de intento
        public static int FuncionHash(int pLlave)
        {
            int indice = 0;
            indice = pLlave % tabla.Length;
            return indice;
        }


    }
}
