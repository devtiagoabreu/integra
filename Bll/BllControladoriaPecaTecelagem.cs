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
    public class BllControladoriaPecaTecelagem
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

        public string Insert(DaoControladoriaPecaTecelagem daoControladoriaPecaTecelagem)
        {
            try
            {
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@ControladoriaRomaneioTecelagemId", daoControladoriaPecaTecelagem.ControladoriaRomaneioTecelagemId);
                dalSqlServer.AdicionaParametros("@OperadorNumero", daoControladoriaPecaTecelagem.OperadorNumero);
                dalSqlServer.AdicionaParametros("@Numero", daoControladoriaPecaTecelagem.Numero);


                string id = dalSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspControladoriaPecaTecelagemInsert").ToString();

                return id;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }

        }

        public string Update(DaoControladoriaPecaTecelagem daoControladoriaPecaTecelagem)
        {
            try
            {
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@Id", daoControladoriaPecaTecelagem.Id);
                dalSqlServer.AdicionaParametros("@ControladoriaRomaneioTecelagemId", daoControladoriaPecaTecelagem.ControladoriaRomaneioTecelagemId);
                dalSqlServer.AdicionaParametros("@OperadorNumero", daoControladoriaPecaTecelagem.OperadorNumero);
                dalSqlServer.AdicionaParametros("@Numero", daoControladoriaPecaTecelagem.Numero);

                string id = dalSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspControladoriaPecaTecelagemUpdate").ToString();

                return id;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }

        }

        public string Ativar(DaoControladoriaPecaTecelagem daoControladoriaPecaTecelagem)
        {
            try
            {
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@Id", daoControladoriaPecaTecelagem.Id);
                dalSqlServer.AdicionaParametros("@ControladoriaRomaneioTecelagemId", daoControladoriaPecaTecelagem.ControladoriaRomaneioTecelagemId);
                dalSqlServer.AdicionaParametros("@OperadorNumero", daoControladoriaPecaTecelagem.OperadorNumero);
                dalSqlServer.AdicionaParametros("@Numero", daoControladoriaPecaTecelagem.Numero);

                string id = dalSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspControladoriaPecaTecelagemAtivar").ToString();

                return id;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }

        }

        public string Desativar(DaoControladoriaPecaTecelagem daoControladoriaPecaTecelagem)
        {
            try
            {
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@Id", daoControladoriaPecaTecelagem.Id);
                dalSqlServer.AdicionaParametros("@OperadorNumero", daoControladoriaPecaTecelagem.OperadorNumero);

                string id = dalSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspControladoriaPecaTecelagemDesativar").ToString();

                return id;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }

        }

        public string Deletar(DaoControladoriaPecaTecelagem daoControladoriaPecaTecelagem)
        {
            try
            {
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@Id", daoControladoriaPecaTecelagem.Id);
                dalSqlServer.AdicionaParametros("@Numero", daoControladoriaPecaTecelagem.Numero);

                string id = dalSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspControladoriaPecaTecelagemDelete").ToString();

                return id;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }

        }

        public DaoControladoriaPecaTecelagemColecao RetornaControladoriaPecaTecelagemPorData(DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                DaoControladoriaPecaTecelagemColecao daoControladoriaPecaTecelagemColecao = new DaoControladoriaPecaTecelagemColecao();
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@dataInicial", dataInicial);
                dalSqlServer.AdicionaParametros("@dataFinal", dataFinal);

                DataTable dataTableControladoriaRomaneioTecelagemColecao = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspRetornarControladoriaRomaneioTecelagemPorData");
                foreach (DataRow linha in dataTableControladoriaRomaneioTecelagemColecao.Rows)
                {
                    DaoControladoriaPecaTecelagem daoControladoriaPecaTecelagem = new DaoControladoriaPecaTecelagem();

                    daoControladoriaPecaTecelagem.Id = Convert.ToInt32(linha["Id"]);
                    daoControladoriaPecaTecelagem.OperadorNumero = linha["OperadorNumero"].ToString();
                    daoControladoriaPecaTecelagem.Numero = linha["Numero"].ToString();
                    daoControladoriaPecaTecelagem.Nro_Rolo = linha["Nro_Rolo"].ToString();
                    daoControladoriaPecaTecelagem.Nro_Peca = linha["Nro_Peca"].ToString();
                    daoControladoriaPecaTecelagem.Metros = Convert.ToDecimal(linha["Metros"].ToString());
                    daoControladoriaPecaTecelagem.DataCadastro = Convert.ToDateTime(linha["DataCadastro"]);
                    daoControladoriaPecaTecelagem.Ativo = Convert.ToInt32(linha["Ativo"]);

                    daoControladoriaPecaTecelagemColecao.Add(daoControladoriaPecaTecelagem);
                }

                return daoControladoriaPecaTecelagemColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel consultar. Detalhes: " + ex.Message);
            }
        }

        public DaoControladoriaPecaTecelagemColecao RetornarControladoriaPecaTecelagemDoRomaneio(int controladoriaRomaneioTecelagemId)
        {
            try
            {
                DaoControladoriaPecaTecelagemColecao daoControladoriaPecaTecelagemColecao = new DaoControladoriaPecaTecelagemColecao();
                dalSqlServer.LimparParametros();
                dalSqlServer.AdicionaParametros("@controladoriaRomaneioTecelagemId", controladoriaRomaneioTecelagemId);

                DataTable dataTableControladoriaPecaTecelagem = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspRetornarControladoriaPecaTecelagemDoRomaneio");
                foreach (DataRow linha in dataTableControladoriaPecaTecelagem.Rows)
                {
                    DaoControladoriaPecaTecelagem daoControladoriaPecaTecelagem = new DaoControladoriaPecaTecelagem();

                    daoControladoriaPecaTecelagem.Id = Convert.ToInt32(linha["Id"]);
                    daoControladoriaPecaTecelagem.ControladoriaRomaneioTecelagemId = Convert.ToInt32(linha["controladoriaRomaneioTecelagemId"]);
                    daoControladoriaPecaTecelagem.OperadorNumero = linha["OperadorNumero"].ToString();
                    daoControladoriaPecaTecelagem.Numero = linha["Numero"].ToString();
                    daoControladoriaPecaTecelagem.Nro_Rolo = linha["Nro_Rolo"].ToString();
                    daoControladoriaPecaTecelagem.Nro_Peca = linha["Nro_Peca"].ToString();
                    
                    daoControladoriaPecaTecelagem.Metros = Convert.ToDecimal(linha["Metros"].ToString().Substring(0,5));
                    daoControladoriaPecaTecelagem.DataCadastro = Convert.ToDateTime(linha["DataCadastro"]);
                    daoControladoriaPecaTecelagem.Ativo = Convert.ToInt32(linha["Ativo"]);

                    daoControladoriaPecaTecelagemColecao.Add(daoControladoriaPecaTecelagem);
                }

                return daoControladoriaPecaTecelagemColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel consultar. Detalhes: " + ex.Message);
            }
        }


        #endregion
    }
}
