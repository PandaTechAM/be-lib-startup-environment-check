namespace StartupEnvironmentCheck;

public class EnvironmentVariableValidator
{
    public static void ValidateEnvironmentVariables(IEnumerable<string> envNames)
    {
        var invalidEnvNames = (from envVariable in envNames
            let env = Environment.GetEnvironmentVariable(envVariable)
            where string.IsNullOrWhiteSpace(env)
            select envVariable).ToList();

        if (invalidEnvNames.Count > 0)
        {
            throw new MissingEnvironmentVariablesException(invalidEnvNames);
        }
    }
}