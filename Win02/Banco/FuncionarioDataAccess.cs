using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlServerCe;
using Win02.Modelos;

namespace Win02.Banco
{
    class FuncionarioDataAccess
    {
        private static SqlCeConnection conn = new SqlCeConnection(@"Data Source=F:\ProjetosWindowsForms\AulasWindosForm\CRUD\Win02\Banco\Banco.sdf");
        public static DataTable PegarFuncionario()
        {
            SqlCeDataAdapter da = new SqlCeDataAdapter("SELECT * FROM Funcionario", conn);
            DataSet ds = new DataSet();

            da.Fill(ds);

            return ds.Tables[0];
        }

        public static bool InserirFuncionario(Funcionario funcionario)
        {
            string sql = "INSERT INTO [Funcionario] (Nome, Email, Salario, Sexo, TipoContrato, DataCadastro, DataAtualizacao) VALUES (@Nome, @Email, @Salario, @Sexo, @TipoContrato, @DataCadastro, @DataAtualizacao)";
            SqlCeCommand sqlCeCommand = new SqlCeCommand(sql, conn);

            sqlCeCommand.Parameters.Add("@Nome", funcionario.Nome);
            sqlCeCommand.Parameters.Add("@Email", funcionario.Email);
            sqlCeCommand.Parameters.Add("@Salario", funcionario.Salario);
            sqlCeCommand.Parameters.Add("@Sexo", funcionario.Sexo);
            sqlCeCommand.Parameters.Add("@TipoContrato", funcionario.TipoContrato);
            sqlCeCommand.Parameters.Add("@DataCadastro", DateTime.Now);
            sqlCeCommand.Parameters.Add("@DataAtualizacao", DateTime.Now);

            conn.Open();
            if (sqlCeCommand.ExecuteNonQuery() > 0) {
                conn.Close();
                return true;
            }
            else{
                conn.Close();
                return false;
            }
            
        }

        public static Funcionario PegaFuncionario(int id)
        {
            string sql = "SELECT * FROM Funcionario WHERE Id = @id";
            SqlCeCommand sqlCeCommand = new SqlCeCommand(sql, conn);

            sqlCeCommand.Parameters.Add("@id", id);
            

            conn.Open();
            SqlCeDataReader resposta = sqlCeCommand.ExecuteReader();

            Funcionario funcionario = new Funcionario();
            while (resposta.Read())
            {
                funcionario.Id = resposta.GetInt32(0);
                funcionario.Nome = resposta.GetString(1);
                funcionario.Email = resposta.GetString(2);
                funcionario.Salario = resposta.GetDecimal(3);
                funcionario.Sexo = resposta.GetString(4);
                funcionario.TipoContrato = resposta.GetString(5);
                funcionario.DataCadastro = resposta.GetDateTime(6);
                funcionario.DataAtualizacao = resposta.GetDateTime(7);

            }

            conn.Close();

            return funcionario;

        }

        public static bool AtualizarFuncionario(Funcionario funcionario)
        {
            string sql = "UPDATE [Funcionario] SET Nome = @Nome, Email = @Email, Salario = @Salario, Sexo = @Sexo, TipoContrato = @TipoContrato, DataAtualizacao = @DataAtualizacao WHERE Id = @id";
            SqlCeCommand sqlCeCommand = new SqlCeCommand(sql, conn);

            sqlCeCommand.Parameters.Add("@Id", funcionario.Id);
            sqlCeCommand.Parameters.Add("@Nome", funcionario.Nome);
            sqlCeCommand.Parameters.Add("@Email", funcionario.Email);
            sqlCeCommand.Parameters.Add("@Salario", funcionario.Salario);
            sqlCeCommand.Parameters.Add("@Sexo", funcionario.Sexo);
            sqlCeCommand.Parameters.Add("@TipoContrato", funcionario.TipoContrato);
            //sqlCeCommand.Parameters.Add("@DataCadastro", DateTime.Now);
            sqlCeCommand.Parameters.Add("@DataAtualizacao", DateTime.Now);

            conn.Open();
            if (sqlCeCommand.ExecuteNonQuery() > 0)
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }

        }

        public static bool ExcluirFuncionario(int id)
        {
            string sql = "DELETE FROM Funcionario WHERE Id = @id";
            SqlCeCommand sqlCeCommand = new SqlCeCommand(sql, conn);

            sqlCeCommand.Parameters.Add("@id", id);
           
            conn.Open();
            if (sqlCeCommand.ExecuteNonQuery() > 0)
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }


        }
    }
}
