namespace Api.Entities;

public class ResumeEntity
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Address { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Email { get; set; }
    public string? Linkedin { get; set; }
    public string? GitHub { get; set; }
    public string? About { get; set; }
    public string[]? Skills { get; set; }
    public string[]? EducationalBackground { get; set; }
    public string[]? ProfessionalExperice { get; set; }
    public string[]? Language { get; set; }
    public string[]? Courses { get; set; }
    public string[]? Certificates { get; set; }
    public string[]? Projects { get; set; }
}