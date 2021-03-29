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
    public class BllDashFaturamentoDiaAtualGrupoSintetico
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

        public DaoDashFaturamentoDiaAtualGrupoSinteticoColecao RetornaFaturamentoDiaAtualGrupoSintetico()
        {
            try
            {
                DaoDashFaturamentoDiaAtualGrupoSinteticoColecao daodashFaturamentoDiaAtualGrupoSinteticoColecao = new DaoDashFaturamentoDiaAtualGrupoSinteticoColecao();
                dalSqlServer.LimparParametros();

                DataTable dataTableDashFaturamentoDiaAtualGrupoSinteticoColecao = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspFaturamentoDiaAtualGrupoSintetico");
                foreach (DataRow linha in dataTableDashFaturamentoDiaAtualGrupoSinteticoColecao.Rows)
                {

                    DaoDashFaturamentoDiaAtualGrupoSintetico dashFaturamentoDiaAtualGrupoSintetico = new DaoDashFaturamentoDiaAtualGrupoSintetico();
                    dashFaturamentoDiaAtualGrupoSintetico.Grupo = linha["Grupo"].ToString();
                    dashFaturamentoDiaAtualGrupoSintetico.Metros = Convert.ToDecimal(linha["Metros"]);
                    dashFaturamentoDiaAtualGrupoSintetico.Faturamento = Convert.ToDecimal(linha["Faturamento"]);

                    daodashFaturamentoDiaAtualGrupoSinteticoColecao.Add(dashFaturamentoDiaAtualGrupoSintetico);

                }
                return daodashFaturamentoDiaAtualGrupoSinteticoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel consultar. Detalhes: " + ex.Message);
            }
        }

        public string CarregarDashFaturamentoDiaAtualGrupoSinteticoEmDBPromodaDash(DaoDashFaturamentoDiaAtualGrupoSinteticoColecao daoDashFaturamentoDiaAtualGrupoSinteticoColecao)
        {
            try
            {
                string retorno = "ok";
                dalMySql.LimparParametros();
                dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDashFaturamentoDiaAtualGrupoSinteticoDeletar");
                DataTable dataTableDashFaturamentoDiaAtualGrupoSinteticoColecao = ConvertToDataTable(daoDashFaturamentoDiaAtualGrupoSinteticoColecao);
                foreach (DataRow linha in dataTableDashFaturamentoDiaAtualGrupoSinteticoColecao.Rows)
                {
                    DaoDashFaturamentoDiaAtualGrupoSintetico daoDashFaturamentoDiaAtualGrupoSintetico = new DaoDashFaturamentoDiaAtualGrupoSintetico();
                    daoDashFaturamentoDiaAtualGrupoSintetico.Grupo = linha["Grupo"].ToString();
                    daoDashFaturamentoDiaAtualGrupoSintetico.Metros = Convert.ToDecimal(linha["Metros"]);
                    daoDashFaturamentoDiaAtualGrupoSintetico.Faturamento = Convert.ToDecimal(linha["Faturamento"]);
                    dalMySql.LimparParametros();
                    dalMySql.AdicionaParametros("@Grupo", daoDashFaturamentoDiaAtualGrupoSintetico.Grupo);
                    dalMySql.AdicionaParametros("@Metros", daoDashFaturamentoDiaAtualGrupoSintetico.Metros);
                    dalMySql.AdicionaParametros("@Faturamento", daoDashFaturamentoDiaAtualGrupoSintetico.Faturamento);


                    dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDashFaturamentoDiaAtualGrupoSinteticoInserir");

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