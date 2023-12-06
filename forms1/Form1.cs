using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms1
{
    public partial class Form1 : Form
    {

        private int id;

        public Form1()
        {
            InitializeComponent();
            UpdateListView();
        }
        private void UpdateListView()
        {
            listView1.Items.Clear();

            UserDAO userDAO = new UserDAO();
            List<Usuario> usuarios = userDAO.SelectUser();

            try
            {
                foreach (Usuario usuario in usuarios)
                {

                    ListViewItem lv = new ListViewItem(usuario.Id.ToString());


                    lv.SubItems.Add(usuario.User);
                    lv.SubItems.Add(usuario.Passwords);
                    listView1.Items.Add(lv);

                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario user = new Usuario(id, txbNome.Text, txbPront.Text);
                UserDAO userDAO = new UserDAO();
                userDAO.InsertUser(user);

                string pront = txbPront.Text;
                string nome = txbNome.Text;
                string message = "E-mail/Usuário " + nome + "\nSenha/Matrícula: " + pront;

                MessageBox.Show(message, "DADOS",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Cadastrado com sucesso!", "1",

              MessageBoxButtons.OK,
              MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

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
            Usuario user = new Usuario(id, txbNome.Text, txbPront.Text);
            UserDAO nomeDoOB = new UserDAO();
            nomeDoOB.EditUser(id, user);

            MessageBox.Show("Editado com sucesso",
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
            id = int.Parse(listView1.Items[index].SubItems[0].Text);
            txbNome.Text = listView1.Items[index].SubItems[1].Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserDAO nomeDoOB = new UserDAO();
            nomeDoOB.DeleteUser(id);

            txbNome.Clear();
            txbPront.Clear();

            MessageBox.Show("Excluida com sucesso",
               "AVISO",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);
            UpdateListView();

        }


        private void txbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbPront_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txbConfirma_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string user, senha;

            Conexao1 connection = new Conexao1();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = "SELECT * FROM tabela_login WHERE [user] = @user";
            sqlCommand.Parameters.AddWithValue("@user", txbNome.Text);

            if (string.IsNullOrEmpty(txbNome.Text))
            {
                MessageBox.Show(
                "Preencha o nome de usuário!",
                "ATENÇÃO!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                txbNome.Clear();
            }
            else
            {
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    reader.Read();
                    user = (string)reader["user"];
                    senha = (string)reader["passwords"];
                }

                string caminho = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string archivename = "relatorio_" + user + ".pdf";
                string caminhoCompleto = Path.Combine(caminho, archivename);
                FileStream archivePDF = new FileStream(caminhoCompleto, FileMode.Create);
                Document doc = new Document(PageSize.A4);
                PdfWriter pdfwriter = PdfWriter.GetInstance(doc, archivePDF);

                string dados = "";

                Paragraph paragraph = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, (int)System.Drawing.FontStyle.Bold));
                paragraph.Alignment = Element.ALIGN_CENTER;
                paragraph.Add("RELATÓRIO - CursosNoah");

                Paragraph paragraphuser = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, (int)System.Drawing.FontStyle.Regular));
                paragraphuser.Alignment = Element.ALIGN_CENTER;
                paragraphuser.Add("Dados do Usuário:\n" + "Usuário: " + user + "\nSenha: " + senha);

                doc.Open();
                doc.Add(paragraph);
                doc.Add(paragraphuser);
                doc.Close();

                MessageBox.Show(
                "O relatório foi criado com sucesso e armazenado na sua área de trabalho!",
                "CURSOSNOAH",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cadastro abrir = new Cadastro();
            abrir.ShowDialog();
        }
    }
}

