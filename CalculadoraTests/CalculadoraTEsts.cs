using Moq;
using Net5Calculadora.Models;
using Net5Calculadora.Services;
using NUnit.Framework;

namespace CalculadoraTests
{
    [TestFixture]
    public class CalculadoraTests
    {
        private readonly CalculadoraService _calculadoraService;

        private readonly Mock<ILogService> _loggerMock = new Mock<ILogService>();

        public CalculadoraTests()
        {
            _calculadoraService = new CalculadoraService(_loggerMock.Object);
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CalculadoraService_Suma_10suma10()
        {
            Operation model = new Operation();
            model.NumberA = 10;
            model.NumberB = 10;
            model.OperationType = OperationType.Suma;
            model = _calculadoraService.Suma(model);
            Assert.AreEqual(20, model.Result);
        }
        [Test]
        public void CalculadoraService_Resta_10suma10()
        {
            Operation model = new Operation();
            model.NumberA = 10;
            model.NumberB = 10;
            model.OperationType = OperationType.Resta;
            model = _calculadoraService.Resta(model);
            Assert.AreEqual(0, model.Result);
        }
        [Test]
        public void CalculadoraService_Multiplicacion_10suma10()
        {
            Operation model = new Operation();
            model.NumberA = 10;
            model.NumberB = 10;
            model.OperationType = OperationType.Multiplicacion;
            model = _calculadoraService.Multiplicacion(model);
            Assert.AreEqual(100, model.Result);
        }
        [Test]
        public void CalculadoraService_Division_10suma10()
        {
            Operation model = new Operation();
            model.NumberA = 10;
            model.NumberB = 10;
            model.OperationType = OperationType.Division;
            model = _calculadoraService.Division(model);
            Assert.AreEqual(1, model.Result);
        }


    }
}