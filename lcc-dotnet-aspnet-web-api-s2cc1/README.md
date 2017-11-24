
# Building Services with ASP.NET Web API Local Code Challenges

## Current Challenge

In this challenge, you'll start building out the Issue Tracker API by adding the Web API framework to the provided, empty ASP.NET project.

### Tasks

Here are the tasks that you need to complete for this code challenge. If you get stuck completing any of these tasks, see below for a list of detailed tasks.

* Install into the "IssueTracker" project the Microsoft.AspNet.WebApi NuGet package (v5.2.3)
* Add a public static class named "WebApiConfig" to the "App_Start" folder
* Stub out a static `Register` method in the WebApiConfig class
* Update the Global.asax.cs file's `Application_Start` method to call the `GlobalConfiguration.Configure` method passing in a reference to the `WebApiConfig.Register` method

## Project Overview

As you complete the code challenges in this course, you'll be working on a simple API for creating, reading, updating, and deleting user issues. When completed, this API could be used as the back-end for a simple issue tracker client.

The provided Visual Studio solution includes an empty ASP.NET project, a shared class library project, and a test project. The shared class library project contains Entity Framework related classes (repository, database context, database initializer, and two model classes) to enable data persistence. The test project contains a collection of unit tests that will verify if your code implements all of the necessary requirements for each code challenge.

__Note: When opening the Visual Studio solution for the first time, you'll be prompted with a security warning, for each project. Visual Studio does this to ensure that you're aware of the risks of executing code from untrusted sources. Go ahead and click the "OK" button to continue with opening the project.__

## Getting Started

Once you've downloaded the files for the code challenge, extract the ZIP file, and open into Visual Studio 2017 the [IssueTracker.sln](src/IssueTracker.sln) file located in the "src" folder.

Each code challenge will include instructions listing the specific tasks that you need to complete. To help determine when you've successfully completed all of the tasks, you can use Visual Studio's Test Explorer window to run all of the provided unit tests. If all of the tests pass, you're ready to upload your solution! If a one or more tests fail, review the error messages for hints on how you can resolve the issues.

Some of the challenges are purely setup or configuration related, so there won't necessarily be something that you easily manually test by debugging the application. For those challenges, you'll have to rely solely upon the provided unit tests to check if you've successfully completed all of the required tasks. Other challenges will have you adding a controller or adding/updating action methods. For those challenges, you can manually debug the application using a browser or a tool like [Postman](https://www.getpostman.com/), in addition to running the provided unit tests.

As a convenience, the root of the "IssueTracker" ASP.NET project contains a [gulp script](https://gulpjs.com/) that you can run using Visual Studio's Task Runner Explorer window. The gulp script contains a "default" task that will restore NuGet packages (if necessary), build the solution, run the unit tests, and if all of the tests pass, create a ZIP file of your solution. You'll find the "project.zip" file in the root folder (the folder that contains the README.md file). Upload this file when you're ready to complete the challenge.

## Detailed Tasks

Before referring to these detailed tasks, you should try to complete the code challenge using the above list of less detailed tasks. Doing that will help increase your retention of the material. If you do get stuck, this list of detailed tasks should help to clarify what needs to be done in order to complete the code challenge. **You've got this!**

* Install into the "IssueTracker" project the Microsoft.AspNet.WebApi NuGet package (v5.2.3)
  * To open the NuGet Package Manager, right click on the "IssueTracker" project and select the "Manage NuGet Packages…" menu item
  * For more information about the NuGet Package Manager in Visual Studio, see this [doc](https://docs.microsoft.com/en-us/nuget/tools/package-manager-ui)
* Add a public static class named "WebApiConfig" to the "App_Start" folder
  * If necessary, add the "App_Start" folder to the root of the project
  * Change the namespace for the WebApiConfig class from `IssueTracker.App_Start` to just `IssueTracker`
* Stub out a static `Register` method in the WebApiConfig class
  * Use `void` for the return type
  * Add a single parameter named `config` of type `HttpConfiguration`
* Update the Global.asax.cs file's `Application_Start` method to call the `GlobalConfiguration.Configure` method passing in a reference to the `WebApiConfig.Register` method
  * Remember, when passing a reference to a method, you don't include a set of parentheses after the method name

__Note: After adding a new class to a project, you'll need to make sure that the project file is saved before running the default gulp task. You can do that by selecting the "File > Save All" menu item.__
