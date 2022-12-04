using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoIII
{
    internal class Nodo2
    {
        private string dato;

        public string Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        private Nodo2 siguiente;

        public Nodo2 Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
        private Nodo2 anterior;

        public Nodo2 Anterior
        {
            get { return anterior; }
            set { anterior = value; }
        }
        public Nodo2()
        {
            dato = "";
            siguiente = null;
            anterior = null;
        }
        public Nodo2(string dato, Nodo2 siguiente, Nodo2 anterior)
        {
            this.dato = dato;
            this.siguiente = siguiente;
            this.anterior = anterior;
        }
        public override string ToString()
        {
            return " - " + Dato.ToString();
        }
    }
}
