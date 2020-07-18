using System;
using System.Configuration;

namespace BuilderCreationalPattern.Contracts
{
    public interface IConfigurationBuilder
    {
        void AddFileSource(string fileName = null);

        void AddAzureAppConfigurationSource(string connectionString = null);

        object Build();
    }
}