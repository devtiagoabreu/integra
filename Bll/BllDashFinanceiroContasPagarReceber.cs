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
    public class BllDashFinanceiroContasPagarReceber
    {
        #region ATRIBUTOS | OBJETOS

        DalSqlServer dalSqlServer = new DalSqlServer();
        DalMySql dalMySql = new DalMySql();

        #endregion

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

        public DaoDashFinanceiroContasPagarReceberColecao RetornaContasPagar()
        {
            try
            {
                DaoDashFinanceiroContasPagarReceberColecao daoDashFinanceiroContasPagarReceberColecao = new DaoDashFinanceiroContasPagarReceberColecao();
                dalSqlServer.LimparParametros();

                DataTable dataTableDaoDashFinanceiroContasPagarReceberColecao = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspDashFinanceiroContasPagar");
                foreach (DataRow linha in dataTableDaoDashFinanceiroContasPagarReceberColecao.Rows)
                {

                    DaoDashFinanceiroContasPagarReceber daoDashFinanceiroContasPagarReceber = new DaoDashFinanceiroContasPagarReceber();
                    daoDashFinanceiroContasPagarReceber.ValorTotalAmanha = Convert.ToDecimal(linha["ValorTotalAmanha"]);
                    daoDashFinanceiroContasPagarReceber.ValorTotalMesAtual = Convert.ToDecimal(linha["ValorTotalMesAtual"]);
                    daoDashFinanceiroContasPagarReceber.ValorTotalRestanteAno = Convert.ToDecimal(linha["ValorTotalRestanteAno"]);

                    daoDashFinanceiroContasPagarReceberColecao.Add(daoDashFinanceiroContasPagarReceber);

                }
                return daoDashFinanceiroContasPagarReceberColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Nao foi Possivel consultar. Detalhes: " + ex.Message);
            }
        }

        public DaoDashFinanceiroContasPagarReceberColecao RetornaContasReceber()
        {
            try
            {
                DaoDashFinanceiroContasPagarReceberColecao daoDashFinanceiroContasPagarReceberColecao = new DaoDashFinanceiroContasPagarReceberColecao();
                dalSqlServer.LimparParametros();

                DataTable dataTableDaoDashFinanceiroContasPagarReceberColecao = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspDashFinanceiroContasReceber");
                foreach (DataRow linha in dataTableDaoDashFinanceiroContasPagarReceberColecao.Rows)
                {

                    DaoDashFinanceiroContasPagarReceber daoDashFinanceiroContasPagarReceber = new DaoDashFinanceiroContasPagarReceber();
                    daoDashFinanceiroContasPagarReceber.ValorTotalHoje = Convert.ToDecimal(linha["ValorTotalHoje"]);
                    daoDashFinanceiroContasPagarReceber.ValorTotalMesAtual = Convert.ToDecimal(linha["ValorTotalMesAtual"]);
                    daoDashFinanceiroContasPagarReceber.ValorTotalRestanteAno = Convert.ToDecimal(linha["ValorTotalRestanteAno"]);

                    daoDashFinanceiroContasPagarReceberColecao.Add(daoDashFinanceiroContasPagarReceber);

                }
                return daoDashFinanceiroContasPagarReceberColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Nao foi Possivel consultar. Detalhes: " + ex.Message);
            }
        }

        public string CarregarDashFinanceiroContasPagarEmDBPromodaDash(DaoDashFinanceiroContasPagarReceberColecao daoDashFinanceiroContasPagarReceberColecao)
        {
            try
            {
                string retorno = "ok";
                dalMySql.LimparParametros();
                dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDashFinanceiroContasPagarDeletar");
                DataTable dataTableDaoDashFinaceiroContasPagarColecao = ConvertToDataTable(daoDashFinanceiroContasPagarReceberColecao);
                foreach (DataRow linha in dataTableDaoDashFinaceiroContasPagarColecao.Rows)
                {
                    DaoDashFinanceiroContasPagarReceber daoDashFinanceiroContasPagarReceber = new DaoDashFinanceiroContasPagarReceber();
                    daoDashFinanceiroContasPagarReceber.ValorTotalAmanha = Convert.ToDecimal(linha["ValorTotalAmanha"]);
                    daoDashFinanceiroContasPagarReceber.ValorTotalMesAtual = Convert.ToDecimal(linha["ValorTotalMesAtual"]);
                    daoDashFinanceiroContasPagarReceber.ValorTotalRestanteAno = Convert.ToDecimal(linha["ValorTotalRestanteAno"]);
                    dalMySql.LimparParametros();
                    dalMySql.AdicionaParametros("@ValorTotalAmanha", daoDashFinanceiroContasPagarReceber.ValorTotalAmanha);
                    dalMySql.AdicionaParametros("@ValorTotalMesAtual", daoDashFinanceiroContasPagarReceber.ValorTotalMesAtual);
                    dalMySql.AdicionaParametros("@ValorTotalRestanteAno", daoDashFinanceiroContasPagarReceber.ValorTotalRestanteAno);


                    dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDashFinanceiroContasPagarInserir");

                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel inserir dados no dash 'Financeiro - Contas a Pagar'. Detalhes: " + ex.Message);
            }


        }

        public string CarregarDashFinanceiroContasReceberEmDBPromodaDash(DaoDashFinanceiroContasPagarReceberColecao daoDashFinanceiroContasPagarReceberColecao)
        {
            try
            {
                string retorno = "ok";
                dalMySql.LimparParametros();
                dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDashFinanceiroContasReceberDeletar");
                DataTable dataTableDaoDashFinaceiroContasReceberColecao = ConvertToDataTable(daoDashFinanceiroContasPagarReceberColecao);
                foreach (DataRow linha in dataTableDaoDashFinaceiroContasReceberColecao.Rows)
                {
                    DaoDashFinanceiroContasPagarReceber daoDashFinanceiroContasPagarReceber = new DaoDashFinanceiroContasPagarReceber();
                    daoDashFinanceiroContasPagarReceber.ValorTotalHoje = Convert.ToDecimal(linha["ValorTotalHoje"]);
                    daoDashFinanceiroContasPagarReceber.ValorTotalMesAtual = Convert.ToDecimal(linha["ValorTotalMesAtual"]);
                    daoDashFinanceiroContasPagarReceber.ValorTotalRestanteAno = Convert.ToDecimal(linha["ValorTotalRestanteAno"]);
                    dalMySql.LimparParametros();
                    dalMySql.AdicionaParametros("@ValorTotalHoje", daoDashFinanceiroContasPagarReceber.ValorTotalHoje);
                    dalMySql.AdicionaParametros("@ValorTotalMesAtual", daoDashFinanceiroContasPagarReceber.ValorTotalMesAtual);
                    dalMySql.AdicionaParametros("@ValorTotalRestanteAno", daoDashFinanceiroContasPagarReceber.ValorTotalRestanteAno);


                    dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDashFinanceiroContasReceberInserir");

                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel inserir dados no dash 'Financeiro - Contas a Receber'. Detalhes: " + ex.Message);
            }


        }

    }
}
