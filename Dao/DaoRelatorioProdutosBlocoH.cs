using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
    public class DaoRelatorioProdutosBlocoH
    {
        #region ATRIBUTOS | OBJETOS

        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string Cod_ClassFisc { get; set; }
        public string Unidade { get; set; }
        public string Fornecedor { get; set; }
        public string Razao_Social { get; set; }
        public string CNPJ { get; set; }
        public string IE { get; set; }
        public string UF { get; set; }
        public decimal Ultima_Qtde { get; set; }
        public decimal Custo_Unidade { get; set; }
        public decimal Preco_Unidade { get; set; }
        public decimal Preco_Liguido { get; set; }

        #endregion
    }
}
