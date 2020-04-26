using System;
using System.Collections.Generic;
using System.Text;

namespace ALGORITMICAPROYECTO2
{
    class LinkedList
    {
        public class Nodo
        {
            public int info;
            public string id;
            public string tipo;
            public string date;
            public Nodo ant, sig;
            public int tamaño=0;
        }

        Nodo raiz;
        public LinkedList()
        {
            raiz = null;
        }

       
        public void InsertarFinal(int x, string id, string tipo, string date)
        {
            Nodo nuevo = new Nodo();
            nuevo.info = x;
            nuevo.id = id;
            nuevo.tipo = tipo;
            nuevo.date = date;
            nuevo.tamaño ++;
            if (raiz == null)
                raiz = nuevo;
            else
            {
                Nodo reco = raiz;
                while (reco.sig != null)
                {
                    reco = reco.sig;
                }
                reco.sig = nuevo;
                nuevo.ant = reco;
                
            }


        }


        public void Borrar(int pos)
        {
            if (pos <= Cantidad())
            {
                if (pos == 1)
                {
                    raiz = raiz.sig;
                    if (raiz != null)
                        raiz.ant = null;
                }
                else
                {
                    Nodo reco;
                    reco = raiz;
                    for (int f = 1; f <= pos - 2; f++)
                        reco = reco.sig;
                    Nodo prox = reco.sig;
                    prox = prox.sig;
                    reco.sig = prox;
                    if (prox != null)
                        prox.ant = reco;
                }
            }
        }
        public int Cantidad()
        {
            int cant = 0;
            Nodo reco = raiz;
            while (reco != null)
            {
                reco = reco.sig;
                cant++;
            }
            return cant;
        }



        public bool Existe(int x)
        {
            Nodo reco = raiz;
            while (reco != null)
            {
                if (reco.info == x)
                    return true;
                reco = reco.sig;
            }
            return false;
        }
        public bool ExisteSecuencial(Nodo head,int value) {
            Nodo start = head;
            Nodo last = null;
            
            do
            {
                // Encontrar el medio
                Nodo mid = middleNode(start, last);

                // Si el medio esta vacio
                if (mid == null)
                    return false;

                // Si el valor esta en el meedio 
                if (mid.info == value)
                    return true;

                // Si el medio es mayor al valor
                else if (mid.info > value)
                {
                    start = mid.sig;
                }

                // Si el valor es mayor al del medio 
                else
                    last = mid;
            } while (last == null || last != start);

            //si no existe. 
            return false;
        }   
        static Nodo middleNode(Nodo start, Nodo last)
        {
            if (start == null)
                return null;

            Nodo slow = start;
            Nodo fast = start.sig;

            while (fast != last)
            {
                fast = fast.sig;
                if (fast != last)
                {
                    slow = slow.sig;
                    fast = fast.sig;
                }
            }
            return slow;
        }


        public bool Vacia()
        {
            if (raiz == null)
                return true;
            else
                return false;
        }

        public void Imprimir()
        {
            Nodo reco = raiz;
            while (reco != null)
            {
                Console.Write("[" + reco.info + "]" + "->" + reco.id + " - " + reco.date + "-" + reco.tipo);
                reco = reco.sig;
            }

        }
    }
}
