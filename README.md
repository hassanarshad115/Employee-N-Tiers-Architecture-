<h1><b><i> employee-N-Tiers-Architecture-
N-Tiers Architecture 
  </h1>
  <h1>  Overview</h1>
botoweb uses wsgi and wsgi chaining to split the logic between multiple layers built inside of the framework:

Application Layer
Caching Layer
Filter Layer
Authentication Layer
Shared Resources
....................
Most developers use the Model View Controller (MVC) design pattern for their projects. Microsoft has an MVC Framework available for both .Net Framework and .Net Core. For many applications a three tiered architecture makes more sense but sometimes it doesn't and a more flexible architecture is required. This repository provides examples of five different ways to implement a three tiered architecture with .Net.

Disadvantages of using Microsoft's MVC Framework

Locked into using Visual Studio or Visual Studio Code for the front end development. Front end developers must know C# or another .Net programming language.
MVC gets overly complicated for very complex applications.
Difficult to use stored procedures with MVC.
Layers must use the same technology.
Parallel development more difficult because the model, view, and controller are all compiled at the same time.
Advantages of a three tiered architecture

Front end developers can develop HTML with any development tool even Dreamweaver. A different technology can be used for each tier. Front end developers don't need to know .Net.
More maintainable for larger more complex applications.
Because the tiers are completely separate, the database developer can freely develop stored procedures.
Technology agnostic for application layers.
Parallel development easier.
