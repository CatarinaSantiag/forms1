using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms1
{
    
    public partial class Form4 : Form
    {
        private readonly string DataBase = "CursosNoah";
        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private string CalcularSHA256(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Converte a string de entrada em bytes
                byte[] bytes = Encoding.UTF8.GetBytes(input);

                // Calcula o hash SHA-256
                byte[] hashBytes = sha256.ComputeHash(bytes);

                // Converte o resultado do hash em uma string hexadecimal
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            

            string email =textBox1.Text;
            string senha = CalcularSHA256(textBox2.Text);

            UserDAO usuario = new UserDAO();

            if (usuario.LoginUser(email, senha))
            {
                Form3 form= new Form3();
                form.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("hgjdgasdha", "asas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

          
        }
       
    }
}
