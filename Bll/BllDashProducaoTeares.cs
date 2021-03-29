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
    public class BllDashProducaoTeares
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

        public DaoDashProducaoTearesColecao RetornarProducaoTeares(DateTime dataCadastro)
        {
            DaoDashProducaoTearesColecao daoDashProducaoTearesColecao = new DaoDashProducaoTearesColecao();
            dalSqlServer.LimparParametros();
            dalSqlServer.AdicionaParametros("@dataCadastro", dataCadastro);
            
            DataTable dataTebleDaoDashProducaoTeares = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspDashProducaoTearesPorDataCadastro");
            foreach (DataRow linha in dataTebleDaoDashProducaoTeares.Rows)
            {
                DaoDashProducaoTeares daoDashProducaoTeares = new DaoDashProducaoTeares();
                daoDashProducaoTeares.TearNumero = linha["TearNumero"].ToString();
                daoDashProducaoTeares.OrdemNumero = linha["OrdemNumero"].ToString();
                daoDashProducaoTeares.RoloUrdume = linha["RoloUrdume"].ToString();
                daoDashProducaoTeares.RoloUrdume2 = linha["RoloUrdume2"].ToString();
                daoDashProducaoTeares.Situacao = Convert.ToInt32(linha["Situacao"]);
                daoDashProducaoTeares.MotivoSituacao = linha["MotivoSituacao"].ToString();
                daoDashProducaoTeares.Obs = linha["Obs"].ToString();
                daoDashProducaoTeares.Rpm = Convert.ToDecimal(linha["Rpm"]);
                daoDashProducaoTeares.EficienciaManha = Convert.ToDecimal(linha["EficienciaManha"]);
                daoDashProducaoTeares.EficienciaTarde = Convert.ToDecimal(linha["EficienciaTarde"]);
                daoDashProducaoTeares.EficienciaNoite = Convert.ToDecimal(linha["EficienciaNoite"]);
                daoDashProducaoTeares.Eficiencia24hs = Convert.ToDecimal(linha["Eficiencia24hs"]);
                daoDashProducaoTeares.MetragemManha = Convert.ToDecimal(linha["MetragemManha"]);
                daoDashProducaoTeares.MetragemTarde = Convert.ToDecimal(linha["MetragemTarde"]);
                daoDashProducaoTeares.MetragemNoite = Convert.ToDecimal(linha["MetragemNoite"]);
                daoDashProducaoTeares.Metragem24hs = Convert.ToDecimal(linha["Metragem24hs"]);
                daoDashProducaoTeares.MetragemAcumulada = Convert.ToDecimal(linha["MetragemAcumulada"]);
                daoDashProducaoTeares.Corte = Convert.ToDecimal(linha["Corte"]);
                daoDashProducaoTeares.DataProducao = Convert.ToDateTime(linha["DataProducao"]);
                
                daoDashProducaoTearesColecao.Add(daoDashProducaoTeares);
            }
            return daoDashProducaoTearesColecao;
        }

        public string CarregarDashProducaoTeares(DaoDashProducaoTearesColecao daoDashProducaoTearesColecao)
        {
            try
            {
                string retorno = "ok";
                dalMySql.LimparParametros();
                dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDashProducaoTearesDeletar");
                DataTable dataTableDaoDashProducaoTeares = ConvertToDataTable(daoDashProducaoTearesColecao);
                foreach (DataRow linha in dataTableDaoDashProducaoTeares.Rows)
                {
                    DaoDashProducaoTeares daoDashProducaoTeares = new DaoDashProducaoTeares();
                    daoDashProducaoTeares.TearNumero = linha["TearNumero"].ToString();
                    daoDashProducaoTeares.OrdemNumero = linha["OrdemNumero"].ToString();
                    daoDashProducaoTeares.RoloUrdume = linha["RoloUrdume"].ToString();
                    daoDashProducaoTeares.RoloUrdume2 = linha["RoloUrdume2"].ToString();
                    daoDashProducaoTeares.Situacao = Convert.ToInt32(linha["Situacao"]);
                    daoDashProducaoTeares.MotivoSituacao = linha["MotivoSituacao"].ToString();
                    daoDashProducaoTeares.Obs = linha["Obs"].ToString();
                    daoDashProducaoTeares.Rpm = Convert.ToDecimal(linha["Rpm"]);
                    daoDashProducaoTeares.EficienciaManha = Convert.ToDecimal(linha["EficienciaManha"]);
                    daoDashProducaoTeares.EficienciaTarde = Convert.ToDecimal(linha["EficienciaTarde"]);
                    daoDashProducaoTeares.EficienciaNoite = Convert.ToDecimal(linha["EficienciaNoite"]);
                    daoDashProducaoTeares.Eficiencia24hs = Convert.ToDecimal(linha["Eficiencia24hs"]);
                    daoDashProducaoTeares.MetragemManha = Convert.ToDecimal(linha["MetragemManha"]);
                    daoDashProducaoTeares.MetragemTarde = Convert.ToDecimal(linha["MetragemTarde"]);
                    daoDashProducaoTeares.MetragemNoite = Convert.ToDecimal(linha["MetragemNoite"]);
                    daoDashProducaoTeares.Metragem24hs = Convert.ToDecimal(linha["Metragem24hs"]);
                    daoDashProducaoTeares.MetragemAcumulada = Convert.ToDecimal(linha["MetragemAcumulada"]);
                    daoDashProducaoTeares.Corte = Convert.ToDecimal(linha["Corte"]);
                    daoDashProducaoTeares.DataProducao = Convert.ToDateTime(linha["DataProducao"]);
                    dalMySql.LimparParametros();
                    dalMySql.AdicionaParametros("@TearNumero", daoDashProducaoTeares.TearNumero);
                    dalMySql.AdicionaParametros("@OrdemNumero", daoDashProducaoTeares.OrdemNumero);
                    dalMySql.AdicionaParametros("@RoloUrdume", daoDashProducaoTeares.RoloUrdume);
                    dalMySql.AdicionaParametros("@RoloUrdume2", daoDashProducaoTeares.RoloUrdume2);
                    dalMySql.AdicionaParametros("@Situacao", daoDashProducaoTeares.Situacao);
                    dalMySql.AdicionaParametros("@MotivoSituacao", daoDashProducaoTeares.MotivoSituacao);
                    dalMySql.AdicionaParametros("@Obs", daoDashProducaoTeares.Obs);
                    dalMySql.AdicionaParametros("@Rpm", daoDashProducaoTeares.Rpm);
                    dalMySql.AdicionaParametros("@EficienciaManha", daoDashProducaoTeares.EficienciaManha);
                    dalMySql.AdicionaParametros("@EficienciaTarde", daoDashProducaoTeares.EficienciaTarde);
                    dalMySql.AdicionaParametros("@EficienciaNoite", daoDashProducaoTeares.EficienciaNoite);
                    dalMySql.AdicionaParametros("@Eficiencia24hs", daoDashProducaoTeares.Eficiencia24hs);
                    dalMySql.AdicionaParametros("@MetragemManha", daoDashProducaoTeares.MetragemManha);
                    dalMySql.AdicionaParametros("@MetragemTarde", daoDashProducaoTeares.MetragemTarde);
                    dalMySql.AdicionaParametros("@MetragemNoite", daoDashProducaoTeares.MetragemNoite);
                    dalMySql.AdicionaParametros("@Metragem24hs", daoDashProducaoTeares.Metragem24hs);
                    dalMySql.AdicionaParametros("@MetragemAcumulada", daoDashProducaoTeares.MetragemAcumulada);
                    dalMySql.AdicionaParametros("@Corte", daoDashProducaoTeares.Corte);
                    dalMySql.AdicionaParametros("@DataProducao", daoDashProducaoTeares.DataProducao);

                    dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDashProducaoTearesInserir");

                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel inserir dados no dash 'Produção Teares'. Detalhes: " + ex.Message);
            }

        }
        

        #endregion
    }
}
