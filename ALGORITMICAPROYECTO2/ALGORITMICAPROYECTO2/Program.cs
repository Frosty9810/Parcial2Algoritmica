
using System;
using System.Collections.Generic;


namespace ALGORITMICAPROYECTO2
{
	class Program
	{
        // private static Paciente[] tabla; //declaramos el arreglo que será la tabla  hash
        private static int cantidad = 11; //representa el tamaño del arreglo
        static void Main(string[] args)
        {

            Hash pr = new Hash(cantidad);

            pr.Añadir(11, "Rivas", "Internado", "14/2/2020");
            pr.Añadir(11, "Rivas", "Internado", "14/2/2020");
            pr.Añadir(11, "Rivas", "Internado", "14/2/2020");

            pr.Añadir(2, "Rivas", "Internado", "14/2/2020");
            pr.Añadir(3, "Rivas", "Internado", "14/2/2020");
            pr.Añadir(4, "Rivas", "Internado", "14/2/2020");
            pr.BuscarSecuencial(1);
            pr.Buscar(2);
            pr.Eliminar(2);

            pr.MostrarPacientes();

            Console.ReadLine();



            Console.ReadLine();


        }
    }
}
