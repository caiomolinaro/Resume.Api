namespace Api.Infrastructure;

public interface IConnectionProvider
{
    Task<IDbConnection> GetConnectionAsync(CancellationToken cancellationToken);
}