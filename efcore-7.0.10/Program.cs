using efcore_7._0._10;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

await Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
    {
        services.AddDbContext<IssueDbContext>((_, options) => options
            .UseOracle("Data Source=MyOracleDB;Integrated Security=yes;"));

    })
    .RunConsoleAsync();