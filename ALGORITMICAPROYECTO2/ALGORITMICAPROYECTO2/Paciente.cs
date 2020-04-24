using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ALGORITMICAPROYECTO2
{
    enum estado
    {
        vacio, ocupado, borrado
    }
    public class Paciente 
    {
        private int llave;
        private string valor;

        private estado miEstado;

        //ahora las propiedades de cada uno de los atributos declarados
        public int Llave { get => llave; set => llave = value; }
        public string Valor { get => valor; set => valor = value; }
        internal estado MiEstado { get => miEstado; set => miEstado = value; }

        public Paciente()
        {
            llave = 0;
            valor = "";
            miEstado = estado.vacio; //valor definido en el enum
        }
    }
}
