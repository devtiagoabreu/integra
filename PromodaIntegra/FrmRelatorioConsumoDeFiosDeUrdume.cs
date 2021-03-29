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
    public partial class FrmRelatorioConsumoDeFiosDeUrdume : Form
    {
        public FrmRelatorioConsumoDeFiosDeUrdume()
        {
            InitializeComponent();
        }

        private void FrmRelatorioConsumoDeFiosDeTramaUrdume_Load(object sender, EventArgs e)
        {
            this.uspRelatorioConsumoDeFiosDeUrdumeTableAdapter.Fill(this.DBPromodaDataRelatorioConsumoDeFiosDeUrdume.uspRelatorioConsumoDeFiosDeUrdume, "01", "*", "*", "000", "01", Convert.ToDateTime(dtpDataInicial.Value.ToShortDateString()), Convert.ToDateTime(dtpDataFinal.Value.ToShortDateString()));
            this.rptRelatorioConsumoDeFiosDeUrdume.RefreshReport();
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            string codigoProduto = "";
            string codigoFio = "";

            BllRelatorioConsumoDeFiosDeTramaUrdume bllRelatorioConsumoDeFiosDeTramaUrdume = new BllRelatorioConsumoDeFiosDeTramaUrdume();

            try
            {
                if (txtCodigoProduto.Text.Equals(""))
                {
                    codigoProduto = "*";
                }
                else
                {
                    codigoProduto = bllRelatorioConsumoDeFiosDeTramaUrdume.TratarCodigoProduto(txtCodigoProduto.Text);
                }

                if (txtCodigoFio.Text.Equals(""))
                {
                    codigoFio = "*";
                }
                else
                {
                    codigoFio = txtCodigoFio.Text;
                }

            }
            catch (Exception)
            {

                throw;
            }
            
            this.uspRelatorioConsumoDeFiosDeUrdumeTableAdapter.Fill(this.DBPromodaDataRelatorioConsumoDeFiosDeUrdume.uspRelatorioConsumoDeFiosDeUrdume, "01", codigoProduto, codigoFio, "000", "01", Convert.ToDateTime(dtpDataInicial.Value.ToShortDateString()), Convert.ToDateTime(dtpDataFinal.Value.ToShortDateString()));
            this.rptRelatorioConsumoDeFiosDeUrdume.RefreshReport();

            txtCodigoProduto.Text = "";
            codigoFio = "";


        }

        private void btnSintetico_Click(object sender, EventArgs e)
        {

        }
    }
}
