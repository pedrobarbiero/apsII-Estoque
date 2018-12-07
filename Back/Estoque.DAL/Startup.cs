using Estoque.DAL.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Artistas.DAL
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            var connString = Configuration.GetConnectionString("TesteConnection");
            services.AddDbContext<DbContext>(options => options.UseSqlServer(connString));
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {            
            using (var scope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                scope.ServiceProvider.GetRequiredService<TesteContext>().Database.Migrate();
            }
        }
    }
}
