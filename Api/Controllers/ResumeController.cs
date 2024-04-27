using Api.Entities;
using Api.Entities.ResumeDetails;
using Api.Repositories;
using Microsoft.AspNetCore.Authorization;

namespace Api.EndPoints;

[Route("api/[controller]")]
[ApiController]
public class ResumeController(IResumeRepository respository) : ControllerBase
{
    [HttpGet("GetFullResume")]
    public async Task<ActionResult<IEnumerable<ResumeEntity>>> GetFullResumeAsync(CancellationToken cancellationToken)
    {
        var query = await respository.GetFullResumeAsync(cancellationToken);

        if (query is null)
        {
            return NotFound();
        }
        return Ok(query);
    }

    [HttpGet("GetPersonalInfo")]
    public async Task<ActionResult<IEnumerable<PersonalInfo>>> GetPersonalInfoAsync(CancellationToken cancellationToken)
    {
        var query = await respository.GetPersonalInfoAsync(cancellationToken);

        if (query is null)
        {
            return NotFound();
        }
        return Ok(query);
    }

    [HttpGet("GetAboutInfo")]
    public async Task<ActionResult<IEnumerable<AboutInfo>>> GetAboutInfoAsync(CancellationToken cancellationToken)
    {
        var query = await respository.GetAboutAsync(cancellationToken);

        if (query is null)
        {
            return NotFound();
        }
        return Ok(query);
    }
}