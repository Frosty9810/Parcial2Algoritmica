
using System;
using System.Collections.Generic;


namespace ALGORITMICAPROYECTO2
{
	class Program
	{
        static void Main(string[] args)
        {

            Hash miTabla = new Hash(11);

            //insertamos elementos e imprimimos
            miTabla.Insertar(23, "Materia");
            miTabla.Insertar(51, "Algorítmica");
            miTabla.Insertar(40, "Tema");
            miTabla.Insertar(62, "Estructuras Hash");
            miTabla.Insertar(32, "Método");
            miTabla.Insertar(11, "Resolución de colisiones");
            miTabla.Insertar(21, "Usando Rehash");

            miTabla.Mostrar();

           
            miTabla.Buscar(21);
            miTabla.Eliminar(51);
            miTabla.Mostrar(); 

            Console.ReadLine();


        }
    }
}
