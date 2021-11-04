namespace EnvVariable.Data
{
    public class EnvironmentVariable
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public EnvironmentVariable(string name, string value)
        {
            Name = name;
            Value = value;
        }
    }
}
