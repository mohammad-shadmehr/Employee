# Employee WebApi + Angular 10

A very small project written in .Net Core and Angular 10, which covers the followings:

-NLayer 

*Presentation Layer: Provides an interface to the user. Uses the Application Layer to achieve user interactions.

*Application Layer: Mediates between the Presentation and Domain Layers. Orchestrates business objects to perform specific application tasks.

*Domain Layer: Includes business objects and their rules. This is the heart of the application.

*Infrastructure Layer: Provides generic technical capabilities that support higher layers mostly using 3rd-party libraries.

-Repository pattern

-Dependency Injection

-Integrating to Swagger for Web Api documentation

Running instruction:

Employee Api:

-.Netcore 3.1

-.EntityFrameworkCore 3.1.6

-Open the Employee solution

-Run (Ctrl+F5) the solution

-Browse to https://localhost:44336/swagger/index.html

Employee Angular:

-Angular 10

-Browse to the Employee \Angular\Employee.Client\ClientApp folder in CMD

-You need to restore package.json via npm or Yarn

-execute the "npm start" command

-Browse to https://localhost:4200

and ... DONE!

