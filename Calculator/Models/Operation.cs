using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Net5Calculadora.Models
{
    public class Operation
    {
        [Display(Name = "Primer Numero")]
        public double NumberA { get; set; }

        [Display(Name = "Segundo Numero")]
        public double NumberB { get; set; }

        [Display(Name = "Resultado")]
        public double Result { get; set; }

        [Display(Name = "Operacion")]
        public OperationType OperationType { get; set; }
    }
}
