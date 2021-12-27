namespace Pentago.Services.Engine;

/// <summary>
/// This class is a default implementation of the <see cref="IEngineService"/> interface.
/// </summary>
/// <inheritdoc cref="IEngineService"/>
public class EngineService : IEngineService
{
    private readonly string _connectionString;

    public EngineService(string connectionString)
    {
        _connectionString = connectionString;
    }
}