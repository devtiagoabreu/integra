using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bll;
using Dao;

namespace PromodaIntegra
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void indicadoresListagemDePecasTecidoCruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIndicadoresListagemDePecas frmIndicadoresListagemDePecas = new FrmIndicadoresListagemDePecas("menu","",DateTime.Now,DateTime.Now);
            //frmIndicadoresListagemDePecas.MdiParent = this;
            frmIndicadoresListagemDePecas.Show();
        }

        private void listagemDePecasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmRelListagemDePecas frmRelListagemDePecas = new FrmRelListagemDePecas();
            frmRelListagemDePecas.Show();
        }

        private void consumoDeFiosTramaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmRelatorioConsumoDeFiosDeTrama frmRelatorioConsumoDeFiosDeTrama = new FrmRelatorioConsumoDeFiosDeTrama();
            frmRelatorioConsumoDeFiosDeTrama.Show();
        }

        private void consumoDeFiosTramaSinteticoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmRelatorioConsumoDeFiosDeTramaSintetico frmRelatorioConsumoDeFiosDeTramaSintetico = new FrmRelatorioConsumoDeFiosDeTramaSintetico();
            frmRelatorioConsumoDeFiosDeTramaSintetico.Show();
        }

        private void consumoDeFiosUrdumeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmRelatorioConsumoDeFiosDeUrdume frmRelatorioConsumoDeFiosDeUrdume = new FrmRelatorioConsumoDeFiosDeUrdume();
            frmRelatorioConsumoDeFiosDeUrdume.Show();
        }

        private void consumoDeFiosUrdumeSinteticoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmRelatorioConsumoDeFiosDeUrdumeSintetico frmRelatorioConsumoDeFiosDeUrdumeSintetico = new FrmRelatorioConsumoDeFiosDeUrdumeSintetico();
            frmRelatorioConsumoDeFiosDeUrdumeSintetico.Show();
        }

        private void CarregarDashsDeProducao()
        {

            #region CARREGA DATAS (INICIAL E FINAL) PARA DADOS DO MÊS ATUAL

            DateTime dataInicialMesAtual = DateTime.Now.Date;
            string diaAtual = DateTime.Now.Date.Day.ToString();
            string sinalSubtracaoMesAtual = "-";
            int diasAtual = (Convert.ToInt32(sinalSubtracaoMesAtual + diaAtual)) + 1;
            dataInicialMesAtual = dataInicialMesAtual.AddDays(diasAtual);

            DateTime dataInicialMesAnterior = DateTime.Now.Date.AddMonths(-1);
            string diaPassado = dataInicialMesAnterior.Date.Day.ToString();
            string sinalSubtracaoMesAnterior = "-";
            int diasPassado = (Convert.ToInt32(sinalSubtracaoMesAnterior + diaPassado)) + 1;
            dataInicialMesAnterior = dataInicialMesAnterior.AddDays(diasPassado);

            #endregion

            #region 01 - DASH LISTAGEM DE PEÇAS 1ª E 2ª CATEGORIAS MÊS ATUAL

            BllDashListagemDePecasMesAtual bllDashListagemDePecasMesAtual = new BllDashListagemDePecasMesAtual();
            DaoDashListagemDePecasMesAtualColecao daoDashListagemDePecasMesAtualColecao = new DaoDashListagemDePecasMesAtualColecao();
            daoDashListagemDePecasMesAtualColecao = bllDashListagemDePecasMesAtual.ConsultarListagemDePecasMesAtualEmDBPromoda("01", "*", "000", "01", dataInicialMesAtual, Convert.ToDateTime(DateTime.Now.ToShortDateString()));
            bllDashListagemDePecasMesAtual.CarregarListagemDePecasMesAtualEmDBPromodaDash(daoDashListagemDePecasMesAtualColecao);
            bllDashListagemDePecasMesAtual.CarregarListagemDePecasDeSegundaMesAtualEmDBPromodaDash(bllDashListagemDePecasMesAtual.ConsultarListagemDePecasDeSegundaMesAtualEmDBPromoda("01", "*", "000", dataInicialMesAtual, Convert.ToDateTime(DateTime.Now.ToShortDateString())));

            #endregion

            #region 02 - DASH LISTAGEM DE PEÇAS 1ª E 2ª CATEGORIAS MÊS ANTERIOR

            //bllDashListagemDePecasMesAnterior = new BllDashListagemDePecasMesAnterior();
            //bllDashListagemDePecasMesAnterior.CarregarListagemDePecasMesAnteriorEmDBPromodaDash(bllDashListagemDePecasMesAnterior.ConsultarListagemDePecasMesAnteriorEmDBPromoda("01", "*", "000", "01", dataInicialMesAnterior, DateTime.Now.Date.AddMonths(-1)));

            #endregion

            #region 03 - DASH TOTAL DE PEÇAS POR OPERADOR MÊS ATUAL 

            BllDashRevisaoTotalMetrosPorOperador bllDashRevisaoTotalMetrosPorOperador = new BllDashRevisaoTotalMetrosPorOperador();
            bllDashRevisaoTotalMetrosPorOperador.CarregarDaoDashRevisaoTotalMetrosPorOperadorEmDBPromodaDash(bllDashRevisaoTotalMetrosPorOperador.ConsultarRevisaoTotalMetrosPorOperadorEmDBPromoda("*", dataInicialMesAtual, Convert.ToDateTime(DateTime.Now.ToShortDateString())));

            #endregion

            #region 04 - DASH TOTAL DE BAIXAS MÊS ATUAL

            BllDashTotalDeBaixas bllDashTotalDeBaixas = new BllDashTotalDeBaixas();
            DaoDashTotalDeBaixasColecao daoDashTotalDeBaixasColecao = new DaoDashTotalDeBaixasColecao();
            daoDashTotalDeBaixasColecao = bllDashTotalDeBaixas.TotalDeBaixas(dataInicialMesAtual, Convert.ToDateTime(DateTime.Now.ToShortDateString()));
            bllDashTotalDeBaixas.CarregarTotalDeBaixasEmDBPromodaDash(daoDashTotalDeBaixasColecao);

            #endregion

            #region 05 - VALOR DO PONTO TECELAGEM | ADMINISTRAÇÃO MÊS ATUAL

            BllDashValorPonto bllDashValorPonto = new BllDashValorPonto();
            DaoDashValorPonto daoDashValorPonto = new DaoDashValorPonto();

            decimal totalPontos = 0;
            foreach (var lista in daoDashListagemDePecasMesAtualColecao)
                totalPontos = lista.Pontos + totalPontos;


            if (totalPontos.Equals(0))
            {
                daoDashValorPonto.Tecelagem = 0;
                bllDashValorPonto.CarregarValorPontoEmDBPromodaDash(daoDashValorPonto);
            }
            else
            {
                daoDashValorPonto.Tecelagem = (daoDashTotalDeBaixasColecao[0].TotalBaixasAdministrativo + daoDashTotalDeBaixasColecao[0].TotalBaixasTecelagem) / totalPontos;
                bllDashValorPonto.CarregarValorPontoEmDBPromodaDash(daoDashValorPonto);
            }
            

            #endregion

            #region 06 - DASH EFICIENCIA | METRAGEM TECELAGEM - (TURNOS: MANHÃ, TARDE, NOITE) MÊS ATUAL

            //BllDashEficienciaMetragem bllDashEficienciaMetragem = new BllDashEficienciaMetragem();
            //bllDashEficienciaMetragem.CarregarEficienciaMetragemEmDBPromodaDash(bllDashEficienciaMetragem.RetornaEficienciaMetragem(dataInicialMesAtual, Convert.ToDateTime(DateTime.Now.ToShortDateString())));

            #endregion

            #region 07 - DASH EFICIENCIA | METRAGEM TECELAGEM - (FOLGUISTA) MÊS ATUAL

            //BllDashEficienciaMetragemFolguista bllDashEficienciaMetragemFolguista = new BllDashEficienciaMetragemFolguista();
            //DaoDashEficienciaMetragemFolguistaColecao daoDashEficienciaMetragemFolguistaColecao = new DaoDashEficienciaMetragemFolguistaColecao();
            //daoDashEficienciaMetragemFolguistaColecao = bllDashEficienciaMetragemFolguista.RetornaEficienciaMetragem(dataInicialMesAtual, Convert.ToDateTime(DateTime.Now.ToShortDateString()));
            //bllDashEficienciaMetragemFolguista.CarregarEficienciaMetragemEmDBPromodaDash(daoDashEficienciaMetragemFolguistaColecao);

            #endregion

            #region 08 - DASH CONSUMO DE FIOS DE URDUME SINTÉTICO MÊS ATUAL

            BllDashConsumoDeFiosDeUrdumeSintetico bllDashConsumoDeFiosDeUrdumeSintetico = new BllDashConsumoDeFiosDeUrdumeSintetico();
            bllDashConsumoDeFiosDeUrdumeSintetico.CarregarDashConsumoDeFiosDeUrdumeSinteticoEmDBPromodaDash(bllDashConsumoDeFiosDeUrdumeSintetico.RetornaConsumoUrdumeSintetico(dataInicialMesAtual, Convert.ToDateTime(DateTime.Now.ToShortDateString())));

            #endregion

            #region 09 - DASH CONSUMO DE FIOS DE TRAMA SINTÉTICO MÊS ATUAL

            BllDashConsumoDeFiosDeTramaSintetico bllDashConsumoDeFiosDeTramaSintetico = new BllDashConsumoDeFiosDeTramaSintetico();
            bllDashConsumoDeFiosDeTramaSintetico.CarregarDashConsumoDeFiosDeTramaSinteticoEmDBPromodaDash(bllDashConsumoDeFiosDeTramaSintetico.RetornaConsumoTramaSintetico(dataInicialMesAtual, Convert.ToDateTime(DateTime.Now.ToShortDateString())));

            #endregion

            #region 10 - DASH PROCESSOS BENEFICIAMENTO

            //BllDashProcessosBeneficiamento bllDashProcessosBeneficiamento = new BllDashProcessosBeneficiamento();
            //bllDashProcessosBeneficiamento.CarregarDashProcessosBeneficiamento(bllDashProcessosBeneficiamento.RetornaProcessosBeneficiamento());

            #endregion

            #region 11 - DASH PRODUCAO TEARES

            //BllDashProducaoTeares bllDashProducaoTeares = new BllDashProducaoTeares();
            //bllDashProducaoTeares.CarregarDashProducaoTeares(bllDashProducaoTeares.RetornarProducaoTeares(Convert.ToDateTime(DateTime.Now.ToShortDateString())));

            #endregion

            #region 12 - DASH PEDIDOS QUANTIDADE VALOR APROVADOS E FATURADOS (MÊS ATUAL, MÊS ANTERIOR, HOJE, ONTEM)

            BllDashPedidosQuantidadeValor bllDashPedidosQuantidadeValor = new BllDashPedidosQuantidadeValor();
            bllDashPedidosQuantidadeValor.CarregarDashPedidosQuantidadeValorMesAtualEmDBPromodaDash(bllDashPedidosQuantidadeValor.RetornaPedidos("MesAtual"));
            bllDashPedidosQuantidadeValor.CarregarDashPedidosFaturadosQuantidadeValorMesAtualEmDBPromodaDash(bllDashPedidosQuantidadeValor.RetornaPedidosFaturados("MesAtual"));
            bllDashPedidosQuantidadeValor.CarregarDashPedidosQuantidadeValorMesAnteriorEmDBPromodaDash(bllDashPedidosQuantidadeValor.RetornaPedidos("MesAnterior"));
            bllDashPedidosQuantidadeValor.CarregarDashPedidosQuantidadeValorHojeEmDBPromodaDash(bllDashPedidosQuantidadeValor.RetornaPedidos("Hoje"));
            bllDashPedidosQuantidadeValor.CarregarDashPedidosFaturadosQuantidadeValorHojeEmDBPromodaDash(bllDashPedidosQuantidadeValor.RetornaPedidosFaturados("Hoje"));
            bllDashPedidosQuantidadeValor.CarregarDashPedidosQuantidadeValorOntemEmDBPromodaDash(bllDashPedidosQuantidadeValor.RetornaPedidos("Ontem"));

            #endregion

            #region 13 - DASH FINANCEIRO CONTAS A PAGAR E RECEBER

            BllDashFinanceiroContasPagarReceber bllDashFinanceiroContasPagarReceber = new BllDashFinanceiroContasPagarReceber();
            bllDashFinanceiroContasPagarReceber.CarregarDashFinanceiroContasPagarEmDBPromodaDash(bllDashFinanceiroContasPagarReceber.RetornaContasPagar());
            bllDashFinanceiroContasPagarReceber.CarregarDashFinanceiroContasReceberEmDBPromodaDash(bllDashFinanceiroContasPagarReceber.RetornaContasReceber());

            #endregion

            #region 14 - DASH INVENTÁRIO SALDO DE FIOS

            BllDashInventarioSaldoFios bllDashInventarioSaldoFios = new BllDashInventarioSaldoFios();
            bllDashInventarioSaldoFios.CarregarDashInventarioSaldoFiosEmDBPromodaDash(bllDashInventarioSaldoFios.RetornaInvetarioSaldoFios());

            #endregion

            #region 15 - DASH BENEFICIAMENTO PRODUÇÃO

            BllDashBeneficiamentoProducao bllDashBeneficiamentoProducao = new BllDashBeneficiamentoProducao();
            bllDashBeneficiamentoProducao.CarregarDashBeneficiamentoProducaoEmDBPromodaDash(bllDashBeneficiamentoProducao.ListarBeneficiamentoProducaoEmDBPromoda());

            #endregion

            #region 16 - DASH BENEFICIAMENTO APONTAMENTO DE MAQUINAS

            BllBeneficiamentoApontamentosMaquinas bllBeneficiamentoApontamentosMaquinas = new BllBeneficiamentoApontamentosMaquinas();
            bllBeneficiamentoApontamentosMaquinas.CarregarDashBeneficiamentoApontamentosMaquinasEmDBPromodaDash(bllBeneficiamentoApontamentosMaquinas.RetornaListaDeAlpontamentoMaquinas());

            #endregion

            #region 17 - DASH BENEFICIAMENTO APONTAMENTO DE MAQUINAS ANALÍTICO

            BllBeneficiamentoApontamentosMaquinasAnalitico bllBeneficiamentoApontamentosMaquinasAnalitico = new BllBeneficiamentoApontamentosMaquinasAnalitico();
            bllBeneficiamentoApontamentosMaquinasAnalitico.CarregarDashBeneficiamentoApontamentosMaquinasAnaliticoEmDBPromodaDash(bllBeneficiamentoApontamentosMaquinasAnalitico.RetornaListaDeAlpontamentoMaquinasAnalitico());

            #endregion

            #region 18 - DASH BENEFICIAMENTO APONTAMENTO DE GRUPO MAQUINA SINTÉTICO

            BllBeneficiamentoApontamentosGrupoMaquinaSintetico bllBeneficiamentoApontamentosGrupoMaquinaSintetico = new BllBeneficiamentoApontamentosGrupoMaquinaSintetico();
            bllBeneficiamentoApontamentosGrupoMaquinaSintetico.CarregarDashBeneficiamentoApontamentosGrupoMaquinaSinteticoEmDBPromodaDash(bllBeneficiamentoApontamentosGrupoMaquinaSintetico.RetornaListaDeAlpontamentosGrupoMaquinaSintetico());

            #endregion

            #region 19 - DASH FATURAMENTO/COMERCIAL POR UF E GRUPO SINTÉTICO

            BllDashFaturamentoMesAtualUFSintetico bllDashFaturamentoMesAtualUFSintetico = new BllDashFaturamentoMesAtualUFSintetico();
            bllDashFaturamentoMesAtualUFSintetico.CarregarDashFaturamentoMesAtualUFSinteticoEmDBPromodaDash(bllDashFaturamentoMesAtualUFSintetico.RetornaFaturamentoMesAtualUFSintetico());

            BllDashFaturamentoMesAtualGrupoSintetico bllDashFaturamentoMesAtualGrupoSintetico = new BllDashFaturamentoMesAtualGrupoSintetico();
            bllDashFaturamentoMesAtualGrupoSintetico.CarregarDashFaturamentoMesAtualGrupoSinteticoEmDBPromodaDash(bllDashFaturamentoMesAtualGrupoSintetico.RetornaFaturamentoMesAtualGrupoSintetico());

            BllDashFaturamentoDiaAtualGrupoSintetico bllDashFaturamentoDiaAtualGrupoSintetico = new BllDashFaturamentoDiaAtualGrupoSintetico();
            bllDashFaturamentoDiaAtualGrupoSintetico.CarregarDashFaturamentoDiaAtualGrupoSinteticoEmDBPromodaDash(bllDashFaturamentoDiaAtualGrupoSintetico.RetornaFaturamentoDiaAtualGrupoSintetico());

            #endregion

            #region 20 - DASH SALDO FACCIONISTA SINTÉTICO

            BllSaldoFaccionistaSintetico bllSaldoFaccionistaSintetico = new BllSaldoFaccionistaSintetico();
            bllSaldoFaccionistaSintetico.CarregarDashSaldoFaccionistaSinteticoEmDBPromodaDash(bllSaldoFaccionistaSintetico.RetornaSaldoFaccionistaSintetico());

            #endregion

            #region 21 - KPI FINANCEIRO - FATURAEMENTO HOJE

            BllKPIFinanceiroFaturamentoHoje bllKPIFinanceiroFaturamentoHoje = new BllKPIFinanceiroFaturamentoHoje();

            bllKPIFinanceiroFaturamentoHoje.CarregarNotasEmitidas(bllKPIFinanceiroFaturamentoHoje.RetornaNotasEmitidas());

            bllKPIFinanceiroFaturamentoHoje.CarregarDuplicatasEmitidas(bllKPIFinanceiroFaturamentoHoje.RetornaDuplicatasEmitidas());

            bllKPIFinanceiroFaturamentoHoje.CarregarEntradasAVista(bllKPIFinanceiroFaturamentoHoje.RetornaEntradasAVista());

            #endregion

            #region 22 - KPI FINANCEIRO - PAGAMENTOS

            BllKPIFinanceiroPagamentos bllKPIFinanceiroPagamentos = new BllKPIFinanceiroPagamentos();

            bllKPIFinanceiroPagamentos.CarregarPagamentosOntem(bllKPIFinanceiroPagamentos.RetornaPagamentosOntem());

            bllKPIFinanceiroPagamentos.CarregarPagamentosHoje(bllKPIFinanceiroPagamentos.RetornaPagamentosHoje());

            bllKPIFinanceiroPagamentos.CarregarPagamentosMes(bllKPIFinanceiroPagamentos.RetornaPagamentosMes());

            bllKPIFinanceiroPagamentos.CarregarPagamentosAno(bllKPIFinanceiroPagamentos.RetornaPagamentosAno());

            bllKPIFinanceiroPagamentos.CarregarPagamentosListagemTotalBaixasDiaMesAtual(bllKPIFinanceiroPagamentos.RetornaPagamentosListagemTotalBaixasDiaMesAtual());

            #endregion

            #region 23 - KPI FINANCEIRO - RECEBIMENTOS

            BllKPIFinanceiroRecebimentos bllKPIFinanceiroRecebimentos = new BllKPIFinanceiroRecebimentos();

            bllKPIFinanceiroRecebimentos.CarregarRecebimentosOntem(bllKPIFinanceiroRecebimentos.RetornaRecebimentosOntem());

            bllKPIFinanceiroRecebimentos.CarregarRecebimentosHoje(bllKPIFinanceiroRecebimentos.RetornaRecebimentosHoje());

            bllKPIFinanceiroRecebimentos.CarregarRecebimentosMes(bllKPIFinanceiroRecebimentos.RetornaRecebimentosMes());

            bllKPIFinanceiroRecebimentos.CarregarRecebimentosAno(bllKPIFinanceiroRecebimentos.RetornaRecebimentosAno());

            #endregion

            #region 24 - KPI FINANCEIRO - INADIMPLÊNCIA

            BllKPIFinanceiroInadimplencia bllKPIFinanceiroInadimplencia = new BllKPIFinanceiroInadimplencia();

            bllKPIFinanceiroInadimplencia.CarregarInadimplencia(bllKPIFinanceiroInadimplencia.RetornaInadimplencia());


            #endregion

            #region 25 - KPI FINANCEIRO - PREVISÃO TRIMESTRAL DE SALDO

            BllKPIFinanceiroPrevisaoTrimestralDeSaldo bllKPIFinanceiroPrevisaoTrimestralDeSaldo = new BllKPIFinanceiroPrevisaoTrimestralDeSaldo();

            bllKPIFinanceiroPrevisaoTrimestralDeSaldo.CarregarPrevisaoTrimestralDeSaldo(bllKPIFinanceiroPrevisaoTrimestralDeSaldo.RetornaPrevisaoTrimestralDeSaldo());


            #endregion

            #region 26 -  KPI FINANCEIRO - FLUXO DE CAIXA HOJE

            BllKPIFinanceiroFluxoCaixaHoje bllKPIFinanceiroFluxoCaixaHoje = new BllKPIFinanceiroFluxoCaixaHoje();

            bllKPIFinanceiroFluxoCaixaHoje.CarregarFluxoCaixaHoje(bllKPIFinanceiroFluxoCaixaHoje.RetornaFluxoCaixaHoje());


            #endregion

            #region 27 - REGISTRO INVENTARIO E BAIXA INVENTARIO - TECIDOS

            BllRegistroInventarioTecidos bllRegistroInventarioTecidos = new BllRegistroInventarioTecidos();

            DaoRegistroInventarioTecidos daoRegistroInventarioTecidos = new DaoRegistroInventarioTecidos();
            daoRegistroInventarioTecidos.ProdutoCodigo = "";
            daoRegistroInventarioTecidos.NumeroRolo = "";
            daoRegistroInventarioTecidos.NumeroPeca = "";
            daoRegistroInventarioTecidos.Situacao = "";
            daoRegistroInventarioTecidos.Cor = "";
            daoRegistroInventarioTecidos.Desenho = "";
            daoRegistroInventarioTecidos.Variante = "";
            daoRegistroInventarioTecidos.Categoria = "01";

            bllRegistroInventarioTecidos.CarregaRegistroInventarioTecidosEmDBPromodaDash(bllRegistroInventarioTecidos.RetornaRegistroInventarioTecidos(daoRegistroInventarioTecidos, "SS", "", ""));


            #endregion
        }

        private void carregarDashboardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarregarDashsDeProducao();
        }

        private void timerCarregaDash_Tick(object sender, EventArgs e)
        {
            CarregarDashsDeProducao();
        }

        private void tecelagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProducaoTecelagem frmCrudProducaoTecelagem = new FrmProducaoTecelagem();
            frmCrudProducaoTecelagem.Show();
        }

        private void beneficiamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSituacaoOp frmSituacaoOp = new FrmSituacaoOp();
            frmSituacaoOp.Show();
        }

        private void peçasTecelagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmControladoriaRomaneioTecelagem frmControladoriaRomaneioTecelagem = new FrmControladoriaRomaneioTecelagem();
            frmControladoriaRomaneioTecelagem.Show();
        }

        private void directPrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDirectPrint frmDirectPrint = new FrmDirectPrint();
            frmDirectPrint.Show();
        }

        private void saldoBancarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSaldoBancario frmSaldoBancario = new FrmSaldoBancario();
            frmSaldoBancario.Show();
        }
    }
}
