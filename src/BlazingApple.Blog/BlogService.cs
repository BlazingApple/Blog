using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordPressPCL;
using WordPressPCL.Models;

namespace BlazingApple.Blog
{
	public class BlogService
	{
		private IEnumerable<Post> posts;
		private IEnumerable<User> users;
		public BlogService()
		{

		}

		public async Task<IEnumerable<Post>> GetPosts(WordPressClient client)
		{
			if (posts==null)
			{
				posts = await client.Posts.Get();
			}
			return posts;
			
		}

		public async Task<IEnumerable<User>> GetUsers(WordPressClient client)
		{
			if (users == null)
			{
				users = await client.Users.GetAll();
			}
			return users;
		}
	}
}
