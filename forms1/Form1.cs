using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pront = txbPront.Text;
            string nome = txbNome.Text;
            string message = "Nome: " + nome + "\nMatricula: " + pront;

            MessageBox.Show(message, "ATENCAO",
                MessageBoxButtons.OK,MessageBoxIcon.Information);


            MessageBox.Show("atenção", MessageBoxButtons.OK,
                MessageBoxIcon.Information);    


        }
    }
}
