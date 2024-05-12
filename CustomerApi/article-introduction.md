How to use ChatGPT to Scaffold a new API - Part 1


Covers the needs of a developer that needs to implement a web api and could utilize ChatGPT ability to create the basic implementation.
Developer has also the ability to ask chat for amendments on the code and improvements.
In this part will cover the initial scaffold of the project, the basic setup and creation of a model and a controller.

## Project Basics
- Firstly we ask chat gpt to create the basic project structure
- Then going step by step to create our domain models and apis for CRUD operations
- Ask chat GPT for directions related to the migration
- Ask chat GPT for creating the docker-compose file to be able to run the full solution locally, including a database container
- Showcase the generation of the project files
- Ask chat GPT to make some adjustments to the models
- Ask chat GPT to create DTOs as a good practise
- Fix issue with DTOs mapping by AutoMapper


##Data
The main entity of the project is the Customer and its relevant properties

Docker
- Dockerfile in place for running the project within a container
- Docker-compose file for running the full solution, the project plus the database locally

DTOs
- Introduced DTOs as a good poractise so that the controller and the consumers of the endpoints will not be tightly coupled to the actual database entities.


Changes Required:

- Update     <InvariantGlobalization>false</InvariantGlobalization> in .csproj to false => not needed, remove it
https://github.com/dotnet/SqlClient/issues/2239
- Update connection string to add the following `TrustServerCertificate=True;` - needed or not? try
https://github.com/dotnet/SqlClient/issues/1479
- Add env variable aspnetcore_environment=developmenrt in docker-compose.yml
- No need to add the following package dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection


## Next Articles
- Introduce tests for mapping, repository using in-memory db, endpoints using webAppFactory and repository
- Add Validations to database models and create-apply the new relevant migrations to the database
- Introduce graphql endpoints
- Add a custom business logic scenario where something should be executed for customer/s
- Enhance swagger documentation(description, examples)
- Enahnce error responses - use library that handling error response type?(there was one i found once upon a time)
- Middleware ideas (logging, validation/fluent validation)
- Mediator introduction
- Message queue events to inform other systems(mass transit)