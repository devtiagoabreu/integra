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
    public partial class FrmSaldoBancario : Form
    {
        public FrmSaldoBancario()
        {
            InitializeComponent();

            DaoInsertsFinanceiros daoInsertsFinanceiros = new DaoInsertsFinanceiros();
            BllInsertsFinanceiros bllInsertsFinanceiros = new BllInsertsFinanceiros();

            daoInsertsFinanceiros = bllInsertsFinanceiros.RetornaInsertsFinanceiros();

            txtId.Text = daoInsertsFinanceiros.Id.ToString();
            lblSaldoAtual.Text = daoInsertsFinanceiros.SaldoBancarioDia.ToString("C");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DaoInsertsFinanceiros daoInsertsFinanceiros = new DaoInsertsFinanceiros();
            BllInsertsFinanceiros bllInsertsFinanceiros = new BllInsertsFinanceiros();

            daoInsertsFinanceiros.Id = Convert.ToInt32(txtId.Text);
            daoInsertsFinanceiros.SaldoBancarioDia = Convert.ToDecimal(txtNovoSaldo.Text);
                       
            bllInsertsFinanceiros.Update(daoInsertsFinanceiros);

            try
            {
                txtNovoSaldo.Text = "";
                txtNovoSaldo.Focus();
                daoInsertsFinanceiros = bllInsertsFinanceiros.RetornaInsertsFinanceiros();
                txtId.Text = daoInsertsFinanceiros.Id.ToString();
                lblSaldoAtual.Text = daoInsertsFinanceiros.SaldoBancarioDia.ToString("C");
                MessageBox.Show("Registro inserido com sucesso!");
            }
            catch
            {
                MessageBox.Show("Não foi possível inserir o registro. Detalhes:  " , "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNovoSaldo.Text = "";
                txtNovoSaldo.Focus();
            }
        }

        private void txtNovoSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;

                SendKeys.Send("{tab}");
            }
        }
    }
}
