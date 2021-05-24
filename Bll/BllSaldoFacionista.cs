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
    public class BllSaldoFacionista
    {
        #region ATRIBUTOS | OBJETOS

        DalSqlServer dalSqlServer = new DalSqlServer();
        DalMySql dalMySql = new DalMySql();
        DalProDash dalProDash = new DalProDash();
        DalDBProDash dalDBProDash = new DalDBProDash();

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

        public DaoSaldoFacionistaList RetornaSaldoFacionista()
        {
            try
            {
                DaoSaldoFacionistaList daoSaldoFacionistaList = new DaoSaldoFacionistaList();
                dalDBProDash.LimparParametros();

                DataTable dataTableDaoBeneficiamentoApontamentosGrupoMaquinaSintetico = dalDBProDash.ExecutarConsulta(CommandType.StoredProcedure, "uspSaldoFacionista");
                foreach (DataRow linha in dataTableDaoBeneficiamentoApontamentosGrupoMaquinaSintetico.Rows)
                {
                    DaoSaldoFacionista daoSaldoFacionista = new DaoSaldoFacionista();
                    daoSaldoFacionista.Empresa = linha["Empresa"].ToString();
                    daoSaldoFacionista.Facionista = linha["Facionista"].ToString();
                    daoSaldoFacionista.Razao_Nome_Cliente = linha["Razao_Nome_Cliente"].ToString();
                    daoSaldoFacionista.Produto = linha["Produto"].ToString();
                    daoSaldoFacionista.Descricao = linha["Descricao"].ToString();
                    daoSaldoFacionista.Cor = linha["Cor"].ToString();
                    daoSaldoFacionista.Desc_Cor = linha["Desc_Cor"].ToString();
                    daoSaldoFacionista.Saldo_Peso = Convert.ToDecimal(linha["Saldo_Peso"]);
                    daoSaldoFacionista.Saldo_Valor = Convert.ToDecimal(linha["Saldo_Valor"]);

                    daoSaldoFacionistaList.Add(daoSaldoFacionista);

                }

                return daoSaldoFacionistaList;
            }
            catch (Exception ex)
            {

                throw new Exception("Nao foi Possivel consultar. Detalhes: " + ex.Message);
            }
        }

        public string CarregaSaldoFacionistaEmProDash(DaoSaldoFacionistaList daoSaldoFacionistaList)
        {
            try
            {
                string retorno = "ok";
                dalProDash.LimparParametros();
                dalProDash.ExecutarManipulacao(CommandType.StoredProcedure, "uspSaldoFacionistaDeletar");
                DataTable dataTableDaoSaldoFacionistaList = ConvertToDataTable(daoSaldoFacionistaList);
                foreach (DataRow linha in dataTableDaoSaldoFacionistaList.Rows)
                {
                    DaoSaldoFacionista daoSaldoFacionista = new DaoSaldoFacionista();
                    daoSaldoFacionista.Empresa = linha["Empresa"].ToString();
                    daoSaldoFacionista.Facionista = linha["Facionista"].ToString();
                    daoSaldoFacionista.Razao_Nome_Cliente = linha["Razao_Nome_Cliente"].ToString();
                    daoSaldoFacionista.Produto = linha["Produto"].ToString();
                    daoSaldoFacionista.Descricao = linha["Descricao"].ToString();
                    daoSaldoFacionista.Cor = linha["Cor"].ToString();
                    daoSaldoFacionista.Desc_Cor = linha["Desc_Cor"].ToString();
                    daoSaldoFacionista.Saldo_Peso = Convert.ToDecimal(linha["Saldo_Peso"]);
                    daoSaldoFacionista.Saldo_Valor = Convert.ToDecimal(linha["Saldo_Valor"]);
                    dalProDash.LimparParametros();

                    dalProDash.AdicionaParametros("@Empresa", daoSaldoFacionista.Empresa);
                    dalProDash.AdicionaParametros("@Facionista", daoSaldoFacionista.Facionista);
                    dalProDash.AdicionaParametros("@Razao_Nome_Cliente", daoSaldoFacionista.Razao_Nome_Cliente);
                    dalProDash.AdicionaParametros("@Produto", daoSaldoFacionista.Produto);
                    dalProDash.AdicionaParametros("@Descricao", daoSaldoFacionista.Descricao);
                    dalProDash.AdicionaParametros("@Cor", daoSaldoFacionista.Cor);
                    dalProDash.AdicionaParametros("@Desc_Cor", daoSaldoFacionista.Desc_Cor);
                    dalProDash.AdicionaParametros("@Saldo_Peso", daoSaldoFacionista.Saldo_Peso);
                    dalProDash.AdicionaParametros("@Saldo_Valor", daoSaldoFacionista.Saldo_Valor);

                    dalProDash.ExecutarManipulacao(CommandType.StoredProcedure, "uspSaldoFacionistaInserir");

                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel inserir dados no dash de Saldo Facionista. Detalhes: " + ex.Message);
            }

        }


        #endregion
    }
}
