using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms1
{
    internal class EndereçoDAO
    {
        public void InsertEndereço(Endereço endereço)
        {
            Conexao1 connection = new Conexao1();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO tabela_endereço VALUES(@user, @cep, @numero, @rua, @bairro, @cidade, @estado)";
            sqlCommand.Parameters.AddWithValue("@user", endereço.User);
            sqlCommand.Parameters.AddWithValue("@cep", endereço.Cep);
            sqlCommand.Parameters.AddWithValue("@numero", endereço.Numero);
            sqlCommand.Parameters.AddWithValue("@rua", endereço.Rua);
            sqlCommand.Parameters.AddWithValue("@bairro", endereço.Bairro);
            sqlCommand.Parameters.AddWithValue("@cidade", endereço.Cidade);
            sqlCommand.Parameters.AddWithValue("@estado", endereço.Estado);
            sqlCommand.ExecuteNonQuery();
        }
        public void DeleteEndereço(int id)
        {
            Conexao1 connection = new Conexao1();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM tabela_endereço WHERE id = @id";
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
        public void EditEndereço(int id, Endereço endereço)
        {
                Conexao1 connection = new Conexao1();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = connection.ReturnConnection();
                sqlCommand.CommandText = @"UPDATE tabela_endereço SET
                [user] = @user,
                cep = @cep,
                numero = @numero,
                rua = @rua,
                bairro = @bairro,
                cidade = @cidade,
                estado = @estado
                WHERE id = @id";

                //UPDATE: atualizar os campos no banco de dados. SET: quais colunas vai alterar no bds
                sqlCommand.Parameters.AddWithValue("@user", endereço.User);
                sqlCommand.Parameters.AddWithValue("@cep", endereço.Cep);
                sqlCommand.Parameters.AddWithValue("@numero", endereço.Numero);
                sqlCommand.Parameters.AddWithValue("@rua", endereço.Rua);
                sqlCommand.Parameters.AddWithValue("@bairro", endereço.Bairro);
                sqlCommand.Parameters.AddWithValue("@cidade", endereço.Cidade);
                sqlCommand.Parameters.AddWithValue("@estado", endereço.Estado);
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.ExecuteNonQuery();
            
        }
        public List<Endereço> SelectEndereço()
        {
            Conexao1 conn = new Conexao1();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM tabela_endereço";

            List<Endereço> endereços = new List<Endereço>();
            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    Endereço obj = new Endereço(
                    (int)dr["id"],
                    (string)dr["user"],
                    (string)dr["cep"],
                    (string)dr["numero"],
                    (string)dr["rua"],
                    (string)dr["bairro"],
                    (string)dr["cidade"],
                    (string)dr["estado"]
                   );
                    endereços.Add(obj);

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
            return endereços;
        }
    }
}
