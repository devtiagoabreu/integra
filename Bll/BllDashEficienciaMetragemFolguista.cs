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
    public class BllDashEficienciaMetragemFolguista
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

        public DaoDashEficienciaMetragemFolguistaColecao RetornaEficienciaMetragem(DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                DaoDashEficienciaMetragemFolguistaColecao daoDashEficienciaMetragemFolguistaColecao = new DaoDashEficienciaMetragemFolguistaColecao();
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@dataInicial", dataInicial);
                dalSqlServer.AdicionaParametros("@dataFinal", dataFinal);

                DataTable dataTableDaoDashEficienciaMetragemFolguista = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspDashEficienciaMetragemFolguista");

                foreach (DataRow linha in dataTableDaoDashEficienciaMetragemFolguista.Rows)
                {

                    DaoDashEficienciaMetragemFolguista daoDashEficienciaMetragemFolguista = new DaoDashEficienciaMetragemFolguista();
                    daoDashEficienciaMetragemFolguista.EficienciaManha = Convert.ToDecimal(linha["EficienciaManha"]);
                    daoDashEficienciaMetragemFolguista.EficienciaTarde = Convert.ToDecimal(linha["EficienciaTarde"]);
                    daoDashEficienciaMetragemFolguista.EficienciaNoite = Convert.ToDecimal(linha["EficienciaNoite"]);
                    daoDashEficienciaMetragemFolguista.MetragemManha = Convert.ToDecimal(linha["MetragemManha"]);
                    daoDashEficienciaMetragemFolguista.MetragemTarde = Convert.ToDecimal(linha["MetragemTarde"]);
                    daoDashEficienciaMetragemFolguista.MetragemNoite = Convert.ToDecimal(linha["MetragemNoite"]);

                    daoDashEficienciaMetragemFolguistaColecao.Add(daoDashEficienciaMetragemFolguista);

                }

                return daoDashEficienciaMetragemFolguistaColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Nao foi Possivel consultar. Detalhes: " + ex.Message);
            }
        }

        public string CarregarEficienciaMetragemEmDBPromodaDash(DaoDashEficienciaMetragemFolguistaColecao daoDashEficienciaMetragemFolguistaColecao)
        {
            try
            {
                string retorno = "ok";
                dalMySql.LimparParametros();
                dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDaoDashEficienciaMetragemFolguistaDeletar");
                DataTable dataTabledaoDaoDashEficienciaMetragemFolguista = ConvertToDataTable(daoDashEficienciaMetragemFolguistaColecao);
                foreach (DataRow linha in dataTabledaoDaoDashEficienciaMetragemFolguista.Rows)
                {
                    DaoDashEficienciaMetragemFolguista daoDashEficienciaMetragemFolguista = new DaoDashEficienciaMetragemFolguista();
                    daoDashEficienciaMetragemFolguista.EficienciaManha = Convert.ToDecimal(linha["EficienciaManha"]);
                    daoDashEficienciaMetragemFolguista.EficienciaTarde = Convert.ToDecimal(linha["EficienciaTarde"]);
                    daoDashEficienciaMetragemFolguista.EficienciaNoite = Convert.ToDecimal(linha["EficienciaNoite"]);
                    daoDashEficienciaMetragemFolguista.MetragemManha = Convert.ToDecimal(linha["MetragemManha"]);
                    daoDashEficienciaMetragemFolguista.MetragemTarde = Convert.ToDecimal(linha["MetragemTarde"]);
                    daoDashEficienciaMetragemFolguista.MetragemNoite = Convert.ToDecimal(linha["MetragemNoite"]);
                    dalMySql.LimparParametros();
                    dalMySql.AdicionaParametros("@EficienciaManha", daoDashEficienciaMetragemFolguista.EficienciaManha);
                    dalMySql.AdicionaParametros("@EficienciaTarde", daoDashEficienciaMetragemFolguista.EficienciaTarde);
                    dalMySql.AdicionaParametros("@EficienciaNoite", daoDashEficienciaMetragemFolguista.EficienciaNoite);
                    dalMySql.AdicionaParametros("@MetragemManha", daoDashEficienciaMetragemFolguista.MetragemManha);
                    dalMySql.AdicionaParametros("@MetragemTarde", daoDashEficienciaMetragemFolguista.MetragemTarde);
                    dalMySql.AdicionaParametros("@MetragemNoite", daoDashEficienciaMetragemFolguista.MetragemNoite);

                    dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDaoDashEficienciaMetragemFolguistaInserir");

                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel inserir dados no dash 'Eficiencia Metragem Folguista'. Detalhes: " + ex.Message);
            }


        }
    }
}
