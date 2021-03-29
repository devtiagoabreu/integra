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
    public class BllOrdem
    {
        #region ATRIBUTOS | OBJETOS
        
        DalSqlServer dalSqlServer = new DalSqlServer();
        DalMySql dalMySql = new DalMySql();

        #endregion

        #region MÉTODOS

        public string Insert(DaoOrdem daoOrdem)
        {
            try
            {
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@Numero", daoOrdem.Numero);
                dalSqlServer.AdicionaParametros("@Descricao", daoOrdem.Descricao);
                dalSqlServer.AdicionaParametros("@Ativo", daoOrdem.Ativo);

                string id = dalSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspOrdemInsert").ToString();

                return id;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }

        }
        public string Update(DaoOrdem daoOrdem)
        {
            try
            {
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@Id", daoOrdem.Id);
                dalSqlServer.AdicionaParametros("@Numero", daoOrdem.Numero);
                dalSqlServer.AdicionaParametros("@Descricao", daoOrdem.Descricao);
                dalSqlServer.AdicionaParametros("@Ativo", daoOrdem.Ativo);

                string id = dalSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspOrdemUpdate").ToString();

                return id;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }

        }
        public string Delete(DaoOrdem daoOrdem)
        {
            try
            {
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@Id", daoOrdem.Id);
                string id = dalSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspOrdemDelete").ToString();

                return id;

            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
        public DaoOrdemColecao Search(string tipo, string parametro)
        {
            try
            {
                DaoOrdemColecao daoOrdemColecao = new DaoOrdemColecao();
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@tipo", tipo);
                dalSqlServer.AdicionaParametros("@parametro", parametro);
                
                DataTable dataTableOrdem = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspOrdemSearch");

                foreach (DataRow linha in dataTableOrdem.Rows)
                {
                    DaoOrdem daoOrdem = new DaoOrdem();
                    daoOrdem.Id = Convert.ToInt32(linha["Id"]);
                    daoOrdem.Numero = linha["Numero"].ToString();
                    daoOrdem.Descricao = linha["Descricao"].ToString(); 
                    daoOrdem.Ativo = Convert.ToInt32(linha["Ativo"]);

                    daoOrdemColecao.Add(daoOrdem);

                }

                return daoOrdemColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel consultar. Detalhes: " + ex.Message);
            }
        }

        #endregion
    }
}
