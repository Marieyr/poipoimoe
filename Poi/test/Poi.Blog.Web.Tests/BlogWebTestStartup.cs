using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace Poi.Blog
{
    public class BlogWebTestStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<BlogWebTestModule>();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.InitializeApplication();
        }
    }
}