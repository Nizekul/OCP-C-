using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_com_C_.OCP.ComOCP
{
    public class ProdutoDiaDosPais : IProduto
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public ICalc CalcValorPromocional { get; set; } = new CalcDiaDosPais();
    }
}
