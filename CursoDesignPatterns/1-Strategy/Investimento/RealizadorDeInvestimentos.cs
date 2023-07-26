using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns._1_Strategy.Investimento
{
    public class RealizadorDeInvestimentos
    {
        public void Investimento(ContaBanco conta, Investimento investimento)
        {
            double retorno = investimento.Calcula(conta);
            conta.AddSaldo(retorno * 0.75);
            Console.WriteLine("Novo saldo: " + conta.Saldo);
        }
    }
}
