using Net5Calculadora.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Net5Calculadora.Services
{
    public class CalculadoraService : ICalculadoraService
    {
        private readonly ILogService _logger;

        public CalculadoraService(ILogService logger)
        {
            _logger = logger;
        }

        public Operation Suma(Operation model)
        {
            _logger.LogInformation("Operación Suma para los números {A} y {B}",model.NumberA, model.NumberB);
            model.Result = Math.Round(model.NumberA + model.NumberB,4);
            return model;
        }
        public Operation Multiplicacion(Operation model)
        {
            _logger.LogInformation("Operación Multiplicación para los números {A} y {B}", model.NumberA, model.NumberB);
            model.Result = Math.Round(model.NumberA * model.NumberB, 4);
            return model;
        }
        public Operation Division(Operation model)
        {
            _logger.LogInformation("Operación División para los números {A} y {B}", model.NumberA, model.NumberB);
            if (model.NumberB == 0)
            {
                model.Result = 0;
            } else
            {
                model.Result = Math.Round(model.NumberA / model.NumberB, 4);
            }
            return model;
        }
        public Operation Resta(Operation model)
        {
            _logger.LogInformation("Operación Resta para los números {A} y {B}", model.NumberA, model.NumberB);
            model.Result = Math.Round(model.NumberA - model.NumberB, 4);
            return model;
        }

        
        

        
    }
}
