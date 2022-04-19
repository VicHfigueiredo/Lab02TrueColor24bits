using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02TrueColor24bits
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void hsbRed_Scroll(object sender, ScrollEventArgs e)
        {
            tbxRed.Text = hsbRed.Value.ToString();
            trocaCor();
        }

        private void hsbGreen_Scroll(object sender, ScrollEventArgs e)
        {
            tbxGreen.Text = hsbGreen.Value.ToString();
            trocaCor();
        }

        private void hsbBlue_Scroll(object sender, ScrollEventArgs e)
        {
            tbxBlue.Text = hsbBlue.Value.ToString();
            trocaCor();
        }
        private void trocaCor()
        {
            lblCores.BackColor = Color.FromArgb(
                hsbRed.Value,
                hsbGreen.Value,
                hsbBlue.Value
                );
        }
    }
}
