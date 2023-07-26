using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns._3_Template.Relatorios
{
    public class RelatorioSimples : Relatorio
    {
        protected override void Cabecalho()
        {
            Console.WriteLine("Banco Exemplo");
        }

        protected override void Rodape()
        {
            Console.WriteLine("(11) 99999-9999");
        }

        protected override void Corpo(IList<ContaBanco> contas)
        {
            foreach (ContaBanco c in contas)
            {
                Console.WriteLine(c.Nome + " - " + c.Saldo);
            }
        }
    }
}
