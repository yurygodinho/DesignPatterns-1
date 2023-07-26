using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns._5_State.EstadosContaBanco
{
    public interface IEstadoDaConta
    {
        void Saca(ContaBanco conta, double valor);
        void Deposita(ContaBanco conta, double valor);
    }
}
