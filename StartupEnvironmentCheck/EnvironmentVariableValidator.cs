namespace StartupEnvironmentCheck;

public class EnvironmentVariableValidator
{
    public static void ValidateEnvironmentVariables(IEnumerable<string> envNames)
    {
        var missingEnvNames = (from envVariable in envNames
            let env = Environment.GetEnvironmentVariable(envVariable)
            where env is null
            select envVariable).ToList();

        if (missingEnvNames.Count > 0)
        {
            throw new MissingEnvironmentVariablesException(missingEnvNames);
        }
    }
}