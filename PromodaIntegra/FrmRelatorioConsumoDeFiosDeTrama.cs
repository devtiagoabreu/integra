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
    public partial class FrmRelatorioConsumoDeFiosDeTrama : Form
    {
        public FrmRelatorioConsumoDeFiosDeTrama()
        {
            InitializeComponent();
        }

        private void FrmRelatorioConsumoDeFiosDeTrama_Load(object sender, EventArgs e)
        {
            this.uspRelatorioConsumoDeFiosDeTramaTableAdapter.Fill(this.DBPromodaDataSetRelatorioConsumoDeFiosDeTrama.uspRelatorioConsumoDeFiosDeTrama, "01", "*", "*", "000", "01", Convert.ToDateTime(dtpDataInicial.Value.ToShortDateString()), Convert.ToDateTime(dtpDataFinal.Value.ToShortDateString()));
            this.rptRelatorioConsumoDeFiosDeTrama.RefreshReport();
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
            
            this.uspRelatorioConsumoDeFiosDeTramaTableAdapter.Fill(this.DBPromodaDataSetRelatorioConsumoDeFiosDeTrama.uspRelatorioConsumoDeFiosDeTrama, "01", codigoProduto, codigoFio, "000", "01", Convert.ToDateTime(dtpDataInicial.Value.ToShortDateString()), Convert.ToDateTime(dtpDataFinal.Value.ToShortDateString()));
            this.rptRelatorioConsumoDeFiosDeTrama.RefreshReport();
            
            txtCodigoProduto.Text = "";
            codigoFio = "";
        }
    }
}
