using System;
using System.Collections.Generic;
using System.Text;

namespace ALGORITMICAPROYECTO2
{
   
    class Menu
    {
        private static int numberOfElements = 11;

        private Hash hashtable = new Hash(numberOfElements);

        public Menu()
        {

            Start();
        }
        private void Start()
        {

            int choiceInMenu = -1;

            while (choiceInMenu != 0)
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("              Linked Hash Table           ");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Que desea hacer:                          ");
                Console.WriteLine("     1) Añadir Paciente                   ");
                Console.WriteLine("     2) Buscar Paciente                   ");
                Console.WriteLine("     3) Eliminar Paciente                 ");
                Console.WriteLine("     4) Imprimir Tabla Hash               ");
                Console.WriteLine("     0) Salir                             ");
                Console.Write("Ingresa tu opcion: ");
                if (int.TryParse(Console.ReadLine(), out choiceInMenu))
                {
                    switch (choiceInMenu)
                    {
                        case 0:
                            break;
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                        default:
                            Console.WriteLine("Opción invalida, intenta de nuevo");
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("Opción inválida");
                    choiceInMenu = -1;
                }
            }
        }
    }
}
