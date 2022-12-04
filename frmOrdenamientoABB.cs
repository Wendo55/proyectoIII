using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoIII
{

    public partial class frmOrdenamientoABB : Form
    {
        ABB1 arbol;
        public frmOrdenamientoABB()
        {
            InitializeComponent();
        }
      
        private void agregar(bool invertido)
        {
            if (String.IsNullOrEmpty(txtCantidad.Text) == true)
            { return; }

            arbol = new ABB1();

            int[] datos = new int[int.Parse(txtCantidad.Text)];
            Random r = new Random();
            string cadena = "";
            for (int i = 0; i < datos.Length; i++)
            {
                datos[i] = r.Next(-500, 500);
                cadena += ", " + datos[i];
            }
            txtSinOrdenar.Text = cadena;

            //invertido
            if (invertido)
            {
                double tiempoIniciali = double.Parse(DateTime.Now.Ticks.ToString());
                for (int i = 0; i < datos.Length; i++)
                {
                    arbol.Insertar(datos[i], invertido);
                }
                txtInorden.Text = arbol.Inorden();
                double tiempoFinali = double.Parse(DateTime.Now.Ticks.ToString());
                MessageBox.Show("El tiempo total en milisegundos fue: " + ((tiempoFinali - tiempoIniciali) / 10000));
                return;
            }

            //no invertido
            double tiempoInicial = double.Parse(DateTime.Now.Ticks.ToString());
            for (int i = 0; i < datos.Length; i++)
            {
                arbol.Insertar(datos[i], invertido);
            }
            txtInorden.Text = arbol.Inorden();
            double tiempoFinal = double.Parse(DateTime.Now.Ticks.ToString());
            MessageBox.Show("El tiempo total en milisegundos fue: " + ((tiempoFinal - tiempoInicial) / 10000));

            arbol = null;

        }

        private void btnInvertidos_Click_1(object sender, EventArgs e)
        {
            agregar(true);
        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            agregar(false);

        }
    }
}

