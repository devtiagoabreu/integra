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
    public partial class FrmProducaoTecelagem : Form
    {
        #region VARIÁVEIS E OBJETOS 

        string operadorNumero = "000000";
        decimal eficienciaManha = 0;
        decimal eficienciaTarde = 0;
        decimal eficienciaNoite = 0;
        decimal eficiencia24hs = 0;
        decimal eficienciaRPMGlobal = 0;

        decimal metragemManha = 0;
        decimal metragemTarde = 0;
        decimal metragemNoite = 0;
        decimal metragem24hs = 0;
        decimal metragemAcumulada = 0;

        decimal metragemLancadaTotalManha = 0;
        decimal metragemLancadaTotalTarde = 0;
        decimal metragemLancadaTotalNoite = 0;
        decimal metragemLancadaTotalTurnos = 0;

        decimal metragemCalculadaManha = 0;
        decimal metragemCalculadaTarde = 0;
        decimal metragemCalculadaNoite = 0;


        #endregion

        public FrmProducaoTecelagem()
        {
            InitializeComponent();

            dgvEficienasMetragens.AutoGenerateColumns = false;
            AtualizarComboBoxTear();
            AtualizarComboBoxOrdem();
            AtualizarComboBoxRoloUrdume();
            cbxRoloUrdume2.Text = "0";
            dtpDataProducao.Value = DateTime.Now.Date.AddDays(-1);
            RetornarMetragensTotalTurnosAnteriores();
            VerificaFolguista();
            AtualizarDgvEficienasMetragens(dtpDataProducao.Value.Date);
        }

        private DateTime RetornoDataInicioMesAtual()
        {
            DateTime dataInicialMesAtual = DateTime.Now.Date;
            string diaAtual = DateTime.Now.Date.Day.ToString();
            string sinalSubtracao = "-";
            int diasAtual = (Convert.ToInt32(sinalSubtracao + diaAtual)) + 1;
            dataInicialMesAtual = dataInicialMesAtual.AddDays(diasAtual);

            return dataInicialMesAtual;
        }

        private void ModoVisualizar()
        {
            cbxTearNumero.Enabled = false;
            ckbTearDuplo.Enabled = false;
            cbxOrdemNumero.Enabled = false;
            cbxRoloUrdume.Enabled = false;
            cbxRoloUrdume2.Enabled = false;
            cbxStatusTear.Enabled = false;
            cbxStatusMotivo.Enabled = false;
            rtxObs.Enabled = false;
            ckbFolguistaManha.Enabled = false;
            ckbFolguistaTarde.Enabled = false;
            ckbFolguistaNoite.Enabled = false;
            txtRPM.Enabled = false;
            txtEficienciaTurnoManha.Enabled = false;
            txtEficienciaTurnoTarde.Enabled = false;
            txtEficienciaTurnoNoite.Enabled = false;
            txtEficiencia24hs.Enabled = false;
            txtMetrosInsert.Enabled = false;
            txtMetrosTurnoManha.Enabled = false;
            txtMetrosTurnoTarde.Enabled = false;
            txtMetrosTurnoNoite.Enabled = false;
            txtMetros24hs.Enabled = false;
            txtCorte.Enabled = false;
            txtMetragemAcumulada.Enabled = false;
            dtpDataProducao.Enabled = false;
            btnGravar.Text = "Voltar";
            btnLimparEficiencias.Enabled = false;
            btnExluir.Enabled = false;
            btnMetrosInsert.Enabled = false;
            btnCarregarEficiencias.Enabled = false;
            dtpDataEficiencias.Enabled = false;
            dtpDataProducao.Enabled = false;
            txtNumeroBatidas.Enabled = false;
            VerificaFolguista();

            this.Text = "Visualizar Produção Tecelagem";

        }

        private void ModoInserir()
        {
            cbxTearNumero.Enabled = true;
            ckbTearDuplo.Enabled = true;
            cbxOrdemNumero.Enabled = true;
            cbxRoloUrdume.Enabled = true;
            cbxRoloUrdume2.Enabled = true;
            cbxStatusTear.Enabled = true;
            cbxStatusMotivo.Enabled = true;
            rtxObs.Enabled = true;
            ckbFolguistaManha.Enabled = true;
            ckbFolguistaTarde.Enabled = true;
            ckbFolguistaNoite.Enabled = true;
            txtRPM.Enabled = true;
            txtEficienciaTurnoManha.Enabled = true;
            txtEficienciaTurnoTarde.Enabled = true;
            txtEficienciaTurnoNoite.Enabled = true;
            txtEficiencia24hs.Enabled = true;
            txtMetrosInsert.Enabled = true;
            txtMetrosTurnoManha.Enabled = true;
            txtMetrosTurnoTarde.Enabled = true;
            txtMetrosTurnoNoite.Enabled = true;
            txtMetros24hs.Enabled = true;
            txtCorte.Enabled = true;
            txtMetragemAcumulada.Enabled = true;
            dtpDataProducao.Enabled = true;
            btnGravar.Text = "Gravar";
            btnLimparEficiencias.Enabled = true;
            btnExluir.Enabled = true;
            btnMetrosInsert.Enabled = true;
            btnCarregarEficiencias.Enabled = true;
            dtpDataEficiencias.Enabled = true;
            dtpDataProducao.Enabled = true;
            txtNumeroBatidas.Enabled = true;
            LimparVariaveis();
            LimparEficiencias();
            LimparMetragemTurnos();
            LimparCampos();
            RetornarMetragensTotalTurnosAnteriores();
            VerificaFolguista();
            cbxTearNumero.Focus();
            cbxOrdemNumero.Focus();
            
            this.Text = "Inserir Produção Tecelagem";
        }

        private void RetornarMetragensTotalTurnosAnteriores()
        {
            DaoProducaoTecelagem daoProducaoTecelagem = new DaoProducaoTecelagem();
            BllProducaoTecelagem bllProducaoTecelagem = new BllProducaoTecelagem();

            daoProducaoTecelagem = bllProducaoTecelagem.RetornaMetragemAcumuladaDoTear(cbxTearNumero.SelectedValue.ToString(), RetornoDataInicioMesAtual(), dtpDataProducao.Value.Date);
            metragemLancadaTotalManha = daoProducaoTecelagem.MetragemManha;
            metragemLancadaTotalTarde = daoProducaoTecelagem.MetragemTarde;
            metragemLancadaTotalNoite = daoProducaoTecelagem.MetragemNoite;
            metragemLancadaTotalTurnos = daoProducaoTecelagem.MetragemLancadaTotalTurnos;

            lblMetragemLancadaTotalManha.Text = daoProducaoTecelagem.MetragemManha.ToString();
            lblMetragemLancadaTotalTarde.Text = daoProducaoTecelagem.MetragemTarde.ToString();
            lblMetragemLancadaTotalNoite.Text = daoProducaoTecelagem.MetragemNoite.ToString();

        }

        private void ManualRetornarNumeroDeBatidas()
        {
            DaoNumeroDeBatidas daoNumeroDeBatidas = new DaoNumeroDeBatidas();
            BllNumeroDeBatidas bllNumeroDeBatidas = new BllNumeroDeBatidas();

            try
            {
                daoNumeroDeBatidas = bllNumeroDeBatidas.RetornaNumeroDeBatidasDoProduto(cbxOrdemNumero.Text);
                txtNumeroBatidas.Text = daoNumeroDeBatidas.Batidas.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível retornar o número de batidas do produto! Erro: " + ex);
            }

        }

        private void RetornarNumeroDeBatidas()
        {
            DaoNumeroDeBatidas daoNumeroDeBatidas = new DaoNumeroDeBatidas();
            BllNumeroDeBatidas bllNumeroDeBatidas = new BllNumeroDeBatidas();

            try
            {
                daoNumeroDeBatidas = bllNumeroDeBatidas.RetornaNumeroDeBatidasDoProduto(cbxOrdemNumero.SelectedValue.ToString());
                txtNumeroBatidas.Text = daoNumeroDeBatidas.Batidas.ToString();
            }
            catch (Exception ex)
            {
                txtNumeroBatidas.Text = "0";
            }
            
        }

        private void VerificaFolguista()
        {
            DaoEscalaFolguista daoEscalaFolguista = new DaoEscalaFolguista();
            BllEscalaFolguista bllEscalaFolguista = new BllEscalaFolguista();

            daoEscalaFolguista = bllEscalaFolguista.RetornaEscalaFoguistaPorData(dtpDataProducao.Value.Date);

            if (daoEscalaFolguista.Data.Equals(dtpDataProducao.Value.Date))
            {
                ckbFolguistaManha.Enabled = false;
                ckbFolguistaTarde.Enabled = false;
                ckbFolguistaNoite.Enabled = false;

                if (daoEscalaFolguista.Turno.Equals("M"))
                {
                    ckbFolguistaManha.Checked = true;
                    ckbFolguistaTarde.Checked = false;
                    ckbFolguistaNoite.Checked = false;
                }
                else if (daoEscalaFolguista.Turno.Equals("T"))
                {
                    ckbFolguistaTarde.Checked = true;
                    ckbFolguistaManha.Checked = false;
                    ckbFolguistaNoite.Checked = false;
                }
                else if (daoEscalaFolguista.Turno.Equals("N"))
                {
                    ckbFolguistaNoite.Checked = true;
                    ckbFolguistaManha.Checked = false;
                    ckbFolguistaTarde.Checked = false;
                }
                else
                {
                    MessageBox.Show("Escala Foguista sem Turno, verifique a escala antes de inserir eficiência!");
                }
                   
            }
            else
            {
                ckbFolguistaManha.Enabled = false;
                ckbFolguistaTarde.Enabled = false;
                ckbFolguistaNoite.Enabled = false;
                ckbFolguistaManha.Checked = false;
                ckbFolguistaTarde.Checked = false;
                ckbFolguistaNoite.Checked = false;
            }
        }

        private void LimparMetragemTurnos()
        {
            txtMetrosInsert.Text = "";
            txtMetrosTurnoManha.Text = "";
            txtMetrosTurnoTarde.Text = "";
            txtMetrosTurnoNoite.Text = "";
            txtMetros24hs.Text = "";
            txtMetragemAcumulada.Text = "";
            txtCorte.Text = "";
        }

        private void LimparCampos()
        {
            rtxObs.Text = "";
            cbxStatusTear.Text = "Trabalhando";
            cbxStatusMotivo.Enabled = false;
            ckbTearDuplo.Checked = false;
            cbxRoloUrdume2.Text = "0";
            txtNumeroBatidas.Text = "";
            txtCorte.Text = "";
        }

        private void LimparEficiencias()
        {
            txtRPM.Text = "";
            txtEficienciaTurnoManha.Text = "";
            txtEficienciaTurnoTarde.Text = "";
            txtEficienciaTurnoNoite.Text = "";
            txtEficiencia24hs.Text = "";
        }

        private void LimparVariaveis()
        {
            metragemLancadaTotalManha = 0;
            metragemLancadaTotalTarde = 0;
            metragemLancadaTotalNoite = 0;
            metragemLancadaTotalTurnos = 0;

            lblMetragemLancadaTotalManha.Text = "0";
            lblMetragemLancadaTotalTarde.Text = "0";
            lblMetragemLancadaTotalNoite.Text = "0";

            

        }

        private void AtualizarComboBoxTear() 
        {
            BllProcessoTear bllProcessoTear = new BllProcessoTear();
            DaoProcessoTearColecao daoProcessoTearColecao = new DaoProcessoTearColecao();
            daoProcessoTearColecao = bllProcessoTear.RetornarDadosProcessoTearEmAberto("Tear", "0"); 
            cbxTearNumero.DataSource = null;
            cbxTearNumero.DisplayMember = "TearDescricao";
            cbxTearNumero.ValueMember = "TearNumero";
            cbxTearNumero.DataSource = daoProcessoTearColecao;
            cbxTearNumero.Update();
            cbxTearNumero.Refresh();
        }
        
        private void AtualizarComboBoxOrdem()
        {
            BllProcessoTear bllProcessoTear = new BllProcessoTear();
            DaoProcessoTearColecao daoProcessoTearColecao = new DaoProcessoTearColecao();
            daoProcessoTearColecao = bllProcessoTear.RetornarDadosProcessoTearEmAberto("Ordem", cbxTearNumero.SelectedValue.ToString()); 
            cbxOrdemNumero.DataSource = null;
            cbxOrdemNumero.DisplayMember = "OrdemNumero";
            cbxOrdemNumero.ValueMember = "OrdemNumero";
            cbxOrdemNumero.DataSource = daoProcessoTearColecao;
            cbxOrdemNumero.Update();
            cbxOrdemNumero.Refresh();
        }

        private void AtualizarComboBoxCor()
        {
            BllProcessoTear bllProcessoTear = new BllProcessoTear();
            DaoProcessoTearColecao daoProcessoTearColecao = new DaoProcessoTearColecao();
            daoProcessoTearColecao = bllProcessoTear.RetornarDadosProcessoTearEmAberto("Cor", cbxTearNumero.SelectedValue.ToString());
            cbxCorNumero.DataSource = null;
            cbxCorNumero.DisplayMember = "CorNumero";
            cbxCorNumero.ValueMember = "CorNumero";
            cbxCorNumero.DataSource = daoProcessoTearColecao;
            cbxCorNumero.Update();
            cbxCorNumero.Refresh();
        }

        private void AtualizarComboBoxDesenho()
        {
            BllProcessoTear bllProcessoTear = new BllProcessoTear();
            DaoProcessoTearColecao daoProcessoTearColecao = new DaoProcessoTearColecao();
            daoProcessoTearColecao = bllProcessoTear.RetornarDadosProcessoTearEmAberto("Desenho", cbxTearNumero.SelectedValue.ToString());
            cbxDesenhoNumero.DataSource = null;
            cbxDesenhoNumero.DisplayMember = "DesenhoNumero";
            cbxDesenhoNumero.ValueMember = "DesenhoNumero";
            cbxDesenhoNumero.DataSource = daoProcessoTearColecao;
            cbxDesenhoNumero.Update();
            cbxDesenhoNumero.Refresh();
        }

        private void AtualizarComboBoxRoloUrdume()
        {
            BllProcessoTear bllProcessoTear = new BllProcessoTear();
            DaoProcessoTearColecao daoProcessoTearColecao = new DaoProcessoTearColecao();
            daoProcessoTearColecao = bllProcessoTear.RetornarDadosProcessoTearEmAberto("RoloUrdume", cbxTearNumero.SelectedValue.ToString());
            cbxRoloUrdume.DataSource = null;
            cbxRoloUrdume.DisplayMember = "RoloUrdume";
            cbxRoloUrdume.ValueMember = "RoloUrdume";
            cbxRoloUrdume.DataSource = daoProcessoTearColecao;
            cbxRoloUrdume.Update();
            cbxRoloUrdume.Refresh();
        }

        private void AtualizarComboBoxRoloUrdume2()
        {
            BllProcessoTear bllProcessoTear = new BllProcessoTear();
            DaoProcessoTearColecao daoProcessoTearColecao = new DaoProcessoTearColecao();
            daoProcessoTearColecao = bllProcessoTear.RetornarDadosProcessoTearEmAberto("RoloUrdume", cbxTearNumero.SelectedValue.ToString());
            cbxRoloUrdume2.DataSource = null;
            cbxRoloUrdume2.DisplayMember = "RoloUrdume";
            cbxRoloUrdume2.ValueMember = "RoloUrdume";
            cbxRoloUrdume2.DataSource = daoProcessoTearColecao;
            cbxRoloUrdume2.Update();
            cbxRoloUrdume2.Refresh();
        }

        private void AtualizarDgvEficienasMetragens(DateTime data)
        {
            BllProducaoTecelagem bllProducaoTecelagem = new BllProducaoTecelagem();
            DaoProducaoTecelagemColecao daoProducaoTecelagemColecao = new DaoProducaoTecelagemColecao();

            daoProducaoTecelagemColecao = bllProducaoTecelagem.RetornarProducaoTecelagemDataCadastro(data.Date);
            
            dgvEficienasMetragens.DataSource = null;
            dgvEficienasMetragens.DataSource = daoProducaoTecelagemColecao;
            dgvEficienasMetragens.Update();
            dgvEficienasMetragens.Refresh();
            dgvEficienasMetragens.Focus();
        
            
        }

        #region EVENTOS

        #region SelectIndexChanged

        private void cbxTearNumero_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarComboBoxOrdem();
            AtualizarComboBoxRoloUrdume();
            dtpDataProducao.Value = DateTime.Now.Date.AddDays(-1);
            RetornarMetragensTotalTurnosAnteriores();
            
            if (cbxTearNumero.Text.Contains("PICANOL"))
                lblMetrosInsert.Text = "Pontos";
            else
                lblMetrosInsert.Text = "Metros";
            AtualizarDgvEficienasMetragens(dtpDataProducao.Value.Date);
            VerificaFolguista();
            RetornarNumeroDeBatidas();
            cbxTearNumero.Focus();
        }

        private void cbxStatusTear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxStatusTear.Text.Equals("Parado"))
            {
                cbxStatusMotivo.Enabled = true;
            }
            else
            {
                cbxStatusMotivo.Enabled = false;
            }
        }

        #endregion
        
        #region KeyPress

        private void txtRPM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                e.Handled = true;

                try
                {
                    eficienciaRPMGlobal = Convert.ToDecimal(txtRPM.Text);
                    txtRPM.Text = eficienciaRPMGlobal.ToString("N2");
                    SendKeys.Send("{tab}");
                }
                catch 
                {
                    MessageBox.Show("Dados Incorretos, insira caracteres numéricos e pressione ENTER!");
                    txtRPM.Text = "";
                    txtRPM.Focus();
                }
                

                
            }
        }

        private void cbxTearNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;

                SendKeys.Send("{tab}");
            }
        }

        private void cbxOrdemNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;

                ManualRetornarNumeroDeBatidas();

                SendKeys.Send("{tab}");
            }
        }

        private void cbxRoloUrdume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;

                SendKeys.Send("{tab}");
            }
        }

        private void cbxStatusTear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;

                SendKeys.Send("{tab}");
            }
        }

        private void cbxStatusMotivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;

                SendKeys.Send("{tab}");
            }
        }

        private void rtxObs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;

                SendKeys.Send("{tab}");
            }
        }

        private void txtEficienciaTurnoManha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;

                try
                {
                    eficienciaManha = Convert.ToDecimal(txtEficienciaTurnoManha.Text);
                    txtEficienciaTurnoManha.Text = eficienciaManha.ToString("N2");
                    SendKeys.Send("{tab}");
                }
                catch 
                {
                    MessageBox.Show("Dados Incorretos, insira caracteres numéricos e pressione ENTER!");
                    txtEficienciaTurnoManha.Text = "";
                    txtEficienciaTurnoManha.Focus();
                }
                
                
                
            }
        }

        private void txtEficienciaTurnoTarde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;

                try
                {
                    eficienciaTarde = Convert.ToDecimal(txtEficienciaTurnoTarde.Text);
                    txtEficienciaTurnoTarde.Text = eficienciaTarde.ToString("N2");
                    SendKeys.Send("{tab}");
                }
                catch 
                {
                    MessageBox.Show("Dados Incorretos, insira caracteres numéricos e pressione ENTER!");
                    txtEficienciaTurnoTarde.Text = "";
                    txtEficienciaTurnoTarde.Focus();
                }
                
                
            }
        }

        private void txtEficienciaTurnoNoite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;

                try
                {
                    eficienciaNoite = Convert.ToDecimal(txtEficienciaTurnoNoite.Text);
                    txtEficienciaTurnoNoite.Text = eficienciaNoite.ToString("N2");
                    eficiencia24hs = (eficienciaManha + eficienciaTarde + eficienciaNoite) / 3;
                    txtEficiencia24hs.Text = eficiencia24hs.ToString("N2");
                    SendKeys.Send("{tab}");
                }
                catch 
                {
                    MessageBox.Show("Dados Incorretos, insira caracteres numéricos e pressione ENTER!");
                    txtEficienciaTurnoNoite.Text = "";
                    txtEficienciaTurnoNoite.Focus();
                }
                
                
               
            }
        }

        private void txtEficiencia24hs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;

                SendKeys.Send("{tab}");
            }
        }

        private void txtMetrosInsert_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;

                if (txtMetrosTurnoManha.Text.Equals(""))
                {
                    
                    try
                    {
                        metragemManha = Convert.ToDecimal(txtMetrosInsert.Text);
                        if (lblMetrosInsert.Text.Contains("Pontos"))
                        {
                            try
                            {
                                decimal pontos = metragemManha;
                                decimal metragem = pontos / Convert.ToDecimal(txtNumeroBatidas.Text);
                                metragemManha = metragem;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Não foi possível converter pontos em metros! erro: " + ex);
                            }
                            
                        }
                        if (metragemManha >= metragemLancadaTotalManha)
                        {
                            metragemCalculadaManha = metragemManha - metragemLancadaTotalManha;
                            txtMetrosTurnoManha.Text = metragemCalculadaManha.ToString("N3");
                            txtMetrosInsert.Text = "";
                            txtMetrosInsert.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Dados Incorretos, verifique metragem inserida, a metragem inserida não pode ser inferior a metragem total do Turno! Metragem Inserida: " + metragemManha.ToString() + " - " + "Metragem Total: " + metragemLancadaTotalManha.ToString());
                            txtMetrosInsert.Text = "";
                            txtMetrosInsert.Focus();
                        }
                        
                    }
                    catch 
                    {
                        MessageBox.Show("Dados Incorretos, insira caracteres numéricos e pressione ENTER!");
                        txtMetrosInsert.Text = "";
                        txtMetrosInsert.Focus();
                    }
                    
                   
                }
                else if (txtMetrosTurnoTarde.Text.Equals(""))
                {

                    try
                    {
                        metragemTarde = Convert.ToDecimal(txtMetrosInsert.Text);
                        if (lblMetrosInsert.Text.Contains("Pontos"))
                        {
                            try
                            {
                                decimal pontos = metragemTarde;
                                decimal metragem = pontos / Convert.ToDecimal(txtNumeroBatidas.Text);
                                metragemTarde = metragem;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Não foi possível converter pontos em metros! erro: " + ex);
                            }

                        }
                        if (metragemTarde >= metragemLancadaTotalTarde)
                        {
                            metragemCalculadaTarde = metragemTarde - metragemLancadaTotalTarde;
                            txtMetrosTurnoTarde.Text = metragemCalculadaTarde.ToString("N3");
                            txtMetrosInsert.Text = "";
                            txtMetrosInsert.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Dados Incorretos, verifique metragem inserida, a metragem inserida não pode ser inferior a metragem total do Turno! Metragem Inserida: " + metragemTarde.ToString() + " - " + "Metragem Total: " + metragemLancadaTotalTarde.ToString());
                            txtMetrosInsert.Text = "";
                            txtMetrosInsert.Focus();
                        }


                    }
                    catch
                    {

                        MessageBox.Show("Dados Incorretos, insira caracteres numéricos e pressione ENTER!");
                        txtMetrosInsert.Text = "";
                        txtMetrosInsert.Focus();
                    }
                    
                }
                else if (txtMetrosTurnoNoite.Text.Equals(""))
                {
                    try
                    {
                        metragemNoite = Convert.ToDecimal(txtMetrosInsert.Text);
                        if (lblMetrosInsert.Text.Contains("Pontos"))
                        {
                            try
                            {
                                decimal pontos = metragemNoite;
                                decimal metragem = pontos / Convert.ToDecimal(txtNumeroBatidas.Text);
                                metragemNoite = metragem;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Não foi possível converter pontos em metros! erro: " + ex);
                            }

                        }
                        if (metragemNoite >= metragemLancadaTotalNoite)
                        {
                            metragemCalculadaNoite = metragemNoite - metragemLancadaTotalNoite;
                            txtMetrosTurnoNoite.Text = metragemCalculadaNoite.ToString("N3");
                            metragem24hs = (metragemCalculadaManha + metragemCalculadaTarde) + metragemCalculadaNoite;
                            metragemAcumulada = metragemLancadaTotalTurnos + metragem24hs;
                            txtMetros24hs.Text = metragem24hs.ToString("N3");
                            txtMetragemAcumulada.Text = metragemAcumulada.ToString("N3");
                            txtMetrosInsert.Text = "";
                            txtMetrosInsert.Focus();
                            SendKeys.Send("{tab}");
                        }
                        else
                        {
                            MessageBox.Show("Dados Incorretos, verifique metragem inserida, a metragem inserida não pode ser inferior a metragem total do Turno! Metragem Inserida: " + metragemNoite.ToString() + " - " + "Metragem Total: " + metragemLancadaTotalNoite.ToString());
                            txtMetrosInsert.Text = "";
                            txtMetrosInsert.Focus();
                        }

                        
                    }
                    catch 
                    {

                        MessageBox.Show("Dados Incorretos, insira caracteres numéricos e pressione ENTER!");
                        txtMetrosInsert.Text = "";
                        txtMetrosInsert.Focus();
                    }
                    
                }

                

            }
        }

        private void btnMetrosInsert_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;

                SendKeys.Send("{tab}");
            }
        }

        private void txtMetrosTurnoManha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;

                SendKeys.Send("{tab}");
            }
        }

        private void txtMetrosTurnoTarde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;

                SendKeys.Send("{tab}");
            }
        }

        private void txtMetrosTurnoNoite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;

                SendKeys.Send("{tab}");
            }
        }

        private void txtMetros24hs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;

                SendKeys.Send("{tab}");
            }
        }

        private void dtpDataProducao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;

                SendKeys.Send("{tab}");
            }
        }

        private void dtpDataEficiencias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;

                SendKeys.Send("{tab}");
            }
        }


        #endregion

        #endregion

        private void btnMetrosInsert_Click(object sender, EventArgs e)
        {
            LimparVariaveis();
            RetornarMetragensTotalTurnosAnteriores();
            txtCorte.Text = "";
            LimparMetragemTurnos();
            txtMetrosInsert.Focus();

        }

        private void dgvEficienasMetragens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
            //Verificar se existe registro selecionado
            if (dgvEficienasMetragens.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum registro selecionado.");
                return;
            }
            //pegar registro selecionado no Grid
            DaoProducaoTecelagem daoProducaoTecelagemSelecionada = (dgvEficienasMetragens.SelectedRows[0].DataBoundItem as DaoProducaoTecelagem);

            lblId.Text = daoProducaoTecelagemSelecionada.Id.ToString();
            lblOperador.Text = daoProducaoTecelagemSelecionada.OperadorNumero.ToString();
            cbxTearNumero.SelectedValue = daoProducaoTecelagemSelecionada.TearNumero;
            cbxOrdemNumero.SelectedValue = daoProducaoTecelagemSelecionada.OrdemNumero;
            cbxRoloUrdume.SelectedValue = daoProducaoTecelagemSelecionada.RoloUrdume;
            cbxRoloUrdume2.SelectedValue = daoProducaoTecelagemSelecionada.RoloUrdume2;
            if (cbxRoloUrdume2.Text.Equals("0") || cbxRoloUrdume2.Text.Equals(""))
                ckbTearDuplo.Checked = false;
            else
                ckbTearDuplo.Checked = true;
            if (daoProducaoTecelagemSelecionada.Equals("1"))
            {
                cbxStatusTear.Text = "Trabalhando";
            }
            else
            {
                cbxStatusTear.Text = "Parado";
            }
            cbxStatusMotivo.Text = daoProducaoTecelagemSelecionada.MotivoSituacao;
            rtxObs.Text = daoProducaoTecelagemSelecionada.Obs;
            txtRPM.Text = daoProducaoTecelagemSelecionada.Rpm.ToString();
            txtEficienciaTurnoManha.Text = daoProducaoTecelagemSelecionada.EficienciaManha.ToString();
            txtEficienciaTurnoTarde.Text = daoProducaoTecelagemSelecionada.EficienciaTarde.ToString();
            txtEficienciaTurnoNoite.Text = daoProducaoTecelagemSelecionada.EficienciaNoite.ToString();
            txtEficiencia24hs.Text = daoProducaoTecelagemSelecionada.Eficiencia24hs.ToString();
            txtMetrosTurnoManha.Text = daoProducaoTecelagemSelecionada.MetragemManha.ToString();
            txtMetrosTurnoTarde.Text = daoProducaoTecelagemSelecionada.MetragemTarde.ToString();
            txtMetrosTurnoNoite.Text = daoProducaoTecelagemSelecionada.MetragemNoite.ToString();
            txtMetros24hs.Text = daoProducaoTecelagemSelecionada.Metragem24hs.ToString();
            txtMetragemAcumulada.Text = daoProducaoTecelagemSelecionada.MetragemAcumulada.ToString();
            dtpDataProducao.Value = daoProducaoTecelagemSelecionada.DataProducao;
            if (daoProducaoTecelagemSelecionada.Folguista.ToString().Equals("M"))
            {
                ckbFolguistaManha.Checked = true;
                ckbFolguistaTarde.Checked = false;
                ckbFolguistaNoite.Checked = false;
            }
            else if (daoProducaoTecelagemSelecionada.Folguista.ToString().Equals("T"))
            {
                ckbFolguistaManha.Checked = false;
                ckbFolguistaTarde.Checked = true;
                ckbFolguistaNoite.Checked = false;
            }
            else if (daoProducaoTecelagemSelecionada.Folguista.ToString().Equals("N"))
            {
                ckbFolguistaManha.Checked = false;
                ckbFolguistaTarde.Checked = false;
                ckbFolguistaNoite.Checked = true;
            }
            else
            {
                ckbFolguistaManha.Checked = false;
                ckbFolguistaTarde.Checked = false;
                ckbFolguistaNoite.Checked = false;
            }    
            ModoVisualizar();

        

          
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (this.Text.Equals("Inserir Produção Tecelagem"))
            {
                
                DaoProducaoTecelagem daoProducaoTecelagem = new DaoProducaoTecelagem();

                daoProducaoTecelagem.OperadorNumero = operadorNumero;
                daoProducaoTecelagem.TearNumero = cbxTearNumero.SelectedValue.ToString();
                daoProducaoTecelagem.OrdemNumero = cbxOrdemNumero.Text.ToString();
                daoProducaoTecelagem.RoloUrdume = cbxRoloUrdume.Text.ToString();
                if (ckbTearDuplo.Checked.Equals(true))
                    daoProducaoTecelagem.RoloUrdume2 = cbxRoloUrdume2.Text.ToString();
                else
                    daoProducaoTecelagem.RoloUrdume2 = "0";
                if (cbxStatusTear.Text.Equals("Parado"))
                {
                    daoProducaoTecelagem.Situacao = 0;
                    daoProducaoTecelagem.MotivoSituacao = cbxStatusMotivo.Text.ToString();
                }
                else
                {
                    daoProducaoTecelagem.Situacao = 1;
                    daoProducaoTecelagem.MotivoSituacao = "OK";
                }
                daoProducaoTecelagem.Obs = rtxObs.Text;
                if (txtRPM.Text.Equals(""))
                    daoProducaoTecelagem.Rpm = Convert.ToDecimal(0.00);
                else
                    daoProducaoTecelagem.Rpm = Convert.ToDecimal(txtRPM.Text);
                if (txtEficienciaTurnoManha.Text.Equals(""))
                    daoProducaoTecelagem.EficienciaManha = Convert.ToDecimal(0.00);
                else
                    daoProducaoTecelagem.EficienciaManha = Convert.ToDecimal(txtEficienciaTurnoManha.Text);
                if (txtEficienciaTurnoTarde.Text.Equals(""))
                    daoProducaoTecelagem.EficienciaTarde = Convert.ToDecimal(0.00);
                else
                    daoProducaoTecelagem.EficienciaTarde = Convert.ToDecimal(txtEficienciaTurnoTarde.Text);
                if (txtEficienciaTurnoNoite.Text.Equals(""))
                    daoProducaoTecelagem.EficienciaNoite = Convert.ToDecimal(0.00);
                else
                    daoProducaoTecelagem.EficienciaNoite = Convert.ToDecimal(txtEficienciaTurnoNoite.Text);
                if (txtEficiencia24hs.Text.Equals(""))
                    daoProducaoTecelagem.Eficiencia24hs = Convert.ToDecimal(0.00);
                else
                    daoProducaoTecelagem.Eficiencia24hs = Convert.ToDecimal(txtEficiencia24hs.Text);
                if (txtEficiencia24hs.Text.Equals(""))
                    daoProducaoTecelagem.Eficiencia24hs = Convert.ToDecimal(0.00);
                else
                    daoProducaoTecelagem.Eficiencia24hs = Convert.ToDecimal(txtEficiencia24hs.Text);
                if (txtMetrosTurnoManha.Text.Equals(""))
                    daoProducaoTecelagem.MetragemManha = Convert.ToDecimal(0.00);
                else
                    daoProducaoTecelagem.MetragemManha = Convert.ToDecimal(txtMetrosTurnoManha.Text);
                if (txtMetrosTurnoTarde.Text.Equals(""))
                    daoProducaoTecelagem.MetragemTarde = Convert.ToDecimal(0.00);
                else
                    daoProducaoTecelagem.MetragemTarde = Convert.ToDecimal(txtMetrosTurnoTarde.Text);

                if (txtMetrosTurnoNoite.Text.Equals(""))
                    daoProducaoTecelagem.MetragemNoite = Convert.ToDecimal(0.00);
                else
                    daoProducaoTecelagem.MetragemNoite = Convert.ToDecimal(txtMetrosTurnoNoite.Text);

                if (txtMetros24hs.Text.Equals(""))
                    daoProducaoTecelagem.Metragem24hs = Convert.ToDecimal(0.00);
                else
                    daoProducaoTecelagem.Metragem24hs = Convert.ToDecimal(txtMetros24hs.Text);
                if (txtMetragemAcumulada.Text.Equals(""))
                    daoProducaoTecelagem.MetragemAcumulada = Convert.ToDecimal(0.00);
                else
                    daoProducaoTecelagem.MetragemAcumulada = Convert.ToDecimal(txtMetragemAcumulada.Text);
                if (txtCorte.Text.Equals(""))
                    daoProducaoTecelagem.Corte = Convert.ToDecimal(0.00);
                else
                    daoProducaoTecelagem.Corte = Convert.ToDecimal(txtCorte.Text);

                daoProducaoTecelagem.DataProducao = dtpDataProducao.Value;
                if ((ckbFolguistaManha.Checked.Equals(false)) && (ckbFolguistaTarde.Checked.Equals(false)) && (ckbFolguistaNoite.Checked.Equals(false)))
                    daoProducaoTecelagem.Folguista = "0";
                else if ((ckbFolguistaManha.Checked.Equals(true)) && (ckbFolguistaTarde.Checked.Equals(false)) && (ckbFolguistaNoite.Checked.Equals(false)))
                    daoProducaoTecelagem.Folguista = "M";
                else if ((ckbFolguistaManha.Checked.Equals(false)) && (ckbFolguistaTarde.Checked.Equals(true)) && (ckbFolguistaNoite.Checked.Equals(false)))
                    daoProducaoTecelagem.Folguista = "T";
                else if ((ckbFolguistaManha.Checked.Equals(false)) && (ckbFolguistaTarde.Checked.Equals(false)) && (ckbFolguistaNoite.Checked.Equals(true)))
                    daoProducaoTecelagem.Folguista = "N";
                else
                    daoProducaoTecelagem.Folguista = "0";

                BllProducaoTecelagem bllProducaoTecelagem = new BllProducaoTecelagem();
                string retorno = bllProducaoTecelagem.Insert(daoProducaoTecelagem);
                try
                {
                    int id = Convert.ToInt32(retorno);
                    cbxTearNumero.Focus();
                    cbxTearNumero.SelectedIndex = cbxTearNumero.SelectedIndex + 1;
                    LimparVariaveis();
                    LimparEficiencias();
                    LimparMetragemTurnos();
                    LimparCampos();
                    txtCorte.Text = "";
                    RetornarMetragensTotalTurnosAnteriores();
                    cbxTearNumero.Focus();
                    cbxOrdemNumero.Focus();
                    cbxTearNumero.Focus();

                }
                catch
                {
                    MessageBox.Show("Não foi possível inserir o registro. Detalhes:  " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbxTearNumero.Focus();
                    cbxTearNumero.SelectedIndex = cbxTearNumero.SelectedIndex + 1;
                    LimparVariaveis();
                    LimparEficiencias();
                    LimparMetragemTurnos();
                    LimparCampos();
                    txtCorte.Text = "";
                    RetornarMetragensTotalTurnosAnteriores();
                    cbxTearNumero.Focus();
                    cbxOrdemNumero.Focus();
                    cbxTearNumero.Focus();
                }

            }
            else if (this.Text.Equals("Alterar Produção Tecelagem"))
            {
                DaoProducaoTecelagem daoProducaoTecelagem = new DaoProducaoTecelagem();

                daoProducaoTecelagem.Id = Convert.ToInt32(lblId.Text);
                daoProducaoTecelagem.OperadorNumero = operadorNumero;
                daoProducaoTecelagem.TearNumero = cbxTearNumero.SelectedValue.ToString();
                daoProducaoTecelagem.OrdemNumero = cbxOrdemNumero.SelectedValue.ToString();
                daoProducaoTecelagem.RoloUrdume = cbxRoloUrdume.SelectedValue.ToString();
                if (daoProducaoTecelagem.Situacao.Equals("Parado"))
                {
                    daoProducaoTecelagem.Situacao = 0;
                    daoProducaoTecelagem.MotivoSituacao = cbxStatusMotivo.SelectedValue.ToString();
                }
                else
                {
                    daoProducaoTecelagem.Situacao = 1;
                    daoProducaoTecelagem.MotivoSituacao = "OK";
                }
                daoProducaoTecelagem.Obs = rtxObs.Text;
                daoProducaoTecelagem.Rpm = Convert.ToDecimal(txtRPM.Text);
                daoProducaoTecelagem.EficienciaManha = Convert.ToDecimal(txtEficienciaTurnoManha.Text);
                daoProducaoTecelagem.EficienciaTarde = Convert.ToDecimal(txtEficienciaTurnoTarde.Text);
                daoProducaoTecelagem.EficienciaNoite = Convert.ToDecimal(txtEficienciaTurnoNoite.Text);
                daoProducaoTecelagem.Eficiencia24hs = Convert.ToDecimal(txtEficiencia24hs.Text);
                daoProducaoTecelagem.MetragemManha = Convert.ToDecimal(txtMetrosTurnoManha.Text);
                daoProducaoTecelagem.MetragemTarde = Convert.ToDecimal(txtMetrosTurnoTarde.Text);
                daoProducaoTecelagem.MetragemNoite = Convert.ToDecimal(txtMetrosTurnoNoite.Text);
                daoProducaoTecelagem.Metragem24hs = Convert.ToDecimal(txtMetros24hs.Text);
                daoProducaoTecelagem.MetragemAcumulada = Convert.ToDecimal(txtMetragemAcumulada.Text);
                daoProducaoTecelagem.Corte = Convert.ToDecimal(txtCorte.Text);
                daoProducaoTecelagem.DataProducao = dtpDataProducao.Value;

                BllProducaoTecelagem bllProducaoTecelagem = new BllProducaoTecelagem();
                string retorno = bllProducaoTecelagem.Insert(daoProducaoTecelagem);
                try
                {
                    cbxTearNumero.Focus();
                    cbxTearNumero.SelectedIndex = cbxTearNumero.SelectedIndex + 1;
                    LimparVariaveis();
                    LimparEficiencias();
                    LimparMetragemTurnos();
                    LimparCampos();
                    RetornarMetragensTotalTurnosAnteriores();
                    cbxTearNumero.Focus();
                    cbxOrdemNumero.Focus();
                }
                catch
                {
                    cbxTearNumero.Focus();
                    cbxTearNumero.SelectedIndex = cbxTearNumero.SelectedIndex + 1;
                    LimparVariaveis();
                    LimparEficiencias();
                    LimparMetragemTurnos();
                    LimparCampos();
                    RetornarMetragensTotalTurnosAnteriores();
                    cbxTearNumero.Focus();
                    cbxOrdemNumero.Focus();
                }
            }
            else if (this.Text.Equals("Visualizar Produção Tecelagem"))
            {
                ModoInserir();
            }
        }

        private void btnLimparEficiencias_Click(object sender, EventArgs e)
        {
            LimparEficiencias();
        }

        private void btnCarregarEficiencias_Click(object sender, EventArgs e)
        {
            AtualizarDgvEficienasMetragens(dtpDataEficiencias.Value.Date);
        }

        private void btnExluir_Click(object sender, EventArgs e)
        {
            //Verificar se existe registro selecionado
            if (dgvEficienasMetragens.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum registro selecionado.");
                return;
            }
            else
            {
                //pegar registro selecionado no Grid
                DaoProducaoTecelagem daoProducaoTecelagemSelecionada = (dgvEficienasMetragens.SelectedRows[0].DataBoundItem as DaoProducaoTecelagem);
                BllProducaoTecelagem bllProducaoTecelagem = new BllProducaoTecelagem();
                bllProducaoTecelagem.Desativar(daoProducaoTecelagemSelecionada);
                AtualizarDgvEficienasMetragens(dtpDataProducao.Value.Date);
            }
            
        }

        private void ckbTearDuplo_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbTearDuplo.Checked.Equals(false))
            {
                cbxRoloUrdume2.Enabled = false;
                cbxRoloUrdume2.Text = "0";
            }
            else
            {
                cbxRoloUrdume2.Enabled = true;
                AtualizarComboBoxRoloUrdume2();
            }


        }

        private void ckbFolguistaManha_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbFolguistaManha.Checked == true)
            {
                ckbFolguistaTarde.Checked = false;
                ckbFolguistaNoite.Checked = false;
            }
        }

        private void ckbFolguistaTarde_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbFolguistaTarde.Checked == true)
            {
                ckbFolguistaManha.Checked = false;
                ckbFolguistaNoite.Checked = false;
            }
        }

        private void ckbFolguistaNoite_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbFolguistaNoite.Checked == true)
            {
                ckbFolguistaManha.Checked = false;
                ckbFolguistaTarde.Checked = false;
            }
        }

        private void ckbTearDuplo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;

                SendKeys.Send("{tab}");
            }
        }

        private void ckbFolguistaManha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;

                SendKeys.Send("{tab}");
            }
        }

        private void ckbFolguistaTarde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;

                SendKeys.Send("{tab}");
            }
        }

        private void ckbFolguistaNoite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;

                SendKeys.Send("{tab}");
            }
        }

        private void cbxRoloUrdume2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;

                SendKeys.Send("{tab}");
            }
        }

        private void dgvEficienasMetragens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbxStatusMotivo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxOrdemNumero_SelectedValueChanged(object sender, EventArgs e)
        {
            RetornarNumeroDeBatidas();
        }

        private void txtNumeroBatidas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;

                SendKeys.Send("{tab}");
            }
        }

        private void txtCorte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;

                SendKeys.Send("{tab}");
            }
        }
    }
}

