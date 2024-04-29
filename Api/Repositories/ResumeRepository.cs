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

    public async Task<IEnumerable<SkillsInfo>> GetSkillAsync(CancellationToken cancellationToken)
    {
        await using var npgsqlDataSource = npgsqlDataSourceBuilder.Build();
        using var connection = await npgsqlDataSource.OpenConnectionAsync(cancellationToken);
        var query = "SELECT skills FROM \"resume\"";
        var resumeEntities = await connection.QueryAsync<ResumeEntity>(query);

        var skillsInfoList = resumeEntities.Select(entity => new SkillsInfo
        {
            Skills = entity.Skills
        });

        return skillsInfoList;
    }

    public async Task<IEnumerable<EducationalBackgroundInfo>> GetEducationalBackgroundAsync(CancellationToken cancellationToken)
    {
        await using var npgsqlDataSource = npgsqlDataSourceBuilder.Build();
        using var connection = await npgsqlDataSource.OpenConnectionAsync(cancellationToken);
        var query = "SELECT educationalbackground FROM \"resume\"";
        var resumeEntities = await connection.QueryAsync<ResumeEntity>(query);

        var educationalBackgroundInfoList = resumeEntities.Select(entity => new EducationalBackgroundInfo
        {
            EducationalBackground = entity.EducationalBackground
        });

        return educationalBackgroundInfoList;
    }

    public async Task<IEnumerable<ProfessionalExperienceInfo>> GetProfessionalExperienceAsync(CancellationToken cancellationToken)
    {
        await using var npgsqlDataSource = npgsqlDataSourceBuilder.Build();
        using var connection = await npgsqlDataSource.OpenConnectionAsync(cancellationToken);
        var query = "SELECT professionalexperience FROM \"resume\"";
        var resumeEntities = await connection.QueryAsync<ResumeEntity>(query);

        var professionalExperienceInfoList = resumeEntities.Select(entity => new ProfessionalExperienceInfo
        {
            ProfessionalExperience = entity.ProfessionalExperience
        });

        return professionalExperienceInfoList;
    }

    public async Task<IEnumerable<LanguageInfo>> GetLanguageAsync(CancellationToken cancellationToken)
    {
        await using var npgsqlDataSource = npgsqlDataSourceBuilder.Build();
        using var connection = await npgsqlDataSource.OpenConnectionAsync(cancellationToken);
        var query = "SELECT language FROM \"resume\"";
        var resumeEntities = await connection.QueryAsync<ResumeEntity>(query);

        var languageInfoList = resumeEntities.Select(entity => new LanguageInfo
        {
            Language = entity.Language
        });

        return languageInfoList;
    }

    public async Task<IEnumerable<CoursesInfo>> GetCoursesAsync(CancellationToken cancellationToken)
    {
        await using var npgsqlDataSource = npgsqlDataSourceBuilder.Build();
        using var connection = await npgsqlDataSource.OpenConnectionAsync(cancellationToken);
        var query = "SELECT courses FROM \"resume\"";
        var resumeEntities = await connection.QueryAsync<ResumeEntity>(query);

        var coursesInfoList = resumeEntities.Select(entity => new CoursesInfo
        {
            Courses = entity.Courses
        });

        return coursesInfoList;
    }

    public async Task<IEnumerable<CertificatesInfo>> GetCertificatesAsync(CancellationToken cancellationToken)
    {
        await using var npgsqlDataSource = npgsqlDataSourceBuilder.Build();
        using var connection = await npgsqlDataSource.OpenConnectionAsync(cancellationToken);
        var query = "SELECT certificates FROM \"resume\"";
        var resumeEntities = await connection.QueryAsync<ResumeEntity>(query);

        var certificatesInfoList = resumeEntities.Select(entity => new CertificatesInfo
        {
            Certificates = entity.Certificates
        });

        return certificatesInfoList;
    }

    public async Task<IEnumerable<ProjectsInfo>> GetProjectsAsync(CancellationToken cancellationToken)
    {
        await using var npgsqlDataSource = npgsqlDataSourceBuilder.Build();
        using var connection = await npgsqlDataSource.OpenConnectionAsync(cancellationToken);
        var query = "SELECT projects FROM \"resume\"";
        var resumeEntities = await connection.QueryAsync<ResumeEntity>(query);

        var projectsInfoList = resumeEntities.Select(entity => new ProjectsInfo
        {
            Projects = entity.Projects
        });

        return projectsInfoList;
    }

    public async Task<int> CreateResumeAsync(ResumeEntity resumeEntity, CancellationToken cancellationToken)
    {
        await using var npgsqlDataSource = npgsqlDataSourceBuilder.Build();
        using var connection = await npgsqlDataSource.OpenConnectionAsync(cancellationToken);
        var query = @"INSERT INTO ""resume"" (id, name, address, phonenumber, email, linkedin, github,
                    about, skills, educationalbackground, professionalexperience, language, courses, certificates, projects)
                     VALUES (@Id, @Name, @Address, @PhoneNumber, @Email, @Linkedin, @GitHub, @About, @Skills, @EducationalBackground,
                            @ProfessionalExperience, @Language, @Courses, @Certificates, @Projects)";
        return await connection.ExecuteAsync(query, resumeEntity);
    }

    public async Task<int> UpdateResumeAsync(ResumeEntity resumeEntity, CancellationToken cancellationToken)
    {
        await using var npgsqlDataSource = npgsqlDataSourceBuilder.Build();
        using var connection = await npgsqlDataSource.OpenConnectionAsync(cancellationToken);
        var query = @"UPDATE ""resume"" SET
                        name = @Name,
                        address = @Address,
                        phonenumber = @PhoneNumber,
                        email = @Email,
                        linkedin = @Linkedin,
                        github = @GitHub,
                        about = @About,
                        skills = @Skills,
                        educationalbackground = @EducationalBackground,
                        professionalexperience = @ProfessionalExperience,
                        language = @Language,
                        courses = @Courses,
                        certificates = @Certificates,
                        projects = @Projects
                        WHERE id = @Id";
        return await connection.ExecuteAsync(query, resumeEntity);
    }

    public async Task<int> DeleteResumeAsync(Guid id, CancellationToken cancellationToken)
    {
        await using var npgsqlDataSource = npgsqlDataSourceBuilder.Build();
        using var connection = await npgsqlDataSource.OpenConnectionAsync(cancellationToken);
        var query = "DELETE FROM \"resume\" WHERE id = @Id";
        return await connection.ExecuteAsync(query, new { Id = id });
    }
}