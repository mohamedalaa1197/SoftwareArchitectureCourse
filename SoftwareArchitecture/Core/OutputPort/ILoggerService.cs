namespace SoftwareArchitecture.Core.OutputPort;

public interface ILoggerService<T> where T : class
{
    void LogError(string errorMessage);
    void LogInfo(string infoMessage);
    void LogDebug(string debugMessage);
}