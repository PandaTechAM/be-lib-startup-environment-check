# Pandatech.StartupEnvironmentCheck

`Pandatech.StartupEnvironmentCheck` is a lightweight library designed to validate required environment variables at
application startup. It helps ensure that essential configurations are in place, preventing unexpected behaviors or
failures due to missing environment variables.

## Installation

You can install `Pandatech.StartupEnvironmentCheck` via NuGet Package Manager or by using the following command in your
Package Manager Console:

```powershell
Install-Package Pandatech.StartupEnvironmentCheck
```

## Usage

### Validating Environment Variables

You can use the `EnvironmentVariableValidator.ValidateEnvironmentVariables` method to validate required environment
variables. Here's an example:

```csharp
using StartupEnvironmentCheck;

public class Program
{
    public static void Main(string[] args)
    {
        var requiredEnvVars = new List<string> { "DB_CONNECTION_STRING", "API_KEY" };
        EnvironmentVariableValidator.ValidateEnvironmentVariables(requiredEnvVars);
        
        // Continue with the rest of the application startup
    }
}
```

### Handling Missing Variables

If any required environment variables are missing, a `MissingEnvironmentVariablesException` will be thrown. This
exception includes a detailed message listing the missing variables.

You can catch this exception to log the error or take other appropriate actions:

```csharp
try
{
EnvironmentVariableValidator.ValidateEnvironmentVariables(requiredEnvVars);
}
catch (MissingEnvironmentVariablesException ex)
{
// Log the error or take other actions
}
```

## Contributing

For support, issues, or contributions, please refer to the project's GitHub repository or contact the maintainers.

## License

This project is licensed under the MIT License.

