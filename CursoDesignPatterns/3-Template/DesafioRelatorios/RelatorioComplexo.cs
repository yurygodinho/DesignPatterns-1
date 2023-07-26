using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns._3_Template.Relatorios
{
    public class RelatorioComplexo : Relatorio
    {
        protected override void Cabecalho()
        {
            Console.WriteLine("Banco Exemplo");
            Console.WriteLine("Av. Dos Estados, 9999");
            Console.WriteLine("(11) 99999-9999");
        }

        protected override void Corpo(IList<ContaBanco> contas)
        {
            foreach(ContaBanco contaBanco in contas)
            {
                Console.WriteLine(contaBanco.Nome + " - " + contaBanco.Numero + " - " + contaBanco.Agencia + " - " + contaBanco.Saldo);
            }
        }

        protected override void Rodape()
        {
            Console.WriteLine("bancoexemplo@gmail.com");
            Console.WriteLine(DateTime.Now);
        }
    }
}
