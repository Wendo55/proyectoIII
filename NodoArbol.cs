using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoIII
{
    internal class NodoArbol
    {
        public int dato { get; set; }
        public NodoArbol izquierdo { get; set; }
        public NodoArbol derecho { get; set; }

        public NodoArbol(int dato)
        {
            this.dato = dato;
            this.izquierdo = null;
            this.derecho = null;
        }
    }
}
