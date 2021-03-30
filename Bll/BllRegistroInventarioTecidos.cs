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
    public class BllRegistroInventarioTecidos
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

        public DaoRegistroInventarioTecidosColecao RetornaRegistroInventarioTecidos(DaoRegistroInventarioTecidos daoRegistroInventarioTecidosParametros, string tipoRetorno, string dataInicial, string dataFinal)
        {
            try
            {
                DaoRegistroInventarioTecidosColecao daoRegistroInventarioTecidosColecao = new DaoRegistroInventarioTecidosColecao();
                dalSqlServer.LimparParametros();
                
                dalSqlServer.AdicionaParametros("@tipoRetorno", tipoRetorno);
                dalSqlServer.AdicionaParametros("@produtoCodigo", daoRegistroInventarioTecidosParametros.ProdutoCodigo);
                dalSqlServer.AdicionaParametros("@numeroRolo", daoRegistroInventarioTecidosParametros.NumeroRolo);
                dalSqlServer.AdicionaParametros("@numeroPeca", daoRegistroInventarioTecidosParametros.NumeroPeca);
                dalSqlServer.AdicionaParametros("@situacao", daoRegistroInventarioTecidosParametros.Situacao);
                dalSqlServer.AdicionaParametros("@cor", daoRegistroInventarioTecidosParametros.Cor);
                dalSqlServer.AdicionaParametros("@desenho", daoRegistroInventarioTecidosParametros.Desenho);
                dalSqlServer.AdicionaParametros("@variante", daoRegistroInventarioTecidosParametros.Variante);
                dalSqlServer.AdicionaParametros("@categoria", daoRegistroInventarioTecidosParametros.Categoria);
                dalSqlServer.AdicionaParametros("@dataInicial", dataInicial);
                dalSqlServer.AdicionaParametros("@dataFinal", dataFinal);

                DataTable dataTableDaoRegistroInventarioTecidos = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspRegistroInventarioTecidos");

                if (tipoRetorno.Equals("SS"))
                {
                    foreach (DataRow linha in dataTableDaoRegistroInventarioTecidos.Rows)
                    {

                        DaoRegistroInventarioTecidos daoRegistroInventarioTecidos = new DaoRegistroInventarioTecidos();
                        daoRegistroInventarioTecidos.ProdutoCodigo = linha["ProdutoCodigo"].ToString();
                        daoRegistroInventarioTecidos.ProdutoDescricao = linha["ProdutoDescricao"].ToString();
                        daoRegistroInventarioTecidos.Situacao = linha["Situacao"].ToString();
                        daoRegistroInventarioTecidos.Cor = linha["Cor"].ToString();
                        daoRegistroInventarioTecidos.CorDescricao = linha["CorDescricao"].ToString();
                        daoRegistroInventarioTecidos.Desenho = linha["Desenho"].ToString();
                        daoRegistroInventarioTecidos.Variante = linha["Variante"].ToString();
                        daoRegistroInventarioTecidos.Categoria = linha["Categoria"].ToString();
                        daoRegistroInventarioTecidos.Metros = Convert.ToDecimal(linha["Metros"]);
                        daoRegistroInventarioTecidos.Peso = Convert.ToDecimal(linha["Peso"]);
                       
                        daoRegistroInventarioTecidosColecao.Add(daoRegistroInventarioTecidos);

                    }
                }
                else if (tipoRetorno.Equals("SC"))
                {
                    foreach (DataRow linha in dataTableDaoRegistroInventarioTecidos.Rows)
                    {

                        DaoRegistroInventarioTecidos daoRegistroInventarioTecidos = new DaoRegistroInventarioTecidos();
                        daoRegistroInventarioTecidos.ProdutoCodigo = linha["ProdutoCodigo"].ToString();
                        daoRegistroInventarioTecidos.ProdutoDescricao = linha["ProdutoDescricao"].ToString();
                        daoRegistroInventarioTecidos.Situacao = linha["Situacao"].ToString();
                        daoRegistroInventarioTecidos.Cor = linha["Cor"].ToString();
                        daoRegistroInventarioTecidos.CorDescricao = linha["CorDescricao"].ToString();
                        daoRegistroInventarioTecidos.Desenho = linha["Desenho"].ToString();
                        daoRegistroInventarioTecidos.Variante = linha["Variante"].ToString();
                        daoRegistroInventarioTecidos.Categoria = linha["Categoria"].ToString();
                        daoRegistroInventarioTecidos.Metros = Convert.ToDecimal(linha["Metros"]);
                        daoRegistroInventarioTecidos.Peso = Convert.ToDecimal(linha["Peso"]);
                        daoRegistroInventarioTecidos.CustoMetro = Convert.ToDecimal(linha["CustoMetro"]);
                        daoRegistroInventarioTecidos.CustoMetroOutros = Convert.ToDecimal(linha["CustoMetroOutros"]);
                        daoRegistroInventarioTecidos.CustoTotal = Convert.ToDecimal(linha["CustoTotal"]);

                        daoRegistroInventarioTecidosColecao.Add(daoRegistroInventarioTecidos);

                    }
                }
                else if (tipoRetorno.Equals("AC"))
                {
                    foreach (DataRow linha in dataTableDaoRegistroInventarioTecidos.Rows)
                    {

                        DaoRegistroInventarioTecidos daoRegistroInventarioTecidos = new DaoRegistroInventarioTecidos();
                        daoRegistroInventarioTecidos.ProdutoCodigo = linha["ProdutoCodigo"].ToString();
                        daoRegistroInventarioTecidos.ProdutoDescricao = linha["ProdutoDescricao"].ToString();
                        daoRegistroInventarioTecidos.NumeroRolo = linha["NumeroRolo"].ToString();
                        daoRegistroInventarioTecidos.NumeroPeca = linha["NumeroPeca"].ToString();
                        daoRegistroInventarioTecidos.Situacao = linha["Situacao"].ToString();
                        daoRegistroInventarioTecidos.Cor = linha["Cor"].ToString();
                        daoRegistroInventarioTecidos.CorDescricao = linha["CorDescricao"].ToString();
                        daoRegistroInventarioTecidos.Desenho = linha["Desenho"].ToString();
                        daoRegistroInventarioTecidos.Variante = linha["Variante"].ToString();
                        daoRegistroInventarioTecidos.Categoria = linha["Categoria"].ToString();
                        daoRegistroInventarioTecidos.Metros = Convert.ToDecimal(linha["Metros"]);
                        daoRegistroInventarioTecidos.Peso = Convert.ToDecimal(linha["Peso"]);
                        daoRegistroInventarioTecidos.CustoMetro = Convert.ToDecimal(linha["CustoMetro"]);
                        daoRegistroInventarioTecidos.CustoMetroOutros = Convert.ToDecimal(linha["CustoMetroOutros"]);
                        daoRegistroInventarioTecidos.CustoTotal = Convert.ToDecimal(linha["CustoTotal"]);

                        daoRegistroInventarioTecidosColecao.Add(daoRegistroInventarioTecidos);

                    }
                }
                else if (tipoRetorno.Equals("IS"))
                {
                    foreach (DataRow linha in dataTableDaoRegistroInventarioTecidos.Rows)
                    {

                        DaoRegistroInventarioTecidos daoRegistroInventarioTecidos = new DaoRegistroInventarioTecidos();
                        daoRegistroInventarioTecidos.ProdutoCodigo = linha["ProdutoCodigo"].ToString();
                        daoRegistroInventarioTecidos.ProdutoDescricao = linha["ProdutoDescricao"].ToString();
                        daoRegistroInventarioTecidos.Situacao = linha["Situacao"].ToString();
                        daoRegistroInventarioTecidos.Cor = linha["Cor"].ToString();
                        daoRegistroInventarioTecidos.CorDescricao = linha["CorDescricao"].ToString();
                        daoRegistroInventarioTecidos.Desenho = linha["Desenho"].ToString();
                        daoRegistroInventarioTecidos.Variante = linha["Variante"].ToString();
                        daoRegistroInventarioTecidos.Categoria = linha["Categoria"].ToString();
                        daoRegistroInventarioTecidos.Metros = Convert.ToDecimal(linha["Metros"]);
                        daoRegistroInventarioTecidos.Peso = Convert.ToDecimal(linha["Peso"]);
                       
                        daoRegistroInventarioTecidosColecao.Add(daoRegistroInventarioTecidos);

                    }
                }
                else
                {
                    foreach (DataRow linha in dataTableDaoRegistroInventarioTecidos.Rows)
                    {

                        DaoRegistroInventarioTecidos daoRegistroInventarioTecidos = new DaoRegistroInventarioTecidos();
                        daoRegistroInventarioTecidos.ProdutoCodigo = linha["ProdutoCodigo"].ToString();
                        daoRegistroInventarioTecidos.ProdutoDescricao = linha["ProdutoDescricao"].ToString();
                        daoRegistroInventarioTecidos.NumeroRolo = linha["NumeroRolo"].ToString();
                        daoRegistroInventarioTecidos.NumeroPeca = linha["NumeroPeca"].ToString();
                        daoRegistroInventarioTecidos.Situacao = linha["Situacao"].ToString();
                        daoRegistroInventarioTecidos.Cor = linha["Cor"].ToString();
                        daoRegistroInventarioTecidos.CorDescricao = linha["CorDescricao"].ToString();
                        daoRegistroInventarioTecidos.Desenho = linha["Desenho"].ToString();
                        daoRegistroInventarioTecidos.Variante = linha["Variante"].ToString();
                        daoRegistroInventarioTecidos.Categoria = linha["Categoria"].ToString();
                        daoRegistroInventarioTecidos.Metros = Convert.ToDecimal(linha["Metros"]);
                        daoRegistroInventarioTecidos.Peso = Convert.ToDecimal(linha["Peso"]);
                        
                        daoRegistroInventarioTecidosColecao.Add(daoRegistroInventarioTecidos);

                    }
                }

                return daoRegistroInventarioTecidosColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Nao foi Possivel consultar. Detalhes: " + ex.Message);
            }
        }

        public string CarregaRegistroInventarioTecidosEmDBPromodaDash(DaoRegistroInventarioTecidosColecao daoRegistroInventarioTecidosColecao)
        {
            try
            {
                string retorno = "ok";
                dalMySql.LimparParametros();
                dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspRegistroInventarioTecidosDeletar");
                DataTable dataTableDaoRegistroInventarioTecidosColecao = ConvertToDataTable(daoRegistroInventarioTecidosColecao);
                foreach (DataRow linha in dataTableDaoRegistroInventarioTecidosColecao.Rows)
                {
                    DaoRegistroInventarioTecidos daoRegistroInventarioTecidos = new DaoRegistroInventarioTecidos();
                    daoRegistroInventarioTecidos.ProdutoCodigo = linha["ProdutoCodigo"].ToString();
                    daoRegistroInventarioTecidos.ProdutoDescricao = linha["ProdutoDescricao"].ToString();
                    daoRegistroInventarioTecidos.NumeroRolo = linha["NumeroRolo"].ToString();
                    daoRegistroInventarioTecidos.NumeroPeca = linha["NumeroPeca"].ToString();
                    daoRegistroInventarioTecidos.Situacao = linha["Situacao"].ToString();
                    daoRegistroInventarioTecidos.Cor = linha["Cor"].ToString();
                    daoRegistroInventarioTecidos.CorDescricao = linha["CorDescricao"].ToString();
                    daoRegistroInventarioTecidos.Desenho = linha["Desenho"].ToString();
                    daoRegistroInventarioTecidos.Variante = linha["Variante"].ToString();
                    daoRegistroInventarioTecidos.Categoria = linha["Categoria"].ToString();
                    daoRegistroInventarioTecidos.Metros = Convert.ToDecimal(linha["Metros"]);
                    daoRegistroInventarioTecidos.Peso = Convert.ToDecimal(linha["Peso"]);
                    daoRegistroInventarioTecidos.CustoMetro = Convert.ToDecimal(linha["CustoMetro"]);
                    daoRegistroInventarioTecidos.CustoMetroOutros = Convert.ToDecimal(linha["CustoMetroOutros"]);
                    daoRegistroInventarioTecidos.CustoTotal = Convert.ToDecimal(linha["CustoTotal"]);
                    dalMySql.LimparParametros();
                    dalMySql.AdicionaParametros("@ProdutoCodigo", daoRegistroInventarioTecidos.ProdutoCodigo);
                    dalMySql.AdicionaParametros("@ProdutoDescricao", daoRegistroInventarioTecidos.ProdutoDescricao);
                    dalMySql.AdicionaParametros("@NumeroRolo", daoRegistroInventarioTecidos.NumeroRolo);
                    dalMySql.AdicionaParametros("@NumeroPeca", daoRegistroInventarioTecidos.NumeroPeca);
                    dalMySql.AdicionaParametros("@Situacao", daoRegistroInventarioTecidos.Situacao);
                    dalMySql.AdicionaParametros("@Cor", daoRegistroInventarioTecidos.Cor);
                    dalMySql.AdicionaParametros("@CorDescricao", daoRegistroInventarioTecidos.CorDescricao);
                    dalMySql.AdicionaParametros("@Desenho", daoRegistroInventarioTecidos.Desenho);
                    dalMySql.AdicionaParametros("@Variante", daoRegistroInventarioTecidos.Variante);
                    dalMySql.AdicionaParametros("@Categoria", daoRegistroInventarioTecidos.Categoria);
                    dalMySql.AdicionaParametros("@Metros", daoRegistroInventarioTecidos.Metros);
                    dalMySql.AdicionaParametros("@Peso", daoRegistroInventarioTecidos.Peso);
                    dalMySql.AdicionaParametros("@CustoMetro", daoRegistroInventarioTecidos.CustoMetro);
                    dalMySql.AdicionaParametros("@CustoMetroOutros", daoRegistroInventarioTecidos.CustoMetroOutros);
                    dalMySql.AdicionaParametros("@CustoTotal", daoRegistroInventarioTecidos.CustoTotal);
                                        
                    dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspRegistroInventarioTecidosInserir");

                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel inserir dados'. Detalhes: " + ex.Message);
            }


        }

        public string CarregaBaixaInventarioEmDBPromodaDash(DaoRegistroInventarioTecidosColecao daoRegistroInventarioTecidosColecao)
        {
            try
            {
                string retorno = "ok";
                dalMySql.LimparParametros();
                dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspBaixaInventarioDeletar");
                DataTable dataTableDaoRegistroInventarioTecidosColecao = ConvertToDataTable(daoRegistroInventarioTecidosColecao);
                foreach (DataRow linha in dataTableDaoRegistroInventarioTecidosColecao.Rows)
                {
                    DaoRegistroInventarioTecidos daoRegistroInventarioTecidos = new DaoRegistroInventarioTecidos();
                    daoRegistroInventarioTecidos.ProdutoCodigo = linha["ProdutoCodigo"].ToString();
                    daoRegistroInventarioTecidos.ProdutoDescricao = linha["ProdutoDescricao"].ToString();
                    daoRegistroInventarioTecidos.NumeroRolo = linha["NumeroRolo"].ToString();
                    daoRegistroInventarioTecidos.NumeroPeca = linha["NumeroPeca"].ToString();
                    daoRegistroInventarioTecidos.Situacao = linha["Situacao"].ToString();
                    daoRegistroInventarioTecidos.Cor = linha["Cor"].ToString();
                    daoRegistroInventarioTecidos.CorDescricao = linha["CorDescricao"].ToString();
                    daoRegistroInventarioTecidos.Desenho = linha["Desenho"].ToString();
                    daoRegistroInventarioTecidos.Variante = linha["Variante"].ToString();
                    daoRegistroInventarioTecidos.Categoria = linha["Categoria"].ToString();
                    daoRegistroInventarioTecidos.Metros = Convert.ToDecimal(linha["Metros"]);
                    daoRegistroInventarioTecidos.Peso = Convert.ToDecimal(linha["Peso"]);
                    daoRegistroInventarioTecidos.CustoMetro = Convert.ToDecimal(linha["CustoMetro"]);
                    daoRegistroInventarioTecidos.CustoMetroOutros = Convert.ToDecimal(linha["CustoMetroOutros"]);
                    daoRegistroInventarioTecidos.CustoTotal = Convert.ToDecimal(linha["CustoTotal"]);
                    dalMySql.LimparParametros();
                    dalMySql.AdicionaParametros("@ProdutoCodigo", daoRegistroInventarioTecidos.ProdutoCodigo);
                    dalMySql.AdicionaParametros("@ProdutoDescricao", daoRegistroInventarioTecidos.ProdutoDescricao);
                    dalMySql.AdicionaParametros("@NumeroRolo", daoRegistroInventarioTecidos.NumeroRolo);
                    dalMySql.AdicionaParametros("@NumeroPeca", daoRegistroInventarioTecidos.NumeroPeca);
                    dalMySql.AdicionaParametros("@Situacao", daoRegistroInventarioTecidos.Situacao);
                    dalMySql.AdicionaParametros("@Cor", daoRegistroInventarioTecidos.Cor);
                    dalMySql.AdicionaParametros("@CorDescricao", daoRegistroInventarioTecidos.CorDescricao);
                    dalMySql.AdicionaParametros("@Desenho", daoRegistroInventarioTecidos.Desenho);
                    dalMySql.AdicionaParametros("@Variante", daoRegistroInventarioTecidos.Variante);
                    dalMySql.AdicionaParametros("@Categoria", daoRegistroInventarioTecidos.Categoria);
                    dalMySql.AdicionaParametros("@Metros", daoRegistroInventarioTecidos.Metros);
                    dalMySql.AdicionaParametros("@Peso", daoRegistroInventarioTecidos.Peso);
                    dalMySql.AdicionaParametros("@CustoMetro", daoRegistroInventarioTecidos.CustoMetro);
                    dalMySql.AdicionaParametros("@CustoMetroOutros", daoRegistroInventarioTecidos.CustoMetroOutros);
                    dalMySql.AdicionaParametros("@CustoTotal", daoRegistroInventarioTecidos.CustoTotal);

                    dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspBaixaInventarioInserir");

                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel inserir dados'. Detalhes: " + ex.Message);
            }


        }
    }
}
