﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RecipeBook.Infrastructure.Repository.RepositoryAccess;

namespace WebApi.Test;

public class RecipeBookWebApplicationFactory<TStartup> : WebApplicationFactory<TStartup> where TStartup : class
{
    private RecipeBook.Domain.Entities.User _user;
    private string _password;

    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.UseEnvironment("Test")
            .ConfigureServices(services =>
            {
                var describer = services.SingleOrDefault(d => d.ServiceType == typeof(RecipeBookContext));

                if (describer != null)
                    services.Remove(describer);

                var provider = services.AddEntityFrameworkInMemoryDatabase().BuildServiceProvider();
                services.AddDbContext<RecipeBookContext>(options =>
                {
                    options.UseInMemoryDatabase("InMemoryDbForTesting");
                    options.UseInternalServiceProvider(provider);
                });

                var serviceProvider = services.BuildServiceProvider();

                using var scope = serviceProvider.CreateScope();
                var scopeService = scope.ServiceProvider;
                var database = scopeService.GetRequiredService<RecipeBookContext>();

                database.Database.EnsureDeleted();

                (_user, _password) = ContextSeedInMemory.Seed(database);
            });
    }

    public RecipeBook.Domain.Entities.User UserRecovery()
    {
        return _user;
    }

    public string PasswordRecovery()
    {
        return _password;
    }
}
