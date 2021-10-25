using Net5Calculadora.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Net5Calculadora.Services
{
    public interface ICalculadoraService
    {
        Operation Suma(Operation model);
        Operation Multiplicacion(Operation model);
        Operation Division(Operation model);
        Operation Resta(Operation model);

    }
}
