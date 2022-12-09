using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoIII
{
    internal class NodoCcirc
    {
        private string dato;
        private NodoCcirc siguiente;
        public string Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public NodoCcirc Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
        public NodoCcirc()
        {
            dato = null;
            siguiente = null;
        }
        public override string ToString()
        {
            return dato;
        }
    }
}