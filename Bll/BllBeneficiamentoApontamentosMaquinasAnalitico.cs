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
    public class BllBeneficiamentoApontamentosMaquinasAnalitico
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

        public DaoBeneficiamentoApontamentosMaquinasAnaliticoColecao RetornaListaDeAlpontamentoMaquinasAnalitico()
        {
            try
            {
                DaoBeneficiamentoApontamentosMaquinasAnaliticoColecao daoBeneficiamentoApontamentosMaquinasAnaliticoColecao = new DaoBeneficiamentoApontamentosMaquinasAnaliticoColecao();
                dalSqlServer.LimparParametros();

                DataTable dataTableDaoBeneficiamentoApontamentosMaquinaAnalitico = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspBeneficiamentoApontamentosMaquinasAnalitico");
                foreach (DataRow linha in dataTableDaoBeneficiamentoApontamentosMaquinaAnalitico.Rows)
                {
                    DaoBeneficiamentoApontamentosMaquinasAnalitico daoBeneficiamentoApontamentosMaquinasAnalitico = new DaoBeneficiamentoApontamentosMaquinasAnalitico();
                    daoBeneficiamentoApontamentosMaquinasAnalitico.Maquina = linha["maquina"].ToString();
                    daoBeneficiamentoApontamentosMaquinasAnalitico.CodProduto = linha["codProduto"].ToString();
                    daoBeneficiamentoApontamentosMaquinasAnalitico.Produto = linha["produto"].ToString();
                    daoBeneficiamentoApontamentosMaquinasAnalitico.Situacao = linha["situacao"].ToString();
                    daoBeneficiamentoApontamentosMaquinasAnalitico.Cor = linha["cor"].ToString();
                    daoBeneficiamentoApontamentosMaquinasAnalitico.Desenho = linha["desenho"].ToString();
                    daoBeneficiamentoApontamentosMaquinasAnalitico.Variante = linha["variante"].ToString();
                    daoBeneficiamentoApontamentosMaquinasAnalitico.Metros = Convert.ToDecimal(linha["metros"]);
                    daoBeneficiamentoApontamentosMaquinasAnalitico.Status = linha["status"].ToString();
                    daoBeneficiamentoApontamentosMaquinasAnalitico.Data_Inicio = Convert.ToDateTime(linha["Data_Inicio"]);

                    daoBeneficiamentoApontamentosMaquinasAnaliticoColecao.Add(daoBeneficiamentoApontamentosMaquinasAnalitico);

                }

                return daoBeneficiamentoApontamentosMaquinasAnaliticoColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Nao foi Possivel consultar. Detalhes: " + ex.Message);
            }
        }


        public string CarregarDashBeneficiamentoApontamentosMaquinasAnaliticoEmDBPromodaDash(DaoBeneficiamentoApontamentosMaquinasAnaliticoColecao daoBeneficiamentoApontamentosMaquinasAnaliticoColecao)
        {
            try
            {
                string retorno = "ok";
                dalMySql.LimparParametros();
                dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDashBeneficiamentoApontamentosMaquinasAnaliticoDeletar");
                DataTable dataTableDaoBeneficiamentoApontamentosMaquinasAnaliticoColecao = ConvertToDataTable(daoBeneficiamentoApontamentosMaquinasAnaliticoColecao);
                foreach (DataRow linha in dataTableDaoBeneficiamentoApontamentosMaquinasAnaliticoColecao.Rows)
                {
                    DaoBeneficiamentoApontamentosMaquinasAnalitico daoBeneficiamentoApontamentosMaquinasAnalitico = new DaoBeneficiamentoApontamentosMaquinasAnalitico();
                    daoBeneficiamentoApontamentosMaquinasAnalitico.Maquina = (linha["maquina"]).ToString();
                    daoBeneficiamentoApontamentosMaquinasAnalitico.CodProduto = linha["codProduto"].ToString();
                    daoBeneficiamentoApontamentosMaquinasAnalitico.Produto = linha["produto"].ToString();
                    daoBeneficiamentoApontamentosMaquinasAnalitico.Situacao = linha["situacao"].ToString();
                    daoBeneficiamentoApontamentosMaquinasAnalitico.Cor = linha["cor"].ToString();
                    daoBeneficiamentoApontamentosMaquinasAnalitico.Desenho = linha["desenho"].ToString();
                    daoBeneficiamentoApontamentosMaquinasAnalitico.Variante = linha["variante"].ToString();
                    daoBeneficiamentoApontamentosMaquinasAnalitico.Metros = Convert.ToDecimal(linha["metros"]);
                    daoBeneficiamentoApontamentosMaquinasAnalitico.Status = (linha["status"]).ToString();
                    daoBeneficiamentoApontamentosMaquinasAnalitico.Data_Inicio = Convert.ToDateTime(linha["Data_Inicio"]);
                    dalMySql.LimparParametros();
                    dalMySql.AdicionaParametros("@maquina", daoBeneficiamentoApontamentosMaquinasAnalitico.Maquina);
                    dalMySql.AdicionaParametros("@codProduto", daoBeneficiamentoApontamentosMaquinasAnalitico.CodProduto);
                    dalMySql.AdicionaParametros("@produto", daoBeneficiamentoApontamentosMaquinasAnalitico.Produto);
                    dalMySql.AdicionaParametros("@situacao", daoBeneficiamentoApontamentosMaquinasAnalitico.Situacao);
                    dalMySql.AdicionaParametros("@cor", daoBeneficiamentoApontamentosMaquinasAnalitico.Cor);
                    dalMySql.AdicionaParametros("@desenho", daoBeneficiamentoApontamentosMaquinasAnalitico.Desenho);
                    dalMySql.AdicionaParametros("@variante", daoBeneficiamentoApontamentosMaquinasAnalitico.Variante);
                    dalMySql.AdicionaParametros("@metros", daoBeneficiamentoApontamentosMaquinasAnalitico.Metros);
                    dalMySql.AdicionaParametros("@status", daoBeneficiamentoApontamentosMaquinasAnalitico.Status);
                    dalMySql.AdicionaParametros("@Data_Inicio", daoBeneficiamentoApontamentosMaquinasAnalitico.Data_Inicio);

                    dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDashBeneficiamentoApontamentosMaquinasAnaliticoInserir");

                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel inserir dados no dash de Apontameto Analítico de Maquinas do Beneficiamento. Detalhes: " + ex.Message);
            }

        }


        #endregion
    }
}
