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
    public class BllDashFaturamentoMesAtualUFSintetico
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

        public DaoDashFaturamentoMesAtualUFSinteticoColecao RetornaFaturamentoMesAtualUFSintetico()
        {
            try
            {
                DaoDashFaturamentoMesAtualUFSinteticoColecao daodashFaturamentoMesAtualUFSinteticoColecao = new DaoDashFaturamentoMesAtualUFSinteticoColecao();
                dalSqlServer.LimparParametros();

                DataTable dataTableDashFaturamentoMesAtualUFSinteticoColecao = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspFaturamentoMesAtualUFSintetico");
                foreach (DataRow linha in dataTableDashFaturamentoMesAtualUFSinteticoColecao.Rows)
                {

                    DaoDashFaturamentoMesAtualUFSintetico dashFaturamentoMesAtualUFSintetico = new DaoDashFaturamentoMesAtualUFSintetico();
                    dashFaturamentoMesAtualUFSintetico.UF = linha["UF"].ToString();
                    dashFaturamentoMesAtualUFSintetico.Metros = Convert.ToDecimal(linha["Metros"]);
                    dashFaturamentoMesAtualUFSintetico.Faturamento = Convert.ToDecimal(linha["Faturamento"]);

                    daodashFaturamentoMesAtualUFSinteticoColecao.Add(dashFaturamentoMesAtualUFSintetico);

                }
                return daodashFaturamentoMesAtualUFSinteticoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel consultar. Detalhes: " + ex.Message);
            }
        }

        public string CarregarDashFaturamentoMesAtualUFSinteticoEmDBPromodaDash(DaoDashFaturamentoMesAtualUFSinteticoColecao daoDashFaturamentoMesAtualUFSinteticoColecao)
        {
            try
            {
                string retorno = "ok";
                dalMySql.LimparParametros();
                dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDashFaturamentoMesAtualUFSinteticoDeletar");
                DataTable dataTableDashFaturamentoMesAtualUFSinteticoColecao = ConvertToDataTable(daoDashFaturamentoMesAtualUFSinteticoColecao);
                foreach (DataRow linha in dataTableDashFaturamentoMesAtualUFSinteticoColecao.Rows)
                {
                    DaoDashFaturamentoMesAtualUFSintetico daoDashFaturamentoMesAtualUFSintetico = new DaoDashFaturamentoMesAtualUFSintetico();
                    daoDashFaturamentoMesAtualUFSintetico.UF = linha["UF"].ToString();
                    daoDashFaturamentoMesAtualUFSintetico.Metros = Convert.ToDecimal(linha["Metros"]);
                    daoDashFaturamentoMesAtualUFSintetico.Faturamento = Convert.ToDecimal(linha["Faturamento"]);
                    dalMySql.LimparParametros();
                    dalMySql.AdicionaParametros("@UF", daoDashFaturamentoMesAtualUFSintetico.UF);
                    dalMySql.AdicionaParametros("@Metros", daoDashFaturamentoMesAtualUFSintetico.Metros);
                    dalMySql.AdicionaParametros("@Faturamento", daoDashFaturamentoMesAtualUFSintetico.Faturamento);


                    dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDashFaturamentoMesAtualUFSinteticoInserir");

                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel inserir dados no dash 'Faturamento por Estado (UF) Mês Atual'. Detalhes: " + ex.Message);
            }


        }
                  
    }
}
