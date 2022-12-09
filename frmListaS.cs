using proyectoIII;
using System;
using System.Collections;
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
    public partial class frmListaS : Form
    {
        public frmListaS()
        {
            InitializeComponent();
        }

        Nodo n;
        Operaciones MiLista = new Operaciones();

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            n = new Nodo();
            n.Dato = int.Parse(txtNodo.Text);
            MiLista.Agregar(n);
            lblLista.Text = MiLista.ToString();
            txtNodo.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int dato = int.Parse(txtNodo.Text);
            MiLista.Borrar(dato);
            lblLista.Text = MiLista.ToString();
            txtNodo.Clear();
        }



    }
}
