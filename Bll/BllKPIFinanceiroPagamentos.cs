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
    public class BllKPIFinanceiroPagamentos
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

        public DaoKPIFinanceiroPagamentosOntemColecao RetornaPagamentosOntem()
        {
            try
            {
                DaoKPIFinanceiroPagamentosOntemColecao daoKPIFinanceiroPagamentosOntemColecao = new DaoKPIFinanceiroPagamentosOntemColecao();
                dalSqlServer.LimparParametros();

                DataTable dataTableDaoKPIFinanceiroPagamentosOntemColecao = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspKPIFinanceiroPagamentosOntem");

                foreach (DataRow linha in dataTableDaoKPIFinanceiroPagamentosOntemColecao.Rows)
                {
                    DaoKPIFinanceiroPagamentosOntem daoKPIFinanceiroPagamentosOntem = new DaoKPIFinanceiroPagamentosOntem();
                    daoKPIFinanceiroPagamentosOntem.Qtd = Convert.ToInt32(linha["Qtd"]);
                    daoKPIFinanceiroPagamentosOntem.Valor = Convert.ToDecimal(linha["Valor"]);

                    daoKPIFinanceiroPagamentosOntemColecao.Add(daoKPIFinanceiroPagamentosOntem);
                }

                return daoKPIFinanceiroPagamentosOntemColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel consultar os Pagamentos de Ontem. Detalhes: " + ex.Message);
            }
        }

        public string CarregarPagamentosOntem(DaoKPIFinanceiroPagamentosOntemColecao daoKPIFinanceiroPagamentosOntemColecao)
        {
            try
            {
                string retorno = "ok";
                dalMySql.LimparParametros();
                dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspKPIFinanceiroPagamentosOntemDeletar");
                DataTable dataTableDaoKPIFinanceiroPagamentosOntemColecao = ConvertToDataTable(daoKPIFinanceiroPagamentosOntemColecao);
                foreach (DataRow linha in dataTableDaoKPIFinanceiroPagamentosOntemColecao.Rows)
                {
                    DaoKPIFinanceiroPagamentosOntem daoKPIFinanceiroPagamentosOntem = new DaoKPIFinanceiroPagamentosOntem();
                    daoKPIFinanceiroPagamentosOntem.Qtd = Convert.ToInt32(linha["Qtd"]);
                    daoKPIFinanceiroPagamentosOntem.Valor = Convert.ToDecimal(linha["Valor"]);
                    dalMySql.LimparParametros();
                    dalMySql.AdicionaParametros("@Qtd", daoKPIFinanceiroPagamentosOntem.Qtd);
                    dalMySql.AdicionaParametros("@Valor", daoKPIFinanceiroPagamentosOntem.Valor);

                    dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspKPIFinanceiroPagamentosOntemInserir");
                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel inserir dados no KPI Financeiro - Pagamentos Ontem . Detalhes: " + ex.Message);
            }


        }

        public DaoKPIFinanceiroPagamentosHojeColecao RetornaPagamentosHoje()
        {
            try
            {
                DaoKPIFinanceiroPagamentosHojeColecao daoKPIFinanceiroPagamentosHojeColecao = new DaoKPIFinanceiroPagamentosHojeColecao();
                dalSqlServer.LimparParametros();

                DataTable dataTableDaoKPIFinanceiroPagamentosHojeColecao = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspKPIFinanceiroPagamentosHoje");

                foreach (DataRow linha in dataTableDaoKPIFinanceiroPagamentosHojeColecao.Rows)
                {
                    DaoKPIFinanceiroPagamentosHoje daoKPIFinanceiroPagamentosHoje = new DaoKPIFinanceiroPagamentosHoje();
                    daoKPIFinanceiroPagamentosHoje.Qtd = Convert.ToInt32(linha["Qtd"]);
                    daoKPIFinanceiroPagamentosHoje.Valor = Convert.ToDecimal(linha["Valor"]);

                    daoKPIFinanceiroPagamentosHojeColecao.Add(daoKPIFinanceiroPagamentosHoje);
                }

                return daoKPIFinanceiroPagamentosHojeColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel consultar os Pagamentos de Hoje. Detalhes: " + ex.Message);
            }
        }

        public string CarregarPagamentosHoje(DaoKPIFinanceiroPagamentosHojeColecao daoKPIFinanceiroPagamentosHojeColecao)
        {
            try
            {
                string retorno = "ok";
                dalMySql.LimparParametros();
                dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspKPIFinanceiroPagamentosHojeDeletar");
                DataTable dataTableDaoKPIFinanceiroPagamentosHojeColecao = ConvertToDataTable(daoKPIFinanceiroPagamentosHojeColecao);
                foreach (DataRow linha in dataTableDaoKPIFinanceiroPagamentosHojeColecao.Rows)
                {
                    DaoKPIFinanceiroPagamentosHoje daoKPIFinanceiroPagamentosHoje = new DaoKPIFinanceiroPagamentosHoje();
                    daoKPIFinanceiroPagamentosHoje.Qtd = Convert.ToInt32(linha["Qtd"]);
                    daoKPIFinanceiroPagamentosHoje.Valor = Convert.ToDecimal(linha["Valor"]);
                    dalMySql.LimparParametros();
                    dalMySql.AdicionaParametros("@Qtd", daoKPIFinanceiroPagamentosHoje.Qtd);
                    dalMySql.AdicionaParametros("@Valor", daoKPIFinanceiroPagamentosHoje.Valor);

                    dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspKPIFinanceiroPagamentosHojeInserir");
                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel inserir dados no KPI Financeiro - Pagamentos Hoje . Detalhes: " + ex.Message);
            }


        }

        public DaoKPIFinanceiroPagamentosMesColecao RetornaPagamentosMes()
        {
            try
            {
                DaoKPIFinanceiroPagamentosMesColecao daoKPIFinanceiroPagamentosMesColecao = new DaoKPIFinanceiroPagamentosMesColecao();
                dalSqlServer.LimparParametros();

                DataTable dataTableDaoKPIFinanceiroPagamentosMesColecao = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspKPIFinanceiroPagamentosMes");

                foreach (DataRow linha in dataTableDaoKPIFinanceiroPagamentosMesColecao.Rows)
                {
                    DaoKPIFinanceiroPagamentosMes daoKPIFinanceiroPagamentosMes = new DaoKPIFinanceiroPagamentosMes();
                    daoKPIFinanceiroPagamentosMes.Qtd = Convert.ToInt32(linha["Qtd"]);
                    daoKPIFinanceiroPagamentosMes.Valor = Convert.ToDecimal(linha["Valor"]);

                    daoKPIFinanceiroPagamentosMesColecao.Add(daoKPIFinanceiroPagamentosMes);
                }

                return daoKPIFinanceiroPagamentosMesColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel consultar os pagamentos do mês. Detalhes: " + ex.Message);
            }
        }

        public string CarregarPagamentosMes(DaoKPIFinanceiroPagamentosMesColecao daoKPIFinanceiroPagamentosMesColecao)
        {
            try
            {
                string retorno = "ok";
                dalMySql.LimparParametros();
                dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspKPIFinanceiroPagamentosMesDeletar");
                DataTable dataTableDaoKPIFinanceiroPagamentosMesColecao = ConvertToDataTable(daoKPIFinanceiroPagamentosMesColecao);
                foreach (DataRow linha in dataTableDaoKPIFinanceiroPagamentosMesColecao.Rows)
                {
                    DaoKPIFinanceiroPagamentosMes daoKPIFinanceiroPagamentosMes = new DaoKPIFinanceiroPagamentosMes();
                    daoKPIFinanceiroPagamentosMes.Qtd = Convert.ToInt32(linha["Qtd"]);
                    daoKPIFinanceiroPagamentosMes.Valor = Convert.ToDecimal(linha["Valor"]);
                    dalMySql.LimparParametros();
                    dalMySql.AdicionaParametros("@Qtd", daoKPIFinanceiroPagamentosMes.Qtd);
                    dalMySql.AdicionaParametros("@Valor", daoKPIFinanceiroPagamentosMes.Valor);

                    dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspKPIFinanceiroPagamentosMesInserir");
                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel inserir dados no KPI Financeiro Pagamentos Mês. Detalhes: " + ex.Message);
            }


        }

        public DaoKPIFinanceiroPagamentosAnoColecao RetornaPagamentosAno()
        {
            try
            {
                DaoKPIFinanceiroPagamentosAnoColecao daoKPIFinanceiroPagamentosAnoColecao = new DaoKPIFinanceiroPagamentosAnoColecao();
                dalSqlServer.LimparParametros();

                DataTable dataTableDaoKPIFinanceiroPagamentosAnoColecao = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspKPIFinanceiroPagamentosAno");

                foreach (DataRow linha in dataTableDaoKPIFinanceiroPagamentosAnoColecao.Rows)
                {
                    DaoKPIFinanceiroPagamentosAno daoKPIFinanceiroPagamentosAno = new DaoKPIFinanceiroPagamentosAno();
                    daoKPIFinanceiroPagamentosAno.Qtd = Convert.ToInt32(linha["Qtd"]);
                    daoKPIFinanceiroPagamentosAno.Valor = Convert.ToDecimal(linha["Valor"]);

                    daoKPIFinanceiroPagamentosAnoColecao.Add(daoKPIFinanceiroPagamentosAno);
                }

                return daoKPIFinanceiroPagamentosAnoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel consultar os pagamentos do mês. Detalhes: " + ex.Message);
            }
        }

        public string CarregarPagamentosAno(DaoKPIFinanceiroPagamentosAnoColecao daoKPIFinanceiroPagamentosAnoColecao)
        {
            try
            {
                string retorno = "ok";
                dalMySql.LimparParametros();
                dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspKPIFinanceiroPagamentosAnoDeletar");
                DataTable dataTableDaoKPIFinanceiroPagamentosAnoColecao = ConvertToDataTable(daoKPIFinanceiroPagamentosAnoColecao);
                foreach (DataRow linha in dataTableDaoKPIFinanceiroPagamentosAnoColecao.Rows)
                {
                    DaoKPIFinanceiroPagamentosAno daoKPIFinanceiroPagamentosAno = new DaoKPIFinanceiroPagamentosAno();
                    daoKPIFinanceiroPagamentosAno.Qtd = Convert.ToInt32(linha["Qtd"]);
                    daoKPIFinanceiroPagamentosAno.Valor = Convert.ToDecimal(linha["Valor"]);
                    dalMySql.LimparParametros();
                    dalMySql.AdicionaParametros("@Qtd", daoKPIFinanceiroPagamentosAno.Qtd);
                    dalMySql.AdicionaParametros("@Valor", daoKPIFinanceiroPagamentosAno.Valor);

                    dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspKPIFinanceiroPagamentosAnoInserir");
                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel inserir dados no KPI Financeiro Pagamentos Mês. Detalhes: " + ex.Message);
            }


        }

        public DaoKPIFinanceiroPagamentosListagemTotalBaixasDiaMesAtualColecao RetornaPagamentosListagemTotalBaixasDiaMesAtual()
        {
            try
            {
                DaoKPIFinanceiroPagamentosListagemTotalBaixasDiaMesAtualColecao daoKPIFinanceiroPagamentosListagemTotalBaixasDiaMesAtualColecao = new DaoKPIFinanceiroPagamentosListagemTotalBaixasDiaMesAtualColecao();
                dalSqlServer.LimparParametros();

                DataTable dataTableDaoKPIFinanceiroPagamentosListagemTotalBaixasDiaMesAtualColecao = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspKPIFinanceiroPagamentosListagemTotalBaixasDiaMesAtual");

                foreach (DataRow linha in dataTableDaoKPIFinanceiroPagamentosListagemTotalBaixasDiaMesAtualColecao.Rows)
                {
                    DaoKPIFinanceiroPagamentosListagemTotalBaixasDiaMesAtual daoKPIFinanceiroPagamentosListagemTotalBaixasDiaMesAtual = new DaoKPIFinanceiroPagamentosListagemTotalBaixasDiaMesAtual();
                    daoKPIFinanceiroPagamentosListagemTotalBaixasDiaMesAtual.Qtd = Convert.ToInt32(linha["Qtd"]);
                    daoKPIFinanceiroPagamentosListagemTotalBaixasDiaMesAtual.Valor = Convert.ToDecimal(linha["Valor"]);
                    daoKPIFinanceiroPagamentosListagemTotalBaixasDiaMesAtual.Baixa = Convert.ToDateTime(linha["Baixa"]);

                    daoKPIFinanceiroPagamentosListagemTotalBaixasDiaMesAtualColecao.Add(daoKPIFinanceiroPagamentosListagemTotalBaixasDiaMesAtual);
                }

                return daoKPIFinanceiroPagamentosListagemTotalBaixasDiaMesAtualColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel consultar os pagamentos do mês. Detalhes: " + ex.Message);
            }
        }

        public string CarregarPagamentosListagemTotalBaixasDiaMesAtual(DaoKPIFinanceiroPagamentosListagemTotalBaixasDiaMesAtualColecao daoKPIFinanceiroPagamentosListagemTotalBaixasDiaMesAtualColecao)
        {
            try
            {
                string retorno = "ok";
                dalMySql.LimparParametros();
                dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspKPIFinanceiroPagamentosListagemTotalBaixasDiaMesAtualDeletar");
                DataTable dataTableDaoKPIFinanceiroPagamentosListagemTotalBaixasDiaMesAtualColecao = ConvertToDataTable(daoKPIFinanceiroPagamentosListagemTotalBaixasDiaMesAtualColecao);
                foreach (DataRow linha in dataTableDaoKPIFinanceiroPagamentosListagemTotalBaixasDiaMesAtualColecao.Rows)
                {
                    DaoKPIFinanceiroPagamentosListagemTotalBaixasDiaMesAtual daoKPIFinanceiroPagamentosListagemTotalBaixasDiaMesAtual = new DaoKPIFinanceiroPagamentosListagemTotalBaixasDiaMesAtual();
                    daoKPIFinanceiroPagamentosListagemTotalBaixasDiaMesAtual.Qtd = Convert.ToInt32(linha["Qtd"]);
                    daoKPIFinanceiroPagamentosListagemTotalBaixasDiaMesAtual.Valor = Convert.ToDecimal(linha["Valor"]);
                    daoKPIFinanceiroPagamentosListagemTotalBaixasDiaMesAtual.Baixa = Convert.ToDateTime(linha["Baixa"]);
                    dalMySql.LimparParametros();
                    dalMySql.AdicionaParametros("@Qtd", daoKPIFinanceiroPagamentosListagemTotalBaixasDiaMesAtual.Qtd);
                    dalMySql.AdicionaParametros("@Valor", daoKPIFinanceiroPagamentosListagemTotalBaixasDiaMesAtual.Valor);
                    dalMySql.AdicionaParametros("@Baixa", daoKPIFinanceiroPagamentosListagemTotalBaixasDiaMesAtual.Baixa);

                    dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspKPIFinanceiroPagamentosListagemTotalBaixasDiaMesAtualInserir");
                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel inserir dados no KPI Financeiro - Pagamentos -  Listagem Total de Baixas por dia do Mês Atual. Detalhes: " + ex.Message);
            }


        }

        #endregion
    }
}
