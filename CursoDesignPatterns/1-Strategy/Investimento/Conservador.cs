using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns._1_Strategy.Investimento
{
    public class Conservador : Investimento
    {
        public double Calcula(ContaBanco conta)
        {
            return conta.Saldo * 0.008;
        }
    }
}
