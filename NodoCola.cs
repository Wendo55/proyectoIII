using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoIII
{
    internal class NodoCola
    {
        private string dato;
        private NodoCola siguiente;
        private int prioridad;
        public string Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public NodoCola Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
        public int Prioridad
        {
            get { return prioridad; }
            set { prioridad = value; }
        }
        
        public NodoCola()
        {
            dato = "";
            prioridad = 0;
            siguiente = null;
        }
        public override string ToString()
        {
            return dato;
        }
    }
}
