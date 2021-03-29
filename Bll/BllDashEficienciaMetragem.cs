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
    public class BllDashEficienciaMetragem
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

        public DaoDashEficienciaMetragemColecao RetornaEficienciaMetragem(DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                DaoDashEficienciaMetragemColecao daoDashEficienciaMetragemColecao = new DaoDashEficienciaMetragemColecao();
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@dataInicial", dataInicial);
                dalSqlServer.AdicionaParametros("@dataFinal", dataFinal);
                
                DataTable dataTableDaoDashEficienciaMetragem = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspDashEficienciaMetragem");
               
                foreach (DataRow linha in dataTableDaoDashEficienciaMetragem.Rows)
                {
                    
                    DaoDashEficienciaMetragem daoDashEficienciaMetragem = new DaoDashEficienciaMetragem();
                    daoDashEficienciaMetragem.EficienciaManha = Convert.ToDecimal(linha["EficienciaManha"]);
                    daoDashEficienciaMetragem.EficienciaTarde = Convert.ToDecimal(linha["EficienciaTarde"]);
                    daoDashEficienciaMetragem.EficienciaNoite = Convert.ToDecimal(linha["EficienciaNoite"]);
                    daoDashEficienciaMetragem.MetragemManha = Convert.ToDecimal(linha["MetragemManha"]);
                    daoDashEficienciaMetragem.MetragemTarde = Convert.ToDecimal(linha["MetragemTarde"]);
                    daoDashEficienciaMetragem.MetragemNoite = Convert.ToDecimal(linha["MetragemNoite"]);

                    daoDashEficienciaMetragemColecao.Add(daoDashEficienciaMetragem);

                }

                return daoDashEficienciaMetragemColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Nao foi Possivel consultar. Detalhes: " + ex.Message);
            }
        }

        public string CarregarEficienciaMetragemEmDBPromodaDash(DaoDashEficienciaMetragemColecao daoDashEficienciaMetragemColecao)
        {
            try
            {
                string retorno = "ok";
                dalMySql.LimparParametros();
                dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDaoDashEficienciaMetragemDeletar");
                DataTable dataTableDaodaoDashEficienciaMetragem = ConvertToDataTable(daoDashEficienciaMetragemColecao);
                foreach (DataRow linha in dataTableDaodaoDashEficienciaMetragem.Rows)
                {
                    DaoDashEficienciaMetragem daoDashEficienciaMetragem = new DaoDashEficienciaMetragem();
                    daoDashEficienciaMetragem.EficienciaManha = Convert.ToDecimal(linha["EficienciaManha"]);
                    daoDashEficienciaMetragem.EficienciaTarde = Convert.ToDecimal(linha["EficienciaTarde"]);
                    daoDashEficienciaMetragem.EficienciaNoite = Convert.ToDecimal(linha["EficienciaNoite"]);
                    daoDashEficienciaMetragem.MetragemManha = Convert.ToDecimal(linha["MetragemManha"]);
                    daoDashEficienciaMetragem.MetragemTarde = Convert.ToDecimal(linha["MetragemTarde"]);
                    daoDashEficienciaMetragem.MetragemNoite = Convert.ToDecimal(linha["MetragemNoite"]);
                    dalMySql.LimparParametros();
                    dalMySql.AdicionaParametros("@EficienciaManha", daoDashEficienciaMetragem.EficienciaManha);
                    dalMySql.AdicionaParametros("@EficienciaTarde", daoDashEficienciaMetragem.EficienciaTarde);
                    dalMySql.AdicionaParametros("@EficienciaNoite", daoDashEficienciaMetragem.EficienciaNoite);
                    dalMySql.AdicionaParametros("@MetragemManha", daoDashEficienciaMetragem.MetragemManha);
                    dalMySql.AdicionaParametros("@MetragemTarde", daoDashEficienciaMetragem.MetragemTarde);
                    dalMySql.AdicionaParametros("@MetragemNoite", daoDashEficienciaMetragem.MetragemNoite);
                    
                    dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDaoDashEficienciaMetragemInserir");

                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel inserir dados no dash 'Eficiencia Metragem'. Detalhes: " + ex.Message);
            }


        }
    }
}
