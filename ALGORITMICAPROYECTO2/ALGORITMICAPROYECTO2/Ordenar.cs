using System;
using System.Collections.Generic;
using System.Text;

namespace ALGORITMICAPROYECTO2
{
    class Ordenar
    {
        //BUSQUEDA SECUENCIAL
        static int Buscar(int buscar, int[] numero)
        {
            int l = 0;
            int r = numero.Length - 1;
            while (l <= r)
            {
                int m = l + (r - l) / 2;
                if (numero[m] == buscar)
                {
                    Console.Write("\nEl elemento {0} esta en la posicion: {1}", buscar, m + 1);
                    return m;
                }
                if (numero[m] < buscar)
                {
                    l = m + 1;
                }
                else
                {
                    r = m - 1;

                }
            }
            return -1;
        }
    }
}
