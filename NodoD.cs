using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoIII
{
    internal class NodoD
    {
        private string dato;
        private NodoD siguiente;
        public string Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public NodoD Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
        public NodoD()
        {
            dato = null;
            siguiente = null;
        }

        public NodoD(string dato, NodoD siguiente)
        {
            this.dato = dato;
            this.siguiente = siguiente;
        }

        public override string ToString()
        {
            return dato;
        }
    }
}