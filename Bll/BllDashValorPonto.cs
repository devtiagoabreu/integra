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
    public class BllDashValorPonto
    {
        #region ATRIBUTOS | OBJETOS
        //Instanciar = criar um novo objeto baseado em um modelo
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

        public string CarregarValorPontoEmDBPromodaDash(DaoDashValorPonto daoDashValorPonto)
        {
            try
            {
                string retorno = "ok";
                dalMySql.LimparParametros();
                dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDaoDashValorPontoDeletar");
                dalMySql.LimparParametros();
                dalMySql.AdicionaParametros("@tecelagem", daoDashValorPonto.Tecelagem);
                dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDaoDashValorPontoInserir");
                
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel inserir dados no dash 'Valor Ponto'. Detalhes: " + ex.Message);
            }


        }









        #endregion

    }
}

