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
    public partial class FrmControladoriaRomaneioTecelagem : Form
    {
        #region VARIÁVEIS
        public string operadorNumero = "000000";

        #endregion

        public void AtivaPecasDoGrid()
        {
            BllControladoriaPecaTecelagem bllControladoriaPecaTecelagem = new BllControladoriaPecaTecelagem();
            
            int total = dgvPecasRomaneio.Rows.Count;
            int i;

            for (i = 0; i < total; i++)
            {
                DaoControladoriaPecaTecelagem daoControladoriaPecaTecelagem = new DaoControladoriaPecaTecelagem();
                daoControladoriaPecaTecelagem.Id = Convert.ToInt32(dgvPecasRomaneio.Rows[i].Cells[0].Value);
                daoControladoriaPecaTecelagem.ControladoriaRomaneioTecelagemId = Convert.ToInt32(dgvPecasRomaneio.Rows[i].Cells[1].Value);
                daoControladoriaPecaTecelagem.OperadorNumero = dgvPecasRomaneio.Rows[i].Cells[2].Value.ToString();
                daoControladoriaPecaTecelagem.Numero = dgvPecasRomaneio.Rows[i].Cells[3].Value.ToString();
                bllControladoriaPecaTecelagem.Ativar(daoControladoriaPecaTecelagem);
            }
        }

        public void CancelarPecasDoGrid()
        {
            BllControladoriaPecaTecelagem bllControladoriaPecaTecelagem = new BllControladoriaPecaTecelagem();

            int total = dgvPecasRomaneio.Rows.Count;
            int i;

            for (i = 0; i < total; i++)
            {
                DaoControladoriaPecaTecelagem daoControladoriaPecaTecelagem = new DaoControladoriaPecaTecelagem();
                daoControladoriaPecaTecelagem.Id = Convert.ToInt32(dgvPecasRomaneio.Rows[i].Cells[0].Value);
                daoControladoriaPecaTecelagem.Numero = dgvPecasRomaneio.Rows[i].Cells[3].Value.ToString();

                bllControladoriaPecaTecelagem.Deletar(daoControladoriaPecaTecelagem);
            }
        }

        public void CancelarRomaneio()
        {
            BllControladoriaRomaneioTecelagem bllControladoriaRomaneioTecelagem = new BllControladoriaRomaneioTecelagem();
            DaoControladoriaRomaneioTecelagem daoControladoriaRomaneioTecelagem = new DaoControladoriaRomaneioTecelagem();
            daoControladoriaRomaneioTecelagem.Id = Convert.ToInt32(txtId.Text);
            daoControladoriaRomaneioTecelagem.Numero = lblNumeroRomaneio.Text;
            string retorno = bllControladoriaRomaneioTecelagem.Deletar(daoControladoriaRomaneioTecelagem);
            try
            {
                int id = Convert.ToInt32(retorno);

                MessageBox.Show("Romaneio cancelado com sucesso! ID: " + id.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível deletar o Romaneio. Erro: " + ex);
            }
        }
        
        public void AtivaRomaneio()
        {
            BllControladoriaRomaneioTecelagem bllControladoriaRomaneioTecelagem = new BllControladoriaRomaneioTecelagem();
            DaoControladoriaRomaneioTecelagem daoControladoriaRomaneioTecelagem = new DaoControladoriaRomaneioTecelagem();
            daoControladoriaRomaneioTecelagem.Id = Convert.ToInt32(txtId.Text);
            daoControladoriaRomaneioTecelagem.OperadorNumero = operadorNumero;
            try
            {
                bllControladoriaRomaneioTecelagem.Ativar(daoControladoriaRomaneioTecelagem);
                //lblNumeroRomaneio.ForeColor = Color.DeepSkyBlue;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não Foi possível Ativar o Romaneio. Erro: " + ex);
            }
            
        }

        public FrmControladoriaRomaneioTecelagem()
        {
            InitializeComponent();

            dgvPecasRomaneio.AutoGenerateColumns = false;
        }

        private void AtualizarDgvPecasRomaneio(int romaneioId)
        {
            BllControladoriaPecaTecelagem bllControladoriaPecaTecelagem = new BllControladoriaPecaTecelagem();
            DaoControladoriaPecaTecelagemColecao daoControladoriaPecaTecelagemColecao = new DaoControladoriaPecaTecelagemColecao();

            daoControladoriaPecaTecelagemColecao = bllControladoriaPecaTecelagem.RetornarControladoriaPecaTecelagemDoRomaneio(romaneioId);

            dgvPecasRomaneio.DataSource = null;
            dgvPecasRomaneio.DataSource = daoControladoriaPecaTecelagemColecao;
            dgvPecasRomaneio.Update();
            dgvPecasRomaneio.Refresh();
   


        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
                if (this.Text.Equals("Inserir Controladoria Romaneio Tecelagem"))
                {
                    if (txtId.Text.Equals(""))
                    {
                        BllControladoriaRomaneioTecelagem bllControladoriaRomaneioTecelagem = new BllControladoriaRomaneioTecelagem();
                        DaoControladoriaRomaneioTecelagem daoControladoriaRomaneioTecelagem = new DaoControladoriaRomaneioTecelagem();
                        int ultimoNumero = Convert.ToInt32(bllControladoriaRomaneioTecelagem.RetornaControladoriaRomaneioTecelagemUltimoNumero());
                        int numeroAtual = ultimoNumero + 1;
                        daoControladoriaRomaneioTecelagem.Numero = numeroAtual.ToString();
                        daoControladoriaRomaneioTecelagem.OperadorNumero = operadorNumero;
                                           
                        string retorno = bllControladoriaRomaneioTecelagem.Insert(daoControladoriaRomaneioTecelagem);
                        try
                        {
                            int id = Convert.ToInt32(retorno);
                            txtId.Text = retorno;
                            lblNumeroRomaneio.Text = daoControladoriaRomaneioTecelagem.Numero;
                            AtualizarDgvPecasRomaneio(Convert.ToInt32(txtId.Text));
                            e.Handled = true;
                            SendKeys.Send("{tab}");
                        
                        }
                        catch
                        {
                            MessageBox.Show("Não foi possível inserir o registro. Detalhes:  " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtId.Focus();
                        }

                    }
                    else
                    {
                        try
                        {

                            BllControladoriaRomaneioTecelagem bllControladoriaRomaneioTecelagem = new BllControladoriaRomaneioTecelagem();
                            DaoControladoriaRomaneioTecelagem daoControladoriaRomaneioTecelagem = new DaoControladoriaRomaneioTecelagem();
                            daoControladoriaRomaneioTecelagem = bllControladoriaRomaneioTecelagem.RetornaControladoriaRomaneioTecelagemPorId(Convert.ToInt32(txtId.Text));
                            if (daoControladoriaRomaneioTecelagem.Numero == null)
                            {
                                txtId.Text = "";
                                lblNumeroRomaneio.Text = "";
                                AtualizarDgvPecasRomaneio(Convert.ToInt32(txtId.Text));
                                txtId.Focus();
                            }
                            else
                            {
                                lblNumeroRomaneio.Text = daoControladoriaRomaneioTecelagem.Numero;
                                e.Handled = true;
                                SendKeys.Send("{tab}");
                                AtualizarDgvPecasRomaneio(Convert.ToInt32(txtId.Text));
                            }
                            
                            
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Este código de romaneio não existe.");
                            AtualizarDgvPecasRomaneio(0);
                            txtId.Focus();
                        }
                       
                    }



                }
                
            }
        }

        private void txtNumeroPeca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (this.Text.Equals("Inserir Controladoria Romaneio Tecelagem"))
                {
                    if (!txtNumeroPeca.Text.Equals(""))
                    {
                        DaoControladoriaPecaTecelagem daoControladoriaPecaTecelagem = new DaoControladoriaPecaTecelagem();
                        daoControladoriaPecaTecelagem.ControladoriaRomaneioTecelagemId = Convert.ToInt32(txtId.Text);
                        daoControladoriaPecaTecelagem.OperadorNumero = operadorNumero;
                        daoControladoriaPecaTecelagem.Numero = txtNumeroPeca.Text;



                        BllControladoriaPecaTecelagem bllControladoriaPecaTecelagem = new BllControladoriaPecaTecelagem();
                        string retorno = bllControladoriaPecaTecelagem.Insert(daoControladoriaPecaTecelagem);
                        try
                        {
                            int id = Convert.ToInt32(retorno);
                            AtualizarDgvPecasRomaneio(Convert.ToInt32(txtId.Text));
                            txtNumeroPeca.Text = "";
                            txtNumeroPeca.Focus();

                        }
                        catch
                        {
                            MessageBox.Show("Não foi possível inserir o registro. Detalhes:  " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtNumeroPeca.Text = "";
                            txtNumeroPeca.Focus();
                        }
                    }

                    
                }
                
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            AtivaRomaneio();
            AtivaPecasDoGrid();
            AtualizarDgvPecasRomaneio(Convert.ToInt32(txtId.Text));
        }

        private void dgvPecasRomaneio_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvPecasRomaneio.Columns[e.ColumnIndex].Name == "ativo")
            {
                if (e.Value != null && (int)e.Value == 1)
                {
                    //e.CellStyle.BackColor = Color.ForestGreen;
                    DataGridViewRow row = dgvPecasRomaneio.Rows[e.RowIndex];
                    row.DefaultCellStyle.ForeColor = Color.White;
                    row.DefaultCellStyle.BackColor = Color.DodgerBlue;
                }
                
            }
         }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CancelarPecasDoGrid();
            CancelarRomaneio();
            AtualizarDgvPecasRomaneio(Convert.ToInt32(txtId.Text));
            txtId.Text = "";
            txtId.Enabled = true;
            txtId.Focus();
            lblNumeroRomaneio.Text = "";
            lblNumeroRomaneio.ForeColor = Color.DarkRed;
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvPecasRomaneio.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum registro selecionado.");
                return;
            }
            else
            {
                //pegar registro selecionado no Grid
                DaoControladoriaPecaTecelagem daoControladoriaPecaTecelagem = (dgvPecasRomaneio.SelectedRows[0].DataBoundItem as DaoControladoriaPecaTecelagem);
                BllControladoriaPecaTecelagem bllControladoriaPecaTecelagem = new BllControladoriaPecaTecelagem();
                bllControladoriaPecaTecelagem.Deletar(daoControladoriaPecaTecelagem);
                AtualizarDgvPecasRomaneio(Convert.ToInt32(txtId.Text));
            }
        }
    }
}
