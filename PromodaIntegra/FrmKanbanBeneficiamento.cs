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
    public partial class FrmKanbanBeneficiamento : Form
    {
        #region ATRIBUTOS | OBJETOS GLOBAIS
        
        int x, y;
        Point point = new Point();
        
        #endregion

        public FrmKanbanBeneficiamento(string processo)
        {
            InitializeComponent();
            dgvProgramadas.AutoGenerateColumns = false;
            dgvEmProducao.AutoGenerateColumns = false;
            dgvFinalizadas.AutoGenerateColumns = false;
            this.Text = processo;
            lblProcesso.Text = processo;
            AtualizarDgvProgramadas(processo);
            AtualizarDgvEmProducao(processo);
            AtualizarDgvFinalizadas(processo);
        }

        private void AtualizarDgvProgramadas(string processo)
        {
            BllDashSituacaoOp bllDashSituacaoOp = new BllDashSituacaoOp();
            DaoDashSituacaoOpColecao daoDashSituacaoOpColecao = new DaoDashSituacaoOpColecao();

            daoDashSituacaoOpColecao = bllDashSituacaoOp.RetornaSituacaoOpKanbanBeneficiamento("01", processo, "P");

            dgvProgramadas.DataSource = null;
            dgvProgramadas.DataSource = daoDashSituacaoOpColecao;
            dgvProgramadas.Update();
            dgvProgramadas.Refresh();
            dgvProgramadas.Focus();

        }

        private void AtualizarDgvEmProducao(string processo)
        {
            BllDashSituacaoOp bllDashSituacaoOp = new BllDashSituacaoOp();
            DaoDashSituacaoOpColecao daoDashSituacaoOpColecao = new DaoDashSituacaoOpColecao();

            daoDashSituacaoOpColecao = bllDashSituacaoOp.RetornaSituacaoOpKanbanBeneficiamento("01", processo, "O");

            dgvEmProducao.DataSource = null;
            dgvEmProducao.DataSource = daoDashSituacaoOpColecao;
            dgvEmProducao.Update();
            dgvEmProducao.Refresh();
            dgvEmProducao.Focus();

        }

        private void AtualizarDgvFinalizadas(string processo)
        {
            BllDashSituacaoOp bllDashSituacaoOp = new BllDashSituacaoOp();
            DaoDashSituacaoOpColecao daoDashSituacaoOpColecao = new DaoDashSituacaoOpColecao();

            daoDashSituacaoOpColecao = bllDashSituacaoOp.RetornaSituacaoOpKanbanBeneficiamento("01", processo, "F");

            dgvFinalizadas.DataSource = null;
            dgvFinalizadas.DataSource = daoDashSituacaoOpColecao;
            dgvFinalizadas.Update();
            dgvFinalizadas.Refresh();
            dgvFinalizadas.Focus();

        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            x = Control.MousePosition.X - this.Location.X;
            y = Control.MousePosition.Y - this.Location.Y;
        }

        private void lblFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblProcesso_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                point = Control.MousePosition;
                point.X -= x;
                point.Y -= y;
                this.Location = point;
                Application.DoEvents();
            }
        }

        private void lblProcesso_MouseDown(object sender, MouseEventArgs e)
        {
            x = Control.MousePosition.X - this.Location.X;
            y = Control.MousePosition.Y - this.Location.Y;
        }

        private void timerUpdateGrids_Tick(object sender, EventArgs e)
        {
            AtualizarDgvProgramadas(this.Text);
            AtualizarDgvEmProducao(this.Text);
            AtualizarDgvFinalizadas(this.Text);
        }

        private void pnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                point = Control.MousePosition;
                point.X -= x;
                point.Y -= y;
                this.Location = point;
                Application.DoEvents();
            }
        }
    }
}
