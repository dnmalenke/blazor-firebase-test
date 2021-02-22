using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Blazor_Firebase_Test.Data;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Blazored.SessionStorage;
using Blazored.Toast;
using Blazored.Modal;

namespace Blazor_Firebase_Test
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine(Directory.GetCurrentDirectory());

            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddOidcAuthentication(options =>
            {
                builder.Configuration.Bind("Local", options.ProviderOptions);
                options.ProviderOptions.DefaultScopes.Add("https://www.googleapis.com/auth/userinfo.email");
            });

            builder.Services.AddScoped<RobotService>();

            builder.Services.AddBlazoredSessionStorage();
            builder.Services.AddBlazoredToast();
            builder.Services.AddBlazoredModal();

            await builder.Build().RunAsync();
        }
    }
}
