using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoIII
{
    internal class Cola2
    {
        private NodoCcirc head;
        private NodoCcirc tail;
        public Cola2()
        {
            head = null;
            tail = null;
        }
        public void Agregar(string dato)
        {
            NodoCcirc nuevo = new NodoCcirc();
            nuevo.Dato = dato;
            if (head == null)
            {
                head = nuevo;
                tail = nuevo;
                return;
            }
            tail.Siguiente = nuevo;
            tail = nuevo;
            tail.Siguiente = head;
        }
        public void Eliminar()
        {
            if (head == null)
            {
                return;
            }
            if (head.Siguiente == head)
            {
                head = null;
                tail = null;
                return;
            }
            head = head.Siguiente;
            tail.Siguiente = head;
        }
        public override string ToString()
        {
            string cadena = "";
            NodoCcirc h = head;
            if (h != null)
            {
                if (h.Siguiente != h)
                {
                    while (h != tail)
                    {
                        cadena += h.ToString() + ", ";
                        h = h.Siguiente;
                    }
                    cadena += h.ToString() + ", ";
                    return cadena;
                }
                else
                {
                    cadena = h.ToString();
                    return cadena;
                }
            }
            else
            {
                return "La cola está vacía.";
            }
        }
    }
}
