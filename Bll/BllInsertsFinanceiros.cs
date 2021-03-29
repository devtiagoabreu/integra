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
    public class BllInsertsFinanceiros
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

        public DaoInsertsFinanceiros RetornaInsertsFinanceiros()
        {
            try
            {
                DaoInsertsFinanceiros daoInsertsFinanceiros = new DaoInsertsFinanceiros();
                dalMySql.LimparParametros();

                DataTable dataTableDaoInsertsFinanceiros = dalMySql.ExecutarConsulta(CommandType.StoredProcedure, "uspInsertsFinanceiros");

                foreach (DataRow linha in dataTableDaoInsertsFinanceiros.Rows)
                {
                    daoInsertsFinanceiros.Id = Convert.ToInt32(linha["Id"]);
                    daoInsertsFinanceiros.SaldoBancarioDia = Convert.ToDecimal(linha["SaldoBancarioDia"]);
                                      
                }
                return daoInsertsFinanceiros;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel consultar os Inserts Financeiros. Detalhes: " + ex.Message);
            }
        }

        public string Insert(DaoInsertsFinanceiros daoInsertsFinanceiros)
        {
            try
            {
                dalMySql.LimparParametros();
                dalMySql.AdicionaParametros("@SaldoBancarioDia", daoInsertsFinanceiros.SaldoBancarioDia);
                
                string retorno = dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspInsertsFinanceirosInsert").ToString();

                return retorno;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }

        }

        public void Update(DaoInsertsFinanceiros daoInsertsFinanceiros)
        {
            try
            {
                dalMySql.LimparParametros();
                dalMySql.AdicionaParametros("@Id", daoInsertsFinanceiros.Id);
                dalMySql.AdicionaParametros("@SaldoBancarioDia", daoInsertsFinanceiros.SaldoBancarioDia);

                dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspInsertsFinanceirosUpdate").ToString();
                      
            }
            catch (Exception exception)
            {
                
            }

        }

        #endregion
    }
}
