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
    public class BllDashListagemDePecasMesAtual
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

        public DaoDashListagemDePecasMesAtualColecao ConsultarListagemDePecasMesAtualEmDBPromoda(string codEmpresa, string codProduto, string codSituacao, string codCategoria, DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                //Criar coleçao nova de Funcionarios (vazia)
                DaoDashListagemDePecasMesAtualColecao daoDashListagemDePecasMesAtualColecao = new DaoDashListagemDePecasMesAtualColecao();
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@codEmpresa", codEmpresa);
                dalSqlServer.AdicionaParametros("@codProduto", codProduto);
                dalSqlServer.AdicionaParametros("@codSituacao", codSituacao);
                dalSqlServer.AdicionaParametros("@codCategoria", codCategoria);
                dalSqlServer.AdicionaParametros("@dataInicial", dataInicial);
                dalSqlServer.AdicionaParametros("@dataFinal", dataFinal);
                //Criando e populando a tabela de dados
                DataTable dataTableDaoDashListagemDePecasMesAtual = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspDashListagemDePecasMesAtual");
                //Percorrer o DataTable e tranformar em coleçao de DaoDashListagemDePecasMesAtual
                //Cada linha do DataTable e um DaoDashListagemDePecasMesAtual
                //Data=Dados e Row=Linha
                //For=para e Each=Cada
                foreach (DataRow linha in dataTableDaoDashListagemDePecasMesAtual.Rows)
                {
                    //Criar um Funcionario Vazio
                    //Colocar os dados da linha nele
                    //Adicionar ele na coleçao
                    DaoDashListagemDePecasMesAtual daoDashListagemDePecasMesAtual = new DaoDashListagemDePecasMesAtual();
                    daoDashListagemDePecasMesAtual.Produto = linha["produto"].ToString();
                    daoDashListagemDePecasMesAtual.Pecas = Convert.ToDecimal(linha["pecas"]);
                    daoDashListagemDePecasMesAtual.Metros = Convert.ToDecimal(linha["metros"]);
                    daoDashListagemDePecasMesAtual.Batidas = Convert.ToDecimal(linha["batidas"]);
                    daoDashListagemDePecasMesAtual.Pontos = Convert.ToDecimal(linha["pontos"]);

                    daoDashListagemDePecasMesAtualColecao.Add(daoDashListagemDePecasMesAtual);

                    

                }

                return daoDashListagemDePecasMesAtualColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Nao foi Possivel consultar. Detalhes: " + ex.Message);
            }
        }

        public string CarregarListagemDePecasMesAtualEmDBPromodaDash(DaoDashListagemDePecasMesAtualColecao daoDashListagemDePecasMesAtualColecao)
        {
            try
            {
                string retorno = "ok";
                dalMySql.LimparParametros();
                dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDaoDashListagemDePecasMesAtualDeletar");
                DataTable dataTabledaoDashListagemDePecasMesAtual = ConvertToDataTable(daoDashListagemDePecasMesAtualColecao);
                foreach (DataRow linha in dataTabledaoDashListagemDePecasMesAtual.Rows)
                {
                    DaoDashListagemDePecasMesAtual daoDashListagemDePecasMesAtual = new DaoDashListagemDePecasMesAtual();
                    daoDashListagemDePecasMesAtual.Produto = linha["produto"].ToString();
                    daoDashListagemDePecasMesAtual.Pecas = Convert.ToDecimal(linha["pecas"]);
                    daoDashListagemDePecasMesAtual.Metros = Convert.ToDecimal(linha["metros"]);
                    daoDashListagemDePecasMesAtual.Batidas = Convert.ToDecimal(linha["batidas"]);
                    daoDashListagemDePecasMesAtual.Pontos = Convert.ToDecimal(linha["pontos"]);
                    dalMySql.LimparParametros();
                    dalMySql.AdicionaParametros("@produto", daoDashListagemDePecasMesAtual.Produto);
                    dalMySql.AdicionaParametros("@pecas", daoDashListagemDePecasMesAtual.Pecas);
                    dalMySql.AdicionaParametros("@metros", daoDashListagemDePecasMesAtual.Metros);
                    dalMySql.AdicionaParametros("@batidas", daoDashListagemDePecasMesAtual.Batidas);
                    dalMySql.AdicionaParametros("@pontos", daoDashListagemDePecasMesAtual.Pontos);
                    
                    dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDaoDashListagemDePecasMesAtualInserir");
                    
                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel inserir dados no dash de mês atual. Detalhes: " + ex.Message);
            }
            
              
        }




        public DaoDashListagemDePecasMesAtualColecao ConsultarListagemDePecasDeSegundaMesAtualEmDBPromoda(string codEmpresa, string codProduto, string codSituacao, DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                //Criar coleçao nova de Funcionarios (vazia)
                DaoDashListagemDePecasMesAtualColecao daoDashListagemDePecasMesAtualColecao = new DaoDashListagemDePecasMesAtualColecao();
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@codEmpresa", codEmpresa);
                dalSqlServer.AdicionaParametros("@codProduto", codProduto);
                dalSqlServer.AdicionaParametros("@codSituacao", codSituacao);
                //dalSqlServer.AdicionaParametros("@codCategoria", codCategoria);
                dalSqlServer.AdicionaParametros("@dataInicial", dataInicial);
                dalSqlServer.AdicionaParametros("@dataFinal", dataFinal);
                //Criando e populando a tabela de dados
                DataTable dataTableDaoDashListagemDePecasMesAtual = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspDashListagemDePecasDeSegundaMesAtual");
                //Percorrer o DataTable e tranformar em coleçao de DaoDashListagemDePecasMesAtual
                //Cada linha do DataTable e um DaoDashListagemDePecasMesAtual
                //Data=Dados e Row=Linha
                //For=para e Each=Cada
                foreach (DataRow linha in dataTableDaoDashListagemDePecasMesAtual.Rows)
                {
                    //Criar um Funcionario Vazio
                    //Colocar os dados da linha nele
                    //Adicionar ele na coleçao
                    DaoDashListagemDePecasMesAtual daoDashListagemDePecasMesAtual = new DaoDashListagemDePecasMesAtual();
                    daoDashListagemDePecasMesAtual.Produto = linha["produto"].ToString();
                    daoDashListagemDePecasMesAtual.Pecas = Convert.ToDecimal(linha["pecas"]);
                    daoDashListagemDePecasMesAtual.Metros = Convert.ToDecimal(linha["metros"]);
                    daoDashListagemDePecasMesAtual.Batidas = Convert.ToDecimal(linha["batidas"]);
                    daoDashListagemDePecasMesAtual.Pontos = Convert.ToDecimal(linha["pontos"]);

                    daoDashListagemDePecasMesAtualColecao.Add(daoDashListagemDePecasMesAtual);

                }

                return daoDashListagemDePecasMesAtualColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Nao foi Possivel consultar. Detalhes: " + ex.Message);
            }
        }

        public string CarregarListagemDePecasDeSegundaMesAtualEmDBPromodaDash(DaoDashListagemDePecasMesAtualColecao daoDashListagemDePecasMesAtualColecao)
        {
            try
            {
                string retorno = "ok";
                dalMySql.LimparParametros();
                dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDaoDashListagemDePecasDeSegundaMesAtualDeletar");
                DataTable dataTabledaoDashListagemDePecasMesAtual = ConvertToDataTable(daoDashListagemDePecasMesAtualColecao);
                foreach (DataRow linha in dataTabledaoDashListagemDePecasMesAtual.Rows)
                {
                    DaoDashListagemDePecasMesAtual daoDashListagemDePecasMesAtual = new DaoDashListagemDePecasMesAtual();
                    daoDashListagemDePecasMesAtual.Produto = linha["produto"].ToString();
                    daoDashListagemDePecasMesAtual.Pecas = Convert.ToDecimal(linha["pecas"]);
                    daoDashListagemDePecasMesAtual.Metros = Convert.ToDecimal(linha["metros"]);
                    daoDashListagemDePecasMesAtual.Batidas = Convert.ToDecimal(linha["batidas"]);
                    daoDashListagemDePecasMesAtual.Pontos = Convert.ToDecimal(linha["pontos"]);
                    dalMySql.LimparParametros();
                    dalMySql.AdicionaParametros("@produto", daoDashListagemDePecasMesAtual.Produto);
                    dalMySql.AdicionaParametros("@pecas", daoDashListagemDePecasMesAtual.Pecas);
                    dalMySql.AdicionaParametros("@metros", daoDashListagemDePecasMesAtual.Metros);
                    dalMySql.AdicionaParametros("@batidas", daoDashListagemDePecasMesAtual.Batidas);
                    dalMySql.AdicionaParametros("@pontos", daoDashListagemDePecasMesAtual.Pontos);

                    dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDaoDashListagemDePecasDeSegundaMesAtualInserir");

                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel inserir dados no dash de mês atual. Detalhes: " + ex.Message);
            }


        }




        public DaoDashListagemDePecasMesAtualColecao ConsultarListagemDePecasMesAtualEmDBPromodaDash()
        {
            try
            {
                //Criar coleçao nova de Funcionarios (vazia)
                DaoDashListagemDePecasMesAtualColecao daoDashListagemDePecasMesAtualColecao = new DaoDashListagemDePecasMesAtualColecao();
                dalMySql.LimparParametros();
                //dalSqlServer.AdicionaParametros("@FuncionarioRg", funcionarioRg);
                //Criando e populando a tabela de dados
                DataTable dataTableDaoDashListagemDePecasMesAtual = dalMySql.ExecutarConsulta(CommandType.StoredProcedure, "uspDaoDashListagemDePecasMesAtualConsultarTodos");
                //Percorrer o DataTable e tranformar em coleçao de DaoDashListagemDePecasMesAtual
                //Cada linha do DataTable e um DaoDashListagemDePecasMesAtual
                //Data=Dados e Row=Linha
                //For=para e Each=Cada
                foreach (DataRow linha in dataTableDaoDashListagemDePecasMesAtual.Rows)
                {
                    //Criar um Funcionario Vazio
                    //Colocar os dados da linha nele
                    //Adicionar ele na coleçao
                    DaoDashListagemDePecasMesAtual daoDashListagemDePecasMesAtual = new DaoDashListagemDePecasMesAtual();
                    daoDashListagemDePecasMesAtual.Produto = linha["produto"].ToString();
                    daoDashListagemDePecasMesAtual.Pecas = Convert.ToDecimal(linha["pecas"]);
                    daoDashListagemDePecasMesAtual.Metros = Convert.ToDecimal(linha["metros"]);
                    daoDashListagemDePecasMesAtual.Batidas = Convert.ToDecimal(linha["batidas"]);
                    daoDashListagemDePecasMesAtual.Pontos = Convert.ToDecimal(linha["pontos"]);

                    daoDashListagemDePecasMesAtualColecao.Add(daoDashListagemDePecasMesAtual);

                }

                return daoDashListagemDePecasMesAtualColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Nao foi Possivel consultar. Detalhes: " + ex.Message);
            }
        }

        #endregion



    }
}
