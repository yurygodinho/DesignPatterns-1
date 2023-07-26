using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns._5_State.EstadosContaBanco
{
    public class Positivo : IEstadoDaConta
    {
        public void Saca(ContaBanco conta, double valor)
        {
            conta.Saldo -= valor;

            if (conta.Saldo < 0) conta.Estado = new Negativo();
        }

        public void Deposita(ContaBanco conta, double valor)
        {
            conta.Saldo += valor * 0.98;
        }
    }
}
