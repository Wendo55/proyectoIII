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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }
        //Métodos de ordenamiento
        private void btnArbol_Click_1(object sender, EventArgs e)
        {
            frmOrdenamientoABB abrir = new frmOrdenamientoABB();
            abrir.Show();
        }

        private void btnBurbuja_Click_1(object sender, EventArgs e)
        {
            FrmBubble abrir = new FrmBubble();
            abrir.Show();

        } 
        private void btnInsercion_Click_1(object sender, EventArgs e)
        {
            frmInsercion abrir = new frmInsercion();
            abrir.Show();
        }
   
        private void btnSelection_Click(object sender, EventArgs e)
        {
            frmSelection abrir = new frmSelection();
            abrir.Show();
        }
        private void btnCuentas_Click_1(object sender, EventArgs e)
        {
            frmCounting abrir = new frmCounting();
            abrir.Show();
        }

        private void btnRadix_Click_1(object sender, EventArgs e)
        {
            frmRadix abrir = new frmRadix();
            abrir.Show();
        }

        private void btnMezcla_Click_1(object sender, EventArgs e)
        {
            frmMerge abrir = new frmMerge();
            abrir.Show();
        }
        private void btnCasilleros_Click_1(object sender, EventArgs e)
        {
            frmShell abrir = new frmShell();
            abrir.Show();
        }

        private void btnORapido_Click(object sender, EventArgs e)
        {
            frmQuicksort abrir = new frmQuicksort();
            abrir.Show();
        }
        //Estructura de datos lineales
        private void btnPilas_Click(object sender, EventArgs e)
        {
            frmPilas abrir = new frmPilas();
            abrir.Show();
        }

        private void btnColas_Click(object sender, EventArgs e)
        {
            frmColas abrir = new frmColas();
            abrir.Show();
        }

        private void btnDoblementeCircular_Click(object sender, EventArgs e)
        {
            frmLdobleCircular abrir = new frmLdobleCircular();
            abrir.Show();
        }

        private void btnDobleEnlazada_Click(object sender, EventArgs e)
        {
            FrmListadoble abrir = new FrmListadoble();
            abrir.Show();
        }

        private void btnCircular_Click(object sender, EventArgs e)
        {
            frmListaCircular abrir = new frmListaCircular();
            abrir.Show();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            frmListaS abrir = new frmListaS();
            abrir.Show();
        }

        //Estructura de datos no lineales
        private void btnArboles_Click(object sender, EventArgs e)
        {
            frmArboles abrir = new frmArboles();
            abrir.Show();
        }
        private void btnGrafos_Click(object sender, EventArgs e)
        {
            frmGrafos abrir = new frmGrafos();
            abrir.Show();
        }

       //Cerrar minimizar
        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
          
        }

       
    }
}
