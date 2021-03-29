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
    public class BllKPIFinanceiroRecebimentos
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

        public DaoKPIFinanceiroRecebimentosOntemColecao RetornaRecebimentosOntem()
        {
            try
            {
                DaoKPIFinanceiroRecebimentosOntemColecao daoKPIFinanceiroRecebimentosOntemColecao = new DaoKPIFinanceiroRecebimentosOntemColecao();
                dalSqlServer.LimparParametros();

                DataTable dataTableDaoKPIFinanceiroRecebimentosOntemColecao = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspKPIFinanceiroRecebimentosOntem");

                foreach (DataRow linha in dataTableDaoKPIFinanceiroRecebimentosOntemColecao.Rows)
                {
                    DaoKPIFinanceiroRecebimentosOntem daoKPIFinanceiroRecebimentosOntem = new DaoKPIFinanceiroRecebimentosOntem();
                    daoKPIFinanceiroRecebimentosOntem.Qtd = Convert.ToInt32(linha["Qtd"]);
                    daoKPIFinanceiroRecebimentosOntem.Valor = Convert.ToDecimal(linha["Valor"]);

                    daoKPIFinanceiroRecebimentosOntemColecao.Add(daoKPIFinanceiroRecebimentosOntem);
                }

                return daoKPIFinanceiroRecebimentosOntemColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel consultar os Recebimentos de Ontem. Detalhes: " + ex.Message);
            }
        }

        public string CarregarRecebimentosOntem(DaoKPIFinanceiroRecebimentosOntemColecao daoKPIFinanceiroRecebimentosOntemColecao)
        {
            try
            {
                string retorno = "ok";
                dalMySql.LimparParametros();
                dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspKPIFinanceiroRecebimentosOntemDeletar");
                DataTable dataTableDaoKPIFinanceiroRecebimentosOntemColecao = ConvertToDataTable(daoKPIFinanceiroRecebimentosOntemColecao);
                foreach (DataRow linha in dataTableDaoKPIFinanceiroRecebimentosOntemColecao.Rows)
                {
                    DaoKPIFinanceiroRecebimentosOntem daoKPIFinanceiroRecebimentosOntem = new DaoKPIFinanceiroRecebimentosOntem();
                    daoKPIFinanceiroRecebimentosOntem.Qtd = Convert.ToInt32(linha["Qtd"]);
                    daoKPIFinanceiroRecebimentosOntem.Valor = Convert.ToDecimal(linha["Valor"]);
                    dalMySql.LimparParametros();
                    dalMySql.AdicionaParametros("@Qtd", daoKPIFinanceiroRecebimentosOntem.Qtd);
                    dalMySql.AdicionaParametros("@Valor", daoKPIFinanceiroRecebimentosOntem.Valor);

                    dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspKPIFinanceiroRecebimentosOntemInserir");
                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel inserir dados no KPI Financeiro - Recebimentos Ontem . Detalhes: " + ex.Message);
            }


        }

        public DaoKPIFinanceiroRecebimentosHojeColecao RetornaRecebimentosHoje()
        {
            try
            {
                DaoKPIFinanceiroRecebimentosHojeColecao daoKPIFinanceiroRecebimentosHojeColecao = new DaoKPIFinanceiroRecebimentosHojeColecao();
                dalSqlServer.LimparParametros();

                DataTable dataTableDaoKPIFinanceiroRecebimentosHojeColecao = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspKPIFinanceiroRecebimentosHoje");

                foreach (DataRow linha in dataTableDaoKPIFinanceiroRecebimentosHojeColecao.Rows)
                {
                    DaoKPIFinanceiroRecebimentosHoje daoKPIFinanceiroRecebimentosHoje = new DaoKPIFinanceiroRecebimentosHoje();
                    daoKPIFinanceiroRecebimentosHoje.Qtd = Convert.ToInt32(linha["Qtd"]);
                    daoKPIFinanceiroRecebimentosHoje.Valor = Convert.ToDecimal(linha["Valor"]);

                    daoKPIFinanceiroRecebimentosHojeColecao.Add(daoKPIFinanceiroRecebimentosHoje);
                }

                return daoKPIFinanceiroRecebimentosHojeColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel consultar os Recebimentos de Hoje. Detalhes: " + ex.Message);
            }
        }

        public string CarregarRecebimentosHoje(DaoKPIFinanceiroRecebimentosHojeColecao daoKPIFinanceiroRecebimentosHojeColecao)
        {
            try
            {
                string retorno = "ok";
                dalMySql.LimparParametros();
                dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspKPIFinanceiroRecebimentosHojeDeletar");
                DataTable dataTableDaoKPIFinanceiroRecebimentosHojeColecao = ConvertToDataTable(daoKPIFinanceiroRecebimentosHojeColecao);
                foreach (DataRow linha in dataTableDaoKPIFinanceiroRecebimentosHojeColecao.Rows)
                {
                    DaoKPIFinanceiroRecebimentosHoje daoKPIFinanceiroRecebimentosHoje = new DaoKPIFinanceiroRecebimentosHoje();
                    daoKPIFinanceiroRecebimentosHoje.Qtd = Convert.ToInt32(linha["Qtd"]);
                    daoKPIFinanceiroRecebimentosHoje.Valor = Convert.ToDecimal(linha["Valor"]);
                    dalMySql.LimparParametros();
                    dalMySql.AdicionaParametros("@Qtd", daoKPIFinanceiroRecebimentosHoje.Qtd);
                    dalMySql.AdicionaParametros("@Valor", daoKPIFinanceiroRecebimentosHoje.Valor);

                    dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspKPIFinanceiroRecebimentosHojeInserir");
                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel inserir dados no KPI Financeiro - Recebimentos Hoje . Detalhes: " + ex.Message);
            }


        }

        public DaoKPIFinanceiroRecebimentosMesColecao RetornaRecebimentosMes()
        {
            try
            {
                DaoKPIFinanceiroRecebimentosMesColecao daoKPIFinanceiroRecebimentosMesColecao = new DaoKPIFinanceiroRecebimentosMesColecao();
                dalSqlServer.LimparParametros();

                DataTable dataTableDaoKPIFinanceiroRecebimentosMesColecao = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspKPIFinanceiroRecebimentosMes");

                foreach (DataRow linha in dataTableDaoKPIFinanceiroRecebimentosMesColecao.Rows)
                {
                    DaoKPIFinanceiroRecebimentosMes daoKPIFinanceiroRecebimentosMes = new DaoKPIFinanceiroRecebimentosMes();
                    daoKPIFinanceiroRecebimentosMes.Qtd = Convert.ToInt32(linha["Qtd"]);
                    daoKPIFinanceiroRecebimentosMes.Valor = Convert.ToDecimal(linha["Valor"]);

                    daoKPIFinanceiroRecebimentosMesColecao.Add(daoKPIFinanceiroRecebimentosMes);
                }

                return daoKPIFinanceiroRecebimentosMesColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel consultar os pagamentos do mês. Detalhes: " + ex.Message);
            }
        }

        public string CarregarRecebimentosMes(DaoKPIFinanceiroRecebimentosMesColecao daoKPIFinanceiroRecebimentosMesColecao)
        {
            try
            {
                string retorno = "ok";
                dalMySql.LimparParametros();
                dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspKPIFinanceiroRecebimentosMesDeletar");
                DataTable dataTableDaoKPIFinanceiroRecebimentosMesColecao = ConvertToDataTable(daoKPIFinanceiroRecebimentosMesColecao);
                foreach (DataRow linha in dataTableDaoKPIFinanceiroRecebimentosMesColecao.Rows)
                {
                    DaoKPIFinanceiroRecebimentosMes daoKPIFinanceiroRecebimentosMes = new DaoKPIFinanceiroRecebimentosMes();
                    daoKPIFinanceiroRecebimentosMes.Qtd = Convert.ToInt32(linha["Qtd"]);
                    daoKPIFinanceiroRecebimentosMes.Valor = Convert.ToDecimal(linha["Valor"]);
                    dalMySql.LimparParametros();
                    dalMySql.AdicionaParametros("@Qtd", daoKPIFinanceiroRecebimentosMes.Qtd);
                    dalMySql.AdicionaParametros("@Valor", daoKPIFinanceiroRecebimentosMes.Valor);

                    dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspKPIFinanceiroRecebimentosMesInserir");
                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel inserir dados no KPI Financeiro Recebimentos Mês. Detalhes: " + ex.Message);
            }


        }

        public DaoKPIFinanceiroRecebimentosAnoColecao RetornaRecebimentosAno()
        {
            try
            {
                DaoKPIFinanceiroRecebimentosAnoColecao daoKPIFinanceiroRecebimentosAnoColecao = new DaoKPIFinanceiroRecebimentosAnoColecao();
                dalSqlServer.LimparParametros();

                DataTable dataTableDaoKPIFinanceiroRecebimentosAnoColecao = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspKPIFinanceiroRecebimentosAno");

                foreach (DataRow linha in dataTableDaoKPIFinanceiroRecebimentosAnoColecao.Rows)
                {
                    DaoKPIFinanceiroRecebimentosAno daoKPIFinanceiroRecebimentosAno = new DaoKPIFinanceiroRecebimentosAno();
                    daoKPIFinanceiroRecebimentosAno.Qtd = Convert.ToInt32(linha["Qtd"]);
                    daoKPIFinanceiroRecebimentosAno.Valor = Convert.ToDecimal(linha["Valor"]);

                    daoKPIFinanceiroRecebimentosAnoColecao.Add(daoKPIFinanceiroRecebimentosAno);
                }

                return daoKPIFinanceiroRecebimentosAnoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel consultar os pagamentos do mês. Detalhes: " + ex.Message);
            }
        }

        public string CarregarRecebimentosAno(DaoKPIFinanceiroRecebimentosAnoColecao daoKPIFinanceiroRecebimentosAnoColecao)
        {
            try
            {
                string retorno = "ok";
                dalMySql.LimparParametros();
                dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspKPIFinanceiroRecebimentosAnoDeletar");
                DataTable dataTableDaoKPIFinanceiroRecebimentosAnoColecao = ConvertToDataTable(daoKPIFinanceiroRecebimentosAnoColecao);
                foreach (DataRow linha in dataTableDaoKPIFinanceiroRecebimentosAnoColecao.Rows)
                {
                    DaoKPIFinanceiroRecebimentosAno daoKPIFinanceiroRecebimentosAno = new DaoKPIFinanceiroRecebimentosAno();
                    daoKPIFinanceiroRecebimentosAno.Qtd = Convert.ToInt32(linha["Qtd"]);
                    daoKPIFinanceiroRecebimentosAno.Valor = Convert.ToDecimal(linha["Valor"]);
                    dalMySql.LimparParametros();
                    dalMySql.AdicionaParametros("@Qtd", daoKPIFinanceiroRecebimentosAno.Qtd);
                    dalMySql.AdicionaParametros("@Valor", daoKPIFinanceiroRecebimentosAno.Valor);

                    dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspKPIFinanceiroRecebimentosAnoInserir");
                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel inserir dados no KPI Financeiro Recebimentos Mês. Detalhes: " + ex.Message);
            }


        }

        #endregion
    }
}
