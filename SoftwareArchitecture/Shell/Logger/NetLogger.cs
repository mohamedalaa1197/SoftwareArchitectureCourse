using SoftwareArchitecture.Core.OutputPort;

namespace SoftwareArchitecture.Shell.Logger;

public class NetLogger<T> : ILoggerService<T> where T : class
{
    private readonly ILogger<T> _logger;

    public NetLogger(ILogger<T> logger)
    {
        _logger = logger;
    }

    public void LogError(string errorMessage)
    {
        _logger.LogError(errorMessage);
    }

    public void LogInfo(string infoMessage)
    {
        _logger.LogInformation(infoMessage);
    }

    public void LogDebug(string debugMessage)
    {
        _logger.LogDebug(debugMessage);
    }
}