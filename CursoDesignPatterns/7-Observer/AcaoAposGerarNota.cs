﻿using CursoDesignPatterns._6_Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public interface AcaoAposGerarNota
    {
        void Executa(NotaFiscal nf);
    }
}
