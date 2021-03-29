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
    public class BllKPIFinanceiroPrevisaoTrimestralDeSaldo
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

        public DaoKPIFinanceiroPrevisaoTrimestralDeSaldoColecao RetornaPrevisaoTrimestralDeSaldo()
        {
            try
            {
                DaoKPIFinanceiroPrevisaoTrimestralDeSaldoColecao daoKPIFinanceiroPrevisaoTrimestralDeSaldoColecao = new DaoKPIFinanceiroPrevisaoTrimestralDeSaldoColecao();
                dalSqlServer.LimparParametros();

                DataTable dataTableDaoKPIFinanceiroPrevisaoTrimestralDeSaldoColecao = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspKPIFinanceiroPrevisaoTrimestralDeSaldo");

                foreach (DataRow linha in dataTableDaoKPIFinanceiroPrevisaoTrimestralDeSaldoColecao.Rows)
                {
                    DaoKPIFinanceiroPrevisaoTrimestralDeSaldo daoKPIFinanceiroPrevisaoTrimestralDeSaldo = new DaoKPIFinanceiroPrevisaoTrimestralDeSaldo();
                    daoKPIFinanceiroPrevisaoTrimestralDeSaldo.Receber = Convert.ToDecimal(linha["Receber"]);
                    daoKPIFinanceiroPrevisaoTrimestralDeSaldo.Pagar = Convert.ToDecimal(linha["Pagar"]);
                    daoKPIFinanceiroPrevisaoTrimestralDeSaldo.Saldo = Convert.ToDecimal(linha["Saldo"]);

                    daoKPIFinanceiroPrevisaoTrimestralDeSaldoColecao.Add(daoKPIFinanceiroPrevisaoTrimestralDeSaldo);
                }

                return daoKPIFinanceiroPrevisaoTrimestralDeSaldoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel consultar a Previsão Trimestra de Saldo.. Detalhes: " + ex.Message);
            }
        }

        public string CarregarPrevisaoTrimestralDeSaldo(DaoKPIFinanceiroPrevisaoTrimestralDeSaldoColecao daoKPIFinanceiroPrevisaoTrimestralDeSaldoColecao)
        {
            try
            {
                string retorno = "ok";
                dalMySql.LimparParametros();
                dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspKPIFinanceiroPrevisaoTrimestralDeSaldoDeletar");
                DataTable dataTableDaoKPIFinanceiroPrevisaoTrimestralDeSaldoColecao = ConvertToDataTable(daoKPIFinanceiroPrevisaoTrimestralDeSaldoColecao);
                foreach (DataRow linha in dataTableDaoKPIFinanceiroPrevisaoTrimestralDeSaldoColecao.Rows)
                {
                    DaoKPIFinanceiroPrevisaoTrimestralDeSaldo daoKPIFinanceiroPrevisaoTrimestralDeSaldo = new DaoKPIFinanceiroPrevisaoTrimestralDeSaldo();
                    daoKPIFinanceiroPrevisaoTrimestralDeSaldo.Receber = Convert.ToDecimal(linha["Receber"]);
                    daoKPIFinanceiroPrevisaoTrimestralDeSaldo.Pagar = Convert.ToDecimal(linha["Pagar"]);
                    daoKPIFinanceiroPrevisaoTrimestralDeSaldo.Saldo = Convert.ToDecimal(linha["Saldo"]);
                    dalMySql.LimparParametros();
                    dalMySql.AdicionaParametros("@Receber", daoKPIFinanceiroPrevisaoTrimestralDeSaldo.Receber);
                    dalMySql.AdicionaParametros("@Pagar", daoKPIFinanceiroPrevisaoTrimestralDeSaldo.Pagar);
                    dalMySql.AdicionaParametros("@Saldo", daoKPIFinanceiroPrevisaoTrimestralDeSaldo.Saldo);

                    dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspKPIFinanceiroPrevisaoTrimestralDeSaldoInserir");
                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel inserir dados no KPI Financeiro - Previsão Trimestra de Saldo. Detalhes: " + ex.Message);
            }


        }

        #endregion

    }
}
