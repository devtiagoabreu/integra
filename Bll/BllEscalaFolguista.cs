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
    public class BllEscalaFolguista
    {
        #region ATRIBUTOS | OBJETOS

        DalSqlServer dalSqlServer = new DalSqlServer();
        DalMySql dalMySql = new DalMySql();

        #endregion

        #region MÉTODOS

        public DaoEscalaFolguista RetornaEscalaFoguistaPorData(DateTime data)
        {
            try
            {
                DaoEscalaFolguista daoEscalaFolguista = new DaoEscalaFolguista();
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@data", data);
                
                DataTable dataTableEscalaFolguista = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspRetornaEscalaFoguistaPorData");

                foreach (DataRow linha in dataTableEscalaFolguista.Rows)
                {
                    daoEscalaFolguista.Id = Convert.ToInt32(linha["Id"]);
                    daoEscalaFolguista.Data = Convert.ToDateTime(linha["Data"].ToString());
                    daoEscalaFolguista.Turno = linha["Turno"].ToString();
                    daoEscalaFolguista.Ativo = Convert.ToInt32(linha["Ativo"]);
                }

                return daoEscalaFolguista;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi retornar dados. Detalhes: " + ex.Message);
            }
        }


        #endregion
    }
}
