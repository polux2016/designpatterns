using System;
using System.Configuration;

namespace BuilderCreationalPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.AddFileSource();
            configurationBuilder.AddAzureAppConfigurationSource();
            var config = configurationBuilder.Build();
        }
    }
}
