using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AugmentedReadingApp
{
    public partial class SeleccionInteraccionPorVoz2 : Form
    {
        public static string activarBusquedaVoz;
        public static string mostrarBotonesconVoz;
        //Codigo agregado
        ///
        public SeleccionInteraccionPorVoz2()
        {
            InitializeComponent();

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (rbtn_voz_si.Checked && rbtn_Si_botones.Checked)
            {
                activarBusquedaVoz = rbtn_voz_si.Text;
                mostrarBotonesconVoz = rbtn_Si_botones.Text;
                MessageBox.Show("Ha seleccionado la opción de interacción por voz");
                this.Hide();
            }
            if (rbtn_voz_si.Checked && rbtn_no_botones.Checked)
            {
                activarBusquedaVoz = rbtn_voz_si.Text;
                mostrarBotonesconVoz = rbtn_no_botones.Text;
                MessageBox.Show("Ha seleccionado la opción de interacción por voz");
                this.Hide();
            }
            if (rbtn_voz_no.Checked)
            {
                activarBusquedaVoz = rbtn_voz_no.Text;
                MessageBox.Show("Ha seleccionado la opción de interacción por botones");
                this.Hide();
            }

        }

        private void rbtn_no_botones_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("When activated it is possible to interact with the web search by means of voice prompts", pictureBox1);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            toolTip1.Show("When activated it is possible to interact with the web search by means of voice prompts", pictureBox1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
      
            toolTip1.Show("When activated, the web search buttons are displayed", pictureBox2);
        }
    }
}
