using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoIII
{
    internal class NodoJ
    {
        private int dato;
        private NodoJ siguiente;
        private NodoJ atras;
        public int Dato
        { get { return dato; } set { dato = value; } }
        public NodoJ Siguiente
        { get { return siguiente; } set { siguiente = value; } }

        public NodoJ Atras
        { get { return atras; } set { atras = value; } }
        public NodoJ()
        {
            dato = 0;
            siguiente = null;
            atras = null;
        }
        public NodoJ(int dato, NodoJ siguiente, NodoJ atras)
        {
            this.dato = dato;
            this.siguiente = siguiente;
            this.atras = atras;
        }
        public override string ToString()
        {
            return dato + " - ";
        }
    }
}