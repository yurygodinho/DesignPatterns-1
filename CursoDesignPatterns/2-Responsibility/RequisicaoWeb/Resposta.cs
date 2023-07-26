using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns._2_Responsibility.RequisicaoWeb
{
    public interface Resposta
    {
        void Responde(Requisicao req, ContaBanco conta);
    }
}
