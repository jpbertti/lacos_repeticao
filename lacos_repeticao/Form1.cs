using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lacos_repeticao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lsbNumeros.Items.Clear();
        }

        private void btnMostar_Click(object sender, EventArgs e)
        {
            lsbNumeros.Items.Clear();
            for (int i = 1; i <= 10; i++)
            {
                lsbNumeros.Items.Add(i);
                

            }
           
            
        }
    }
}
