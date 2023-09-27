using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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
                Usuario user = new Usuario( txbPront.Text, txbNome.Text );
                UserDAO nomeDoOB = new UserDAO();
                nomeDoOB.InsertUser(txbNome.Text, txbPront.Text);
                MessageBox.Show("Cadastrado com sucesso!", "1",

              MessageBoxButtons.OK,
              MessageBoxIcon.Information);
            }
            catch(Exception error)
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

            UserDAO dao = new UserDAO();
            dao.EditUser(txbNome.Text, txbPront.Text, id);
            

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
            txbPront.Text = listView1.Items[index].SubItems[2].Text;
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
    }
}     

