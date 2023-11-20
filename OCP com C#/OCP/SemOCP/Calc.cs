using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_com_C_.OCP.SemOCP
{
    public static class Calc
    {
        public static decimal ValorPromocao(Produto produto)
        {
            if (produto.Tipo == PromocaoTipo.DiaMaes) return produto.Valor - ((produto.Valor * 5) / 100);
            if (produto.Tipo == PromocaoTipo.DiaPais) return produto.Valor - ((produto.Valor * 10) / 100);
            if (produto.Tipo == PromocaoTipo.Nenhuma) return produto.Valor;

            return produto.Valor;
        }

    }
}
