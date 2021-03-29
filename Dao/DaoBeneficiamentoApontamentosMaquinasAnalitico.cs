using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
    public class DaoBeneficiamentoApontamentosMaquinasAnalitico
    {
        public string Maquina { get; set; }
        public string CodProduto { get; set; }
        public string Produto { get; set; }
        public string Situacao { get; set; }
        public string Cor { get; set; }
        public string Desenho { get; set; }
        public string Variante { get; set; }
        public decimal Metros { get; set; }
        public string Status { get; set; }
        public DateTime Data_Inicio { get; set; }
    }
}
