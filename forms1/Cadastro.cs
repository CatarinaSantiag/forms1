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
    public partial class Cadastro : Form
    {
        private int id;
        public Cadastro()
        {
            InitializeComponent();
            UpdateListView();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index;
            index = listView1.FocusedItem.Index;
            id = int.Parse(listView1.Items[index].SubItems[0].Text);
            txbNome.Text = listView1.Items[index].SubItems[1].Text;
            txbCep.Text = listView1.Items[index].SubItems[2].Text;
            txbNum.Text = listView1.Items[index].SubItems[3].Text;
            txbRua.Text = listView1.Items[index].SubItems[4].Text;
            txbBairro.Text = listView1.Items[index].SubItems[5].Text;
            txbCidade.Text = listView1.Items[index].SubItems[6].Text;
            txbEstado.Text = listView1.Items[index].SubItems[7].Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EndereçoDAO nomeDoOB = new EndereçoDAO();
            nomeDoOB.DeleteEndereço(id);

            txbNome.Clear();
            txbCep.Clear();
            txbNum.Clear();
            txbRua.Clear();
            txbBairro.Clear();
            txbCidade.Clear();
            txbEstado.Clear();

            MessageBox.Show("Excluida com sucesso",
               "AVISO",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);
            UpdateListView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Endereço user = new Endereço(id, txbNome.Text, txbCep.Text, txbNum.Text, txbRua.Text, txbBairro.Text, txbCidade.Text, txbEstado.Text);
            EndereçoDAO nomeDoOB = new EndereçoDAO();
            nomeDoOB.EditEndereço(id, user);

            MessageBox.Show("Editado com sucesso",
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            txbNome.Clear();
            txbCep.Clear();
            txbNum.Clear();
            txbRua.Clear();
            txbBairro.Clear();
            txbCidade.Clear();
            txbEstado.Clear();

            UpdateListView();
        }

        private void butao_Click(object sender, EventArgs e)
        {
            try
            {
                Endereço user = new Endereço(id, txbNome.Text, txbCep.Text, txbNum.Text, txbRua.Text, txbBairro.Text, txbCidade.Text, txbEstado.Text);
                EndereçoDAO nomeDoOB = new EndereçoDAO();
                nomeDoOB.InsertEndereço(user);

                string nome = txbNome.Text;
                string cep = txbCep.Text;
                string numero = txbNum.Text;
                string rua = txbRua.Text;
                string bairro = txbBairro.Text;
                string cidade = txbCidade.Text;
                string estado = txbEstado.Text;
                string message = "E-mail/Usuário: " + nome + "\nCep: " + cep + "\nNumero: " + numero + "\nRua: " + rua + "\nBairro: " + bairro + "\nCidade: " + cidade + "\nEstado: " + estado;

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
            txbCep.Clear();
            txbNum.Clear();
            txbRua.Clear();
            txbBairro.Clear();
            txbCidade.Clear();
            txbEstado.Clear();

            UpdateListView();
        }
        private void UpdateListView()
        {
            listView1.Items.Clear();

            EndereçoDAO endereçoDAO = new EndereçoDAO();
            List<Endereço> endereços = endereçoDAO.SelectEndereço();

            try
            {
                foreach (Endereço endereço in endereços)
                {

                    ListViewItem lv = new ListViewItem(endereço.Id.ToString());
                    lv.SubItems.Add(endereço.User);
                    lv.SubItems.Add(endereço.Cep);
                    lv.SubItems.Add(endereço.Numero);
                    lv.SubItems.Add(endereço.Rua);
                    lv.SubItems.Add(endereço.Bairro);
                    lv.SubItems.Add(endereço.Cidade);
                    lv.SubItems.Add(endereço.Estado);
                    listView1.Items.Add(lv);

                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void txbCep_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
