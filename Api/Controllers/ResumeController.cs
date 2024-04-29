using Api.Entities;
using Api.Entities.ResumeDetails;
using Api.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Api.EndPoints;

[Route("api/[controller]")]
[ApiController]
public class ResumeController(IResumeRepository repository) : ControllerBase
{
    [HttpGet("GetFullResume")]
    public async Task<ActionResult<IEnumerable<ResumeEntity>>> GetFullResumeAsync(CancellationToken cancellationToken)
    {
        var query = await repository.GetFullResumeAsync(cancellationToken);

        if (query is null)
        {
            return NotFound();
        }
        return Ok(query);
    }

    [HttpGet("GetPersonalInfo")]
    public async Task<ActionResult<IEnumerable<PersonalInfo>>> GetPersonalInfoAsync(CancellationToken cancellationToken)
    {
        var query = await repository.GetPersonalInfoAsync(cancellationToken);

        if (query is null)
        {
            return NotFound();
        }
        return Ok(query);
    }

    [HttpGet("GetAboutInfo")]
    public async Task<ActionResult<IEnumerable<AboutInfo>>> GetAboutInfoAsync(CancellationToken cancellationToken)
    {
        var query = await repository.GetAboutAsync(cancellationToken);

        if (query is null)
        {
            return NotFound();
        }
        return Ok(query);
    }

    [HttpGet("GetSkillsAsync")]
    public async Task<ActionResult<IEnumerable<SkillsInfo>>> GetSkillsAsync(CancellationToken cancellationToken)
    {
        var query = await repository.GetSkillAsync(cancellationToken);

        if (query is null)
        {
            return NotFound();
        }
        return Ok(query);
    }

    [HttpGet("GetEducationalBackground")]
    public async Task<ActionResult<IEnumerable<EducationalBackgroundInfo>>> GetEducationalBackgroundAsync(CancellationToken cancellationToken)
    {
        var query = await repository.GetEducationalBackgroundAsync(cancellationToken);

        if (query is null)
        {
            return NotFound();
        }
        return Ok(query);
    }

    [HttpGet("GetProfessionalExperience")]
    public async Task<ActionResult<IEnumerable<EducationalBackgroundInfo>>> GetProfessionalExperienceAsync(CancellationToken cancellationToken)
    {
        var query = await repository.GetProfessionalExperienceAsync(cancellationToken);

        if (query is null)
        {
            return NotFound();
        }
        return Ok(query);
    }

    [HttpGet("GetLanguages")]
    public async Task<ActionResult<IEnumerable<EducationalBackgroundInfo>>> GetLanguagesAsync(CancellationToken cancellationToken)
    {
        var query = await repository.GetLanguageAsync(cancellationToken);

        if (query is null)
        {
            return NotFound();
        }
        return Ok(query);
    }

    [HttpGet("GetCourses")]
    public async Task<ActionResult<IEnumerable<EducationalBackgroundInfo>>> GetCoursesAsync(CancellationToken cancellationToken)
    {
        var query = await repository.GetCoursesAsync(cancellationToken);

        if (query is null)
        {
            return NotFound();
        }
        return Ok(query);
    }

    [HttpGet("GetCertificates")]
    public async Task<ActionResult<IEnumerable<EducationalBackgroundInfo>>> GetCertificatesAsync(CancellationToken cancellationToken)
    {
        var query = await repository.GetCertificatesAsync(cancellationToken);

        if (query is null)
        {
            return NotFound();
        }
        return Ok(query);
    }

    [HttpGet("GetProjects")]
    public async Task<ActionResult<IEnumerable<EducationalBackgroundInfo>>> GetProjectsAsync(CancellationToken cancellationToken)
    {
        var query = await repository.GetProjectsAsync(cancellationToken);

        if (query is null)
        {
            return NotFound();
        }
        return Ok(query);
    }

    [HttpPost("CreateResume")]
    public async Task<ActionResult> CreateResumeAsync([FromBody] ResumeEntity entity, CancellationToken cancellationToken)
    {
        entity.Id = Guid.NewGuid();

        if (entity is null)
        {
            return BadRequest();
        }

        await repository.CreateResumeAsync(entity, cancellationToken);

        return Created("", entity);
    }

    [HttpPut("UpdateResume")]
    public async Task<ActionResult> UpdateResumeAsync([FromBody] ResumeEntity entity, CancellationToken cancellationToken)
    {
        if (entity is null)
        {
            return BadRequest();
        }

        await repository.UpdateResumeAsync(entity, cancellationToken);

        return Ok();
    }

    [HttpDelete("DeleteResume/{id:guid}")]
    public async Task<ActionResult> DeleteResumeAsync(Guid id, CancellationToken cancellationToken)
    {
        await repository.DeleteResumeAsync(id, cancellationToken);

        return NoContent();
    }
}