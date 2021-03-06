﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using NicoDeWet.WebApi.Configuration;
using NicoDeWet.WebApi.Web;

namespace NicoDeWet.WebApi.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class WebApiDbContextFactory : IDesignTimeDbContextFactory<WebApiDbContext>
    {
        public WebApiDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<WebApiDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            WebApiDbContextConfigurer.Configure(builder, configuration.GetConnectionString(WebApiConsts.ConnectionStringName));

            return new WebApiDbContext(builder.Options);
        }
    }
}
