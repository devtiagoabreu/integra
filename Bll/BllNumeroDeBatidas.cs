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
    public class BllNumeroDeBatidas
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

        public DaoNumeroDeBatidas RetornaNumeroDeBatidas(string codProduto)
        {
            try
            {
                DaoNumeroDeBatidas daoNumeroDeBatidas = new DaoNumeroDeBatidas();
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@codProduto", codProduto);

                DataTable dataTableDaoNumeroDeBatidas = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspNumeroDeBatidasPorArtigo");
                foreach (DataRow linha in dataTableDaoNumeroDeBatidas.Rows)
                {
                    try
                    {
                        daoNumeroDeBatidas.Batidas = Convert.ToDecimal(linha["Batidas"].ToString());
                    }
                    catch (Exception)
                    {
                        daoNumeroDeBatidas.Batidas = 0;
                    }
                    
                }

                return daoNumeroDeBatidas;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel consultar. Detalhes: " + ex.Message);
            }
        }

        public DaoNumeroDeBatidas RetornaNumeroDeBatidasDoProduto(string codProduto)
        {
            try
            {
                DaoNumeroDeBatidas daoNumeroDeBatidas = new DaoNumeroDeBatidas();
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@codProduto", codProduto);

                DataTable dataTableDaoNumeroDeBatidas = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspNumeroDeBatidasPorArtigo");
                foreach (DataRow linha in dataTableDaoNumeroDeBatidas.Rows)
                {
                    daoNumeroDeBatidas.Batidas = Convert.ToDecimal(linha["Batidas"].ToString());
                }

                return daoNumeroDeBatidas;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel consultar. Detalhes: " + ex.Message);
            }
        }

        #endregion
    }
}
