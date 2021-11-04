using System.Collections.Generic;

namespace EnvVariable.Data
{
    public interface IEnvironmentVariableProvider
    {
        List<EnvironmentVariable> GetAll();
    }
}
