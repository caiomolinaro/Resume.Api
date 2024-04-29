using Api.Entities;
using Api.Entities.ResumeDetails;

namespace Api.Repositories;

public interface IResumeRepository
{
    Task<IEnumerable<ResumeEntity>> GetFullResumeAsync(CancellationToken cancellationToken);

    Task<IEnumerable<PersonalInfo>> GetPersonalInfoAsync(CancellationToken cancellationToken);

    Task<IEnumerable<AboutInfo>> GetAboutAsync(CancellationToken cancellationToken);

    Task<IEnumerable<SkillsInfo>> GetSkillAsync(CancellationToken cancellationToken);

    Task<IEnumerable<EducationalBackgroundInfo>> GetEducationalBackgroundAsync(CancellationToken cancellationToken);

    Task<IEnumerable<ProfessionalExperienceInfo>> GetProfessionalExperienceAsync(CancellationToken cancellationToken);

    Task<IEnumerable<LanguageInfo>> GetLanguageAsync(CancellationToken cancellationToken);

    Task<IEnumerable<CoursesInfo>> GetCoursesAsync(CancellationToken cancellationToken);

    Task<IEnumerable<CertificatesInfo>> GetCertificatesAsync(CancellationToken cancellationToken);

    Task<IEnumerable<ProjectsInfo>> GetProjectsAsync(CancellationToken cancellationToken);

    Task<int> CreateResumeAsync(ResumeEntity resumeEntity, CancellationToken cancellationToken);

    Task<int> UpdateResumeAsync(ResumeEntity resumeEntity, CancellationToken cancellationToken);

    Task<int> DeleteResumeAsync(Guid id, CancellationToken cancellationToken);
}