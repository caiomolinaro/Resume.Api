using Api.Entities;
using Api.Entities.ResumeDetails;

namespace Api.Repositories;

public interface IResumeRepository
{
    Task<IEnumerable<ResumeEntity>> GetFullResumeAsync(CancellationToken cancellationToken);

    Task<IEnumerable<PersonalInfo>> GetPersonalInfoAsync(CancellationToken cancellationToken);

    Task<IEnumerable<AboutInfo>> GetAboutAsync(CancellationToken cancellationToken);

    Task<ResumeEntity> GetSkillAsync();

    Task<ResumeEntity> GetEducationalBackgroundAsync();

    Task<ResumeEntity> GetProfessionalExperienceAsync();

    Task<ResumeEntity> GetLanguageAsync();

    Task<ResumeEntity> GetCoursesAsync();

    Task<ResumeEntity> GetCertificatesAsync();

    Task<ResumeEntity> GetProjectsAsync();

    Task<ResumeEntity> CreateResumeAsync(ResumeEntity resumeEntity);

    Task<ResumeEntity> UpdateResumeAsync(ResumeEntity entity);

    Task<ResumeEntity> DeleteResumeAsync(Guid id);
}