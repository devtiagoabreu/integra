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
    public class BllBeneficiamentoProcesso
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

        public DaoBeneficiamentoProcessoColecao RetornaListaDeProcessos(string empresa)
        {
            try
            {
                DaoBeneficiamentoProcessoColecao daoBeneficiamentoProcessoColecao = new DaoBeneficiamentoProcessoColecao();
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@empresa", empresa);
                
                DataTable dataTableDaoBeneficiamentoProcesso = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspBeneficiamentoProcessoSelect");
                foreach (DataRow linha in dataTableDaoBeneficiamentoProcesso.Rows)
                {
                    DaoBeneficiamentoProcesso daoBeneficiamentoProcesso = new DaoBeneficiamentoProcesso();
                    daoBeneficiamentoProcesso.Empresa = linha["Empresa"].ToString();
                    daoBeneficiamentoProcesso.Processo = linha["Processo"].ToString();
                    daoBeneficiamentoProcesso.Descricao = linha["Descricao"].ToString();
                    daoBeneficiamentoProcesso.TipoProcesso = linha["TipoProcesso"].ToString();
                    daoBeneficiamentoProcesso.GrupoMaquina = linha["GrupoMaquina"].ToString();

                    daoBeneficiamentoProcessoColecao.Add(daoBeneficiamentoProcesso);

                }

                return daoBeneficiamentoProcessoColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Nao foi Possivel consultar. Detalhes: " + ex.Message);
            }
        }

        
        #endregion
    }
}
