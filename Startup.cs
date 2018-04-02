using System;
#if NETCORE
using Microsoft.AspNetCore.Builder;
#elif FW
using Owin;
#endif
using Microsoft.Extensions.DependencyInjection;

#if AUTOFAC
using DxLibs.Extensions.Web.DependencyInjection.Autofac;
#endif

namespace DxLibs.Framework.Web
{
    public class Startup : DxLibs.Web.Startup
    {
        protected override IServiceProvider BuildServiceProvider(IServiceCollection services)
        {
            return services.BuildServiceProvider();
        }

#if NETCORE
        public override void Configure(IApplicationBuilder app)
#elif FW
        public override void Configure(IAppBuilder app)
#endif
        {
            base.Configure(app);
        }

        //public override IServiceProvider ConfigureServices(IServiceCollection services)
        //{
        //    //services.AddMvc();

        //    return base.ConfigureServices(services);
        //}
    }
}
