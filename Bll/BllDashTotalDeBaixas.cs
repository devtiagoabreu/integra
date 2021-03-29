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
    public class BllDashTotalDeBaixas
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

        public DaoDashTotalDeBaixasColecao TotalDeBaixas(DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                //Criar coleçao nova de Funcionarios (vazia)
                DaoDashTotalDeBaixasColecao daoDashTotalDeBaixasColecao = new DaoDashTotalDeBaixasColecao();
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@dataInicial", dataInicial);
                dalSqlServer.AdicionaParametros("@dataFinal", dataFinal);
                //Criando e populando a tabela de dados
                DataTable dataTableDaoDashTotalDeBaixas = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspDashTotalDeBaixas");
                //Percorrer o DataTable e tranformar em coleçao de DaoDashTotalDeBaixas
                //Cada linha do DataTable e um DaoDashTotalDeBaixas
                //Data=Dados e Row=Linha
                //For=para e Each=Cada
                foreach (DataRow linha in dataTableDaoDashTotalDeBaixas.Rows)
                {
                    //Criar um objeto Vazio
                    //Colocar os dados da linha nele
                    //Adicionar ele na coleçao
                    DaoDashTotalDeBaixas daoDashTotalDeBaixas = new DaoDashTotalDeBaixas();
                    daoDashTotalDeBaixas.TotalBaixasAdministrativo = Convert.ToDecimal(linha["TotalBaixasAdministrativo"]);
                    daoDashTotalDeBaixas.TotalBaixasTecelagem = Convert.ToDecimal(linha["TotalBaixasTecelagem"]);
                    daoDashTotalDeBaixas.TotalBaixasRama = Convert.ToDecimal(linha["TotalBaixasRama"]);
                    daoDashTotalDeBaixas.TotalBaixasTinturaria = Convert.ToDecimal(linha["TotalBaixasTinturaria"]);
                    daoDashTotalDeBaixas.TotalBaixasInvestimentos = Convert.ToDecimal(linha["TotalBaixasInvestimentos"]);
                    daoDashTotalDeBaixas.TotalBaixasFiacao = Convert.ToDecimal(linha["TotalBaixasFiacao"]);
                    daoDashTotalDeBaixas.TotalBaixasFretes = Convert.ToDecimal(linha["TotalBaixasFretes"]);
                    daoDashTotalDeBaixas.TotalBaixasImpostos = Convert.ToDecimal(linha["TotalBaixasImpostos"]);
                    daoDashTotalDeBaixas.TotalBaixasBeneficiamento = Convert.ToDecimal(linha["TotalBaixasBeneficiamento"]);
                    daoDashTotalDeBaixas.TotalBaixasRama2 = Convert.ToDecimal(linha["TotalBaixasRama2"]);
                    daoDashTotalDeBaixas.TotalBaixasMaqEstampar = Convert.ToDecimal(linha["TotalBaixasMaqEstampar"]);
                    daoDashTotalDeBaixas.TotalBaixasJiggerGrande = Convert.ToDecimal(linha["TotalBaixasJiggerGrande"]);
                    daoDashTotalDeBaixas.TotalBaixasAdmProducao = Convert.ToDecimal(linha["TotalBaixasAdmProducao"]);
                    daoDashTotalDeBaixas.TotalBaixasTurbo = Convert.ToDecimal(linha["TotalBaixasTurbo"]);
                    daoDashTotalDeBaixas.TotalBaixasEnroladeira = Convert.ToDecimal(linha["TotalBaixasEnroladeira"]);
                    daoDashTotalDeBaixas.TotalBaixasCalandra = Convert.ToDecimal(linha["TotalBaixasCalandra"]);
                    daoDashTotalDeBaixas.TotalBaixasSanforizadeira = Convert.ToDecimal(linha["TotalBaixasSanforizadeira"]);
                    daoDashTotalDeBaixas.TotalBaixasTearesDelmiroGouveia = Convert.ToDecimal(linha["TotalBaixasTearesDelmiroGouveia"]);
                    daoDashTotalDeBaixas.TotalBaixasEstamparia = Convert.ToDecimal(linha["TotalBaixasEstamparia"]);
                    daoDashTotalDeBaixas.TotalBaixasFabricaNova = Convert.ToDecimal(linha["TotalBaixasFabricaNova"]);
                    daoDashTotalDeBaixas.TotalBaixasCaldeira = Convert.ToDecimal(linha["TotalBaixasCaldeira"]);
                    
                    daoDashTotalDeBaixasColecao.Add(daoDashTotalDeBaixas);

                }

                return daoDashTotalDeBaixasColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Nao foi Possivel consultar. Detalhes: " + ex.Message);
            }
        }

        public string CarregarTotalDeBaixasEmDBPromodaDash(DaoDashTotalDeBaixasColecao daoDashTotalDeBaixasColecao)
        {
            try
            {
                string retorno = "ok";
                dalMySql.LimparParametros();
                dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDaoDashTotalDeBaixasDeletar");
                DataTable dataTabledaoDashTotalDeBaixas = ConvertToDataTable(daoDashTotalDeBaixasColecao);
                foreach (DataRow linha in dataTabledaoDashTotalDeBaixas.Rows)
                {
                    DaoDashTotalDeBaixas daoDashTotalDeBaixas = new DaoDashTotalDeBaixas();
                    daoDashTotalDeBaixas.TotalBaixasAdministrativo = Convert.ToDecimal(linha["TotalBaixasAdministrativo"]);
                    daoDashTotalDeBaixas.TotalBaixasTecelagem = Convert.ToDecimal(linha["TotalBaixasTecelagem"]);
                    daoDashTotalDeBaixas.TotalBaixasRama = Convert.ToDecimal(linha["TotalBaixasRama"]);
                    daoDashTotalDeBaixas.TotalBaixasTinturaria = Convert.ToDecimal(linha["TotalBaixasTinturaria"]);
                    daoDashTotalDeBaixas.TotalBaixasInvestimentos = Convert.ToDecimal(linha["TotalBaixasInvestimentos"]);
                    daoDashTotalDeBaixas.TotalBaixasFiacao = Convert.ToDecimal(linha["TotalBaixasFiacao"]);
                    daoDashTotalDeBaixas.TotalBaixasFretes = Convert.ToDecimal(linha["TotalBaixasFretes"]);
                    daoDashTotalDeBaixas.TotalBaixasImpostos = Convert.ToDecimal(linha["TotalBaixasImpostos"]);
                    daoDashTotalDeBaixas.TotalBaixasBeneficiamento = Convert.ToDecimal(linha["TotalBaixasBeneficiamento"]);
                    daoDashTotalDeBaixas.TotalBaixasRama2 = Convert.ToDecimal(linha["TotalBaixasRama2"]);
                    daoDashTotalDeBaixas.TotalBaixasMaqEstampar = Convert.ToDecimal(linha["TotalBaixasMaqEstampar"]);
                    daoDashTotalDeBaixas.TotalBaixasJiggerGrande = Convert.ToDecimal(linha["TotalBaixasJiggerGrande"]);
                    daoDashTotalDeBaixas.TotalBaixasAdmProducao = Convert.ToDecimal(linha["TotalBaixasAdmProducao"]);
                    daoDashTotalDeBaixas.TotalBaixasTurbo = Convert.ToDecimal(linha["TotalBaixasTurbo"]);
                    daoDashTotalDeBaixas.TotalBaixasEnroladeira = Convert.ToDecimal(linha["TotalBaixasEnroladeira"]);
                    daoDashTotalDeBaixas.TotalBaixasCalandra = Convert.ToDecimal(linha["TotalBaixasCalandra"]);
                    daoDashTotalDeBaixas.TotalBaixasSanforizadeira = Convert.ToDecimal(linha["TotalBaixasSanforizadeira"]);
                    daoDashTotalDeBaixas.TotalBaixasTearesDelmiroGouveia = Convert.ToDecimal(linha["TotalBaixasTearesDelmiroGouveia"]);
                    daoDashTotalDeBaixas.TotalBaixasEstamparia = Convert.ToDecimal(linha["TotalBaixasEstamparia"]);
                    daoDashTotalDeBaixas.TotalBaixasFabricaNova = Convert.ToDecimal(linha["TotalBaixasFabricaNova"]);
                    daoDashTotalDeBaixas.TotalBaixasCaldeira = Convert.ToDecimal(linha["TotalBaixasCaldeira"]);
                    dalMySql.LimparParametros();
                    dalMySql.AdicionaParametros("@TotalBaixasAdministrativo", daoDashTotalDeBaixas.TotalBaixasAdministrativo);
                    dalMySql.AdicionaParametros("@TotalBaixasTecelagem", daoDashTotalDeBaixas.TotalBaixasTecelagem);
                    dalMySql.AdicionaParametros("@TotalBaixasRama", daoDashTotalDeBaixas.TotalBaixasRama);
                    dalMySql.AdicionaParametros("@TotalBaixasTinturaria", daoDashTotalDeBaixas.TotalBaixasTinturaria);
                    dalMySql.AdicionaParametros("@TotalBaixasInvestimentos", daoDashTotalDeBaixas.TotalBaixasInvestimentos);
                    dalMySql.AdicionaParametros("@TotalBaixasFiacao", daoDashTotalDeBaixas.TotalBaixasFiacao);
                    dalMySql.AdicionaParametros("@TotalBaixasFretes", daoDashTotalDeBaixas.TotalBaixasFretes);
                    dalMySql.AdicionaParametros("@TotalBaixasImpostos", daoDashTotalDeBaixas.TotalBaixasImpostos);
                    dalMySql.AdicionaParametros("@TotalBaixasBeneficiamento", daoDashTotalDeBaixas.TotalBaixasBeneficiamento);
                    dalMySql.AdicionaParametros("@TotalBaixasRama2", daoDashTotalDeBaixas.TotalBaixasRama2);
                    dalMySql.AdicionaParametros("@TotalBaixasMaqEstampar", daoDashTotalDeBaixas.TotalBaixasMaqEstampar);
                    dalMySql.AdicionaParametros("@TotalBaixasJiggerGrande", daoDashTotalDeBaixas.TotalBaixasJiggerGrande);
                    dalMySql.AdicionaParametros("@TotalBaixasAdmProducao", daoDashTotalDeBaixas.TotalBaixasAdmProducao);
                    dalMySql.AdicionaParametros("@TotalBaixasTurbo", daoDashTotalDeBaixas.TotalBaixasTurbo);
                    dalMySql.AdicionaParametros("@TotalBaixasEnroladeira", daoDashTotalDeBaixas.TotalBaixasEnroladeira);
                    dalMySql.AdicionaParametros("@TotalBaixasCalandra", daoDashTotalDeBaixas.TotalBaixasCalandra);
                    dalMySql.AdicionaParametros("@TotalBaixasSanforizadeira", daoDashTotalDeBaixas.TotalBaixasSanforizadeira);
                    dalMySql.AdicionaParametros("@TotalBaixasTearesDelmiroGouveia", daoDashTotalDeBaixas.TotalBaixasTearesDelmiroGouveia);
                    dalMySql.AdicionaParametros("@TotalBaixasEstamparia", daoDashTotalDeBaixas.TotalBaixasEstamparia);
                    dalMySql.AdicionaParametros("@TotalBaixasFabricaNova", daoDashTotalDeBaixas.TotalBaixasFabricaNova);
                    dalMySql.AdicionaParametros("@TotalBaixasCaldeira", daoDashTotalDeBaixas.TotalBaixasCaldeira);



                    dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDaoDashTotalDeBaixasInserir");

                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel inserir dados no dash 'Total de Baixas'. Detalhes: " + ex.Message);
            }


        }

        public DaoDashTotalDeBaixasColecao ConsultarListagemDePecasMesAtualEmDBPromodaDash()
        {
            try
            {
                //Criar coleçao nova de Funcionarios (vazia)
                DaoDashTotalDeBaixasColecao daoDashTotalDeBaixasColecao = new DaoDashTotalDeBaixasColecao();
                dalMySql.LimparParametros();
                //dalSqlServer.AdicionaParametros("@FuncionarioRg", funcionarioRg);
                //Criando e populando a tabela de dados
                DataTable dataTableDaoDashTotalDeBaixas = dalMySql.ExecutarConsulta(CommandType.StoredProcedure, "uspDaoDashTotalDeBaixasConsultarTodos");
                //Percorrer o DataTable e tranformar em coleçao de DaoDashTotalDeBaixas
                //Cada linha do DataTable e um DaoDashTotalDeBaixas
                //Data=Dados e Row=Linha
                //For=para e Each=Cada
                foreach (DataRow linha in dataTableDaoDashTotalDeBaixas.Rows)
                {
                    //Criar um Objeto Vazio
                    //Colocar os dados da linha nele
                    //Adicionar ele na coleçao
                    DaoDashTotalDeBaixas daoDashTotalDeBaixas = new DaoDashTotalDeBaixas();
                    daoDashTotalDeBaixas.Id = Convert.ToInt32(linha["Id"]);
                    daoDashTotalDeBaixas.TotalBaixasAdministrativo = Convert.ToDecimal(linha["TotalBaixasAdministrativo"]);
                    daoDashTotalDeBaixas.TotalBaixasTecelagem = Convert.ToDecimal(linha["TotalBaixasTecelagem"]);
                    daoDashTotalDeBaixas.TotalBaixasRama = Convert.ToDecimal(linha["TotalBaixasRama"]);
                    daoDashTotalDeBaixas.TotalBaixasTinturaria = Convert.ToDecimal(linha["TotalBaixasTinturaria"]);
                    daoDashTotalDeBaixas.TotalBaixasInvestimentos = Convert.ToDecimal(linha["TotalBaixasInvestimentos"]);
                    daoDashTotalDeBaixas.TotalBaixasFiacao = Convert.ToDecimal(linha["TotalBaixasFiacao"]);
                    daoDashTotalDeBaixas.TotalBaixasFretes = Convert.ToDecimal(linha["TotalBaixasFretes"]);
                    daoDashTotalDeBaixas.TotalBaixasImpostos = Convert.ToDecimal(linha["TotalBaixasImpostos"]);
                    daoDashTotalDeBaixas.TotalBaixasBeneficiamento = Convert.ToDecimal(linha["TotalBaixasBeneficiamento"]);
                    daoDashTotalDeBaixas.TotalBaixasRama2 = Convert.ToDecimal(linha["TotalBaixasRama2"]);
                    daoDashTotalDeBaixas.TotalBaixasMaqEstampar = Convert.ToDecimal(linha["TotalBaixasMaqEstampar"]);
                    daoDashTotalDeBaixas.TotalBaixasJiggerGrande = Convert.ToDecimal(linha["TotalBaixasJiggerGrande"]);
                    daoDashTotalDeBaixas.TotalBaixasAdmProducao = Convert.ToDecimal(linha["TotalBaixasAdmProducao"]);
                    daoDashTotalDeBaixas.TotalBaixasTurbo = Convert.ToDecimal(linha["TotalBaixasTurbo"]);
                    daoDashTotalDeBaixas.TotalBaixasEnroladeira = Convert.ToDecimal(linha["TotalBaixasEnroladeira"]);
                    daoDashTotalDeBaixas.TotalBaixasCalandra = Convert.ToDecimal(linha["TotalBaixasCalandra"]);
                    daoDashTotalDeBaixas.TotalBaixasSanforizadeira = Convert.ToDecimal(linha["TotalBaixasSanforizadeira"]);
                    daoDashTotalDeBaixas.TotalBaixasTearesDelmiroGouveia = Convert.ToDecimal(linha["TotalBaixasTearesDelmiroGouveia"]);
                    daoDashTotalDeBaixas.TotalBaixasEstamparia = Convert.ToDecimal(linha["TotalBaixasEstamparia"]);
                    daoDashTotalDeBaixas.TotalBaixasFabricaNova = Convert.ToDecimal(linha["TotalBaixasFabricaNova"]);
                    daoDashTotalDeBaixas.TotalBaixasCaldeira = Convert.ToDecimal(linha["TotalBaixasCaldeira"]);


                    daoDashTotalDeBaixasColecao.Add(daoDashTotalDeBaixas);

                }

                return daoDashTotalDeBaixasColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Nao foi Possivel consultar. Detalhes: " + ex.Message);
            }
        }

        #endregion
    }
}
