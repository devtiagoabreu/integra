using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class BllRelatorioConsumoDeFiosDeTramaUrdume
    {
        public string TratarCodigoProduto(string codProduto)
        {
            string codProdutoTratado = "";

            int qtdCaracteresCodProduto = 0;

            for (int i = 0; i < codProduto.Length; i++)
            {
                qtdCaracteresCodProduto++;
            }

            if (qtdCaracteresCodProduto == 1)
            {
                codProdutoTratado = "00000" + codProduto;
            }
            else if (qtdCaracteresCodProduto == 2)
            {
                codProdutoTratado = "0000" + codProduto;
            }
            else if (qtdCaracteresCodProduto == 3)
            {
                codProdutoTratado = "000" + codProduto;
            }
            else if (qtdCaracteresCodProduto == 4)
            {
                codProdutoTratado = "00" + codProduto;
            }
            else if (qtdCaracteresCodProduto == 5)
            {
                codProdutoTratado = "0" + codProduto;
            }
            else if (qtdCaracteresCodProduto == 6)
            {
                codProdutoTratado = codProduto;
            }
            else
            {

            }

            return codProdutoTratado;
        }

    }
}
