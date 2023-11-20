using OCP_com_C_.OCP.ComOCP;
using OCP_com_C_.OCP.SemOCP;

namespace OCP_com_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            //SemOCP();
            ComOCP();
        }

        private static void SemOCP()
        {
            var produtos = new List<Produto>
            {
                new Produto()
                {
                    Descricao = "Monitor",
                    Valor = 1000,
                    Tipo = PromocaoTipo.DiaPais
                },

                new Produto()
                {
                    Descricao = "Monitor",
                    Valor = 1000,
                    Tipo = PromocaoTipo.DiaMaes
                }
            };

            foreach (var prod in produtos)
            {
                Console.WriteLine($"Descrição: {prod.Descricao} \nValor: {prod.Valor}\nPromocao: {Calc.ValorPromocao(prod)}\n\n");
            }
            Console.ReadKey();
        }

        private static void ComOCP()
        {
            var produtos = new List<IProduto>
            {
                new ProdutoDiaDosPais()
                {
                    Descricao = "Monitor",
                    Valor = 1000
                },

                new ProdutoDiaDasMaes()
                {
                    Descricao = "Monitor",
                    Valor = 1000
                }
            };

            foreach (var prod in produtos)
            {
                Console.WriteLine($"Descrição: {prod.Descricao} \nValor: {prod.Valor}\nPromocao: {prod.CalcValorPromocional.ValorPromocao(prod)}\n\n");
            }
        }

    }
}