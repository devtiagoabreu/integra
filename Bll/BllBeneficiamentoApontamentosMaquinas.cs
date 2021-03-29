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
    public class BllBeneficiamentoApontamentosMaquinas
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

        public DaoBeneficiamentoApontamentosMaquinasColecao RetornaListaDeAlpontamentoMaquinas()
        {
            try
            {
                DaoBeneficiamentoApontamentosMaquinasColecao daoBeneficiamentoApontamentosMaquinasColecao = new DaoBeneficiamentoApontamentosMaquinasColecao();
                dalSqlServer.LimparParametros();
                
                DataTable dataTableDaoBeneficiamentoProcesso = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspBeneficiamentoApontamentosMaquinas");
                foreach (DataRow linha in dataTableDaoBeneficiamentoProcesso.Rows)
                {
                    DaoBeneficiamentoApontamentosMaquinas daoBeneficiamentoApontamentosMaquinas = new DaoBeneficiamentoApontamentosMaquinas();
                    daoBeneficiamentoApontamentosMaquinas.Maquina = linha["Maquina"].ToString();
                    daoBeneficiamentoApontamentosMaquinas.Metros = Convert.ToDecimal(linha["Metros"]);
                    daoBeneficiamentoApontamentosMaquinas.Status = linha["Status"].ToString();
                    
                    daoBeneficiamentoApontamentosMaquinasColecao.Add(daoBeneficiamentoApontamentosMaquinas);

                }

                return daoBeneficiamentoApontamentosMaquinasColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Nao foi Possivel consultar. Detalhes: " + ex.Message);
            }
        }


        public string CarregarDashBeneficiamentoApontamentosMaquinasEmDBPromodaDash(DaoBeneficiamentoApontamentosMaquinasColecao daoBeneficiamentoApontamentosMaquinasColecao)
        {
            try
            {
                string retorno = "ok";
                dalMySql.LimparParametros();
                dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDashBeneficiamentoApontamentosMaquinasDeletar");
                DataTable dataTableDaoBeneficiamentoApontamentosMaquinasColecao = ConvertToDataTable(daoBeneficiamentoApontamentosMaquinasColecao);
                foreach (DataRow linha in dataTableDaoBeneficiamentoApontamentosMaquinasColecao.Rows)
                {
                    DaoBeneficiamentoApontamentosMaquinas daoBeneficiamentoApontamentosMaquinas = new DaoBeneficiamentoApontamentosMaquinas();
                    daoBeneficiamentoApontamentosMaquinas.Maquina = (linha["maquina"]).ToString();
                    daoBeneficiamentoApontamentosMaquinas.Metros = Convert.ToDecimal(linha["metros"]);
                    daoBeneficiamentoApontamentosMaquinas.Status = (linha["status"]).ToString();
                    dalMySql.LimparParametros();
                    dalMySql.AdicionaParametros("@maquina", daoBeneficiamentoApontamentosMaquinas.Maquina);
                    dalMySql.AdicionaParametros("@metros", daoBeneficiamentoApontamentosMaquinas.Metros);
                    dalMySql.AdicionaParametros("@status", daoBeneficiamentoApontamentosMaquinas.Status);
                    
                    dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDashBeneficiamentoApontamentosMaquinasInserir");

                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel inserir dados no dash de Apontameto de Maquinas do Beneficiamento. Detalhes: " + ex.Message);
            }

        }


        #endregion
    }
}
