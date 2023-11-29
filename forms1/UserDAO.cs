using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace forms1
{
    internal class UserDAO
    {

        public bool LoginUser(string txbNome, string txbPront)  
       {
            Conexao1 connection = new Conexao1();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = "SELECT*FROM tabela_login WHERE + user= @user AND passwords=@passwords";   
            sqlCommand.Parameters.AddWithValue("@user", txbNome);
            sqlCommand.Parameters.AddWithValue("@passwords", txbPront);

            try
            {
               SqlDataReader dr=sqlCommand.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Close();
                        return true;

                }
                dr.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                connection.CloseConnection();
            }

            return false;
        }
        public void InsertUser(string txbNome, string txbPront)
           
        {

            Conexao1 connection = new Conexao1();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO tabela_login VALUES(@user, @passwords)";
            sqlCommand.Parameters.AddWithValue("@user", txbNome);
            sqlCommand.Parameters.AddWithValue("@passwords", txbPront);
            sqlCommand.ExecuteNonQuery();

           


            string pront = txbPront;
            string nome = txbNome;
            string message = "E-mail/Usuário " + nome + "\nSenha/Matrícula: " + pront;

            MessageBox.Show(message, "DADOS",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

    
      
        public void DeleteUser(int id)
        {


            Conexao1 connection = new Conexao1();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM tabela_login WHERE id = @id";
            sqlCommand.Parameters.AddWithValue("@id", id);
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
        }

        public void EditUser(string txbNome, string txbPront, int id)
        {    
            

            Conexao1 connection = new Conexao1();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"UPDATE tabela_login SET
             [user] = @user,
             passwords = @passwords
             WHERE id = @id";      //UPDATE: atualizar os campos no banco de dados. SET: quais colunas vai alterar no bds

            sqlCommand.Parameters.AddWithValue("@user", txbNome);
            sqlCommand.Parameters.AddWithValue("@passwords", txbPront);
            sqlCommand.Parameters.AddWithValue("@id", id);
            sqlCommand.ExecuteNonQuery();
        }

        public List<Usuario> SelectUser()
        {
            Conexao1 conn = new Conexao1();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM tabela_login";

            List<Usuario> users = new List<Usuario>();
            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {

                   int id = (int)dr["id"];

                    string user = (string)dr["user"];
                    string pass = (string)dr["passwords"];
                    Usuario usuario= new Usuario(id, user, pass);
                    users.Add(usuario); 

                }
                dr.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro na Leitura de Dados.\n"+ err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
            return users;
        }
    }
}
