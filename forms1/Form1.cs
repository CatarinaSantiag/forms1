using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms1
{
    public partial class Form1 : Form
    {

        private  string name;

        public Form1()
        {
            InitializeComponent();
        }
        private void UpdateListView()
        {
            listView1.Items.Clear();

            Conexao1 conn = new Conexao1();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM tabela_login";

            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {

                     name = (string)dr["user"];

                    string pass = (string)dr["passwords"];

                    ListViewItem lv = new ListViewItem(dr["id"].ToString());


                    lv.SubItems.Add(name);
                     lv.SubItems.Add(pass);
                    listView1.Items.Add(lv);

                }
                dr.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
        }

        private void button1_Click(object sender, EventArgs e)


        { 
            Conexao1 connection = new Conexao1();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO tabela_login VALUES(@user, @password)";
            sqlCommand.Parameters.AddWithValue("@user", txbNome.Text );
            sqlCommand.Parameters.AddWithValue("@password", txbPront.Text);
            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Cadastrado com sucesso!", "1",

                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            txbNome.Clear();
            txbPront.Clear();


            string pront = txbPront.Text;
            string nome = txbNome.Text;
            string message = "E-mail/Usuário " + nome + "\nSenha/Matrícula: " + pront;

            MessageBox.Show(message, "DADOS",
                MessageBoxButtons.OK,MessageBoxIcon.Information);


            MessageBox.Show("atenção",
                "3", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            txbNome.Clear();
            txbPront.Clear();

            UpdateListView();


        }

        private void txbPront_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Conexao1 connection = new Conexao1();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"UPDATE tabela_login SET 
            
            passwords = @passwords
            WHERE user = @user";         //UPDATE: atualizar os campos no banco de dados. SET: quais colunas vai alterar no bds

            sqlCommand.Parameters.AddWithValue("@user", txbNome.Text);
            sqlCommand.Parameters.AddWithValue("@passwords", txbPront.Text);
            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Cadastrado com sucesso",
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            txbNome.Clear();
            txbPront.Clear();

            UpdateListView();

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index;
            index = listView1.FocusedItem.Index;
            name = (listView1.Items[index].SubItems[0].Text);
            txbNome.Text = listView1.Items[index].SubItems[0].Text;
            txbPront.Text = listView1.Items[index].SubItems[1].Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexao1 connection = new Conexao1();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM tabela_login WHERE user = @user";
            sqlCommand.Parameters.AddWithValue("@user", name );
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir usuário no banco.\n" + err.Message);
            }
            finally
            {
                connection.CloseConnection();
            }
            UpdateListView();
        }
    }
}           
