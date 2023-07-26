using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns._3_Template
{
    public abstract class Relatorio
    {
        protected abstract void Cabecalho();
        protected abstract void Rodape();
        protected abstract void Corpo(IList<ContaBanco> contas);

        public void Imprime(IList<ContaBanco> contas)
        {
            Cabecalho();
            Corpo(contas);
            Rodape();
        }
    }
}
