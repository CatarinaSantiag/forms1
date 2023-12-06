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
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexao1 connection = new Conexao1();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = "SELECT * FROM tabela_login WHERE [user] = @user";
            sqlCommand.Parameters.AddWithValue("@user", loginuser.Text);

            if (string.IsNullOrEmpty(loginuser.Text))
            {
                MessageBox.Show(
                "O nome de usuário está vazio!",
                "ATENÇÃO!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                loginuser.Clear();
            }

            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    string senhasgbd = (string)reader["passwords"];

                    string senhalogin = loginsenha.Text;
                    using (SHA256 sha256 = SHA256.Create())
                    {
                        byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(senhalogin));
                        StringBuilder sb = new StringBuilder();
                        foreach (byte b in bytes)
                        {
                            sb.Append(b.ToString("x2"));
                        }
                        string sha256login = sb.ToString();

                        if (senhasgbd == sha256login)
                        {
                            MessageBox.Show(
                            "Bem vindo!",
                            "ATENÇÃO",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                            loginuser.Clear();
                            loginsenha.Clear();

                            Form3 login = new Form3();
                            login.ShowDialog();
                        }

                        else
                        {
                            MessageBox.Show(
                            "A senha está incorreta!",
                            "ATENÇÃO!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                            loginsenha.Clear();
                        }
                    }
                }

            }

        }
    }
}
