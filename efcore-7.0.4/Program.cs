using efcore_7._0._4;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

await Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
    {
        services.AddDbContext<IssueDbContext>((_, options) => options
            .UseOracle("Data Source=MyOracleDB;Integrated Security=yes;")
            .ReplaceService<IModelValidator, IssueRelationalModelValidator>());

    })
    .RunConsoleAsync();