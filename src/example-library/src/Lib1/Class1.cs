namespace Lib1;
public class Class1
{
    private readonly ILogger<Class1> _log;

    public Class1(ILogger<Class1> log)
    {
        _log = log;
    }

    public void LogInfo(string message) => _log.LogInformation(message);
}
