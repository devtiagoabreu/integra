using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
    public class DaoDashProcessosBeneficiamento
    {
        #region ATRIBUTOS | OBJETOS
               
        public string TipoProcesso { get; set; }
        public string DescricaoTipoProcesso { get; set; }
        public string StatusAtual { get; set; }
        public decimal Metros { get; set; }
       
        #endregion
    }
}
