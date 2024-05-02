# Resume.Api

In this project, my resume was transformed into a API, where each endpoint returns a field of my resume.

## Technologies used in this project

- .NET 8
- ASP.NET Core Web API
- PostgreSQL
- Microsoft SQL Server
- Dapper
- Entity Framework Core
- Microsot ASP.NET Core Identity
- Microsoft ASP.NET Core Authentication JWT Bearer
- Swagger OpenAPI
- Docker

## API Documentation

#### Returns full resume

```
  GET /api/Resume/GetFullResume
```
#### Returns only personal information section

```
  GET /api/Resume/GetPersonalInfo
```
#### Returns only the about section

```
  GET /api/Resume/GetAbout
```
#### Returns only the skills section

```
  GET /api/Resume/GetSkills
```
#### Returns only the educational background section

```
  GET /api/Resume/GetEducationalBackground
```
#### Returns only the professional experience section

```
  GET /api/Resume/GetProfessionalExperience
```
#### Returns only the languages section

```
  GET /api/Resume/GetLanguages
```
#### Returns only the courses section

```
  GET /api/Resume/GetCourses
```
#### Returns only the certificates section

```
  GET /api/Resume/GetCertificates
```
#### Returns only the projects section

```
  GET /api/Resume/GetProjects
```