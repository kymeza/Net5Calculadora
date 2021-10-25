namespace Net5Calculadora.Services

{
    public interface ILogService
    {
        void LogInformation(string message, params object[] parameters);
    }
}