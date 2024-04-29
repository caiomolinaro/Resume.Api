INSERT INTO Resume (Id, Name, Address, PhoneNumber, Email, Linkedin, GitHub, About, Skills, EducationalBackground, ProfessionalExperience, Language, Courses, Certificates, Projects)
VALUES
    ('123e4567-e89b-12d3-a456-426655440000', 'John Doe', '123 Main St, City', '+1 (555) 123-4567', 'john.doe@example.com', 'linkedin.com/in/johndoe', 'github.com/johndoe', 'Passionate software developer with a love for clean code.',
    ARRAY['C#', 'JavaScript', 'ASP.NET Core', 'React'],
    ARRAY['Bachelor''s in Computer Science, University XYZ'],
    ARRAY['Software Engineer at Company ABC', 'Frontend Developer at Company XYZ'],
    ARRAY['English', 'Spanish'],
    ARRAY['Advanced Algorithms', 'Web Development Bootcamp'],
    ARRAY['Microsoft Certified: Azure Developer Associate', 'React Certification'],
    ARRAY['E-commerce website', 'Personal blog']);
