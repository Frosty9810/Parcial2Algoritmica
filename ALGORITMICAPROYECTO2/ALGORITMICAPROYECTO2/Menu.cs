using System;
using System.Text;
using System.Diagnostics;

namespace ALGORITMICAPROYECTO2
{
   
    class Menu
    {
        //MANDA EL TAMAÑO DEL HASH
        private static int numberOfElements = 23;
       
        private Hash hashtable = new Hash(numberOfElements);
        private Hash2 hashtable2 = new Hash2(numberOfElements);
        private static string[] nombres = { "VICTOR HUGO", "JOSE LUIS","MARCEL BARRERO","AUGUSTO ALBORTA","GABRIEL ACOSTA","PABLO RIVAS","ALBERTO SOLIZ",
        "SANTIAGO RELOS","CARLOS DE LA TORRE","DODROVOSKY MEDRANO","PEDRO","PABLO GONZALES","JOSE LUIS", "ALBERT EINSTEIN","SEBASTIAN","SOPA DO MACACO",
        "ALISON PEREDO","MARCO ANTONIO","MATEO","CARLOS","URQUIDI LUIS","MEDINA NICOLAS","FERNANDA ESPINOZA","MARIA ESPINOZA","FERNANDA MONJE","RENATA TERRAZAS",
        "FATIMA OPORTO","RICARDO CACERES","EMILIO BUTRAGEÑO","JORGE ORTUÑO","MARITZA RIVAS","JOSE PEREDO","MARCO SOLIZ","BRENDA SORA","FABIOLA MEDINA"
        };
        public Menu()
        {

            Start();
        }
        private void Start()
        {

            int choiceInMenu = -1;

            while (choiceInMenu != 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("              Linked Hash Table           ");
                Console.WriteLine("------------------------------------------");
                Console.ResetColor();
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
                            MenuPaciente();
                            break;
                        case 2:
                            MenuBuscar();
                            break;
                        case 3:
                            MenuEliminar();
                            break;
                        case 4:
                            MenuMostrar();
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
                Console.Clear();
            }
        }
        private void MenuPaciente() {
          
                int choiceInMenu = -1;

                while (choiceInMenu != 0)
                {
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("           Menu de Agregar Paciente       ");
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("Que desea hacer:                          ");
                    Console.WriteLine("     1) Agregar un paciente               ");
                    Console.WriteLine("     2) Agregar varios pacientes          ");
                    Console.WriteLine("     0) Salir                             ");
                    Console.Write("Ingresa tu opcion: ");
                    if (int.TryParse(Console.ReadLine(), out choiceInMenu))
                    {
                        switch (choiceInMenu)
                        {
                            case 0:
                                break;
                            case 1:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("");
                                Console.WriteLine("--------Añadir paciente---------");
                                Console.WriteLine("");

                                Console.ResetColor();
                                Console.WriteLine("Nombre del paciente: ");
                                string name = Console.ReadLine();
                                Console.WriteLine("CI del paciente:");
                                int id = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Tipo de paciente:Internado o Ambulatorio ");
                                string tipopaciente = Console.ReadLine();
                                Console.WriteLine("Fecha de ingreso: ");
                                string fechaingreso = Console.ReadLine();
                                //REGISTRO ALMACENADO EN LAS DOS ESTRUCTURAS HASH DE 23
                                hashtable.Añadir(id, name, tipopaciente, fechaingreso);
                                hashtable2.Añadir(id, name, tipopaciente, fechaingreso);
                            break;
                            case 2:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("");
                                    Console.WriteLine("--------Añadir paciente---------");
                                    Console.WriteLine("");

                                    Console.ResetColor();
                                    Console.WriteLine("Ingrese el numero de pacientes a ingresar");
                                    int numero = Convert.ToInt32(Console.ReadLine());


                                     for (int i=0; i <=numero; i++) {
                                        //Console.WriteLine(nombres[i]);
                                        int ids = new Random().Next(1000,2000);
                                        string tipo="Internado";
                                        
                                        string date = Convert.ToString(new Random().Next(1, 30))+ "/"+Convert.ToString(new Random().Next(1, 12)+ "/"+Convert.ToString(new Random().Next(2018, 2020)));
                                        hashtable.Añadir(ids, nombres[i], tipo, date);
                                        hashtable2.Añadir(ids, nombres[i], tipo, date);
                                      }
                                   
                                  
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
        private void MenuBuscar() 
        {
            Stopwatch sw = new Stopwatch();

            int choiceInMenu = -1;

            while (choiceInMenu != 0)
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("              Menu de busqueda            ");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Que desea hacer:                          ");
                Console.WriteLine("     1) Buscar por Nombre                 ");
                Console.WriteLine("     2) Buscar por C.I.                   ");
                Console.WriteLine("     0) Salir                             ");
                Console.Write("Ingresa tu opcion: ");
                if (int.TryParse(Console.ReadLine(), out choiceInMenu))
                {
                    switch (choiceInMenu)
                    {
                        case 0:
                            break;
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("");
                            Console.WriteLine("--------Buscar paciente---------");
                            Console.WriteLine("");
                            Console.ResetColor();
                            Console.WriteLine("Nombre del paciente:");
                            string name = Console.ReadLine();
                            sw.Start();
                            hashtable2.BuscarSecuencial(name);
                            sw.Stop();
                            Console.WriteLine("Tiempo que tarde en hacer la busqueda: {0:N0}", sw.ElapsedTicks); 

                            sw.Reset();
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("");
                            Console.WriteLine("--------Buscar paciente---------");
                            Console.WriteLine("");
                            Console.ResetColor();
                            Console.WriteLine("Cedula de Identidad del paciente:");
                            int ci = Convert.ToInt32(Console.ReadLine());
                            sw.Start();
                            hashtable.BusquedaBinaria(ci);
                            sw.Stop();
                            Console.WriteLine("Tiempo que tarde en hacer la busqueda: {0:N0}", sw.ElapsedTicks);

                            sw.Reset();
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
        private void MenuEliminar()
        {
            int choiceInMenu = -1;

            while (choiceInMenu != 0)
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("              Menu de Eliminación         ");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Que desea hacer:                          ");
                Console.WriteLine("     1) Eliminar por Nombre               ");
                Console.WriteLine("     2) Eliminar por C.I.                 ");
                Console.WriteLine("     0) Salir                             ");
                Console.Write("Ingresa tu opcion: ");
                if (int.TryParse(Console.ReadLine(), out choiceInMenu))
                {
                    switch (choiceInMenu)
                    {
                        case 0:
                            break;
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("");
                            Console.WriteLine("--------Eliminar paciente---------");

                            Console.WriteLine("");
                            Console.ResetColor();

                            Console.WriteLine("Nombre del paciente:");
                            Console.ResetColor();
                            string name = Console.ReadLine();
                            //AQUI SE ELIMINA DE LAS DOS TABLAS
                            hashtable2.EliminarNombre(name);
                            hashtable.EliminarSecuencialmente(name);
                            break;
                        case 2:
                            Console.WriteLine("--------Eliminar paciente---------");
                            Console.WriteLine("CEDULA DE IDENTIDAD del paciente:");
                          //errror
                            int ci = Convert.ToInt32(Console.ReadLine());
                            //AQUI SE ELIMINA DE LAS DOS TABLAS

                            hashtable.EliminarSecuencial(ci);
                            hashtable2.EliminarCedula(ci);
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
        private void MenuMostrar()
        {
            Stopwatch sw = new Stopwatch();

            int choiceInMenu = -1;

            while (choiceInMenu != 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("            Menu Mostrar Paciente         ");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("");
                Console.ResetColor();
               
                Console.WriteLine("Que desea hacer:                          ");
                Console.WriteLine("     1) Mostrar todos los datos de los pacientes");
                Console.WriteLine("     2) Mostrar solo las Cédula de Identidad de los pacientes");
                Console.WriteLine("     0) Salir                             ");
                Console.Write("Ingresa tu opcion: ");
                if (int.TryParse(Console.ReadLine(), out choiceInMenu))
                {
                    switch (choiceInMenu)
                    {
                        case 0:
                            break;
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("");
                            Console.WriteLine("-------Mostrar Pacientes---------");
                            Console.WriteLine("");
                            Console.ResetColor();    

                            hashtable.MostrarPacientes();


                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("");
                            Console.WriteLine("-------Mostrar Pacientes por CI---------");
                            Console.WriteLine("");
                            Console.ResetColor();

                            hashtable.MostrarPacienteporCI();
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
