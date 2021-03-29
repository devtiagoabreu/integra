using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
    public class DaoDashBeneficiamentoProducao
    {
        #region ATRIBUTOS | OBJETOS

        
        public decimal PreparacaoEmOperacao { get; set; }
        public decimal PreparacaoFinalizadaDia { get; set; }
        public decimal PreparacaoFinalizadaMes { get; set; }

        public decimal TingimentoEmOperacao { get; set; }
        public decimal TingimentoFinalizadoDia { get; set; }
        public decimal TingimentoFinalizadoMes { get; set; }

        public decimal EstampariaEmOperacao { get; set; }
        public decimal EstampariaFinalizadaDia { get; set; }
        public decimal EstampariaFinalizadaMes { get; set; }

        public decimal AcabamentoEmOperacao { get; set; }
        public decimal AcabamentoFinalizadoDia { get; set; }
        public decimal AcabamentoFinalizadoMes { get; set; }

        public decimal RevisaoEmOperacao { get; set; }
        public decimal RevisaoFinalizadaDia { get; set; }
        public decimal RevisaoFinalizadaMes { get; set; }

        #endregion
                              
    }
}
