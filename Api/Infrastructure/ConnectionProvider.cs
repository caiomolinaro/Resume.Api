namespace Api.Infrastructure;

public class ConnectionProvider : IConnectionProvider
{
    private const string SqlServerConfiguration = "ConnectionStrings:Postgres";
    private readonly string _connectionString;

    public ConnectionProvider(IConfiguration configuration)
    {
        _connectionString = configuration.GetSection(SqlServerConfiguration).Value!;

        if (string.IsNullOrWhiteSpace(_connectionString))
        {
            throw new ArgumentException(SqlServerConfiguration);
        }
    }

    public async Task<IDbConnection> GetConnectionAsync(CancellationToken cancellationToken)
    {
        var npgsqlConnection = new NpgsqlConnection(_connectionString);
        await npgsqlConnection.OpenAsync(cancellationToken);
        return npgsqlConnection;
    }
}