using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
    public class DaoTearOrdem
    {
        #region ATRIBUTOS | OBJETOS

        public int Id { get; set; }
        public int TearId { get; set; }
        public string TearNumero { get; set; }
        public int OrdemId { get; set; }
        public string OrdemNumero { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataFechamento { get; set; }
        public int Situacao { get; set; }
        public int Ativo { get; set; }

        #endregion


    }
}
