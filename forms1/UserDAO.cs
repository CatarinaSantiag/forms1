using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace forms1
{
    internal class UserDAO
    {


        public void InsertUser(Usuario usuario)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(usuario.Passwords));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                {
                    sb.Append(b.ToString("x2"));
                }
                string sha256string = sb.ToString();

                Conexao1 connection = new Conexao1();
                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.Connection = connection.ReturnConnection();
                sqlCommand.CommandText = @"INSERT INTO tabela_login VALUES(@user, @passwords)";
                sqlCommand.Parameters.AddWithValue("@user", usuario.User);
                sqlCommand.Parameters.AddWithValue("@passwords", sha256string);
                sqlCommand.ExecuteNonQuery();
            }
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

        public void EditUser(int id, Usuario usuario)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(usuario.Passwords));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                {
                    sb.Append(b.ToString("x2"));
                }
                string sha256string = sb.ToString();

                Conexao1 connection = new Conexao1();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = connection.ReturnConnection();
                sqlCommand.CommandText = @"UPDATE tabela_login SET
                [user] = @user,
                passwords = @passwords
                WHERE id = @id";      
                
                //UPDATE: atualizar os campos no banco de dados. SET: quais colunas vai alterar no bds

                sqlCommand.Parameters.AddWithValue("@user", usuario.User) ;
                sqlCommand.Parameters.AddWithValue("@passwords", sha256string);
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.ExecuteNonQuery();
            }
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
                    Usuario obj = new Usuario(
                   (int)dr["id"],
                    (string)dr["user"],
                    (string)dr["passwords"]
                   );
                    users.Add(obj);

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
            return users;
        }
    }
}
