using System;
using System.Collections.Generic;
using System.Text;

namespace ALGORITMICAPROYECTO2
{
    class LinkedList
    {
        private int count;

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

        public Nodo Search(int data)
        {
            Nodo found = Search(raiz, data);
            if (found == null)
            {
                Console.WriteLine("Busqueda sin fin");
            }
            return found;
        }
        //EXISTE SECUENCIAL
        public bool ExisteSecuencial(string x)
        {
            Nodo reco = raiz;
            while (reco != null)
            {
                if (reco.id == x)
                    return true;
                reco = reco.sig;
            }
            return false;
        }
        public void Existe(int data)
        {

            Nodo removing = Search(raiz, data);
            if (removing == null)
            {
                Console.WriteLine("Valor no encontrado.");
                return;
            }
            else
            {
                Console.WriteLine("CI: {0} encontrado ",data);
            }

        }

        //Search recursively finds the first instance of a Node with given data and returns that Node.
        private Nodo Search(Nodo parental, int data)
        {
            Nodo left = parental.ant;
            Nodo right = parental.sig;
            if (parental.info == data)
            {
                return parental;
            }

            if (data <= parental.info && left != null)
            {
                return Search(left, data);
            }

            if (data > parental.info && right != null)
            {
                return Search(right, data);
            }
            return null;
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
                //current now =reco
                //firstnode = raiz
                reco.sig = nuevo;
                nuevo.ant = reco;
             }
        }
        private Nodo NodeAt(int index)
        {
            if (raiz != null && index >= 0)
            {
                Nodo node = raiz;
                for (int i = 0; i <= index; i++)
                {
                    if (index == i)
                    {
                        break;
                    }
                    
                    node = node.sig;
                }

                return node;
            }
            else if (index < 0)
            {
                return this.NodeAt(Count() + index); //Positive index/offset
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        public void Remove(string value)
        {
            int position = IndexOf(value);

            if (position >= 0)
            {
                if (position == 0)
                {
                    raiz = raiz.sig;
                }
                else if (position >= 1 )
                {
                    NodeAt(position - 1).sig = NodeAt(position + 1);
                }
               
                count--;
            }
        }

        //Busqueda por nombre
        public int IndexOf(string value)
        {
            Nodo reco = raiz;
            int position = 0;
            bool found = false;
            if (raiz == null)
            {
                position = -1;
            }
            else
            {
                //position++;
                while (reco != null)
                {
                    if (value == reco.id)
                    {
                        found = true;
                        break;
                    }
                    reco = reco.sig;
                    position++;
                }
                if (!found)
                {
                    position = -1;
                }
            }
            return position;
        }
        //Busqueda por ci
        public int IndexOfCI(int value)
        {
            Nodo reco = raiz;
            int position = 0;
            bool found = false;
            if (raiz == null)
            {
                position = -1;
            }
            else
            {
                //position++;
                while (reco != null)
                {
                    if (value == reco.info)
                    {
                        found = true;
                        break;
                    }
                    reco = reco.sig;
                    position++;
                }
                if (!found)
                {
                    position = -1;
                }
            }
            return position;
        }
        //BUSQUEDA POR NOMBRE
        public bool Existe(string x)
        {
            Nodo reco = raiz;
            while (reco != null)
            {
                if (reco.id == x)
                {
                    return true;
                }
                reco = reco.sig;
            }
            return false;
        }
        //BUSQUEDA POR CI
        public bool ExisteCI(int x)
        {
            Nodo reco = raiz;
            while (reco != null)
            {
                if (reco.info == x)
                {
                    return true;
                }
                reco = reco.sig;
            }
            return false;
        }

        public void Eliminar(int pos) {
            int position = IndexOfCI(pos);

            if (position >= 0)
            {
                if (position == 0)
                {
                    raiz = raiz.sig;
                }
                else if (position >= 1)
                {
                    NodeAt(position - 1).sig = NodeAt(position + 1);
                }

                count--;
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
        //Busqueda secuencial
        public int Count()
        {
            return count;
        }
        public bool ExisteBooleana(Nodo head,int value) {
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
            Console.WriteLine("El numero del medio es {0}",slow);
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
                Console.Write("[" + reco.info + "]" + "->" + reco.id + " - " + reco.date + "-" + reco.tipo+"-- ");
                reco = reco.sig;
            }

        }
        public void ImprimirporCI()
        {
            Nodo reco = raiz;
            while (reco != null)
            {
                Console.Write("{" + reco.info + "}" + "->" );
                reco = reco.sig;
            }

        }
    }
}
