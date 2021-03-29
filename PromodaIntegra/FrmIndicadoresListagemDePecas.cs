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
    public partial class FrmIndicadoresListagemDePecas : Form
    {
        DaoRelListagemDePecas daoRelListagemDePecas = new DaoRelListagemDePecas();
        BllRelListagemDePecas bllRelListagemDePecas = new BllRelListagemDePecas();

        public FrmIndicadoresListagemDePecas(string tipo, string codProduto, DateTime dataInicio, DateTime dataFim)
        {
            InitializeComponent();
                        
            try
            {
                if (codProduto.Equals(""))
                {
                    codProduto = "*";
                }
                else
                {
                    codProduto = bllRelListagemDePecas.TratarCodigoProduto(codProduto);
                }

            }
            catch (Exception)
            {

                throw;
            }

            daoRelListagemDePecas.CodProduto = codProduto;
            daoRelListagemDePecas.DataInicio = dataInicio;
            daoRelListagemDePecas.DataFim = dataFim;
            daoRelListagemDePecas.Tipo = tipo;
        }

        private void CarregarIndicadoresMesAtual()
        {
            if (daoRelListagemDePecas.Tipo.Equals("menu"))
            {
                DateTime dataInicialMesAtual = DateTime.Now.Date;
                string diaAtual = DateTime.Now.Date.Day.ToString();
                string sinalSubtracao = "-";
                int diasAtual = (Convert.ToInt32(sinalSubtracao + diaAtual)) + 1;
                dataInicialMesAtual = dataInicialMesAtual.AddDays(diasAtual);
                dtpDataFinalMesAtual.Value = DateTime.Now.Date;
                dtpDataInicialMesAtual.Value = dataInicialMesAtual;

                this.uspRelListagemDePecasTableAdapter.Fill(this.DBPromodaDataSetUspRelListagemDePecas.uspRelListagemDePecas, "01", "*", "000", "01", Convert.ToDateTime(dtpDataInicialMesAtual.Value.ToShortDateString()), Convert.ToDateTime(dtpDataFinalMesAtual.Value.ToShortDateString()));

                this.rptIndicadoresListagemDePecasDataAtual.RefreshReport();
            }
            else
            {
                this.uspRelListagemDePecasTableAdapter.Fill(this.DBPromodaDataSetUspRelListagemDePecas.uspRelListagemDePecas, "01", daoRelListagemDePecas.CodProduto, "000", "01", Convert.ToDateTime(daoRelListagemDePecas.DataInicio.ToShortDateString()), Convert.ToDateTime(daoRelListagemDePecas.DataFim.ToShortDateString()));

                this.rptIndicadoresListagemDePecasDataAtual.RefreshReport();
            }
            
        }

        private void CarregarIndicadoresMesPassado()
        {
            if (daoRelListagemDePecas.Tipo.Equals("menu"))
            {
                DateTime dataInicialMesPassado = DateTime.Now.Date.AddMonths(-1);
                string diaPassado = dataInicialMesPassado.Date.Day.ToString();
                string sinalSubtracao = "-";
                int diasPassado = (Convert.ToInt32(sinalSubtracao + diaPassado)) + 1;
                dataInicialMesPassado = dataInicialMesPassado.AddDays(diasPassado);
                dtpDataFinalMesPassado.Value = DateTime.Now.Date.AddMonths(-1);
                dtpDataInicialMesPassado.Value = dataInicialMesPassado;


                this.uspRelListagemDePecasTableAdapter.Fill(this.DBPromodaDataSetUspRelListagemDePecas.uspRelListagemDePecas, "01", "*", "000", "01", Convert.ToDateTime(dtpDataInicialMesPassado.Value.ToShortDateString()), Convert.ToDateTime(dtpDataFinalMesPassado.Value.ToShortDateString()));

                this.rptIndicadoresListagemDePecasMesPassado.RefreshReport();
            }
            else
            {
                this.uspRelListagemDePecasTableAdapter.Fill(this.DBPromodaDataSetUspRelListagemDePecas.uspRelListagemDePecas, "01", "*", "000", "01", Convert.ToDateTime(daoRelListagemDePecas.DataInicio.AddMonths(-1).ToShortDateString()), Convert.ToDateTime(daoRelListagemDePecas.DataFim.AddMonths(-1).ToShortDateString()));

                this.rptIndicadoresListagemDePecasMesPassado.RefreshReport();
            }
           
        }

        private void FrmIndicadoresListagemDePecas_Load(object sender, EventArgs e)
        {
           
        }

        private void timerIndicadoresMesAtual_Tick(object sender, EventArgs e)
        {
            CarregarIndicadoresMesAtual();
            timerIndicadoresMesAtual.Enabled = false;
        }

        private void timerIndicadoresMesPassado_Tick(object sender, EventArgs e)
        {
            CarregarIndicadoresMesPassado();
            timerIndicadoresMesPassado.Enabled = false;
        }

        private void timerEnableTimers_Tick(object sender, EventArgs e)
        {
            timerIndicadoresMesAtual.Enabled = true;
            timerIndicadoresMesPassado.Enabled = true;
        }
    }
}
