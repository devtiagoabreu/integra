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
    public class BllBeneficiamentoApontamentosGrupoMaquinaSintetico
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

        public DaoBeneficiamentoApontamentosGrupoMaquinaSinteticoColecao RetornaListaDeAlpontamentosGrupoMaquinaSintetico()
        {
            try
            {
                DaoBeneficiamentoApontamentosGrupoMaquinaSinteticoColecao daoBeneficiamentoApontamentosGrupoMaquinaSinteticoColecao = new DaoBeneficiamentoApontamentosGrupoMaquinaSinteticoColecao();
                dalSqlServer.LimparParametros();

                DataTable dataTableDaoBeneficiamentoApontamentosGrupoMaquinaSintetico = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspBeneficiamentoApontamentosGrupoMaquinaSintetico");
                foreach (DataRow linha in dataTableDaoBeneficiamentoApontamentosGrupoMaquinaSintetico.Rows)
                {
                    DaoBeneficiamentoApontamentosGrupoMaquinaSintetico daoBeneficiamentoApontamentosGrupoMaquinaSintetico = new DaoBeneficiamentoApontamentosGrupoMaquinaSintetico();
                    daoBeneficiamentoApontamentosGrupoMaquinaSintetico.GrupoMaquina = linha["GrupoMaquina"].ToString();
                    daoBeneficiamentoApontamentosGrupoMaquinaSintetico.Metros = Convert.ToDecimal(linha["Metros"]);
                    daoBeneficiamentoApontamentosGrupoMaquinaSintetico.DataInicio = Convert.ToDateTime(linha["DataInicio"]);

                    daoBeneficiamentoApontamentosGrupoMaquinaSinteticoColecao.Add(daoBeneficiamentoApontamentosGrupoMaquinaSintetico);

                }

                return daoBeneficiamentoApontamentosGrupoMaquinaSinteticoColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Nao foi Possivel consultar. Detalhes: " + ex.Message);
            }
        }


        public string CarregarDashBeneficiamentoApontamentosGrupoMaquinaSinteticoEmDBPromodaDash(DaoBeneficiamentoApontamentosGrupoMaquinaSinteticoColecao daoBeneficiamentoApontamentosGrupoMaquinaSinteticoColecao)
        {
            try
            {
                string retorno = "ok";
                dalMySql.LimparParametros();
                dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDashBeneficiamentoApontamentosGrupoMaquinaSinteticoDeletar");
                DataTable dataTableDaoBeneficiamentoApontamentosGrupoMaquinaSinteticoColecao = ConvertToDataTable(daoBeneficiamentoApontamentosGrupoMaquinaSinteticoColecao);
                foreach (DataRow linha in dataTableDaoBeneficiamentoApontamentosGrupoMaquinaSinteticoColecao.Rows)
                {
                    DaoBeneficiamentoApontamentosGrupoMaquinaSintetico daoBeneficiamentoApontamentosGrupoMaquinaSintetico = new DaoBeneficiamentoApontamentosGrupoMaquinaSintetico();
                    daoBeneficiamentoApontamentosGrupoMaquinaSintetico.GrupoMaquina = linha["GrupoMaquina"].ToString();
                    daoBeneficiamentoApontamentosGrupoMaquinaSintetico.Metros = Convert.ToDecimal(linha["Metros"]);
                    daoBeneficiamentoApontamentosGrupoMaquinaSintetico.DataInicio = Convert.ToDateTime(linha["DataInicio"]);
                    dalMySql.LimparParametros();
                    dalMySql.AdicionaParametros("@GrupoMaquina", daoBeneficiamentoApontamentosGrupoMaquinaSintetico.GrupoMaquina);
                    dalMySql.AdicionaParametros("@Metros", daoBeneficiamentoApontamentosGrupoMaquinaSintetico.Metros);
                    dalMySql.AdicionaParametros("@DataInicio", daoBeneficiamentoApontamentosGrupoMaquinaSintetico.DataInicio);

                    dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDashBeneficiamentoApontamentosGrupoMaquinaSinteticoInserir");

                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel inserir dados no dash de Apontameto de Grupo Maquina do Beneficiamento. Detalhes: " + ex.Message);
            }

        }


        #endregion
    }
}
