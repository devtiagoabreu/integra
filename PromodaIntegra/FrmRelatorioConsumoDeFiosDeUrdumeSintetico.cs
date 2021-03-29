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
    public partial class FrmRelatorioConsumoDeFiosDeUrdumeSintetico : Form
    {
        public FrmRelatorioConsumoDeFiosDeUrdumeSintetico()
        {
            InitializeComponent();
        }

        private void FrmRelatorioConsumoDeFiosDeUrdumeSintetico_Load(object sender, EventArgs e)
        {
            this.uspRelatorioConsumoDeFiosDeUrdumeSinteticoTableAdapter.Fill(this.DBPromodaDataSetRelatorioConsumoDeFiosDeUrdumeSintetico.uspRelatorioConsumoDeFiosDeUrdumeSintetico, "01", "*", "*", "000", "01", Convert.ToDateTime(dtpDataInicial.Value.ToShortDateString()), Convert.ToDateTime(dtpDataFinal.Value.ToShortDateString()));
            this.rptRelatorioConsumoDeFiosDeUrdumeSintetico.RefreshReport();
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

            this.uspRelatorioConsumoDeFiosDeUrdumeSinteticoTableAdapter.Fill(this.DBPromodaDataSetRelatorioConsumoDeFiosDeUrdumeSintetico.uspRelatorioConsumoDeFiosDeUrdumeSintetico, "01", codigoProduto, codigoFio, "000", "01", Convert.ToDateTime(dtpDataInicial.Value.ToShortDateString()), Convert.ToDateTime(dtpDataFinal.Value.ToShortDateString()));
            this.rptRelatorioConsumoDeFiosDeUrdumeSintetico.RefreshReport();

            txtCodigoProduto.Text = "";
            codigoFio = "";
        }

        private void rptRelatorioConsumoDeFiosDeUrdumeSintetico_Load(object sender, EventArgs e)
        {

        }
    }
}
