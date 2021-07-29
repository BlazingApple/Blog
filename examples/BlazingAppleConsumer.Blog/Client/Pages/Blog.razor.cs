using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace BlazingAppleConsumer.Blog.Client.Pages
{
	public partial class Blog : ComponentBase
	{
		[Inject]
		public WordPressPCL.WordPressClient Client { get; set; }
	}
}
