using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMenemFerrocarrilSp2
{
    public partial class frmMain : Form
    {
         public int Distancia;
         public int Dias;
         public float Precio;
         public float Total;
         
        
        public frmMain()
        {
            InitializeComponent();
        }

        private void lblKm_Click(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            Precio = Convert.ToInt32(txtDistancia.Text) * 5;

            txtPrecio.Text = Precio.ToString();

        }

        private void txtDistancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true; 
            }
        }

        private void nudDias_ValueChanged(object sender, EventArgs e)
        {
            Dias = Convert.ToInt32(nudDias.Value);
        }

        private void txtDistancia_TextChanged(object sender, EventArgs e)
        {
            Distancia = Convert.ToInt32(txtDistancia.Text);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
