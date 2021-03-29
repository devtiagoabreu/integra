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
    public class BllKPIFinanceiroFluxoCaixaHoje
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

        public DaoKPIFinanceiroFluxoCaixaHojeColecao RetornaFluxoCaixaHoje()
        {
            try
            {
                DaoKPIFinanceiroFluxoCaixaHojeColecao daoKPIFinanceiroFluxoCaixaHojeColecao = new DaoKPIFinanceiroFluxoCaixaHojeColecao();
                dalSqlServer.LimparParametros();

                DataTable dataTableDaoKPIFinanceiroFluxoCaixaHojeColecao = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspKPIFinanceiroFluxoCaixaHoje");

                foreach (DataRow linha in dataTableDaoKPIFinanceiroFluxoCaixaHojeColecao.Rows)
                {
                    DaoKPIFinanceiroFluxoCaixaHoje daoKPIFinanceiroFluxoCaixaHoje = new DaoKPIFinanceiroFluxoCaixaHoje();
                    daoKPIFinanceiroFluxoCaixaHoje.QtdPagamentos = Convert.ToInt32(linha["QtdPagamentos"]);
                    daoKPIFinanceiroFluxoCaixaHoje.ValorPagamentos = Convert.ToDecimal(linha["ValorPagamentos"]);
                    daoKPIFinanceiroFluxoCaixaHoje.QtdRecebimentos = Convert.ToInt32(linha["QtdRecebimentos"]);
                    daoKPIFinanceiroFluxoCaixaHoje.ValorRecebimentos = Convert.ToDecimal(linha["ValorRecebimentos"]);
                    daoKPIFinanceiroFluxoCaixaHoje.VLP = Convert.ToDecimal(linha["VLP"]);

                    daoKPIFinanceiroFluxoCaixaHojeColecao.Add(daoKPIFinanceiroFluxoCaixaHoje);
                }

                return daoKPIFinanceiroFluxoCaixaHojeColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel consultar o Fluxo de Caixa Hoje. Detalhes: " + ex.Message);
            }
        }

        public string CarregarFluxoCaixaHoje(DaoKPIFinanceiroFluxoCaixaHojeColecao daoKPIFinanceiroFluxoCaixaHojeColecao)
        {
            try
            {
                string retorno = "ok";
                dalMySql.LimparParametros();
                dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspKPIFinanceiroFluxoCaixaHojeDeletar");
                DataTable dataTableDaoKPIFinanceiroFluxoCaixaHojeColecao = ConvertToDataTable(daoKPIFinanceiroFluxoCaixaHojeColecao);
                foreach (DataRow linha in dataTableDaoKPIFinanceiroFluxoCaixaHojeColecao.Rows)
                {
                    DaoKPIFinanceiroFluxoCaixaHoje daoKPIFinanceiroFluxoCaixaHoje = new DaoKPIFinanceiroFluxoCaixaHoje();
                    daoKPIFinanceiroFluxoCaixaHoje.QtdPagamentos = Convert.ToInt32(linha["QtdPagamentos"]);
                    daoKPIFinanceiroFluxoCaixaHoje.ValorPagamentos = Convert.ToDecimal(linha["ValorPagamentos"]);
                    daoKPIFinanceiroFluxoCaixaHoje.QtdRecebimentos = Convert.ToInt32(linha["QtdRecebimentos"]);
                    daoKPIFinanceiroFluxoCaixaHoje.ValorRecebimentos = Convert.ToDecimal(linha["ValorRecebimentos"]);
                    daoKPIFinanceiroFluxoCaixaHoje.VLP = Convert.ToDecimal(linha["VLP"]);
                    dalMySql.LimparParametros();
                    dalMySql.AdicionaParametros("@QtdPagamentos", daoKPIFinanceiroFluxoCaixaHoje.QtdPagamentos);
                    dalMySql.AdicionaParametros("@ValorPagamentos", daoKPIFinanceiroFluxoCaixaHoje.ValorPagamentos);
                    dalMySql.AdicionaParametros("@QtdRecebimentos", daoKPIFinanceiroFluxoCaixaHoje.QtdRecebimentos);
                    dalMySql.AdicionaParametros("@ValorRecebimentos", daoKPIFinanceiroFluxoCaixaHoje.ValorRecebimentos);
                    dalMySql.AdicionaParametros("@VLP", daoKPIFinanceiroFluxoCaixaHoje.VLP);

                    dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspKPIFinanceiroFluxoCaixaHojeInserir");
                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel inserir dados no KPI Financeiro - Fluxo de Caixa Hoje. Detalhes: " + ex.Message);
            }


        }

        #endregion




    }
}
