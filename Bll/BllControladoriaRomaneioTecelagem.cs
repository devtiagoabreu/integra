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
    public class BllControladoriaRomaneioTecelagem
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

        public string Insert(DaoControladoriaRomaneioTecelagem daoControladoriaRomaneioTecelagem)
        {
            try
            {
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@OperadorNumero", daoControladoriaRomaneioTecelagem.OperadorNumero);
                dalSqlServer.AdicionaParametros("@Numero", daoControladoriaRomaneioTecelagem.Numero);


                string id = dalSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspControladoriaRomaneioTecelagemInsert").ToString();

                return id;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }

        }

        public string Update(DaoControladoriaRomaneioTecelagem daoControladoriaRomaneioTecelagem)
        {
            try
            {
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@Id", daoControladoriaRomaneioTecelagem.Id);
                dalSqlServer.AdicionaParametros("@OperadorNumero", daoControladoriaRomaneioTecelagem.OperadorNumero);
                dalSqlServer.AdicionaParametros("@RStatus", daoControladoriaRomaneioTecelagem.RStatus);
                dalSqlServer.AdicionaParametros("@DataAlteracaoStatus", daoControladoriaRomaneioTecelagem.DataAlteracaoStatus);

                string id = dalSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspControladoriaRomaneioTecelagemUpdate").ToString();

                return id;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }

        }

        public string Ativar(DaoControladoriaRomaneioTecelagem daoControladoriaRomaneioTecelagem)
        {
            try
            {
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@Id", daoControladoriaRomaneioTecelagem.Id);
                dalSqlServer.AdicionaParametros("@OperadorNumero", daoControladoriaRomaneioTecelagem.OperadorNumero);

                string id = dalSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspControladoriaRomaneioTecelagemAtivar").ToString();

                return id;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }

        }

        public string Desativar(DaoControladoriaRomaneioTecelagem daoControladoriaRomaneioTecelagem)
        {
            try
            {
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@Id", daoControladoriaRomaneioTecelagem.Id);
                dalSqlServer.AdicionaParametros("@OperadorNumero", daoControladoriaRomaneioTecelagem.OperadorNumero);

                string id = dalSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspControladoriaRomaneioTecelagemDesativar").ToString();

                return id;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }

        }

        public string Deletar(DaoControladoriaRomaneioTecelagem daoControladoriaRomaneioTecelagem)
        {
            try
            {
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@Id", daoControladoriaRomaneioTecelagem.Id);
                dalSqlServer.AdicionaParametros("@Numero", daoControladoriaRomaneioTecelagem.Numero);

                string id = dalSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspControladoriaRomaneioTecelagemDelete").ToString();

                return id;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }

        }

        public DaoControladoriaRomaneioTecelagemColecao RetornaControladoriaRomaneioTecelagemPorData(DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                DaoControladoriaRomaneioTecelagemColecao daoControladoriaRomaneioTecelagemColecao = new DaoControladoriaRomaneioTecelagemColecao();
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@dataInicial", dataInicial);
                dalSqlServer.AdicionaParametros("@dataFinal", dataFinal);

                DataTable dataTableControladoriaRomaneioTecelagemColecao = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspRetornarControladoriaRomaneioTecelagemPorData");
                foreach (DataRow linha in dataTableControladoriaRomaneioTecelagemColecao.Rows)
                {
                    DaoControladoriaRomaneioTecelagem daoControladoriaRomaneioTecelagem = new DaoControladoriaRomaneioTecelagem();

                    daoControladoriaRomaneioTecelagem.Id = Convert.ToInt32(linha["Id"]);
                    daoControladoriaRomaneioTecelagem.OperadorNumero = linha["OperadorNumero"].ToString();
                    daoControladoriaRomaneioTecelagem.RStatus = linha["RStatus"].ToString();
                    daoControladoriaRomaneioTecelagem.DataCadastro = Convert.ToDateTime(linha["DataCadastro"]);
                    daoControladoriaRomaneioTecelagem.Ativo = Convert.ToInt32(linha["Ativo"]);

                    daoControladoriaRomaneioTecelagemColecao.Add(daoControladoriaRomaneioTecelagem);
                }

                return daoControladoriaRomaneioTecelagemColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel consultar. Detalhes: " + ex.Message);
            }
        }

        public DaoControladoriaRomaneioTecelagem RetornaControladoriaRomaneioTecelagemPorId(int id)
        {
            try
            {
                DaoControladoriaRomaneioTecelagem daoControladoriaRomaneioTecelagem = new DaoControladoriaRomaneioTecelagem();
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@id", id);

                DataTable dataTableControladoriaRomaneioTecelagemColecao = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspRetornarControladoriaRomaneioTecelagemPorId");
                foreach (DataRow linha in dataTableControladoriaRomaneioTecelagemColecao.Rows)
                {
                    
                    daoControladoriaRomaneioTecelagem.Id = Convert.ToInt32(linha["Id"]);
                    daoControladoriaRomaneioTecelagem.OperadorNumero = linha["OperadorNumero"].ToString();
                    daoControladoriaRomaneioTecelagem.Numero = linha["Numero"].ToString();
                    daoControladoriaRomaneioTecelagem.RStatus = linha["RStatus"].ToString();
                    daoControladoriaRomaneioTecelagem.DataCadastro = Convert.ToDateTime(linha["DataCadastro"]);
                    daoControladoriaRomaneioTecelagem.Ativo = Convert.ToInt32(linha["Ativo"]);
                    
                }

                return daoControladoriaRomaneioTecelagem;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel consultar. Detalhes: " + ex.Message);
            }
        }

        public string RetornaControladoriaRomaneioTecelagemUltimoNumero()
        {

            try
            {
                DaoControladoriaRomaneioTecelagemColecao daoControladoriaRomaneioTecelagemColecao = new DaoControladoriaRomaneioTecelagemColecao();
                dalSqlServer.LimparParametros();

                string numero = dalSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspRetornarControladoriaRomaneioTecelagemUltimoNumero").ToString();

                return numero;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }


            #endregion
        }

        
    }
}
