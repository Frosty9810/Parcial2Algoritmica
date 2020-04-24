using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoAlgoritmica
{
    public class LinkedList
    {

        public class Nodo
        {
            public int info;
            public Nodo ant, sig;
        }

        Nodo raiz;
        public LinkedList()
        {
            raiz = null;
        }
        //INSERTAR AL PRINCIPIO

        public void InsertarPrimero(int x)
        {
            Nodo nuevo = new Nodo();
            nuevo.info = x;
            nuevo.sig = raiz;
            if (raiz != null)
                raiz.ant = nuevo;
            raiz = nuevo;
        }
        public void InsertarFinal(int x)
        {

            if (raiz == null)
            {
                raiz = new Nodo();
                raiz.info = x;
                raiz.sig = null;

            }
            else
            {

                Nodo nuevo = new Nodo();
                nuevo.info = x;
                Nodo actual = raiz;
                while (actual.sig != null)
                {
                    actual = actual.sig;

                }
                actual.sig = nuevo;
            }


        }

        //INSERTAR EN POSICION
        public void insertar(int pos, int x)
        {
            if (pos <= Cantidad() + 1)
            {
                Nodo nuevo = new Nodo();
                nuevo.info = x;
                if (pos == 1)
                {
                    nuevo.sig = raiz;
                    raiz = nuevo;
                }
                else
                    if (pos == Cantidad() + 1)
                {
                    Nodo reco = raiz;
                    while (reco.sig != null)
                    {
                        reco = reco.sig;
                    }
                    reco.sig = nuevo;
                    nuevo.sig = null;
                }
                else
                {
                    Nodo reco = raiz;
                    for (int f = 1; f <= pos - 2; f++)
                        reco = reco.sig;
                    Nodo siguiente = reco.sig;
                    reco.sig = nuevo;
                    nuevo.sig = siguiente;
                }
            }
        }




        public int Extraer(int pos)
        {
            if (pos <= Cantidad())
            {
                int informacion;
                if (pos == 1)
                {
                    informacion = raiz.info;
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
                    reco.sig = prox.sig;
                    Nodo siguiente = prox.sig;
                    if (siguiente != null)
                        siguiente.ant = reco;
                    informacion = prox.info;
                }
                return informacion;
            }
            else
                return int.MaxValue;
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

        public void Intercambiar(int pos1, int pos2)
        {
            if (pos1 <= Cantidad() && pos2 <= Cantidad())
            {
                Nodo reco1 = raiz;
                for (int f = 1; f < pos1; f++)
                    reco1 = reco1.sig;
                Nodo reco2 = raiz;
                for (int f = 1; f < pos2; f++)
                    reco2 = reco2.sig;
                int aux = reco1.info;
                reco1.info = reco2.info;
                reco2.info = aux;
            }
        }

        public int Mayor()
        {
            if (!Vacia())
            {
                int may = raiz.info;
                Nodo reco = raiz.sig;
                while (reco != null)
                {
                    if (reco.info > may)
                        may = reco.info;
                    reco = reco.sig;
                }
                return may;
            }
            else
                return int.MaxValue;
        }

        public int PosMayor()
        {
            if (!Vacia())
            {
                int may = raiz.info;
                int x = 1;
                int pos = x;
                Nodo reco = raiz.sig;
                while (reco != null)
                {
                    if (reco.info > may)
                    {
                        may = reco.info;
                        pos = x;
                    }
                    reco = reco.sig;
                    x++;
                }
                return pos;
            }
            else
                return int.MaxValue;
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

        public bool Ordenada()
        {
            if (Cantidad() > 1)
            {
                Nodo reco1 = raiz;
                Nodo reco2 = raiz.sig;
                while (reco2 != null)
                {
                    if (reco2.info < reco1.info)
                    {
                        return false;
                    }
                    reco2 = reco2.sig;
                    reco1 = reco1.sig;
                }
            }
            return true;
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
                Console.Write(reco.info + "-");
                reco = reco.sig;
            }

        }

    }
}
