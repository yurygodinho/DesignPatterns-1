using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns._1_Strategy.Investimento
{
    public class Arrojado : Investimento
    {
        private Random random;

        public Arrojado()
        {
            random = new Random();
        }
        public double Calcula(ContaBanco conta)
        {
            int chance = random.Next(10);

            if (chance >= 0 && chance <= 1)
            {
                return conta.Saldo * 0.5;
            }
            else if (chance >= 2 && chance <= 4)
            {
                return conta.Saldo * 0.3;
            }
            else
            {
                return conta.Saldo * 0.006;
            }
        }
    }
}
