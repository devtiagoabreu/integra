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
    public class BllDashConsumoDeFiosDeTramaSintetico
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

        public DaoDashConsumoDeFiosDeTramaSinteticoColecao RetornaConsumoTramaSintetico(DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                DaoDashConsumoDeFiosDeTramaSinteticoColecao daoDashConsumoDeFiosDeTramaSinteticoColecao = new DaoDashConsumoDeFiosDeTramaSinteticoColecao();
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@dataInicial", dataInicial);
                dalSqlServer.AdicionaParametros("@dataFinal", dataFinal);

                DataTable dataTableDaoDashConsumoDeFiosDeTramaSintetico = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspDashConsumoDeFiosDeTramaSintetico");

                foreach (DataRow linha in dataTableDaoDashConsumoDeFiosDeTramaSintetico.Rows)
                {

                    DaoDashConsumoDeFiosDeTramaSintetico daoDashConsumoDeFiosDeTramaSintetico = new DaoDashConsumoDeFiosDeTramaSintetico();
                    daoDashConsumoDeFiosDeTramaSintetico.FioCodigo = linha["FioCodigo"].ToString();
                    daoDashConsumoDeFiosDeTramaSintetico.FioDescricao = linha["FioDescricao"].ToString();
                    daoDashConsumoDeFiosDeTramaSintetico.PesoTrama = Convert.ToDecimal(linha["PesoTrama"]);


                    daoDashConsumoDeFiosDeTramaSinteticoColecao.Add(daoDashConsumoDeFiosDeTramaSintetico);

                }

                return daoDashConsumoDeFiosDeTramaSinteticoColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Nao foi Possivel consultar. Detalhes: " + ex.Message);
            }
        }

        public string CarregarDashConsumoDeFiosDeTramaSinteticoEmDBPromodaDash(DaoDashConsumoDeFiosDeTramaSinteticoColecao daoDashConsumoDeFiosDeTramaSinteticoColecao)
        {
            try
            {
                string retorno = "ok";
                dalMySql.LimparParametros();
                dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDashConsumoDeFiosDeTramaSinteticoDeletar");
                DataTable dataTableDaoDashConsumoDeFiosDeTramaSinteticoColecao = ConvertToDataTable(daoDashConsumoDeFiosDeTramaSinteticoColecao);
                foreach (DataRow linha in dataTableDaoDashConsumoDeFiosDeTramaSinteticoColecao.Rows)
                {
                    DaoDashConsumoDeFiosDeTramaSintetico daoDashConsumoDeFiosDeTramaSintetico = new DaoDashConsumoDeFiosDeTramaSintetico();
                    daoDashConsumoDeFiosDeTramaSintetico.FioCodigo = linha["FioCodigo"].ToString();
                    daoDashConsumoDeFiosDeTramaSintetico.FioDescricao = linha["FioDescricao"].ToString();
                    daoDashConsumoDeFiosDeTramaSintetico.PesoTrama = Convert.ToDecimal(linha["PesoTrama"]);
                    dalMySql.LimparParametros();
                    dalMySql.AdicionaParametros("@FioCodigo", daoDashConsumoDeFiosDeTramaSintetico.FioCodigo);
                    dalMySql.AdicionaParametros("@FioDescricao", daoDashConsumoDeFiosDeTramaSintetico.FioDescricao);
                    dalMySql.AdicionaParametros("@PesoTrama", daoDashConsumoDeFiosDeTramaSintetico.PesoTrama);


                    dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDashConsumoDeFiosDeTramaSinteticoInserir");

                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel inserir dados no dash 'Consumo de Trama'. Detalhes: " + ex.Message);
            }


        }
    }
}
