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
    public class BllDashRevisaoTotalMetrosPorOperador
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

        public DaoDashRevisaoTotalMetrosPorOperadorColecao ConsultarRevisaoTotalMetrosPorOperadorEmDBPromoda(string operador, DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                //Criar coleçao nova (vazia)
                DaoDashRevisaoTotalMetrosPorOperadorColecao daoDashRevisaoTotalMetrosPorOperadorColecao = new DaoDashRevisaoTotalMetrosPorOperadorColecao();
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@operador", operador);
                dalSqlServer.AdicionaParametros("@dataInicial", dataInicial);
                dalSqlServer.AdicionaParametros("@dataFinal", dataFinal);
                //Criando e populando a tabela de dados
                DataTable dataTableDaoDashRevisaoTotalMetrosPorOperador = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspDashRevisaoTotalMetrosPorOperador");
                //Percorrer o DataTable e tranformar em coleçao de DaoDashListagemDePecasMesAtual
                //Cada linha do DataTable e um DaoDashListagemDePecasMesAtual
                //Data=Dados e Row=Linha
                //For=para e Each=Cada
                foreach (DataRow linha in dataTableDaoDashRevisaoTotalMetrosPorOperador.Rows)
                {
                    //Criar um objeto Vazio
                    //Colocar os dados da linha nele
                    //Adicionar ele na coleçao
                    DaoDashRevisaoTotalMetrosPorOperador daoDashRevisaoTotalMetrosPorOperador = new DaoDashRevisaoTotalMetrosPorOperador();
                    daoDashRevisaoTotalMetrosPorOperador.Operador = linha["operador"].ToString();
                    daoDashRevisaoTotalMetrosPorOperador.Nome = linha["nome"].ToString();
                    daoDashRevisaoTotalMetrosPorOperador.TotalMetros = Convert.ToDecimal(linha["totalMetros"]);


                    daoDashRevisaoTotalMetrosPorOperadorColecao.Add(daoDashRevisaoTotalMetrosPorOperador);

                }

                return daoDashRevisaoTotalMetrosPorOperadorColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Nao foi Possivel consultar. Detalhes: " + ex.Message);
            }
        }

        public string CarregarDaoDashRevisaoTotalMetrosPorOperadorEmDBPromodaDash(DaoDashRevisaoTotalMetrosPorOperadorColecao daoDashRevisaoTotalMetrosPorOperadorColecao)
        {
            try
            {
                string retorno = "ok";
                dalMySql.LimparParametros();
                dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDashRevisaoTotalMetrosPorOperadorDeletar");
                DataTable dataTabledaoDaoDashRevisaoTotalMetrosPorOperador = ConvertToDataTable(daoDashRevisaoTotalMetrosPorOperadorColecao);
                foreach (DataRow linha in dataTabledaoDaoDashRevisaoTotalMetrosPorOperador.Rows)
                {
                    DaoDashRevisaoTotalMetrosPorOperador daoDashRevisaoTotalMetrosPorOperador = new DaoDashRevisaoTotalMetrosPorOperador();
                    daoDashRevisaoTotalMetrosPorOperador.Operador = linha["operador"].ToString();
                    daoDashRevisaoTotalMetrosPorOperador.Nome = linha["nome"].ToString();
                    daoDashRevisaoTotalMetrosPorOperador.TotalMetros = Convert.ToDecimal(linha["totalMetros"]);
                    dalMySql.LimparParametros();
                    dalMySql.AdicionaParametros("@operador", daoDashRevisaoTotalMetrosPorOperador.Operador);
                    dalMySql.AdicionaParametros("@nome", daoDashRevisaoTotalMetrosPorOperador.Nome);
                    dalMySql.AdicionaParametros("@totalMetros", daoDashRevisaoTotalMetrosPorOperador.TotalMetros);
                    
                    dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDashRevisaoTotalMetrosPorOperadorInserir");

                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel inserir dados no dash da Revisão. Detalhes: " + ex.Message);
            }


        }

        public DaoDashRevisaoTotalMetrosPorOperadorColecao ConsultarDaoDashRevisaoTotalMetrosPorOperadorEmDBPromodaDash()
        {
            try
            {
                //Criar coleçao nova (vazia)
                DaoDashRevisaoTotalMetrosPorOperadorColecao daoDashRevisaoTotalMetrosPorOperadorColecao = new DaoDashRevisaoTotalMetrosPorOperadorColecao();
                dalMySql.LimparParametros();
                //dalSqlServer.AdicionaParametros("@FuncionarioRg", funcionarioRg);
                //Criando e populando a tabela de dados
                DataTable dataTableDaoDashRevisaoTotalMetrosPorOperador = dalMySql.ExecutarConsulta(CommandType.StoredProcedure, "uspDashRevisaoTotalMetrosPorOperador");
                //Percorrer o DataTable e tranformar em coleçao de DaoDashListagemDePecasMesAtual
                //Cada linha do DataTable e um DaoDashListagemDePecasMesAtual
                //Data=Dados e Row=Linha
                //For=para e Each=Cada
                foreach (DataRow linha in dataTableDaoDashRevisaoTotalMetrosPorOperador.Rows)
                {
                    //Criar um objeto Vazio
                    //Colocar os dados da linha nele
                    //Adicionar ele na coleçao
                    DaoDashRevisaoTotalMetrosPorOperador daoDashRevisaoTotalMetrosPorOperador = new DaoDashRevisaoTotalMetrosPorOperador();
                    daoDashRevisaoTotalMetrosPorOperador.Operador = linha["operador"].ToString();
                    daoDashRevisaoTotalMetrosPorOperador.Nome = linha["nome"].ToString();
                    daoDashRevisaoTotalMetrosPorOperador.TotalMetros = Convert.ToDecimal(linha["metros"]);

                    daoDashRevisaoTotalMetrosPorOperadorColecao.Add(daoDashRevisaoTotalMetrosPorOperador);

                }

                return daoDashRevisaoTotalMetrosPorOperadorColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Nao foi Possivel consultar. Detalhes: " + ex.Message);
            }
        }

        #endregion

    }
}
