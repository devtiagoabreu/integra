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
    public class BllDashProcessosBeneficiamento
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

        public DaoDashProcessosBeneficiamentoColecao RetornaProcessosBeneficiamento()
        {
            try
            {
                DaoDashProcessosBeneficiamentoColecao daoDashProcessosBeneficiamentoColecao = new DaoDashProcessosBeneficiamentoColecao();
                dalSqlServer.LimparParametros();
                
                DataTable dataTableDaoDashProcessosBeneficiamento = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspDashProcessosBeneficiamento");

                foreach (DataRow linha in dataTableDaoDashProcessosBeneficiamento.Rows)
                {

                    DaoDashProcessosBeneficiamento daoDashProcessosBeneficiamento = new DaoDashProcessosBeneficiamento();
                    daoDashProcessosBeneficiamento.TipoProcesso = linha["TipoProcesso"].ToString();
                    daoDashProcessosBeneficiamento.DescricaoTipoProcesso = linha["DescricaoTipoProcesso"].ToString();
                    daoDashProcessosBeneficiamento.StatusAtual = linha["StatusAtual"].ToString();
                    daoDashProcessosBeneficiamento.Metros = Convert.ToDecimal(linha["Metros"]);


                    daoDashProcessosBeneficiamentoColecao.Add(daoDashProcessosBeneficiamento);

                }

                return daoDashProcessosBeneficiamentoColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Nao foi Possivel consultar. Detalhes: " + ex.Message);
            }
        }

        public string CarregarDashProcessosBeneficiamento(DaoDashProcessosBeneficiamentoColecao daoDashProcessosBeneficiamentoColecao)
        {
            try
            {
                string retorno = "ok";
                dalMySql.LimparParametros();
                dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDashProcessosBeneficiamentoDeletar");
                DataTable dataTableDaoDashProcessosBeneficiamento = ConvertToDataTable(daoDashProcessosBeneficiamentoColecao);
                foreach (DataRow linha in dataTableDaoDashProcessosBeneficiamento.Rows)
                {
                    DaoDashProcessosBeneficiamento daoDashProcessosBeneficiamento = new DaoDashProcessosBeneficiamento();
                    daoDashProcessosBeneficiamento.TipoProcesso = linha["TipoProcesso"].ToString();
                    daoDashProcessosBeneficiamento.DescricaoTipoProcesso = linha["DescricaoTipoProcesso"].ToString();
                    daoDashProcessosBeneficiamento.StatusAtual = linha["StatusAtual"].ToString();
                    daoDashProcessosBeneficiamento.Metros = Convert.ToDecimal(linha["Metros"]);
                    dalMySql.LimparParametros();
                    dalMySql.AdicionaParametros("@TipoProcesso", daoDashProcessosBeneficiamento.TipoProcesso);
                    dalMySql.AdicionaParametros("@DescricaoTipoProcesso", daoDashProcessosBeneficiamento.DescricaoTipoProcesso);
                    dalMySql.AdicionaParametros("@StatusAtual", daoDashProcessosBeneficiamento.StatusAtual);
                    dalMySql.AdicionaParametros("@Metros", daoDashProcessosBeneficiamento.Metros);

                    dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDashProcessosBeneficiamentoInserir");

                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel inserir dados no dash 'Processo de Beneficiamento'. Detalhes: " + ex.Message);
            }


        }
    }
}
