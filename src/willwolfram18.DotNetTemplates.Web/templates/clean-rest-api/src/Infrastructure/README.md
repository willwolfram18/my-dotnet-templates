# $AppName$.Infrastructure
> The low-level details of the application.

The `$AppName$.Infrastructure` project is intended to house the low-level details of the application. This is where the bulk of implementation details, like database query languages or external API integrations, should be implemented. This allows the business logic, i.e. `$AppName$.Domain` project, to be better isolated from things that are more volatile than the business logic.