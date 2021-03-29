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
    public class BllKPIFinanceiroFaturamentoHoje
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

        public DaoKPIFinanceiroFaturamentoHojeNotasEmitidasColecao RetornaNotasEmitidas()
        {
            try
            {
                DaoKPIFinanceiroFaturamentoHojeNotasEmitidasColecao daoKPIFinanceiroFaturamentoHojeNotasEmitidasColecao = new DaoKPIFinanceiroFaturamentoHojeNotasEmitidasColecao();
                dalSqlServer.LimparParametros();
               
                DataTable dataTableDaoKPIFinanceiroFaturamentoHojeNotasEmitidasColecao = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspKPIFinanceiroFaturamentoHojeNotasEmitidas");

                foreach (DataRow linha in dataTableDaoKPIFinanceiroFaturamentoHojeNotasEmitidasColecao.Rows)
                {
                    DaoKPIFinanceiroFaturamentoHojeNotasEmitidas daoKPIFinanceiroFaturamentoHojeNotasEmitidas = new DaoKPIFinanceiroFaturamentoHojeNotasEmitidas();
                    daoKPIFinanceiroFaturamentoHojeNotasEmitidas.Qtd = Convert.ToInt32(linha["Qtd"]);
                    daoKPIFinanceiroFaturamentoHojeNotasEmitidas.Valor = Convert.ToDecimal(linha["Valor"]);
                    
                    daoKPIFinanceiroFaturamentoHojeNotasEmitidasColecao.Add(daoKPIFinanceiroFaturamentoHojeNotasEmitidas);
                }

                return daoKPIFinanceiroFaturamentoHojeNotasEmitidasColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel consultar. Detalhes: " + ex.Message);
            }
        }

        public string CarregarNotasEmitidas(DaoKPIFinanceiroFaturamentoHojeNotasEmitidasColecao daoKPIFinanceiroFaturamentoHojeNotasEmitidasColecao)
        {
            try
            {
                string retorno = "ok";
                dalMySql.LimparParametros();
                dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspKPIFinanceiroFaturamentoHojeNotasEmitidasDeletar");
                DataTable dataTableDaoKPIFinanceiroFaturamentoHojeNotasEmitidasColecao = ConvertToDataTable(daoKPIFinanceiroFaturamentoHojeNotasEmitidasColecao);
                foreach (DataRow linha in dataTableDaoKPIFinanceiroFaturamentoHojeNotasEmitidasColecao.Rows)
                {
                    DaoKPIFinanceiroFaturamentoHojeNotasEmitidas daoKPIFinanceiroFaturamentoHojeNotasEmitidas = new DaoKPIFinanceiroFaturamentoHojeNotasEmitidas();
                    daoKPIFinanceiroFaturamentoHojeNotasEmitidas.Qtd = Convert.ToInt32(linha["Qtd"]);
                    daoKPIFinanceiroFaturamentoHojeNotasEmitidas.Valor = Convert.ToDecimal(linha["Valor"]);
                    dalMySql.LimparParametros();
                    dalMySql.AdicionaParametros("@Qtd", daoKPIFinanceiroFaturamentoHojeNotasEmitidas.Qtd);
                    dalMySql.AdicionaParametros("@Valor", daoKPIFinanceiroFaturamentoHojeNotasEmitidas.Valor);
                    
                    dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspKPIFinanceiroFaturamentoHojeNotasEmitidasInserir");
                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel inserir dados no KPI Financeiro Faturamento Hoje - Notas Emitidas. Detalhes: " + ex.Message);
            }


        }

        public DaoKPIFinanceiroFaturamentoHojeDuplicatasEmitidasColecao RetornaDuplicatasEmitidas()
        {
            try
            {
                DaoKPIFinanceiroFaturamentoHojeDuplicatasEmitidasColecao daoKPIFinanceiroFaturamentoHojeDuplicatasEmitidasColecao = new DaoKPIFinanceiroFaturamentoHojeDuplicatasEmitidasColecao();
                dalSqlServer.LimparParametros();

                DataTable dataTableDaoKPIFinanceiroFaturamentoHojeDuplicatasEmitidasColecao = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspKPIFinanceiroFaturamentoHojeDuplicatasEmitidas");

                foreach (DataRow linha in dataTableDaoKPIFinanceiroFaturamentoHojeDuplicatasEmitidasColecao.Rows)
                {
                    DaoKPIFinanceiroFaturamentoHojeDuplicatasEmitidas daoKPIFinanceiroFaturamentoHojeDuplicatasEmitidas = new DaoKPIFinanceiroFaturamentoHojeDuplicatasEmitidas();
                    daoKPIFinanceiroFaturamentoHojeDuplicatasEmitidas.Qtd = Convert.ToInt32(linha["Qtd"]);
                    daoKPIFinanceiroFaturamentoHojeDuplicatasEmitidas.Valor = Convert.ToDecimal(linha["Valor"]);
                    
                    daoKPIFinanceiroFaturamentoHojeDuplicatasEmitidasColecao.Add(daoKPIFinanceiroFaturamentoHojeDuplicatasEmitidas);

                }
                return daoKPIFinanceiroFaturamentoHojeDuplicatasEmitidasColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel consultar. Detalhes: " + ex.Message);
            }
        }

        public string CarregarDuplicatasEmitidas(DaoKPIFinanceiroFaturamentoHojeDuplicatasEmitidasColecao daoKPIFinanceiroFaturamentoHojeDuplicatasEmitidasColecao)
        {
            try
            {
                string retorno = "ok";
                dalMySql.LimparParametros();
                dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspKPIFinanceiroFaturamentoHojeDuplicatasEmitidasDeletar");
                DataTable dataTableDaoKPIFinanceiroFaturamentoHojeDuplicatasEmitidasColecao = ConvertToDataTable(daoKPIFinanceiroFaturamentoHojeDuplicatasEmitidasColecao);
                foreach (DataRow linha in dataTableDaoKPIFinanceiroFaturamentoHojeDuplicatasEmitidasColecao.Rows)
                {
                    DaoKPIFinanceiroFaturamentoHojeDuplicatasEmitidas daoKPIFinanceiroFaturamentoHojeDuplicatasEmitidas = new DaoKPIFinanceiroFaturamentoHojeDuplicatasEmitidas();
                    daoKPIFinanceiroFaturamentoHojeDuplicatasEmitidas.Qtd = Convert.ToInt32(linha["Qtd"]);
                    daoKPIFinanceiroFaturamentoHojeDuplicatasEmitidas.Valor = Convert.ToDecimal(linha["Valor"]);
                    dalMySql.LimparParametros();
                    dalMySql.AdicionaParametros("@Qtd", daoKPIFinanceiroFaturamentoHojeDuplicatasEmitidas.Qtd);
                    dalMySql.AdicionaParametros("@Valor", daoKPIFinanceiroFaturamentoHojeDuplicatasEmitidas.Valor);
                    
                    dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspKPIFinanceiroFaturamentoHojeDuplicatasEmitidasInserir");

                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel inserir dados no KPI Financeiro - Faturamento Hoje - Duplicatas Emitidas. Detalhes: " + ex.Message);
            }


        }

        public DaoKPIFinanceiroFaturamentoHojeEntradasAVistaColecao RetornaEntradasAVista()
        {
            try
            {
                DaoKPIFinanceiroFaturamentoHojeEntradasAVistaColecao daoKPIFinanceiroFaturamentoHojeEntradasAVistaColecao = new DaoKPIFinanceiroFaturamentoHojeEntradasAVistaColecao();
                dalSqlServer.LimparParametros();

                DataTable dataTableDaoKPIFinanceiroFaturamentoHojeEntradasAVistaColecao = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspKPIFinanceiroFaturamentoHojeEntradasAVista");

                foreach (DataRow linha in dataTableDaoKPIFinanceiroFaturamentoHojeEntradasAVistaColecao.Rows)
                {
                    DaoKPIFinanceiroFaturamentoHojeEntradasAVista daoKPIFinanceiroFaturamentoHojeEntradasAVista = new DaoKPIFinanceiroFaturamentoHojeEntradasAVista();
                    daoKPIFinanceiroFaturamentoHojeEntradasAVista.Qtd = Convert.ToInt32(linha["Qtd"]);
                    daoKPIFinanceiroFaturamentoHojeEntradasAVista.Valor = Convert.ToDecimal(linha["Valor"]);
                    
                    daoKPIFinanceiroFaturamentoHojeEntradasAVistaColecao.Add(daoKPIFinanceiroFaturamentoHojeEntradasAVista);
                }
                return daoKPIFinanceiroFaturamentoHojeEntradasAVistaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel consultar. Detalhes: " + ex.Message);
            }
        }

        public string CarregarEntradasAVista(DaoKPIFinanceiroFaturamentoHojeEntradasAVistaColecao daoKPIFinanceiroFaturamentoHojeEntradasAVistaColecao)
        {
            try
            {
                string retorno = "ok";
                dalMySql.LimparParametros();
                dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspKPIFinanceiroFaturamentoHojeEntradasAVistaDeletar");
                DataTable dataTableDaoKPIFinanceiroFaturamentoHojeEntradasAVistaColecao = ConvertToDataTable(daoKPIFinanceiroFaturamentoHojeEntradasAVistaColecao);
                foreach (DataRow linha in dataTableDaoKPIFinanceiroFaturamentoHojeEntradasAVistaColecao.Rows)
                {
                    DaoKPIFinanceiroFaturamentoHojeEntradasAVista daoKPIFinanceiroFaturamentoHojeEntradasAVista = new DaoKPIFinanceiroFaturamentoHojeEntradasAVista();
                    daoKPIFinanceiroFaturamentoHojeEntradasAVista.Qtd = Convert.ToInt32(linha["Qtd"]);
                    daoKPIFinanceiroFaturamentoHojeEntradasAVista.Valor = Convert.ToDecimal(linha["Valor"]);
                    dalMySql.LimparParametros();
                    dalMySql.AdicionaParametros("@Qtd", daoKPIFinanceiroFaturamentoHojeEntradasAVista.Qtd);
                    dalMySql.AdicionaParametros("@Valor", daoKPIFinanceiroFaturamentoHojeEntradasAVista.Valor);

                    dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspKPIFinanceiroFaturamentoHojeEntradasAVistaInserir");

                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel inserir dados no KPI Financeiro Faturamento Hoje - Entradas à Vista. Detalhes: " + ex.Message);
            }


        }
    }

}
