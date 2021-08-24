# SquaredClientApp
Demo WinForms application in .NET Core 3.1 that handles a simple Employee Maintenance Form for the purpose of showing knowledge of C# language and object oriented design and fundamentals.

# Database
The App is self contained with a light database (sqlite) for demo purposes.  The database will be built and seeded with some data on the app folder location when the app runs the first time.  

# Overview of SquaredClientApp
When running the App the app will show a list of managers and employees reporting to them.  You can also add new employees and managers (which are employees with a Director Role).
You can assign multiple roles when creating a new employee.

The App demostrates these Object Oriented design principles:

- Use of Generics.
- Single responsability classes. (classes have one responsability task)
- Open closed principle. Classes can be extended or derived but not modified.
- Use of interfaces. 
- Use of dependency injection.
- Use of Object Relational Mapping (ORM) .NET Framework for sqllite
- Error handling.
- Simple event logging (windows only)

The App was made as a WinForms client application for simplicity and to be self contained, but same priciples can be applied to a .NET Core MVC Application or any other.
