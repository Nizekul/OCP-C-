using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_com_C_.OCP.SemOCP
{
    public class Produto
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public PromocaoTipo Tipo { get; set; } = PromocaoTipo.Nenhuma;
    }
}
