namespace Api.Entities;

public class RegisterEntity
{
    public string Email { get; set; }
    public string Password { get; set; }

    [Compare("Password", ErrorMessage = "Passwords dont match")]
    public string ConfirmPassword { get; set; }
}