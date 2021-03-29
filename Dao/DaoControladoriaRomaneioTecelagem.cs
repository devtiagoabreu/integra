using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
    public class DaoControladoriaRomaneioTecelagem
    {
        #region ATRIBUTOS | OBJETOS

        public int Id { get; set; }
        public string Numero { get; set; }
        public string OperadorNumero { get; set; }
        public string RStatus { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracaoStatus { get; set; }
        public int Ativo { get; set; }
       
        #endregion
    }
}
