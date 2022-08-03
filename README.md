# Kodtest-Stratsys

## Code test
This repository contains a ASP.NET Core Web API project, a simple c# class project and a unit test project. The whole solution and its structure is based around [Clean Architecture](https://docs.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/common-web-application-architectures). Since the solution is rather small, the benefit of structuring it according to Clean Architecture is basically non existent, but i saw it as a learning experience. The structure is not perfect and there is probably some leaking abstractions, but for a solution this small i think it's good enough.  

The Project "Application.Tests" is a XUnit test project that focuses on unit tests for code inside the Application layer.  

The solution can be tested locally with Postman, for example.
![bild](https://user-images.githubusercontent.com/10603275/182548968-258b65f3-f4ac-4f59-85f5-f25c2eaf5a58.png)
