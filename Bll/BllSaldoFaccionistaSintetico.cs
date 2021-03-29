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
    public class BllSaldoFaccionistaSintetico
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

        public DaoSaldoFaccionistaSinteticoColecao RetornaSaldoFaccionistaSintetico()
        {
            try
            {
                DaoSaldoFaccionistaSinteticoColecao daoSaldoFaccionistaSinteticoColecao = new DaoSaldoFaccionistaSinteticoColecao();
                dalSqlServer.LimparParametros();

                DataTable dataTabledaoSaldoFaccionistaSinteticoColecao = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspSaldoFaccionistaSintetico");
                foreach (DataRow linha in dataTabledaoSaldoFaccionistaSinteticoColecao.Rows)
                {

                    DaoSaldoFaccionistaSintetico daoSaldoFaccionistaSintetico = new DaoSaldoFaccionistaSintetico();
                    daoSaldoFaccionistaSintetico.Produto = linha["Produto"].ToString();
                    daoSaldoFaccionistaSintetico.Descricao = linha["Descricao"].ToString();
                    daoSaldoFaccionistaSintetico.Remessa = Convert.ToDecimal(linha["Remessa"]);
                    daoSaldoFaccionistaSintetico.Retorno = Convert.ToDecimal(linha["Retorno"]);
                    daoSaldoFaccionistaSintetico.Saldo = Convert.ToDecimal(linha["Saldo"]);

                    daoSaldoFaccionistaSinteticoColecao.Add(daoSaldoFaccionistaSintetico);

                }
                return daoSaldoFaccionistaSinteticoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel consultar. Detalhes: " + ex.Message);
            }
        }

        public string CarregarDashSaldoFaccionistaSinteticoEmDBPromodaDash(DaoSaldoFaccionistaSinteticoColecao daoSaldoFaccionistaSinteticoColecao)
        {
            try
            {
                string retorno = "ok";
                dalMySql.LimparParametros();
                dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDashSaldoFaccionistaSinteticoDeletar");
                DataTable dataTabledaoSaldoFaccionistaSinteticoColecao = ConvertToDataTable(daoSaldoFaccionistaSinteticoColecao);
                foreach (DataRow linha in dataTabledaoSaldoFaccionistaSinteticoColecao.Rows)
                {
                    DaoSaldoFaccionistaSintetico daoSaldoFaccionistaSintetico = new DaoSaldoFaccionistaSintetico();
                    daoSaldoFaccionistaSintetico.Produto = linha["Produto"].ToString();
                    daoSaldoFaccionistaSintetico.Descricao = linha["Descricao"].ToString();
                    daoSaldoFaccionistaSintetico.Remessa = Convert.ToDecimal(linha["Remessa"]);
                    daoSaldoFaccionistaSintetico.Retorno = Convert.ToDecimal(linha["Retorno"]);
                    daoSaldoFaccionistaSintetico.Saldo = Convert.ToDecimal(linha["Saldo"]);
                    dalMySql.LimparParametros();
                    dalMySql.AdicionaParametros("@Produto", daoSaldoFaccionistaSintetico.Produto);
                    dalMySql.AdicionaParametros("@Descricao", daoSaldoFaccionistaSintetico.Descricao);
                    dalMySql.AdicionaParametros("@Remessa", daoSaldoFaccionistaSintetico.Remessa);
                    dalMySql.AdicionaParametros("@Retorno", daoSaldoFaccionistaSintetico.Retorno);
                    dalMySql.AdicionaParametros("@Saldo", daoSaldoFaccionistaSintetico.Saldo);


                    dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDashSaldoFaccionistaSinteticoInserir");

                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel inserir dados no dash 'Saldo Faccionista (Sintético)'. Detalhes: " + ex.Message);
            }


        }

    }
}
