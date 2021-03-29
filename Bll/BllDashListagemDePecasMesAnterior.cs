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
    public class BllDashListagemDePecasMesAnterior
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

        public DaoDashListagemDePecasMesAnteriorColecao ConsultarListagemDePecasMesAnteriorEmDBPromoda(string codEmpresa, string codProduto, string codSituacao, string codCategoria, DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                //Criar nova coleçãos (vazia)
                DaoDashListagemDePecasMesAnteriorColecao daoDashListagemDePecasMesAnteriorColecao = new DaoDashListagemDePecasMesAnteriorColecao();
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@codEmpresa", codEmpresa);
                dalSqlServer.AdicionaParametros("@codProduto", codProduto);
                dalSqlServer.AdicionaParametros("@codSituacao", codSituacao);
                dalSqlServer.AdicionaParametros("@codCategoria", codCategoria);
                dalSqlServer.AdicionaParametros("@dataInicial", dataInicial);
                dalSqlServer.AdicionaParametros("@dataFinal", dataFinal);
                //Criando e populando a tabela de dados
                DataTable dataTableDaoDashListagemDePecasMesAnterior = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspDashListagemDePecasMesAnterior");
                //Percorrer o DataTable e tranformar em coleçao de DaoDashListagemDePecasMesAnterior
                //Cada linha do DataTable e um DaoDashListagemDePecasMesAnterior
                //Data=Dados e Row=Linha
                //For=para e Each=Cada
                foreach (DataRow linha in dataTableDaoDashListagemDePecasMesAnterior.Rows)
                {
                    //Criar um objeto Vazio
                    //Colocar os dados da linha nele
                    //Adicionar ele na coleçao
                    DaoDashListagemDePecasMesAnterior daoDashListagemDePecasMesAnterior = new DaoDashListagemDePecasMesAnterior();
                    daoDashListagemDePecasMesAnterior.Produto = linha["produto"].ToString();
                    daoDashListagemDePecasMesAnterior.Pecas = Convert.ToDecimal(linha["pecas"]);
                    daoDashListagemDePecasMesAnterior.Metros = Convert.ToDecimal(linha["metros"]);
                    daoDashListagemDePecasMesAnterior.Batidas = Convert.ToDecimal(linha["batidas"]);
                    daoDashListagemDePecasMesAnterior.Pontos = Convert.ToDecimal(linha["pontos"]);

                    daoDashListagemDePecasMesAnteriorColecao.Add(daoDashListagemDePecasMesAnterior);

                }

                return daoDashListagemDePecasMesAnteriorColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Nao foi Possivel consultar. Detalhes: " + ex.Message);
            }
        }

        public string CarregarListagemDePecasMesAnteriorEmDBPromodaDash(DaoDashListagemDePecasMesAnteriorColecao daoDashListagemDePecasMesAnteriorColecao)
        {
            try
            {
                dalMySql.LimparParametros();
                dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDaoDashListagemDePecasMesAnteriorDeletar");
                DataTable dataTabledaoDashListagemDePecasMesAnterior = ConvertToDataTable(daoDashListagemDePecasMesAnteriorColecao);
                foreach (DataRow linha in dataTabledaoDashListagemDePecasMesAnterior.Rows)
                {
                    DaoDashListagemDePecasMesAnterior daoDashListagemDePecasMesAnterior = new DaoDashListagemDePecasMesAnterior();
                    daoDashListagemDePecasMesAnterior.Produto = linha["produto"].ToString();
                    daoDashListagemDePecasMesAnterior.Pecas = Convert.ToDecimal(linha["pecas"]);
                    daoDashListagemDePecasMesAnterior.Metros = Convert.ToDecimal(linha["metros"]);
                    daoDashListagemDePecasMesAnterior.Batidas = Convert.ToDecimal(linha["batidas"]);
                    daoDashListagemDePecasMesAnterior.Pontos = Convert.ToDecimal(linha["pontos"]);
                    dalMySql.LimparParametros();
                    dalMySql.AdicionaParametros("@produto", daoDashListagemDePecasMesAnterior.Produto);
                    dalMySql.AdicionaParametros("@pecas", daoDashListagemDePecasMesAnterior.Pecas);
                    dalMySql.AdicionaParametros("@metros", daoDashListagemDePecasMesAnterior.Metros);
                    dalMySql.AdicionaParametros("@batidas", daoDashListagemDePecasMesAnterior.Batidas);
                    dalMySql.AdicionaParametros("@pontos", daoDashListagemDePecasMesAnterior.Pontos);

                    dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDaoDashListagemDePecasMesAnteriorInserir");

                }
                return "ok";
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel inserir dados no dash de mês anterior. Detalhes: " + ex.Message);
            }


        }

        public DaoDashListagemDePecasMesAnteriorColecao ConsultarListagemDePecasMesAnteriorEmDBPromodaDash()
        {
            try
            {
                //Criar nova coleção (vazia)
                DaoDashListagemDePecasMesAnteriorColecao daoDashListagemDePecasMesAnteriorColecao = new DaoDashListagemDePecasMesAnteriorColecao();
                dalMySql.LimparParametros();
                //dalSqlServer.AdicionaParametros("@FuncionarioRg", funcionarioRg);
                //Criando e populando a tabela de dados
                DataTable dataTableDaoDashListagemDePecasMesAnterior = dalMySql.ExecutarConsulta(CommandType.StoredProcedure, "uspDaoDashListagemDePecasMesAnteriorConsultarTodos");
                //Percorrer o DataTable e tranformar em coleçao de DaoDashListagemDePecasMesAnterior
                //Cada linha do DataTable e um DaoDashListagemDePecasMesAnterior
                //Data=Dados e Row=Linha
                //For=para e Each=Cada
                foreach (DataRow linha in dataTableDaoDashListagemDePecasMesAnterior.Rows)
                {
                    //Criar um Funcionario Vazio
                    //Colocar os dados da linha nele
                    //Adicionar ele na coleçao
                    DaoDashListagemDePecasMesAnterior daoDashListagemDePecasMesAnterior = new DaoDashListagemDePecasMesAnterior();
                    daoDashListagemDePecasMesAnterior.Produto = linha["produto"].ToString();
                    daoDashListagemDePecasMesAnterior.Pecas = Convert.ToDecimal(linha["pecas"]);
                    daoDashListagemDePecasMesAnterior.Metros = Convert.ToDecimal(linha["metros"]);
                    daoDashListagemDePecasMesAnterior.Batidas = Convert.ToDecimal(linha["batidas"]);
                    daoDashListagemDePecasMesAnterior.Pontos = Convert.ToDecimal(linha["pontos"]);

                    daoDashListagemDePecasMesAnteriorColecao.Add(daoDashListagemDePecasMesAnterior);

                }

                return daoDashListagemDePecasMesAnteriorColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Nao foi Possivel consultar. Detalhes: " + ex.Message);
            }
        }

        #endregion
    }
}
