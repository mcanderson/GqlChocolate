using GqlChocolate.Database;
using GqlChocolate.GraphQL;
using GqlChocolate.GraphQL.Types;
using HotChocolate;
using HotChocolate.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GqlChocolate
{
    /// <summary>
    /// Project started from this tutorial: https://dev.to/mnsr/entity-framework-dotnet-core-with-graphql-and-sql-server-using-hotchocolate-4fl6
    /// </summary>
    /// 
    // TODO go through more of this: Get started with GraphQL and Entity Framework - DEV
    // https://dev.to/michaelstaib/get-started-with-hot-chocolate-and-entity-framework-e9i
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<MyDbContext>(options =>
                options.UseSqlServer(MyDbContext.DbConnectionString));

            // Add GraphQL Services
            services
              .AddDataLoaderRegistry()
              .AddGraphQL(SchemaBuilder
                  .New()
                  // Here, we add the LocationQueryType as a QueryType
                  .AddQueryType<LocationQueryType>()
                  .AddMutationType<LocationMutationType>()
                  .Create());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app
              .UseRouting()
              .UseWebSockets()
              .UseGraphQL()
              .UsePlayground();
        }
    }
}
