using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dal;
using Dao;

namespace Bll
{
    public class BllTearOrdem
    {
        #region ATRIBUTOS | OBJETOS

        DalSqlServer dalSqlServer = new DalSqlServer();
        DalMySql dalMySql = new DalMySql();

        #endregion

        #region MÉTODOS

        public string Insert(DaoTearOrdem daoTearOrdem)
        {
            try
            {
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@TearId", daoTearOrdem.TearId);
                dalSqlServer.AdicionaParametros("@OrdemId", daoTearOrdem.OrdemId);
                dalSqlServer.AdicionaParametros("@DataFechamento", daoTearOrdem.DataFechamento);
                dalSqlServer.AdicionaParametros("@Situacao", daoTearOrdem.Situacao);
                dalSqlServer.AdicionaParametros("@Ativo", daoTearOrdem.Ativo);

                string id = dalSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspTearOrdemInsert").ToString();

                return id;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }

        }
        public string Update(DaoTearOrdem daoTearOrdem)
        {
            try
            {
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@Id", daoTearOrdem.Id);
                dalSqlServer.AdicionaParametros("@TearId", daoTearOrdem.TearId);
                dalSqlServer.AdicionaParametros("@OrdemId", daoTearOrdem.OrdemId);
                dalSqlServer.AdicionaParametros("@DataFechamento", daoTearOrdem.DataFechamento);
                dalSqlServer.AdicionaParametros("@Situacao", daoTearOrdem.Situacao);
                dalSqlServer.AdicionaParametros("@Ativo", daoTearOrdem.Ativo);

                string id = dalSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspTearOrdemUpdate").ToString();

                return id;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }

        }
        public string Delete(DaoTearOrdem daoTearOrdem)
        {
            try
            {
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@Id", daoTearOrdem.Id);
                string id = dalSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspTearOrdemDelete").ToString();

                return id;

            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
        public DaoTearOrdemColecao Search(string tipo, string parametro, DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                DaoTearOrdemColecao daoTearOrdemColecao = new DaoTearOrdemColecao();
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@tipo", tipo);
                dalSqlServer.AdicionaParametros("@parametro", parametro);
                dalSqlServer.AdicionaParametros("@dataInicio", dataInicio);
                dalSqlServer.AdicionaParametros("@dataFim", dataFim);

                DataTable dataTableoTearOrdem = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspTearOrdemSearch");

                foreach (DataRow linha in dataTableoTearOrdem.Rows)
                {
                    DaoTearOrdem daoTearOrdem = new DaoTearOrdem();
                    daoTearOrdem.Id = Convert.ToInt32(linha["Id"]);
                    daoTearOrdem.TearId = Convert.ToInt32(linha["TearId"]);
                    daoTearOrdem.OrdemId = Convert.ToInt32(linha["OrdemId"]);
                    daoTearOrdem.DataCadastro = Convert.ToDateTime(linha["DataCadastro"]);
                    daoTearOrdem.DataFechamento = Convert.ToDateTime(linha["DataFechamento"]);
                    daoTearOrdem.Situacao = Convert.ToInt32(linha["Situacao"]);
                    daoTearOrdem.Ativo = Convert.ToInt32(linha["Ativo"]);

                    daoTearOrdemColecao.Add(daoTearOrdem);

                }

                return daoTearOrdemColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel consultar. Detalhes: " + ex.Message);
            }
        }
        public DaoTearOrdem RetornarOrdemDoTear(string tearNumero)
        {
            try
            {
                DaoTearOrdem daoTearOrdem = new DaoTearOrdem();
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@tearNumero", tearNumero);

                DataTable dataTableTearOrdem = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspRetornarOrdemDoTear");

                foreach (DataRow linha in dataTableTearOrdem.Rows)
                {
                    daoTearOrdem.OrdemNumero = linha["OrdemNumero"].ToString();
                }

                return daoTearOrdem;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel consultar. Detalhes: " + ex.Message);
            }
        }

        #endregion
    }
}
