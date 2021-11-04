using System;
using System.Collections;
using System.Collections.Generic;

namespace EnvVariable.Data
{
    public class SimpleProvider : IEnvironmentVariableProvider
    {
        public List<EnvironmentVariable> GetAll()
        {
            IDictionary environmentVariables = Environment.GetEnvironmentVariables();
            var environmentVariableList = new List<EnvironmentVariable>();

            foreach (DictionaryEntry variable in environmentVariables)
            {
                environmentVariableList.Add(new EnvironmentVariable(variable.Key.ToString(), variable.Value.ToString()));
            }

            return environmentVariableList;
        }
    }
}
