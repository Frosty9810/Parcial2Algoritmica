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
        }

        Nodo raiz;
        public LinkedList()
        {
            raiz = null;
        }
        //INSERTAR AL PRINCIPIO


        public void InsertarFinal(int x, string id, string tipo, string date)
        {

            Nodo nuevo = new Nodo();
            nuevo.info = x;
            nuevo.id = id;
            nuevo.tipo = tipo;
            nuevo.date = date;
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
