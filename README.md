# ASP.NET Core 2.x Boilerplate (ABP) Web API Starter App

An [ASP.NET Boilerplate (ABP)](https://aspnetboilerplate.com) Web API Starter Application based on ASP.NET Core 2.x

The [3.4.1](3.4.1) directory contains the original ABP version 3.4.1 import.

Our requirements are as follows:

* PostgreSQL on Docker for localhost based persistence.
* Swagger and Swagger UI to document our Web API.
* AWS Cognito JWT tokens for end user authentication.
* CORS support expected.

### Understanding ABP 3.4.1 NLayer Architecture ###

#### NicoDeWet.WebApi.Core ####

#### NicoDeWet.WebApi.EntityFrameworkCore ####

#### NicoDeWet.WebApi.Migrator ####

#### Web.Core Layer - NicoDeWet.WebApi.Web.Core ####

The Web.Core layer depends on the application layer.

#### Application Layer - NicoDeWet.WebApi.Application ####

See [Application Services](https://aspnetboilerplate.com/Pages/Documents/Application-Services)

> Application Services are used to expose domain logic to the presentation layer.
> An Application Service is called from the presentation layer using a DTO (Data Transfer Object) as a parameter.
> It also uses domain objects to perform some specific business logic and returns a DTO back to the presentation layer.
> Thus, the presentation layer is completely isolated from Domain layer.
>
> In an ideally layered application, the presentation layer never directly works with domain objects.

See [ISessionAppService.cs](3.4.1/aspnet-core/src/NicoDeWet.WebApi.Application/Sessions/ISessionAppService.cs)

See [IAccountAppService.cs](3.4.1/aspnet-core/src/NicoDeWet.WebApi.Application/Authorization/Accounts/IAccountAppService.cs)

#### NicoDeWet.WebApi.Web.Host ####

## Getting Set Up As A Developer ##

**Development Environment**: macOS High Sierra

### Building & Running ABP 3.4.1 As-Is ###

Skip this if all you want to do is build your Web API.

The ABP 3.4.1 build process and documentation needs work in my opinion. As an aside ABP does not compete with the quality of for example [Spring's Guides](https://spring.io/guides), but that's a whole different world.

#### Step 1: Building ABP 3.4.1 As-Is On Your Local ####

ABP has a PowerShell based [build script](3.4.1/aspnet-core/build/build-with-ng.ps1) in the aspnet-core directory, so a logical starting point when getting familiar with our version of ABP 3.4.1 is to run it!

So, to do so, install PowerShell. I happened to install powershell-6.0.1-osx.10.12-x64.pkg and so to test whether it works run: 

```
$ pwsh
```

Next install the angular-cli since the [build script](3.4.1/aspnet-core/build/build-with-ng.ps1) references the *ng* command.

```
$ npm install -g angular-cli
$ ng help
```

In order to initiate a build you have to do so from the $build directory, as follows:

```
abp_web_api_starter_app/3.4.1/aspnet-core/build$ pwsh build-with-ng.ps1
```

I got a number of build errors, some path related and some tool related, so I abandoned the overarching build and decided to focus on the aspnet-core build.

##### aspnet-core build #####

Sadly **$ dotnet build** from that directory also gave me **Build FAILED** (various unmet dependencies). But I [fixed it](https://github.com/aspnetboilerplate/aspnetboilerplate/issues/2831)
by adding a NuGet.Config file ([here is the NuGet.Config reference documentation](https://docs.microsoft.com/en-gb/nuget/reference/nuget-config-file)).

So, if you check out this repo and issue **$ dotnet build** your build should succeed.

##### aspnet-core test #####

Run **abp_web_api_starter_app/3.4.1/aspnet-core/test/NicoDeWet.WebApi.Tests$ dotnet test**

##### aspnet-core run #####

Although this will bomb out because it cannot connect to SQLServer, try to run it up as follows:

```
$abp_web_api_starter_app/3.4.1/aspnet-core/src/NicoDeWet.WebApi.Web.Host$ dotnet run
```