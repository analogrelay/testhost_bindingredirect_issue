using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net.Http;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

public class UnitTest
{
    [Fact]
    public void Main()
    {
        var th = new TestServer(new WebHostBuilder().UseStartup<Startup>());
        var client = th.CreateClient();
    }

    public class Startup : IStartup
    {
        public void Configure(IApplicationBuilder app)
        {
            return;
        }

        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            return services.BuildServiceProvider();
        }
    }
}