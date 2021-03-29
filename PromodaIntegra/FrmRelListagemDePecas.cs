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
    public partial class FrmRelListagemDePecas : Form
    {
                public FrmRelListagemDePecas()
        {
            InitializeComponent();
          
        }

        private void FrmRelListagemDePecas_Load(object sender, EventArgs e)
        {

        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            string codigoProduto = "";
            BllRelListagemDePecas bllRelListagemDePecas = new BllRelListagemDePecas();

            try
            {
                if (txtCodigoProduto.Text.Equals(""))
                {
                    codigoProduto = "*";
                }
                else
                {
                    codigoProduto = bllRelListagemDePecas.TratarCodigoProduto(txtCodigoProduto.Text);
                }

            }
            catch (Exception)
            {

                throw;
            }
            
            this.uspRelListagemDePecasTableAdapter.Fill(this.DBPromodaDataSetUspRelListagemDePecas.uspRelListagemDePecas,"01", codigoProduto, "000","01",Convert.ToDateTime(dtpDataInicial.Value.ToShortDateString()),Convert.ToDateTime(dtpDataFinal.Value.ToShortDateString()));
            this.rptRelListagemDePecas.RefreshReport();

            txtCodigoProduto.Text = "";
        }

        private void btnIndicadores_Click(object sender, EventArgs e)
        {
            FrmIndicadoresListagemDePecas frmIndicadoresListagemDePecas = new FrmIndicadoresListagemDePecas("relatorio",txtCodigoProduto.Text, dtpDataInicial.Value, dtpDataFinal.Value);
            //frmIndicadoresListagemDePecas.MdiParent = this;
            frmIndicadoresListagemDePecas.Show();
        }
    }
}
