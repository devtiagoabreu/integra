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
    public class BllRelatorioProdutosBlocoH
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

        public DaoDashInventarioSaldoFiosColecao RetornaRelProdutosBlocoH()
        {
            try
            {
                DaoDashInventarioSaldoFiosColecao daoDashInventarioSaldoFiosColecao = new DaoDashInventarioSaldoFiosColecao();
                dalSqlServer.LimparParametros();

                DataTable dataTableDaoDashInventarioSaldoFiosColecao = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspDashInventarioSaldoFios");
                foreach (DataRow linha in dataTableDaoDashInventarioSaldoFiosColecao.Rows)
                {

                    DaoDashInventarioSaldoFios daoDashInventarioSaldoFios = new DaoDashInventarioSaldoFios();
                    daoDashInventarioSaldoFios.Fio = linha["Fio"].ToString();
                    daoDashInventarioSaldoFios.Descricao = linha["Descricao"].ToString();
                    daoDashInventarioSaldoFios.QtdCaixas = Convert.ToDecimal(linha["QtdCaixas"]);
                    daoDashInventarioSaldoFios.SaldoPeso = Convert.ToDecimal(linha["SaldoPeso"]);

                    daoDashInventarioSaldoFiosColecao.Add(daoDashInventarioSaldoFios);

                }
                return daoDashInventarioSaldoFiosColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Nao foi Possivel consultar. Detalhes: " + ex.Message);
            }
        }

        public string CarregarDashInventarioSaldoFiosEmDBPromodaDash(DaoDashInventarioSaldoFiosColecao daoDashInventarioSaldoFiosColecao)
        {
            try
            {
                string retorno = "ok";
                dalMySql.LimparParametros();
                dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDashInventarioSaldoFiosDeletar");
                DataTable dataTabledaoDashInventarioSaldoFiosColecao = ConvertToDataTable(daoDashInventarioSaldoFiosColecao);
                foreach (DataRow linha in dataTabledaoDashInventarioSaldoFiosColecao.Rows)
                {
                    DaoDashInventarioSaldoFios daoDashInventarioSaldoFios = new DaoDashInventarioSaldoFios();
                    daoDashInventarioSaldoFios.Fio = linha["Fio"].ToString();
                    daoDashInventarioSaldoFios.Descricao = linha["Descricao"].ToString();
                    daoDashInventarioSaldoFios.QtdCaixas = Convert.ToDecimal(linha["QtdCaixas"]);
                    daoDashInventarioSaldoFios.SaldoPeso = Convert.ToDecimal(linha["SaldoPeso"]);
                    dalMySql.LimparParametros();
                    dalMySql.AdicionaParametros("@Fio", daoDashInventarioSaldoFios.Fio);
                    dalMySql.AdicionaParametros("@Descricao", daoDashInventarioSaldoFios.Descricao);
                    dalMySql.AdicionaParametros("@QtdCaixas", daoDashInventarioSaldoFios.QtdCaixas);
                    dalMySql.AdicionaParametros("@SaldoPeso", daoDashInventarioSaldoFios.SaldoPeso);

                    dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDashInventarioSaldoFiosInserir");

                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel inserir dados no dash 'Saldo de Fios'. Detalhes: " + ex.Message);
            }


        }
    }
}
