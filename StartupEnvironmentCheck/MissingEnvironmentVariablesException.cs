namespace StartupEnvironmentCheck;

public class MissingEnvironmentVariablesException : Exception
{
    public MissingEnvironmentVariablesException(IEnumerable<string> missingVariables)
        : base(GenerateMessage(missingVariables))
    {
    }

    private static string GenerateMessage(IEnumerable<string> missingVariables)
    {
        var joinedNames = string.Join("\n", missingVariables.Select(v => $"- {v}"));
        return
            $"The following environment variable(s) are missing:\n{joinedNames}\nPlease ensure that these variables are properly configured in the environment settings. These variables might be essential for connecting to specific services or performing necessary application functions.";
    }
}