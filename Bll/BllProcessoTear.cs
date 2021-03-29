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
    public class BllProcessoTear
    {
        #region ATRIBUTOS | OBJETOS

        DalSqlServer dalSqlServer = new DalSqlServer();
        DalMySql dalMySql = new DalMySql();

        #endregion

        public DaoProcessoTearColecao RetornarDadosProcessoTearEmAberto(string tipo, string tearNumero)
        {
            try
            {
                DaoProcessoTearColecao DaoProcessoTearColecao = new DaoProcessoTearColecao();
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@tipo", tipo);
                dalSqlServer.AdicionaParametros("@tearNumero", tearNumero);

                DataTable dataTableProcessoTear = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspRetornaDadosProcessoTearEmAberto");

                foreach (DataRow linha in dataTableProcessoTear.Rows)
                {
                    DaoProcessoTear daoProcessoTear = new DaoProcessoTear();

                    daoProcessoTear.TearNumero = linha["TearNumero"].ToString();
                    daoProcessoTear.TearDescricao = linha["TearDescricao"].ToString();
                    daoProcessoTear.OrdemNumero = linha["OrdemNumero"].ToString();
                    daoProcessoTear.CorNumero = linha["CorNumero"].ToString();
                    daoProcessoTear.DesenhoNumero = linha["DesenhoNumero"].ToString();
                    daoProcessoTear.RoloUrdume = linha["RoloUrdume"].ToString();

                    DaoProcessoTearColecao.Add(daoProcessoTear);

                }

                return DaoProcessoTearColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel retornar dados do processo, insira manualmente. Detalhes: " + ex.Message);
            }
        }
    }
}
