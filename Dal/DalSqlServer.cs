using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//namespaces que contem banco de dados 
using System.Data;
using System.Data.SqlClient;
using System.IO;


namespace Dal
{
    public class DalSqlServer
    {

        //Criar Conexao Banco de Dados
        private SqlConnection CriarConexao()
        {
            String connString = null;
            StreamReader sr = File.OpenText("stringConexao.txt");
            string input = null;
            while ((input = sr.ReadLine()) != null)
            {
                connString = input;
            }
            return new SqlConnection(connString);
            //return new SqlConnection(Settings.Default.stringConexao);
        }
        //Parametros que vao para o banco
        private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;
        public void LimparParametros()
        {
            sqlParameterCollection.Clear();
        }
        public void AdicionaParametros(string nomeParametro, object valorParametro)
        {
            sqlParameterCollection.Add(new SqlParameter(nomeParametro, valorParametro));
        }
        //Persistencia - inserir/alterar/excluir
        public object ExecutarManipulacao(CommandType commandType, string nomeProcedore)
        {
            try
            {
                //Criar conexao
                SqlConnection sqlConnection = CriarConexao();
                //Abrir Conexao
                sqlConnection.Open();
                //Criar comando que leva a informaçao para o banco
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                //Alimentando o comando
                //sqlCommand.CommandType = CommandType.StoredProcedure;
                //sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeProcedore;
                sqlCommand.CommandTimeout = 20200; //20 segundos
                //Adiciona os parametros no comando
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }
                //Executar Comando
                return sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        //Consultar registros do banco dados
        public DataTable ExecutarConsulta(CommandType commandType, string nomeProcedore)
        {
            try
            {
                //Criar conexao
                SqlConnection sqlConnection = CriarConexao();
                //Abrir Conexao
                sqlConnection.Open();
                //Criar comando que leva a informaçao para o banco
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                //Alimentando o comando
                //sqlCommand.CommandType = CommandType.StoredProcedure;
                //sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeProcedore;
                sqlCommand.CommandTimeout = 20200; //20 segundos
                //Adiciona os parametros no comando
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }
                //Criar Adaptador
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                //Tabela de dados Vazia
                DataTable dataTable = new DataTable();
                //comando vai ao banco e busca os dados
                sqlDataAdapter.Fill(dataTable);

                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }
}
