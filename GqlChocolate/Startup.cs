using GqlChocolate.Database;
using GqlChocolate.GraphQL;
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
