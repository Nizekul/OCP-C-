using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_com_C_.OCP.ComOCP
{
    public class CalcDiaDasMaes : ICalc
    {
        public decimal ValorPromocao(IProduto produto)
        {
            return produto.Valor - ((produto.Valor * 5) / 100);
        }
    }
}
