using Api.Entities;
using Api.Entities.ResumeDetails;

namespace Api.Repositories;

public class ResumeRepository(NpgsqlDataSourceBuilder npgsqlDataSourceBuilder) : IResumeRepository
{
    public async Task<IEnumerable<ResumeEntity>> GetFullResumeAsync(CancellationToken cancellationToken)
    {
        await using var npgsqlDataSource = npgsqlDataSourceBuilder.Build();
        using var connection = await npgsqlDataSource.OpenConnectionAsync(cancellationToken);
        var query = "SELECT * FROM \"resume\"";
        return await connection.QueryAsync<ResumeEntity>(query);
    }

    public async Task<IEnumerable<PersonalInfo>> GetPersonalInfoAsync(CancellationToken cancellationToken)
    {
        await using var npgsqlDataSource = npgsqlDataSourceBuilder.Build();
        using var connection = await npgsqlDataSource.OpenConnectionAsync(cancellationToken);
        var query = "SELECT name, address, phonenumber, email, linkedin, github FROM \"resume\"";
        var resumeEntities = await connection.QueryAsync<ResumeEntity>(query);

        var personalInfoList = resumeEntities.Select(entity => new PersonalInfo
        {
            Name = entity.Name,
            Address = entity.Address,
            Email = entity.Email,
            Linkedin = entity.Linkedin,
            GitHub = entity.GitHub
        });

        return personalInfoList;
    }

    public async Task<IEnumerable<AboutInfo>> GetAboutAsync(CancellationToken cancellationToken)
    {
        await using var npgsqlDataSource = npgsqlDataSourceBuilder.Build();
        using var connection = await npgsqlDataSource.OpenConnectionAsync(cancellationToken);
        var query = "SELECT about FROM \"resume\"";
        var resumeEntities = await connection.QueryAsync<ResumeEntity>(query);

        var personalInfoList = resumeEntities.Select(entity => new AboutInfo
        {
            About = entity.About
        });

        return personalInfoList;
    }

    public async Task<ResumeEntity> GetSkillAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<ResumeEntity> GetEducationalBackgroundAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<ResumeEntity> GetProfessionalExperienceAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<ResumeEntity> GetLanguageAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<ResumeEntity> GetCoursesAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<ResumeEntity> GetCertificatesAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<ResumeEntity> GetProjectsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ResumeEntity> CreateResumeAsync(ResumeEntity entity)
    {
        throw new NotImplementedException();
    }

    public async Task<ResumeEntity> UpdateResumeAsync(ResumeEntity entity)
    {
        throw new NotImplementedException();
    }

    public async Task<ResumeEntity> DeleteResumeAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}