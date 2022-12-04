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
    public partial class FrmListadoble : Form
    {
        public FrmListadoble()
        {
            InitializeComponent();
        }
        ListaDoble lista = new ListaDoble();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Nodo2 n = new Nodo2();
            n.Dato = txtDato.Text;
            lista.Agregar(n);
            MessageBox.Show(lista.ToString());
        }

        private void txtDato_TextChanged(object sender, EventArgs e)
        { }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (lista.Buscar(txtDato.Text))
            {
                MessageBox.Show("Encontrado");
                return;
            }
            MessageBox.Show("No encontrado");
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            lista.Borrar(txtDato.Text);
            MessageBox.Show(lista.ToString());
        }

    }
}
