using Microsoft.Data.SqlClient;
using System.Configuration;
using Dapper;
using Microsoft.Extensions.DependencyInjection;
using Flashcards.Coordinators;

namespace Flashcards;

class Program
{
    static void Main(string[] args)
    {
        // Create service collection
        var services = new ServiceCollection();

        // Register services
        services.AddSingleton<AppCoordinator>();

        //  Build service provider
        var serviceProvider = services.BuildServiceProvider();

        // Resolve AppCoordinator and start app
        var appCoordinator = serviceProvider.GetRequiredService<AppCoordinator>();
        appCoordinator.Start();

        // string? connectionString = ConfigurationManager.AppSettings["connectionString"];

        // using var connection = new SqlConnection(connectionString);
        // connection.Open();

    }
}
