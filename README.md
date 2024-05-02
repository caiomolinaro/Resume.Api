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

```http
  GET /api/Resume/GetFullResume
```
#### Returns only personal information section

```http
  GET /api/Resume/GetPersonalInfo
```
#### Returns only the about section

```http
  GET /api/Resume/GetAbout
```
#### Returns only the skills section

```http
  GET /api/Resume/GetSkills
```
#### Returns only the educational background section

```http
  GET /api/Resume/GetEducationalBackground
```
#### Returns only the professional experience section

```http
  GET /api/Resume/GetProfessionalExperience
```
#### Returns only the languages section

```http
  GET /api/Resume/GetLanguages
```
#### Returns only the courses section

```http
  GET /api/Resume/GetCourses
```
#### Returns only the certificates section

```http
  GET /api/Resume/GetCertificates
```
#### Returns only the projects section

```http
  GET /api/Resume/GetProjects
```