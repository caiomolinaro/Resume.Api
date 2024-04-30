namespace Api.Repositories;

public interface IAuthenticateRepository
{
    Task<bool> AuthenticateUserAsync(string email, string password);

    Task<bool> RegisterUserAsync(string email, string password);

    Task LogoutAsync();
}