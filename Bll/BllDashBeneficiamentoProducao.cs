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
    public class BllDashBeneficiamentoProducao
    {
        #region ATRIBUTOS | OBJETOS
        //Instanciar = criar um novo objeto baseado em um modelo
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

        public DaoDashBeneficiamentoProducaoColecao ListarBeneficiamentoProducaoEmDBPromoda()
        {
            try
            {
                DaoDashBeneficiamentoProducaoColecao daoDashBeneficiamentoProducaoColecao = new DaoDashBeneficiamentoProducaoColecao();
                                
                DataTable dataTableDaoDashBeneficiamentoProducaoColecao = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspDashBeneficiamentoProducaoListar");
               
                foreach (DataRow linha in dataTableDaoDashBeneficiamentoProducaoColecao.Rows)
                {
                    DaoDashBeneficiamentoProducao daoDashBeneficiamentoProducao = new DaoDashBeneficiamentoProducao();
                    daoDashBeneficiamentoProducao.PreparacaoEmOperacao = Convert.ToDecimal(linha["preparacaoEmOperacao"]);
                    daoDashBeneficiamentoProducao.PreparacaoFinalizadaDia = Convert.ToDecimal(linha["preparacaoFinalizadaDia"]);
                    daoDashBeneficiamentoProducao.PreparacaoFinalizadaMes = Convert.ToDecimal(linha["preparacaoFinalizadaMes"]);
                    daoDashBeneficiamentoProducao.TingimentoEmOperacao = Convert.ToDecimal(linha["tingimentoEmOperacao"]);
                    daoDashBeneficiamentoProducao.TingimentoFinalizadoDia = Convert.ToDecimal(linha["tingimentoFinalizadoDia"]);
                    daoDashBeneficiamentoProducao.TingimentoFinalizadoMes = Convert.ToDecimal(linha["tingimentoFinalizadoMes"]);
                    daoDashBeneficiamentoProducao.EstampariaEmOperacao = Convert.ToDecimal(linha["estampariaEmOperacao"]);
                    daoDashBeneficiamentoProducao.EstampariaFinalizadaDia = Convert.ToDecimal(linha["estampariaFinalizadaDia"]);
                    daoDashBeneficiamentoProducao.EstampariaFinalizadaMes = Convert.ToDecimal(linha["estampariaFinalizadaMes"]);
                    daoDashBeneficiamentoProducao.AcabamentoEmOperacao = Convert.ToDecimal(linha["acabamentoEmOperacao"]);
                    daoDashBeneficiamentoProducao.AcabamentoFinalizadoDia = Convert.ToDecimal(linha["acabamentoFinalizadoDia"]);
                    daoDashBeneficiamentoProducao.AcabamentoFinalizadoMes = Convert.ToDecimal(linha["acabamentoFinalizadoMes"]);
                    daoDashBeneficiamentoProducao.RevisaoEmOperacao = Convert.ToDecimal(linha["revisaoEmOperacao"]);
                    daoDashBeneficiamentoProducao.RevisaoFinalizadaDia = Convert.ToDecimal(linha["revisaoFinalizadaDia"]);
                    daoDashBeneficiamentoProducao.RevisaoFinalizadaMes = Convert.ToDecimal(linha["revisaoFinalizadaMes"]);
                    
                    daoDashBeneficiamentoProducaoColecao.Add(daoDashBeneficiamentoProducao);
                }

                return daoDashBeneficiamentoProducaoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel Listar a produção! Detalhes: " + ex.Message);
            }
        }

        public string CarregarDashBeneficiamentoProducaoEmDBPromodaDash(DaoDashBeneficiamentoProducaoColecao daoDashBeneficiamentoProducaoColecao)
        {
            try
            {
                string retorno = "ok";
                dalMySql.LimparParametros();
                dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDashBeneficiamentoProducaoDeletar");
                DataTable dataTableDaoDashBeneficiamentoProducaoColecao = ConvertToDataTable(daoDashBeneficiamentoProducaoColecao);
                foreach (DataRow linha in dataTableDaoDashBeneficiamentoProducaoColecao.Rows)
                {
                    DaoDashBeneficiamentoProducao daoDashBeneficiamentoProducao = new DaoDashBeneficiamentoProducao();
                    daoDashBeneficiamentoProducao.PreparacaoEmOperacao = Convert.ToDecimal(linha["preparacaoEmOperacao"]);
                    daoDashBeneficiamentoProducao.PreparacaoFinalizadaDia = Convert.ToDecimal(linha["preparacaoFinalizadaDia"]);
                    daoDashBeneficiamentoProducao.PreparacaoFinalizadaMes = Convert.ToDecimal(linha["preparacaoFinalizadaMes"]);
                    daoDashBeneficiamentoProducao.TingimentoEmOperacao = Convert.ToDecimal(linha["tingimentoEmOperacao"]);
                    daoDashBeneficiamentoProducao.TingimentoFinalizadoDia = Convert.ToDecimal(linha["tingimentoFinalizadoDia"]);
                    daoDashBeneficiamentoProducao.TingimentoFinalizadoMes = Convert.ToDecimal(linha["tingimentoFinalizadoMes"]);
                    daoDashBeneficiamentoProducao.EstampariaEmOperacao = Convert.ToDecimal(linha["estampariaEmOperacao"]);
                    daoDashBeneficiamentoProducao.EstampariaFinalizadaDia = Convert.ToDecimal(linha["estampariaFinalizadaDia"]);
                    daoDashBeneficiamentoProducao.EstampariaFinalizadaMes = Convert.ToDecimal(linha["estampariaFinalizadaMes"]);
                    daoDashBeneficiamentoProducao.AcabamentoEmOperacao = Convert.ToDecimal(linha["acabamentoEmOperacao"]);
                    daoDashBeneficiamentoProducao.AcabamentoFinalizadoDia = Convert.ToDecimal(linha["acabamentoFinalizadoDia"]);
                    daoDashBeneficiamentoProducao.AcabamentoFinalizadoMes = Convert.ToDecimal(linha["acabamentoFinalizadoMes"]);
                    daoDashBeneficiamentoProducao.RevisaoEmOperacao = Convert.ToDecimal(linha["revisaoEmOperacao"]);
                    daoDashBeneficiamentoProducao.RevisaoFinalizadaDia = Convert.ToDecimal(linha["revisaoFinalizadaDia"]);
                    daoDashBeneficiamentoProducao.RevisaoFinalizadaMes = Convert.ToDecimal(linha["revisaoFinalizadaMes"]);
                    dalMySql.LimparParametros();
                    dalMySql.AdicionaParametros("@preparacaoEmOperacao", daoDashBeneficiamentoProducao.PreparacaoEmOperacao);
                    dalMySql.AdicionaParametros("@preparacaoFinalizadaDia", daoDashBeneficiamentoProducao.PreparacaoFinalizadaDia);
                    dalMySql.AdicionaParametros("@preparacaoFinalizadaMes", daoDashBeneficiamentoProducao.PreparacaoFinalizadaMes);
                    dalMySql.AdicionaParametros("@tingimentoEmOperacao", daoDashBeneficiamentoProducao.TingimentoEmOperacao);
                    dalMySql.AdicionaParametros("@tingimentoFinalizadoDia", daoDashBeneficiamentoProducao.TingimentoFinalizadoDia);
                    dalMySql.AdicionaParametros("@tingimentoFinalizadoMes", daoDashBeneficiamentoProducao.TingimentoFinalizadoMes);
                    dalMySql.AdicionaParametros("@estampariaEmOperacao", daoDashBeneficiamentoProducao.EstampariaEmOperacao);
                    dalMySql.AdicionaParametros("@estampariaFinalizadaDia", daoDashBeneficiamentoProducao.EstampariaFinalizadaDia);
                    dalMySql.AdicionaParametros("@estampariaFinalizadaMes", daoDashBeneficiamentoProducao.EstampariaFinalizadaMes);
                    dalMySql.AdicionaParametros("@acabamentoEmOperacao", daoDashBeneficiamentoProducao.AcabamentoEmOperacao);
                    dalMySql.AdicionaParametros("@acabamentoFinalizadoDia", daoDashBeneficiamentoProducao.AcabamentoFinalizadoDia);
                    dalMySql.AdicionaParametros("@acabamentoFinalizadoMes", daoDashBeneficiamentoProducao.AcabamentoFinalizadoMes);
                    dalMySql.AdicionaParametros("@revisaoEmOperacao", daoDashBeneficiamentoProducao.RevisaoEmOperacao);
                    dalMySql.AdicionaParametros("@revisaoFinalizadaDia", daoDashBeneficiamentoProducao.RevisaoFinalizadaDia);
                    dalMySql.AdicionaParametros("@revisaoFinalizadaMes", daoDashBeneficiamentoProducao.RevisaoFinalizadaMes);


                    dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDashBeneficiamentoProducaoInserir");

                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel inserir dados no dash de produção beneficiamento. Detalhes: " + ex.Message);
            }

        }
        
        #endregion
    }
}
