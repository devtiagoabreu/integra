using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
    public class DaoMetas
    {
        #region ATRIBUTOS | OBJETOS

        public int Id { get; set; }
        public int SetorId { get; set; }
        public int GeandezaId { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public int Ativo { get; set; }
           
        #endregion
    }
}
