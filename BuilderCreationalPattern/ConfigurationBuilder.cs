using BuilderCreationalPattern.Contracts;

namespace BuilderCreationalPattern
{
    public class ConfigurationBuilder: IConfigurationBuilder
    {
        public void AddFileSource(string fileName = null)
        {
            //Read the configuration from file source and merge it with existing one
        }

        public void AddAzureAppConfigurationSource(string connectionString = null)
        {
            //Read the configuration from azure app configuration and merge it with existing one
        }

        public object Build()
        {
            //Should return ready to use default app configuration that was merged from other sources 
            return new object();
        }
    }
}