using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using Dal;
using Dao;

namespace Bll
{
    public class BllKPIFinanceiroInadimplencia
    {
        #region ATRIBUTOS | OBJETOS

        DalSqlServer dalSqlServer = new DalSqlServer();
        DalMySql dalMySql = new DalMySql();

        #endregion

        #region MÉTODOS

        public DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;

        }

        public DaoKPIFinanceiroInadimplenciaColecao RetornaInadimplencia()
        {
            try
            {
                DaoKPIFinanceiroInadimplenciaColecao daoKPIFinanceiroInadimplenciaColecao = new DaoKPIFinanceiroInadimplenciaColecao();
                dalSqlServer.LimparParametros();

                DataTable dataTableDaoKPIFinanceiroInadimplenciaColecao = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspKPIFinanceiroInadimplencia");

                foreach (DataRow linha in dataTableDaoKPIFinanceiroInadimplenciaColecao.Rows)
                {
                    DaoKPIFinanceiroInadimplencia daoKPIFinanceiroInadimplencia = new DaoKPIFinanceiroInadimplencia();
                    daoKPIFinanceiroInadimplencia.ValorDia = Convert.ToDecimal(linha["ValorDia"]);
                    daoKPIFinanceiroInadimplencia.ValorMes = Convert.ToDecimal(linha["ValorMes"]);
                    daoKPIFinanceiroInadimplencia.ValorAno = Convert.ToDecimal(linha["ValorAno"]);

                    daoKPIFinanceiroInadimplenciaColecao.Add(daoKPIFinanceiroInadimplencia);
                }

                return daoKPIFinanceiroInadimplenciaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel consultar a Inadimplência. Detalhes: " + ex.Message);
            }
        }

        public string CarregarInadimplencia(DaoKPIFinanceiroInadimplenciaColecao daoKPIFinanceiroInadimplenciaColecao)
        {
            try
            {
                string retorno = "ok";
                dalMySql.LimparParametros();
                dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspKPIFinanceiroInadimplenciaDeletar");
                DataTable dataTableDaoKPIFinanceiroInadimplenciaColecao = ConvertToDataTable(daoKPIFinanceiroInadimplenciaColecao);
                foreach (DataRow linha in dataTableDaoKPIFinanceiroInadimplenciaColecao.Rows)
                {
                    DaoKPIFinanceiroInadimplencia daoKPIFinanceiroInadimplencia = new DaoKPIFinanceiroInadimplencia();
                    daoKPIFinanceiroInadimplencia.ValorDia = Convert.ToDecimal(linha["ValorDia"]);
                    daoKPIFinanceiroInadimplencia.ValorMes = Convert.ToDecimal(linha["ValorMes"]);
                    daoKPIFinanceiroInadimplencia.ValorAno = Convert.ToDecimal(linha["ValorAno"]);
                    dalMySql.LimparParametros();
                    dalMySql.AdicionaParametros("@ValorDia", daoKPIFinanceiroInadimplencia.ValorDia);
                    dalMySql.AdicionaParametros("@ValorMes", daoKPIFinanceiroInadimplencia.ValorMes);
                    dalMySql.AdicionaParametros("@ValorAno", daoKPIFinanceiroInadimplencia.ValorAno);

                    dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspKPIFinanceiroInadimplenciaInserir");
                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel inserir dados no KPI Financeiro - Inadimplência. Detalhes: " + ex.Message);
            }


        }

        #endregion
    }
}
