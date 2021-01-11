using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using StardustDL.RazorComponents.Markdown;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WordPressPCL;
using BlazingApple.Blog;
namespace BlazingAppleConsumer.Blog.Client
{
	public class Program
	{
		public static async Task Main(string[] args)
		{
			var builder = WebAssemblyHostBuilder.CreateDefault(args);
			builder.RootComponents.Add<App>("#app");

			builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
			builder.Services.AddScoped(pcl => new WordPressClient("https://old.taylorchasewhite.com/wp-json/"));
			builder.Services.AddScoped<BlogService>();
			builder.Services.AddMarkdownComponent();
			await builder.Build().RunAsync();
		}
	}
}
