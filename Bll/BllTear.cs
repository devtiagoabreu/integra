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
    public class BllTear
    {
        #region ATRIBUTOS | OBJETOS
        
        DalSqlServer dalSqlServer = new DalSqlServer();
        DalMySql dalMySql = new DalMySql();

        #endregion

        #region MÉTODOS

        public string Insert(DaoTear daoTear)
        {
            try
            {
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@Numero", daoTear.Numero);
                dalSqlServer.AdicionaParametros("@Ativo", daoTear.Ativo);

                string id = dalSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspTearInsert").ToString();

                return id;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }

        }
        public string Update(DaoTear daoTear)
        {
            try
            {
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@Id", daoTear.Id);
                dalSqlServer.AdicionaParametros("@Numero", daoTear.Numero);
                dalSqlServer.AdicionaParametros("@Ativo", daoTear.Ativo);

                string id = dalSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspTearUpdate").ToString();

                return id;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }

        }
        public string Delete(DaoTear daoTear)
        {
            try
            {
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@Id", daoTear.Id);
                string id = dalSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspTearDelete").ToString();

                return id;

            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
        public DaoTearColecao Search(string tipo, string parametro)
        {
            try
            {
                DaoTearColecao daoTearColecao = new DaoTearColecao();
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@tipo", tipo);
                dalSqlServer.AdicionaParametros("@parametro", parametro);
                
                DataTable dataTableTear = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspTearSearch");

                foreach (DataRow linha in dataTableTear.Rows)
                {
                    DaoTear daoTear = new DaoTear();
                    daoTear.Id = Convert.ToInt32(linha["Id"]);
                    daoTear.Numero = linha["Numero"].ToString();
                    daoTear.Ativo = Convert.ToInt32(linha["Ativo"]);

                    daoTearColecao.Add(daoTear);

                }

                return daoTearColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel consultar. Detalhes: " + ex.Message);
            }
        }

        #endregion
    }

}
