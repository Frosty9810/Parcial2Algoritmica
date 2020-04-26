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
        public void Buscar(int id) {

            int indice = 0;
            indice = FuncionHash(id);
            Console.WriteLine(" ");
            if (tabla[indice].Existe(id))
            {
                Console.WriteLine("Existe");
            }
            else {
                Console.WriteLine("No existe");
            }

        }
       
        public void BuscarSecuencial(int id) {
            int indice = 0;
            indice = FuncionHash(id);
            Console.WriteLine(" ");
            if (tabla[indice].Existe(id))
            {
                Console.WriteLine("El CI: {0} Existe",id);
            }
            else
            {
                Console.WriteLine("No existe el CI: {0} en la lista",id);
            }

        }
        public void Eliminar(int id) {
            int indice = 0;
            indice = FuncionHash(id);
            Console.WriteLine(" ");
            if (tabla[indice].Existe(id))
            {
                Console.WriteLine("Id a Eliminar");
                Console.WriteLine("El {0} existe y será eliminado",id);
                tabla[indice].Borrar(indice);
            }
            else
            {
                Console.WriteLine("El CI: {0} a eliminar no existe",id);
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
