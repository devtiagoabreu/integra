using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
    public class DaoKPIFinanceiroFluxoCaixaHoje
    {
        public int QtdPagamentos { get; set; }
        public decimal ValorPagamentos { get; set; }
        public int QtdRecebimentos { get; set; }
        public decimal ValorRecebimentos { get; set; }
        public decimal VLP { get; set; }
    }
}
