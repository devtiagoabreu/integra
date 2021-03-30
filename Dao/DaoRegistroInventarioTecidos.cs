using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
    public class DaoRegistroInventarioTecidos
    {
        public string ProdutoCodigo { get; set; }
        public string ProdutoDescricao { get; set; }
        public string NumeroRolo { get; set; }
        public string NumeroPeca { get; set; }
        public string Situacao { get; set; }
        public string Cor { get; set; }
        public string CorDescricao { get; set; }
        public string Desenho { get; set; }
        public string Variante { get; set; }
        public string Categoria { get; set; }
        public decimal Metros { get; set; }
        public decimal Peso { get; set; }
        public decimal CustoMetro { get; set; }
        public decimal CustoMetroOutros { get; set; }
        public decimal CustoTotal { get; set; }
    }
}
