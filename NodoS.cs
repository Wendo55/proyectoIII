using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoIII
{
    internal class NodoS
    {
        private int dato;
        private NodoS siguiente;

        //Propiedades
        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public NodoS Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        //Constructor
        public NodoS()
        {
            dato = 0;
            siguiente = null;
        }

        public NodoS(int dato, NodoS siguiente)
        {
            this.dato = dato;
            this.siguiente = siguiente;
        }

        public override string ToString()
        {
            return dato + "";
        }
    }
}
