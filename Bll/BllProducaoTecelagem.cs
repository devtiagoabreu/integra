using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dal;
using Dao;

namespace Bll
{
    public class BllProducaoTecelagem
    {
        #region ATRIBUTOS | OBJETOS

        DalSqlServer dalSqlServer = new DalSqlServer();
        DalMySql dalMySql = new DalMySql();

        #endregion

        #region MÉTODOS

        public string Insert(DaoProducaoTecelagem daoProducaoTecelagem)
        {
            try
            {
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@OperadorNumero", daoProducaoTecelagem.OperadorNumero);
                dalSqlServer.AdicionaParametros("@TearNumero", daoProducaoTecelagem.TearNumero);
                dalSqlServer.AdicionaParametros("@OrdemNumero", daoProducaoTecelagem.OrdemNumero);
                dalSqlServer.AdicionaParametros("@RoloUrdume", daoProducaoTecelagem.RoloUrdume);
                dalSqlServer.AdicionaParametros("@RoloUrdume2", daoProducaoTecelagem.RoloUrdume2);
                dalSqlServer.AdicionaParametros("@Situacao", daoProducaoTecelagem.Situacao);
                dalSqlServer.AdicionaParametros("@MotivoSituacao", daoProducaoTecelagem.MotivoSituacao);
                dalSqlServer.AdicionaParametros("@Obs", daoProducaoTecelagem.Obs);
                if (daoProducaoTecelagem.Rpm.Equals(""))
                    dalSqlServer.AdicionaParametros("@Rpm", 0.00);
                else
                    dalSqlServer.AdicionaParametros("@Rpm", daoProducaoTecelagem.Rpm);
                if (daoProducaoTecelagem.EficienciaManha.Equals(""))
                    dalSqlServer.AdicionaParametros("@EficienciaManha", 0.00);
                else
                    dalSqlServer.AdicionaParametros("@EficienciaManha", daoProducaoTecelagem.EficienciaManha);
                if (daoProducaoTecelagem.EficienciaTarde.Equals(""))
                    dalSqlServer.AdicionaParametros("@EficienciaTarde", 0.00);
                else
                    dalSqlServer.AdicionaParametros("@EficienciaTarde", daoProducaoTecelagem.EficienciaTarde);
                if (daoProducaoTecelagem.EficienciaNoite.Equals(""))
                    dalSqlServer.AdicionaParametros("@EficienciaNoite", 0.00);
                else
                    dalSqlServer.AdicionaParametros("@EficienciaNoite", daoProducaoTecelagem.EficienciaNoite);
                if (daoProducaoTecelagem.Eficiencia24hs.Equals(""))
                    dalSqlServer.AdicionaParametros("@Eficiencia24hs", 0.00);
                else
                    dalSqlServer.AdicionaParametros("@Eficiencia24hs", daoProducaoTecelagem.Eficiencia24hs);
                if (daoProducaoTecelagem.MetragemManha.Equals(""))
                    dalSqlServer.AdicionaParametros("@MetragemManha", 0.000);
                else
                    dalSqlServer.AdicionaParametros("@MetragemManha", daoProducaoTecelagem.MetragemManha);
                if (daoProducaoTecelagem.MetragemTarde.Equals(""))
                    dalSqlServer.AdicionaParametros("@MetragemTarde", 0.000);
                else
                    dalSqlServer.AdicionaParametros("@MetragemTarde", daoProducaoTecelagem.MetragemTarde);
                if (daoProducaoTecelagem.MetragemNoite.Equals(""))
                    dalSqlServer.AdicionaParametros("@MetragemNoite", 0.000);
                else
                    dalSqlServer.AdicionaParametros("@MetragemNoite", daoProducaoTecelagem.MetragemNoite);
                if (daoProducaoTecelagem.Metragem24hs.Equals(""))
                    dalSqlServer.AdicionaParametros("@Metragem24hs", 0.000);
                else
                    dalSqlServer.AdicionaParametros("@Metragem24hs", daoProducaoTecelagem.Metragem24hs);
                if (daoProducaoTecelagem.MetragemAcumulada.Equals(""))
                    dalSqlServer.AdicionaParametros("@MetragemAcumulada", 0.000);
                else
                    dalSqlServer.AdicionaParametros("@MetragemAcumulada", daoProducaoTecelagem.MetragemAcumulada);
                if (daoProducaoTecelagem.Corte.Equals(""))
                    dalSqlServer.AdicionaParametros("@Corte", 0.000);
                else
                    dalSqlServer.AdicionaParametros("@Corte", daoProducaoTecelagem.Corte);

                dalSqlServer.AdicionaParametros("@DataProducao", daoProducaoTecelagem.DataProducao);
                dalSqlServer.AdicionaParametros("@Folguista", daoProducaoTecelagem.Folguista);

                string id = dalSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspProducaoTecelagemInsert").ToString();

                return id;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }

        }

        public string Update(DaoProducaoTecelagem daoProducaoTecelagem)
        {
            try
            {
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@Id", daoProducaoTecelagem.Id);
                dalSqlServer.AdicionaParametros("@OperadorNumero", daoProducaoTecelagem.OperadorNumero);
                dalSqlServer.AdicionaParametros("@TearNumero", daoProducaoTecelagem.TearNumero);
                dalSqlServer.AdicionaParametros("@OrdemNumero", daoProducaoTecelagem.OrdemNumero);
                dalSqlServer.AdicionaParametros("@RoloUrdume", daoProducaoTecelagem.RoloUrdume);
                dalSqlServer.AdicionaParametros("@Situacao", daoProducaoTecelagem.Situacao);
                dalSqlServer.AdicionaParametros("@MotivoSituacao", daoProducaoTecelagem.MotivoSituacao);
                dalSqlServer.AdicionaParametros("@Obs", daoProducaoTecelagem.Obs);
                dalSqlServer.AdicionaParametros("@Rpm", daoProducaoTecelagem.Rpm);
                dalSqlServer.AdicionaParametros("@EficienciaManha", daoProducaoTecelagem.EficienciaManha);
                dalSqlServer.AdicionaParametros("@EficienciaTarde", daoProducaoTecelagem.EficienciaTarde);
                dalSqlServer.AdicionaParametros("@EficienciaNoite", daoProducaoTecelagem.EficienciaNoite);
                dalSqlServer.AdicionaParametros("@Eficiencia24hs", daoProducaoTecelagem.Eficiencia24hs);
                dalSqlServer.AdicionaParametros("@MetragemManha", daoProducaoTecelagem.MetragemManha);
                dalSqlServer.AdicionaParametros("@MetragemTarde", daoProducaoTecelagem.MetragemTarde);
                dalSqlServer.AdicionaParametros("@MetragemNoite", daoProducaoTecelagem.MetragemNoite);
                dalSqlServer.AdicionaParametros("@Metragem24hs", daoProducaoTecelagem.Metragem24hs);
                dalSqlServer.AdicionaParametros("@MetragemAcumulada", daoProducaoTecelagem.MetragemAcumulada);
                dalSqlServer.AdicionaParametros("@Corte", daoProducaoTecelagem.Corte);
                dalSqlServer.AdicionaParametros("@DataProducao", daoProducaoTecelagem.DataProducao);
                dalSqlServer.AdicionaParametros("@Ativo", daoProducaoTecelagem.Ativo);

                string id = dalSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspProducaoTecelagemUpdate").ToString();

                return id;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }

        }

        public string Desativar(DaoProducaoTecelagem daoProducaoTecelagem)
        {
            try
            {
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@Id", daoProducaoTecelagem.Id);
                string id = dalSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspProducaoTecelagemDesativar").ToString();

                return id;

            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Delete(DaoProducaoTecelagem daoProducaoTecelagem)
        {
            try
            {
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@Id", daoProducaoTecelagem.Id);
                string id = dalSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspProducaoTecelagemDesativar").ToString();

                return id;

            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public DaoProducaoTecelagemColecao Search(string tipo, string parametro, DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                DaoProducaoTecelagemColecao daoProducaoTecelagemColecao = new DaoProducaoTecelagemColecao();
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@tipo", tipo);
                dalSqlServer.AdicionaParametros("@parametro", parametro);
                dalSqlServer.AdicionaParametros("@dataInicio", dataInicio);
                dalSqlServer.AdicionaParametros("@dataFim", dataFim);

                DataTable dataTableProducaoTecelagem = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspProducaoTecelagemSearch");
                
                foreach (DataRow linha in dataTableProducaoTecelagem.Rows)
                {
                    DaoProducaoTecelagem daoProducaoTecelagem = new DaoProducaoTecelagem();
                    daoProducaoTecelagem.Id = Convert.ToInt32(linha["Id"]);
                    daoProducaoTecelagem.OperadorNumero = linha["Operadornumero"].ToString();
                    daoProducaoTecelagem.TearNumero = linha["TearNumero"].ToString();
                    daoProducaoTecelagem.OrdemNumero = linha["OrdemNumero"].ToString();
                    daoProducaoTecelagem.RoloUrdume = linha["RoloUrdume"].ToString();
                    daoProducaoTecelagem.RoloUrdume2 = linha["RoloUrdume2"].ToString();
                    daoProducaoTecelagem.Situacao = Convert.ToInt32(linha["Situacao"]);
                    daoProducaoTecelagem.MotivoSituacao = linha["MotivoSituacao"].ToString();
                    daoProducaoTecelagem.Obs = linha["Obs"].ToString();
                    daoProducaoTecelagem.Rpm = Convert.ToDecimal(linha["Rpm"]);
                    daoProducaoTecelagem.EficienciaManha = Convert.ToDecimal(linha["EficienciaManha"]);
                    daoProducaoTecelagem.EficienciaTarde = Convert.ToDecimal(linha["EficienciaTarde"]);
                    daoProducaoTecelagem.EficienciaNoite = Convert.ToDecimal(linha["EficienciaNoite"]);
                    daoProducaoTecelagem.Eficiencia24hs = Convert.ToDecimal(linha["Eficiencia24hs"]);
                    daoProducaoTecelagem.MetragemManha = Convert.ToDecimal(linha["MetragemManha"]);
                    daoProducaoTecelagem.MetragemTarde = Convert.ToDecimal(linha["MetragemTarde"]);
                    daoProducaoTecelagem.MetragemNoite = Convert.ToDecimal(linha["MetragemNoite"]);
                    daoProducaoTecelagem.Metragem24hs = Convert.ToDecimal(linha["Metragem24hs"]);
                    daoProducaoTecelagem.MetragemAcumulada = Convert.ToDecimal(linha["MetragemAcumulada"]);
                    daoProducaoTecelagem.Corte = Convert.ToDecimal(linha["Corte"]);
                    daoProducaoTecelagem.DataProducao = Convert.ToDateTime(linha["DataProducao"]);
                    daoProducaoTecelagem.Ativo= Convert.ToInt32(linha["Ativo"]);
                    daoProducaoTecelagem.Folguista = linha["Folguista"].ToString();

                    daoProducaoTecelagemColecao.Add(daoProducaoTecelagem);

                }

                return daoProducaoTecelagemColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel consultar. Detalhes: " + ex.Message);
            }
        }

        public DaoProducaoTecelagemColecao RetornarProducaoTecelagemDataCadastro(DateTime dataProducao)
        {
            try
            {
                DaoProducaoTecelagemColecao daoProducaoTecelagemColecao = new DaoProducaoTecelagemColecao();
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@dataProducao", dataProducao);

                DataTable dataTableProducaoTecelagem = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspRetornarProducaoTecelagemPorDataProducao");

                foreach (DataRow linha in dataTableProducaoTecelagem.Rows)
                {
                    DaoProducaoTecelagem daoProducaoTecelagem = new DaoProducaoTecelagem();
                    daoProducaoTecelagem.Id = Convert.ToInt32(linha["Id"]);
                    daoProducaoTecelagem.OperadorNumero = linha["Operadornumero"].ToString();
                    daoProducaoTecelagem.TearNumero = linha["TearNumero"].ToString();
                    daoProducaoTecelagem.OrdemNumero = linha["OrdemNumero"].ToString();
                    daoProducaoTecelagem.RoloUrdume = linha["RoloUrdume"].ToString();
                    daoProducaoTecelagem.RoloUrdume2 = linha["RoloUrdume2"].ToString();
                    daoProducaoTecelagem.Situacao = Convert.ToInt32(linha["Situacao"]);
                    daoProducaoTecelagem.MotivoSituacao = linha["MotivoSituacao"].ToString();
                    daoProducaoTecelagem.Obs = linha["Obs"].ToString();
                    daoProducaoTecelagem.Rpm = Convert.ToDecimal(linha["Rpm"]);
                    daoProducaoTecelagem.EficienciaManha = Convert.ToDecimal(linha["EficienciaManha"]);
                    daoProducaoTecelagem.EficienciaTarde = Convert.ToDecimal(linha["EficienciaTarde"]);
                    daoProducaoTecelagem.EficienciaNoite = Convert.ToDecimal(linha["EficienciaNoite"]);
                    daoProducaoTecelagem.Eficiencia24hs = Convert.ToDecimal(linha["Eficiencia24hs"]);
                    daoProducaoTecelagem.MetragemManha = Convert.ToDecimal(linha["MetragemManha"]);
                    daoProducaoTecelagem.MetragemTarde = Convert.ToDecimal(linha["MetragemTarde"]);
                    daoProducaoTecelagem.MetragemNoite = Convert.ToDecimal(linha["MetragemNoite"]);
                    daoProducaoTecelagem.Metragem24hs = Convert.ToDecimal(linha["Metragem24hs"]);
                    daoProducaoTecelagem.MetragemAcumulada = Convert.ToDecimal(linha["MetragemAcumulada"]);
                    daoProducaoTecelagem.Corte = Convert.ToDecimal(linha["Corte"]);
                    daoProducaoTecelagem.DataProducao = Convert.ToDateTime(linha["DataProducao"]);
                    daoProducaoTecelagem.Ativo = Convert.ToInt32(linha["Ativo"]);
                    daoProducaoTecelagem.Folguista = linha["Folguista"].ToString();

                    daoProducaoTecelagemColecao.Add(daoProducaoTecelagem);

                }

                return daoProducaoTecelagemColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel consultar. Detalhes: " + ex.Message);
            }
        }

        public DaoProducaoTecelagem RetornaMetragemAcumuladaDoTear(string tearNumero, DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                DaoProducaoTecelagem daoProducaoTecelagem = new DaoProducaoTecelagem();
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@tearNumero", tearNumero);
                dalSqlServer.AdicionaParametros("@dataInicio", dataInicio);
                dalSqlServer.AdicionaParametros("@dataFim", dataFim);

                DataTable dataTableProducaoTecelagem = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspRetornaMetragemAcumuladaDoTear");

                foreach (DataRow linha in dataTableProducaoTecelagem.Rows)
                {
                    daoProducaoTecelagem.MetragemManha = Convert.ToDecimal(linha["metragemLancadaTotalManha"]);
                    daoProducaoTecelagem.MetragemTarde = Convert.ToDecimal(linha["metragemLancadaTotalTarde"]);
                    daoProducaoTecelagem.MetragemNoite = Convert.ToDecimal(linha["metragemLancadaTotalNoite"]);
                    daoProducaoTecelagem.MetragemLancadaTotalTurnos = Convert.ToDecimal(linha["metragemLancadaTotalTurnos"]);
                }

                return daoProducaoTecelagem;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel retornar Metragem Acumulada do Tear. Detalhes: " + ex.Message);
            }
        }

        public DaoProducaoTecelagemColecao RetornaCortesMetragens(DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                DaoProducaoTecelagemColecao daoProducaoTecelagemColecao = new DaoProducaoTecelagemColecao();
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@dataInicio", dataInicio);
                dalSqlServer.AdicionaParametros("@dataFim", dataFim);

                DataTable dataTableProducaoTecelagem = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspRetornaCortesMetragens");

                foreach (DataRow linha in dataTableProducaoTecelagem.Rows)
                {
                    DaoProducaoTecelagem daoProducaoTecelagem = new DaoProducaoTecelagem();
                    daoProducaoTecelagem.TearNumero = linha["TearNumero"].ToString();
                    daoProducaoTecelagem.OrdemNumero = linha["OrdemNumero"].ToString();
                    daoProducaoTecelagem.Corte = Convert.ToDecimal(linha["Corte"]);
                    daoProducaoTecelagem.MetragemManha = Convert.ToDecimal(linha["MetragemManha"]);
                    daoProducaoTecelagem.MetragemTarde = Convert.ToDecimal(linha["MetragemTarde"]);
                    daoProducaoTecelagem.MetragemNoite = Convert.ToDecimal(linha["MetragemNoite"]);
                    daoProducaoTecelagem.MetragemLancadaTotalTurnos = Convert.ToDecimal(linha["metragemLancadaTotalTurnos"]);

                    daoProducaoTecelagemColecao.Add(daoProducaoTecelagem);
                }

                return daoProducaoTecelagemColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel retornar dados. Detalhes: " + ex.Message);
            }
        }

        #endregion
    }
}

