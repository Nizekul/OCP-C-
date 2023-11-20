using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_com_C_.OCP.ComOCP
{
    public interface IProduto
    {
        string Descricao { get; set; }
        decimal Valor { get; set; }
        ICalc CalcValorPromocional {  get; set; }
    }
}
