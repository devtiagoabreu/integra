using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
    public class DaoProducaoTecelagem
    {
        #region ATRIBUTOS | OBJETOS

        public int Id { get; set; }
        public string OperadorNumero { get; set; }
        public string TearNumero { get; set; }
        public string OrdemNumero { get; set; }
        public string RoloUrdume { get; set; }
        public string RoloUrdume2 { get; set; }
        public int Situacao { get; set; }
        public string MotivoSituacao { get; set; }
        public string Obs { get; set; }
        public decimal Rpm { get; set; }
        public decimal EficienciaManha { get; set; }
        public decimal EficienciaTarde { get; set; }
        public decimal EficienciaNoite { get; set; }
        public decimal Eficiencia24hs { get; set; }
        public decimal MetragemManha { get; set; }
        public decimal MetragemTarde { get; set; }
        public decimal MetragemNoite { get; set; }
        public decimal Metragem24hs { get; set; }
        public decimal MetragemAcumulada { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataProducao { get; set; }
        public int Ativo { get; set; }
        public string Folguista { get; set; }
        public decimal EficienciaFolguista { get; set; }
        public decimal MetragemFolguista { get; set; }
        public decimal MetragemLancadaTotalTurnos { get; set; }
        public decimal Corte { get; set; }




        #endregion
    }
}
