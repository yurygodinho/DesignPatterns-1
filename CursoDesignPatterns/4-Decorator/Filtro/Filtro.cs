using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns._4_Decorator.Filtro
{
    public abstract class Filtro
    {
        public Filtro() { }

        public Filtro(Filtro outroFiltro)
        {
            this.OutroFiltro = outroFiltro;
        }

        protected Filtro OutroFiltro { get; set; }

        public abstract IList<ContaBanco> Filtra(IList contas);

        protected IList<ContaBanco> Proximo(IList contas)
        {
            if (OutroFiltro != null) return OutroFiltro.Filtra(contas);
            else return new List<ContaBanco>();
        }
    }
}
