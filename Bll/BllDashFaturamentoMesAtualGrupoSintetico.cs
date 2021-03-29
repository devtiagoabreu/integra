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
    public class BllDashFaturamentoMesAtualGrupoSintetico
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

        public DaoDashFaturamentoMesAtualGrupoSinteticoColecao RetornaFaturamentoMesAtualGrupoSintetico()
        {
            try
            {
                DaoDashFaturamentoMesAtualGrupoSinteticoColecao daodashFaturamentoMesAtualGrupoSinteticoColecao = new DaoDashFaturamentoMesAtualGrupoSinteticoColecao();
                dalSqlServer.LimparParametros();

                DataTable dataTableDashFaturamentoMesAtualGrupoSinteticoColecao = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspFaturamentoMesAtualGrupoSintetico");
                foreach (DataRow linha in dataTableDashFaturamentoMesAtualGrupoSinteticoColecao.Rows)
                {

                    DaoDashFaturamentoMesAtualGrupoSintetico dashFaturamentoMesAtualGrupoSintetico = new DaoDashFaturamentoMesAtualGrupoSintetico();
                    dashFaturamentoMesAtualGrupoSintetico.Grupo = linha["Grupo"].ToString();
                    dashFaturamentoMesAtualGrupoSintetico.Metros = Convert.ToDecimal(linha["Metros"]);
                    dashFaturamentoMesAtualGrupoSintetico.Faturamento = Convert.ToDecimal(linha["Faturamento"]);

                    daodashFaturamentoMesAtualGrupoSinteticoColecao.Add(dashFaturamentoMesAtualGrupoSintetico);

                }
                return daodashFaturamentoMesAtualGrupoSinteticoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel consultar. Detalhes: " + ex.Message);
            }
        }

        public string CarregarDashFaturamentoMesAtualGrupoSinteticoEmDBPromodaDash(DaoDashFaturamentoMesAtualGrupoSinteticoColecao daoDashFaturamentoMesAtualGrupoSinteticoColecao)
        {
            try
            {
                string retorno = "ok";
                dalMySql.LimparParametros();
                dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDashFaturamentoMesAtualGrupoSinteticoDeletar");
                DataTable dataTableDashFaturamentoMesAtualGrupoSinteticoColecao = ConvertToDataTable(daoDashFaturamentoMesAtualGrupoSinteticoColecao);
                foreach (DataRow linha in dataTableDashFaturamentoMesAtualGrupoSinteticoColecao.Rows)
                {
                    DaoDashFaturamentoMesAtualGrupoSintetico daoDashFaturamentoMesAtualGrupoSintetico = new DaoDashFaturamentoMesAtualGrupoSintetico();
                    daoDashFaturamentoMesAtualGrupoSintetico.Grupo = linha["Grupo"].ToString();
                    daoDashFaturamentoMesAtualGrupoSintetico.Metros = Convert.ToDecimal(linha["Metros"]);
                    daoDashFaturamentoMesAtualGrupoSintetico.Faturamento = Convert.ToDecimal(linha["Faturamento"]);
                    dalMySql.LimparParametros();
                    dalMySql.AdicionaParametros("@Grupo", daoDashFaturamentoMesAtualGrupoSintetico.Grupo);
                    dalMySql.AdicionaParametros("@Metros", daoDashFaturamentoMesAtualGrupoSintetico.Metros);
                    dalMySql.AdicionaParametros("@Faturamento", daoDashFaturamentoMesAtualGrupoSintetico.Faturamento);


                    dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDashFaturamentoMesAtualGrupoSinteticoInserir");

                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel inserir dados no dash 'Faturamento por Grupo (Beneficiamento, Decoração, Moda) Mês Atual'. Detalhes: " + ex.Message);
            }


        }

    }
}
