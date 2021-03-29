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
    public class BllDashSituacaoOp
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

        public DaoDashSituacaoOpColecao RetornaSituacaoOp(string empresa, string descricaoProcesso, string status)
        {
            try
            {
                DaoDashSituacaoOpColecao daoDashSituacaoOpColecao = new DaoDashSituacaoOpColecao();
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@empresa", empresa);
                dalSqlServer.AdicionaParametros("@descricaoProcesso", descricaoProcesso);
                dalSqlServer.AdicionaParametros("@status", status);

                DataTable dataTableDaoDashSituacaoOp = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspDashSituacaoOp");
                foreach (DataRow linha in dataTableDaoDashSituacaoOp.Rows)
                {
                    DaoDashSituacaoOp daoDashSituacaoOp = new DaoDashSituacaoOp();
                    //daoDashSituacaoOp.Empresa = linha["Empresa"].ToString();
                    daoDashSituacaoOp.OP = linha["OP"].ToString();
                    //daoDashSituacaoOp.Sequencia = linha["Sequencia"].ToString();
                    //daoDashSituacaoOp.Processo = linha["Processo"].ToString();
                    //daoDashSituacaoOp.Item = linha["Item"].ToString();
                    //daoDashSituacaoOp.GrupoMaquina = linha["GrupoMaquina"].ToString();
                    //daoDashSituacaoOp.DescricaoProcesso = linha["DescricaoProcesso"].ToString();
                    //daoDashSituacaoOp.Status = linha["Status"].ToString();
                    //if (linha["DataInicio"] == DBNull.Value)
                    //    daoDashSituacaoOp.DataInicio = DateTime.Now.Date;
                    //else
                    //    daoDashSituacaoOp.DataInicio = Convert.ToDateTime(linha["DataInicio"]);
                    //if (linha["HoraInicio"] == DBNull.Value)
                    //    daoDashSituacaoOp.HoraInicio = DateTime.Now;
                    //else
                    //    daoDashSituacaoOp.HoraInicio = Convert.ToDateTime(linha["HoraInicio"]);

                    //if (linha["DataFinal"] == DBNull.Value)
                    //    daoDashSituacaoOp.DataFinal = DateTime.Now.Date;
                    //else
                    //    daoDashSituacaoOp.DataFinal = Convert.ToDateTime(linha["DataFinal"]);
                    //if (linha["HoraFinal"] == DBNull.Value)
                    //    daoDashSituacaoOp.HoraFinal = DateTime.Now.Date;
                    //else
                    //    daoDashSituacaoOp.HoraFinal = Convert.ToDateTime(linha["HoraFinal"]);
                  
                    daoDashSituacaoOpColecao.Add(daoDashSituacaoOp);

                }

                return daoDashSituacaoOpColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Nao foi Possivel consultar. Detalhes: " + ex.Message);
            }
        }

        public DaoDashSituacaoOpColecao RetornaSituacaoOpKanbanBeneficiamento(string empresa, string descricaoProcesso, string status)
        {
            try
            {
                DaoDashSituacaoOpColecao daoDashSituacaoOpColecao = new DaoDashSituacaoOpColecao();
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@empresa", empresa);
                dalSqlServer.AdicionaParametros("@descricaoProcesso", descricaoProcesso);
                dalSqlServer.AdicionaParametros("@status", status);

                DataTable dataTableDaoDashSituacaoOp = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspDashSituacaoOp");
                foreach (DataRow linha in dataTableDaoDashSituacaoOp.Rows)
                {
                    DaoDashSituacaoOp daoDashSituacaoOp = new DaoDashSituacaoOp();
                    daoDashSituacaoOp.OP = linha["OP"].ToString();
                    
                    daoDashSituacaoOpColecao.Add(daoDashSituacaoOp);

                }

                return daoDashSituacaoOpColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Nao foi Possivel consultar. Detalhes: " + ex.Message);
            }
        }

        public string CarregarSituacaoOpEmDBPromodaDash(DaoDashSituacaoOpColecao daoDashSituacaoOpColecao)
        {
            try
            {
                string retorno = "ok";
                dalMySql.LimparParametros();
                dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDaoDashSituacaoOpDeletar");
                DataTable dataTableDaoDashSituacaoOp = ConvertToDataTable(daoDashSituacaoOpColecao);
                foreach (DataRow linha in dataTableDaoDashSituacaoOp.Rows)
                {
                    DaoDashSituacaoOp daoDashSituacaoOp = new DaoDashSituacaoOp();
                    //daoDashSituacaoOp.Empresa = linha["Empresa"].ToString();
                    daoDashSituacaoOp.OP = linha["OP"].ToString();
                    //daoDashSituacaoOp.Sequencia = linha["Sequencia"].ToString();
                    //daoDashSituacaoOp.Processo = linha["Processo"].ToString();
                    //daoDashSituacaoOp.Item = linha["Item"].ToString();
                    //daoDashSituacaoOp.GrupoMaquina = linha["GrupoMaquina"].ToString();
                    //daoDashSituacaoOp.DescricaoProcesso = linha["DescricaoProcesso"].ToString();
                    //daoDashSituacaoOp.Status = linha["Status"].ToString();
                    //daoDashSituacaoOp.DataInicio = Convert.ToDateTime(linha["DataInicio"]);
                    //daoDashSituacaoOp.HoraInicio = Convert.ToDateTime(linha["HoraInicio"]);
                    //daoDashSituacaoOp.DataFinal = Convert.ToDateTime(linha["DataFinal"]);
                    //daoDashSituacaoOp.HoraFinal = Convert.ToDateTime(linha["HoraFinal"]);
                    //dalMySql.LimparParametros();
                    //dalMySql.AdicionaParametros("@Empresa", daoDashSituacaoOp.Empresa);
                    //dalMySql.AdicionaParametros("@OP", daoDashSituacaoOp.OP);
                    //dalMySql.AdicionaParametros("@Sequencia", daoDashSituacaoOp.Sequencia);
                    //dalMySql.AdicionaParametros("@Processo", daoDashSituacaoOp.Processo);
                    //dalMySql.AdicionaParametros("@Item", daoDashSituacaoOp.Item);
                    //dalMySql.AdicionaParametros("@GrupoMaquina", daoDashSituacaoOp.GrupoMaquina);
                    //dalMySql.AdicionaParametros("@DescricaoProcesso", daoDashSituacaoOp.DescricaoProcesso);
                    //dalMySql.AdicionaParametros("@Status", daoDashSituacaoOp.Status);
                    //dalMySql.AdicionaParametros("@DataInicio", daoDashSituacaoOp.DataInicio);
                    //dalMySql.AdicionaParametros("@HoraInicio", daoDashSituacaoOp.HoraInicio);
                    //dalMySql.AdicionaParametros("@DataFinal", daoDashSituacaoOp.DataFinal);
                    //dalMySql.AdicionaParametros("@HoraFinal", daoDashSituacaoOp.HoraFinal);

                    dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDaoDashSituacaoOpInserir");

                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel inserir dados no dash 'Situação OP'. Detalhes: " + ex.Message);
            }


        }

        #endregion
    }
}
