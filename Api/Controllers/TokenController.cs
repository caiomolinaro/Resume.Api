using Api.Entities;
using Api.Identity;
using Api.Repositories;

namespace Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TokenController : ControllerBase
{
    private readonly IAuthenticateRepository _authenticate;
    private readonly IConfiguration _configuration;

    public TokenController(IAuthenticateRepository authenticate, IConfiguration configuration)
    {
        _authenticate = authenticate;
        _configuration = configuration;
    }

    //[ApiExplorerSettings(IgnoreApi = true)]
    [HttpPost("LoginUser")]
    public async Task<ActionResult<UserToken>> LoginAsync([FromBody] LoginEntity entity)
    {
        var result = await _authenticate.AuthenticateUserAsync(entity.Email, entity.Password);

        if (result)
        {
            return GenerateToken(entity);
        }
        else
        {
            ModelState.AddModelError(string.Empty, "Invalid login");
            return BadRequest(ModelState);
        }
    }

    //[ApiExplorerSettings(IgnoreApi = true)]
    [Authorize]
    [HttpPost("CreateUser")]
    public async Task<ActionResult> RegisterAsync([FromBody] RegisterEntity entity)
    {
        var result = await _authenticate.RegisterUserAsync(entity.Email, entity.Password);

        if (result)
        {
            return Ok("User created");
        }
        else
        {
            ModelState.AddModelError(string.Empty, "Invalid register");
            return BadRequest(ModelState);
        }
    }

    private UserToken GenerateToken(LoginEntity entity)
    {
        var claims = new[]
        {
            new Claim("email", entity.Email),
            new Claim("myvalue", "idkismyvalue"),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };

        var privateKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:SecretKey"]));

        var credentials = new SigningCredentials(privateKey, SecurityAlgorithms.HmacSha256);

        var expiration = DateTime.UtcNow.AddMinutes(10);

        JwtSecurityToken token = new JwtSecurityToken(
            issuer: _configuration["Jwt:Issuer"],
            audience: _configuration["Jwt:Audience"],
            claims: claims,
            expires: expiration,
            signingCredentials: credentials
            );

        return new UserToken()
        {
            Token = new JwtSecurityTokenHandler().WriteToken(token),
            Expiration = expiration
        };
    }
}