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
    public class BllDashConsumoDeFiosDeUrdumeSintetico
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

        public DaoDashConsumoDeFiosDeUrdumeSinteticoColecao RetornaConsumoUrdumeSintetico(DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                DaoDashConsumoDeFiosDeUrdumeSinteticoColecao daoDashConsumoDeFiosDeUrdumeSinteticoColecao = new DaoDashConsumoDeFiosDeUrdumeSinteticoColecao();
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@dataInicial", dataInicial);
                dalSqlServer.AdicionaParametros("@dataFinal", dataFinal);

                DataTable dataTableDaoDashConsumoDeFiosDeUrdumeSintetico = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspDashConsumoDeFiosDeUrdumeSintetico");

                foreach (DataRow linha in dataTableDaoDashConsumoDeFiosDeUrdumeSintetico.Rows)
                {

                    DaoDashConsumoDeFiosDeUrdumeSintetico daoDashConsumoDeFiosDeUrdumeSintetico = new DaoDashConsumoDeFiosDeUrdumeSintetico();
                    daoDashConsumoDeFiosDeUrdumeSintetico.FioCodigo = linha["FioCodigo"].ToString();
                    daoDashConsumoDeFiosDeUrdumeSintetico.FioDescricao = linha["FioDescricao"].ToString();
                    daoDashConsumoDeFiosDeUrdumeSintetico.PesoUrdume = Convert.ToDecimal(linha["PesoUrdume"]);


                    daoDashConsumoDeFiosDeUrdumeSinteticoColecao.Add(daoDashConsumoDeFiosDeUrdumeSintetico);

                }

                return daoDashConsumoDeFiosDeUrdumeSinteticoColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Nao foi Possivel consultar. Detalhes: " + ex.Message);
            }
        }

        public string CarregarDashConsumoDeFiosDeUrdumeSinteticoEmDBPromodaDash(DaoDashConsumoDeFiosDeUrdumeSinteticoColecao daoDashConsumoDeFiosDeUrdumeSinteticoColecao)
        {
            try
            {
                string retorno = "ok";
                dalMySql.LimparParametros();
                dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDashConsumoDeFiosDeUrdumeSinteticoDeletar");
                DataTable dataTableDaoDashConsumoDeFiosDeUrdumeSinteticoColecao = ConvertToDataTable(daoDashConsumoDeFiosDeUrdumeSinteticoColecao);
                foreach (DataRow linha in dataTableDaoDashConsumoDeFiosDeUrdumeSinteticoColecao.Rows)
                {
                    DaoDashConsumoDeFiosDeUrdumeSintetico daoDashConsumoDeFiosDeUrdumeSintetico = new DaoDashConsumoDeFiosDeUrdumeSintetico();
                    daoDashConsumoDeFiosDeUrdumeSintetico.FioCodigo = linha["FioCodigo"].ToString();
                    daoDashConsumoDeFiosDeUrdumeSintetico.FioDescricao = linha["FioDescricao"].ToString();
                    daoDashConsumoDeFiosDeUrdumeSintetico.PesoUrdume = Convert.ToDecimal(linha["PesoUrdume"]);
                    dalMySql.LimparParametros();
                    dalMySql.AdicionaParametros("@FioCodigo", daoDashConsumoDeFiosDeUrdumeSintetico.FioCodigo);
                    dalMySql.AdicionaParametros("@FioDescricao", daoDashConsumoDeFiosDeUrdumeSintetico.FioDescricao);
                    dalMySql.AdicionaParametros("@PesoUrdume", daoDashConsumoDeFiosDeUrdumeSintetico.PesoUrdume);
                    

                    dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDashConsumoDeFiosDeUrdumeSinteticoInserir");

                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel inserir dados no dash 'Consumo de Urdume'. Detalhes: " + ex.Message);
            }


        }
    }
}
