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
    public partial class FrmSituacaoOp : Form
    {
        public FrmSituacaoOp()
        {
            InitializeComponent();
            AtualizarComboBoxProcesso();
        }

        private void AtualizarComboBoxProcesso()
        {
            BllBeneficiamentoProcesso bllBeneficiamentoProcesso = new BllBeneficiamentoProcesso();
            DaoBeneficiamentoProcessoColecao daoBeneficiamentoProcessoColecao = new DaoBeneficiamentoProcessoColecao();
            daoBeneficiamentoProcessoColecao = bllBeneficiamentoProcesso.RetornaListaDeProcessos("01");
            cbxProcesso.DataSource = null;
            cbxProcesso.DisplayMember = "Descricao";
            cbxProcesso.ValueMember = "Processo";
            cbxProcesso.DataSource = daoBeneficiamentoProcessoColecao;
            cbxProcesso.Update();
            cbxProcesso.Refresh();
        }

        private void btnExibirProcesso_Click(object sender, EventArgs e)
        {
            FrmKanbanBeneficiamento frmKanbanBeneficiamento = new FrmKanbanBeneficiamento(cbxProcesso.Text);
            frmKanbanBeneficiamento.Show();
        }
    }
}
