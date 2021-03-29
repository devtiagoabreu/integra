using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao
{
    public class DaoControladoriaPecaTecelagem
    {
        #region ATRIBUTOS | OBJETOS

        public int Id { get; set; }
        public int ControladoriaRomaneioTecelagemId { get; set; }
        public string OperadorNumero { get; set; }
        public string Numero { get; set; }
        public string Nro_Rolo { get; set; }
        public string Nro_Peca { get; set; }
        public decimal Metros { get; set; }
        public DateTime DataCadastro { get; set; }
        public int Ativo { get; set; }

        #endregion
    }
}
