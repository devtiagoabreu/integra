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
    public class BllDashPedidosQuantidadeValor
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

        public DaoDashPedidosQuantidadeValorColecao RetornaPedidos(string parametro)
        {
            try
            {
                DaoDashPedidosQuantidadeValorColecao daoDashPedidosQuantidadeValorColecao = new DaoDashPedidosQuantidadeValorColecao();
                dalSqlServer.LimparParametros();

                
                switch (parametro)
                {
                    case "MesAtual":
                        DataTable dataTableDaoDashPedidosQuantidadeValorMesAtualColecao = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspDashPedidosQuantidadeValorMesAtual");
                        foreach (DataRow linha in dataTableDaoDashPedidosQuantidadeValorMesAtualColecao.Rows)
                        {

                            DaoDashPedidosQuantidadeValor daoDashPedidosQuantidadeValor = new DaoDashPedidosQuantidadeValor();
                            daoDashPedidosQuantidadeValor.QtdePedidos = Convert.ToInt32(linha["QtdePedidos"]);
                            daoDashPedidosQuantidadeValor.Metros = Convert.ToDecimal(linha["Metros"]);
                            daoDashPedidosQuantidadeValor.ValorTotal = Convert.ToDecimal(linha["ValorTotal"]);


                            daoDashPedidosQuantidadeValorColecao.Add(daoDashPedidosQuantidadeValor);

                        }
                        break;
                    case "MesAnterior":
                        DataTable dataTableDaoDashPedidosQuantidadeValorMesAnteriorColecao = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspDashPedidosQuantidadeValorMesAnterior");
                        foreach (DataRow linha in dataTableDaoDashPedidosQuantidadeValorMesAnteriorColecao.Rows)
                        {

                            DaoDashPedidosQuantidadeValor daoDashPedidosQuantidadeValor = new DaoDashPedidosQuantidadeValor();
                            daoDashPedidosQuantidadeValor.QtdePedidos = Convert.ToInt32(linha["QtdePedidos"]);
                            daoDashPedidosQuantidadeValor.Metros = Convert.ToDecimal(linha["Metros"]);
                            daoDashPedidosQuantidadeValor.ValorTotal = Convert.ToDecimal(linha["ValorTotal"]);


                            daoDashPedidosQuantidadeValorColecao.Add(daoDashPedidosQuantidadeValor);

                        }
                        break;
                    case "Hoje":
                        DataTable dataTableDaoDashPedidosQuantidadeValorHojeColecao = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspDashPedidosQuantidadeValorHoje");
                        foreach (DataRow linha in dataTableDaoDashPedidosQuantidadeValorHojeColecao.Rows)
                        {

                            DaoDashPedidosQuantidadeValor daoDashPedidosQuantidadeValor = new DaoDashPedidosQuantidadeValor();
                            daoDashPedidosQuantidadeValor.QtdePedidos = Convert.ToInt32(linha["QtdePedidos"]);
                            daoDashPedidosQuantidadeValor.Metros = Convert.ToDecimal(linha["Metros"]);
                            daoDashPedidosQuantidadeValor.ValorTotal = Convert.ToDecimal(linha["ValorTotal"]);


                            daoDashPedidosQuantidadeValorColecao.Add(daoDashPedidosQuantidadeValor);

                        }
                        break;
                    case "Ontem":
                        DataTable dataTableDaoDashPedidosQuantidadeValorOntemColecao = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspDashPedidosQuantidadeValorOntem");
                        foreach (DataRow linha in dataTableDaoDashPedidosQuantidadeValorOntemColecao.Rows)
                        {

                            DaoDashPedidosQuantidadeValor daoDashPedidosQuantidadeValor = new DaoDashPedidosQuantidadeValor();
                            daoDashPedidosQuantidadeValor.QtdePedidos = Convert.ToInt32(linha["QtdePedidos"]);
                            daoDashPedidosQuantidadeValor.Metros = Convert.ToDecimal(linha["Metros"]);
                            daoDashPedidosQuantidadeValor.ValorTotal = Convert.ToDecimal(linha["ValorTotal"]);


                            daoDashPedidosQuantidadeValorColecao.Add(daoDashPedidosQuantidadeValor);

                        }
                        break;
                    default:
                        break;
                }
                

                return daoDashPedidosQuantidadeValorColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Nao foi Possivel consultar. Detalhes: " + ex.Message);
            }
        }

        public DaoDashPedidosQuantidadeValorColecao RetornaPedidosFaturados(string parametro)
        {
            try
            {
                DaoDashPedidosQuantidadeValorColecao daoDashPedidosQuantidadeValorColecao = new DaoDashPedidosQuantidadeValorColecao();
                dalSqlServer.LimparParametros();


                switch (parametro)
                {
                    case "MesAtual":
                        DataTable dataTableDaoDashPedidosQuantidadeValorMesAtualColecao = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspDashPedidosFaturadosQuantidadeValorMesAtual");
                        foreach (DataRow linha in dataTableDaoDashPedidosQuantidadeValorMesAtualColecao.Rows)
                        {

                            DaoDashPedidosQuantidadeValor daoDashPedidosQuantidadeValor = new DaoDashPedidosQuantidadeValor();
                            daoDashPedidosQuantidadeValor.QtdePedidos = Convert.ToInt32(linha["QtdePedidos"]);
                            daoDashPedidosQuantidadeValor.Metros = Convert.ToDecimal(linha["Metros"]);
                            daoDashPedidosQuantidadeValor.ValorTotal = Convert.ToDecimal(linha["ValorTotal"]);


                            daoDashPedidosQuantidadeValorColecao.Add(daoDashPedidosQuantidadeValor);

                        }
                        break;
                    case "MesAnterior":
                        DataTable dataTableDaoDashPedidosQuantidadeValorMesAnteriorColecao = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspDashPedidosFaturadosQuantidadeValorMesAnterior");
                        foreach (DataRow linha in dataTableDaoDashPedidosQuantidadeValorMesAnteriorColecao.Rows)
                        {

                            DaoDashPedidosQuantidadeValor daoDashPedidosQuantidadeValor = new DaoDashPedidosQuantidadeValor();
                            daoDashPedidosQuantidadeValor.QtdePedidos = Convert.ToInt32(linha["QtdePedidos"]);
                            daoDashPedidosQuantidadeValor.Metros = Convert.ToDecimal(linha["Metros"]);
                            daoDashPedidosQuantidadeValor.ValorTotal = Convert.ToDecimal(linha["ValorTotal"]);


                            daoDashPedidosQuantidadeValorColecao.Add(daoDashPedidosQuantidadeValor);

                        }
                        break;
                    case "Hoje":
                        DataTable dataTableDaoDashPedidosQuantidadeValorHojeColecao = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspDashPedidosFaturadosQuantidadeValorHoje");
                        foreach (DataRow linha in dataTableDaoDashPedidosQuantidadeValorHojeColecao.Rows)
                        {

                            DaoDashPedidosQuantidadeValor daoDashPedidosQuantidadeValor = new DaoDashPedidosQuantidadeValor();
                            daoDashPedidosQuantidadeValor.QtdePedidos = Convert.ToInt32(linha["QtdePedidos"]);
                            daoDashPedidosQuantidadeValor.Metros = Convert.ToDecimal(linha["Metros"]);
                            daoDashPedidosQuantidadeValor.ValorTotal = Convert.ToDecimal(linha["ValorTotal"]);


                            daoDashPedidosQuantidadeValorColecao.Add(daoDashPedidosQuantidadeValor);

                        }
                        break;
                    case "Ontem":
                        DataTable dataTableDaoDashPedidosQuantidadeValorOntemColecao = dalSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspDashPedidosFaturadosQuantidadeValorOntem");
                        foreach (DataRow linha in dataTableDaoDashPedidosQuantidadeValorOntemColecao.Rows)
                        {

                            DaoDashPedidosQuantidadeValor daoDashPedidosQuantidadeValor = new DaoDashPedidosQuantidadeValor();
                            daoDashPedidosQuantidadeValor.QtdePedidos = Convert.ToInt32(linha["QtdePedidos"]);
                            daoDashPedidosQuantidadeValor.Metros = Convert.ToDecimal(linha["Metros"]);
                            daoDashPedidosQuantidadeValor.ValorTotal = Convert.ToDecimal(linha["ValorTotal"]);


                            daoDashPedidosQuantidadeValorColecao.Add(daoDashPedidosQuantidadeValor);

                        }
                        break;
                    default:
                        break;
                }


                return daoDashPedidosQuantidadeValorColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Nao foi Possivel consultar. Detalhes: " + ex.Message);
            }
        }

        public string CarregarDashPedidosQuantidadeValorMesAtualEmDBPromodaDash(DaoDashPedidosQuantidadeValorColecao daoDashPedidosQuantidadeValorColecao)
        {
            try
            {
                string retorno = "ok";
                dalMySql.LimparParametros();
                dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDashPedidosQuantidadeValorMesAtualDeletar");
                DataTable dataTableDashPedidosQuantidadeValorMesAtualColecao = ConvertToDataTable(daoDashPedidosQuantidadeValorColecao);
                foreach (DataRow linha in dataTableDashPedidosQuantidadeValorMesAtualColecao.Rows)
                {
                    DaoDashPedidosQuantidadeValor daoDashPedidosQuantidadeValor = new DaoDashPedidosQuantidadeValor();
                    daoDashPedidosQuantidadeValor.QtdePedidos = Convert.ToInt32(linha["QtdePedidos"]);
                    daoDashPedidosQuantidadeValor.Metros = Convert.ToDecimal(linha["Metros"]);
                    daoDashPedidosQuantidadeValor.ValorTotal = Convert.ToDecimal(linha["ValorTotal"]);
                    dalMySql.LimparParametros();
                    dalMySql.AdicionaParametros("@QtdePedidos", daoDashPedidosQuantidadeValor.QtdePedidos);
                    dalMySql.AdicionaParametros("@Metros", daoDashPedidosQuantidadeValor.Metros);
                    dalMySql.AdicionaParametros("@ValorTotal", daoDashPedidosQuantidadeValor.ValorTotal);


                    dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDashPedidosQuantidadeValorMesAtualInserir");

                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel inserir dados no dash 'Pedidos Mês Atual'. Detalhes: " + ex.Message);
            }


        }

        public string CarregarDashPedidosFaturadosQuantidadeValorMesAtualEmDBPromodaDash(DaoDashPedidosQuantidadeValorColecao daoDashPedidosQuantidadeValorColecao)
        {
            try
            {
                string retorno = "ok";
                dalMySql.LimparParametros();
                dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDashPedidosFaturadosQuantidadeValorMesAtualDeletar");
                DataTable dataTableDashPedidosQuantidadeValorMesAtualColecao = ConvertToDataTable(daoDashPedidosQuantidadeValorColecao);
                foreach (DataRow linha in dataTableDashPedidosQuantidadeValorMesAtualColecao.Rows)
                {
                    DaoDashPedidosQuantidadeValor daoDashPedidosQuantidadeValor = new DaoDashPedidosQuantidadeValor();
                    daoDashPedidosQuantidadeValor.QtdePedidos = Convert.ToInt32(linha["QtdePedidos"]);
                    daoDashPedidosQuantidadeValor.Metros = Convert.ToDecimal(linha["Metros"]);
                    daoDashPedidosQuantidadeValor.ValorTotal = Convert.ToDecimal(linha["ValorTotal"]);
                    dalMySql.LimparParametros();
                    dalMySql.AdicionaParametros("@QtdePedidos", daoDashPedidosQuantidadeValor.QtdePedidos);
                    dalMySql.AdicionaParametros("@Metros", daoDashPedidosQuantidadeValor.Metros);
                    dalMySql.AdicionaParametros("@ValorTotal", daoDashPedidosQuantidadeValor.ValorTotal);


                    dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDashPedidosFaturadosQuantidadeValorMesAtualInserir");

                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel inserir dados no dash 'Pedidos Faturados do Mês Atual'. Detalhes: " + ex.Message);
            }


        }

        public string CarregarDashPedidosQuantidadeValorMesAnteriorEmDBPromodaDash(DaoDashPedidosQuantidadeValorColecao daoDashPedidosQuantidadeValorColecao)
        {
            try
            {
                string retorno = "ok";
                dalMySql.LimparParametros();
                dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDashPedidosQuantidadeValorMesAnteriorDeletar");
                DataTable dataTableDashPedidosQuantidadeValorMesAtualColecao = ConvertToDataTable(daoDashPedidosQuantidadeValorColecao);
                foreach (DataRow linha in dataTableDashPedidosQuantidadeValorMesAtualColecao.Rows)
                {
                    DaoDashPedidosQuantidadeValor daoDashPedidosQuantidadeValor = new DaoDashPedidosQuantidadeValor();
                    daoDashPedidosQuantidadeValor.QtdePedidos = Convert.ToInt32(linha["QtdePedidos"]);
                    daoDashPedidosQuantidadeValor.Metros = Convert.ToDecimal(linha["Metros"]);
                    daoDashPedidosQuantidadeValor.ValorTotal = Convert.ToDecimal(linha["ValorTotal"]);
                    dalMySql.LimparParametros();
                    dalMySql.AdicionaParametros("@QtdePedidos", daoDashPedidosQuantidadeValor.QtdePedidos);
                    dalMySql.AdicionaParametros("@Metros", daoDashPedidosQuantidadeValor.Metros);
                    dalMySql.AdicionaParametros("@ValorTotal", daoDashPedidosQuantidadeValor.ValorTotal);


                    dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDashPedidosQuantidadeValorMesAnteriorInserir");

                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel inserir dados no dash 'Pedidos Mês Anterior'. Detalhes: " + ex.Message);
            }


        }

        public string CarregarDashPedidosQuantidadeValorHojeEmDBPromodaDash(DaoDashPedidosQuantidadeValorColecao daoDashPedidosQuantidadeValorColecao)
        {
            try
            {
                string retorno = "ok";
                dalMySql.LimparParametros();
                dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDashPedidosQuantidadeValorHojeDeletar");
                DataTable dataTableDashPedidosQuantidadeValorHojeColecao = ConvertToDataTable(daoDashPedidosQuantidadeValorColecao);
                foreach (DataRow linha in dataTableDashPedidosQuantidadeValorHojeColecao.Rows)
                {
                    DaoDashPedidosQuantidadeValor daoDashPedidosQuantidadeValor = new DaoDashPedidosQuantidadeValor();
                    daoDashPedidosQuantidadeValor.QtdePedidos = Convert.ToInt32(linha["QtdePedidos"]);
                    daoDashPedidosQuantidadeValor.Metros = Convert.ToDecimal(linha["Metros"]);
                    daoDashPedidosQuantidadeValor.ValorTotal = Convert.ToDecimal(linha["ValorTotal"]);
                    dalMySql.LimparParametros();
                    dalMySql.AdicionaParametros("@QtdePedidos", daoDashPedidosQuantidadeValor.QtdePedidos);
                    dalMySql.AdicionaParametros("@Metros", daoDashPedidosQuantidadeValor.Metros);
                    dalMySql.AdicionaParametros("@ValorTotal", daoDashPedidosQuantidadeValor.ValorTotal);


                    dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDashPedidosQuantidadeValorHojeInserir");

                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel inserir dados no dash 'Pedidos de Hoje'. Detalhes: " + ex.Message);
            }


        }

        public string CarregarDashPedidosFaturadosQuantidadeValorHojeEmDBPromodaDash(DaoDashPedidosQuantidadeValorColecao daoDashPedidosQuantidadeValorColecao)
        {
            try
            {
                string retorno = "ok";
                dalMySql.LimparParametros();
                dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDashPedidosFaturadosQuantidadeValorHojeDeletar");
                DataTable dataTableDashPedidosQuantidadeValorHojeColecao = ConvertToDataTable(daoDashPedidosQuantidadeValorColecao);
                foreach (DataRow linha in dataTableDashPedidosQuantidadeValorHojeColecao.Rows)
                {
                    DaoDashPedidosQuantidadeValor daoDashPedidosQuantidadeValor = new DaoDashPedidosQuantidadeValor();
                    daoDashPedidosQuantidadeValor.QtdePedidos = Convert.ToInt32(linha["QtdePedidos"]);
                    daoDashPedidosQuantidadeValor.Metros = Convert.ToDecimal(linha["Metros"]);
                    daoDashPedidosQuantidadeValor.ValorTotal = Convert.ToDecimal(linha["ValorTotal"]);
                    dalMySql.LimparParametros();
                    dalMySql.AdicionaParametros("@QtdePedidos", daoDashPedidosQuantidadeValor.QtdePedidos);
                    dalMySql.AdicionaParametros("@Metros", daoDashPedidosQuantidadeValor.Metros);
                    dalMySql.AdicionaParametros("@ValorTotal", daoDashPedidosQuantidadeValor.ValorTotal);


                    dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDashPedidosFaturadosQuantidadeValorHojeInserir");

                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel inserir dados no dash 'Pedidos Faturados de Hoje'. Detalhes: " + ex.Message);
            }


        }

        public string CarregarDashPedidosQuantidadeValorOntemEmDBPromodaDash(DaoDashPedidosQuantidadeValorColecao daoDashPedidosQuantidadeValorColecao)
        {
            try
            {
                string retorno = "ok";
                dalMySql.LimparParametros();
                dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDashPedidosQuantidadeValorOntemDeletar");
                DataTable dataTableDashPedidosQuantidadeValorMesAtualColecao = ConvertToDataTable(daoDashPedidosQuantidadeValorColecao);
                foreach (DataRow linha in dataTableDashPedidosQuantidadeValorMesAtualColecao.Rows)
                {
                    DaoDashPedidosQuantidadeValor daoDashPedidosQuantidadeValor = new DaoDashPedidosQuantidadeValor();
                    daoDashPedidosQuantidadeValor.QtdePedidos = Convert.ToInt32(linha["QtdePedidos"]);
                    daoDashPedidosQuantidadeValor.Metros = Convert.ToDecimal(linha["Metros"]);
                    daoDashPedidosQuantidadeValor.ValorTotal = Convert.ToDecimal(linha["ValorTotal"]);
                    dalMySql.LimparParametros();
                    dalMySql.AdicionaParametros("@QtdePedidos", daoDashPedidosQuantidadeValor.QtdePedidos);
                    dalMySql.AdicionaParametros("@Metros", daoDashPedidosQuantidadeValor.Metros);
                    dalMySql.AdicionaParametros("@ValorTotal", daoDashPedidosQuantidadeValor.ValorTotal);


                    dalMySql.ExecutarManipulacao(CommandType.StoredProcedure, "uspDashPedidosQuantidadeValorOntemInserir");

                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception("Nao foi Possivel inserir dados no dash 'Pedidos de Ontem'. Detalhes: " + ex.Message);
            }


        }


    }
}
