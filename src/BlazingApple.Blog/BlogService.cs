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
		private List<Post> posts;
		private IEnumerable<User> users;

		public BlogService()
		{
		}

		public async Task<Post> GetPost(WordPressClient client, int postId)
		{
			try
			{
				return await client.Posts.GetByID(postId);
			}
			catch (Exception e)
			{
				return await client.Posts.GetByID(postId);
			}
		}

		public async Task<List<Post>> GetPosts(WordPressClient client)
		{
			if (posts == null)
			{
				try
				{
					posts = (await client.Posts.Get()).ToList();
				}
				catch (Exception e)
				{
					posts = (await client.Posts.Get()).ToList();
				}
			}
			return posts;
		}

		public async Task<IEnumerable<Post>> GetPostsWithCategories(WordPressClient client, int categoryId)
		{
			try
			{
				return await client.Posts.GetPostsByCategory(categoryId);
			}
			catch (Exception e)
			{
				return await client.Posts.GetPostsByCategory(categoryId);
			}
		}

		public async Task<IEnumerable<Post>> GetPostsWithCategories(WordPressClient client, IList<int> categoryIds)
		{
			posts = new List<Post>();
			for (int i = 0; i < categoryIds.Count; i++)
			{
				try
				{
					var response = await client.Posts.GetPostsByCategory(categoryIds[i]);
					posts.AddRange(response);
				}
				catch (Exception e)
				{
					var response = await client.Posts.GetPostsByCategory(categoryIds[i]);
					posts.AddRange(response);
					return response;
				}
			}
			return posts;
		}

		public async Task<IEnumerable<User>> GetUsers(WordPressClient client)
		{
			if (users == null)
			{
				try
				{
					users = await client.Users.GetAll();
				}
				catch (Exception e)
				{
					users = await client.Users.GetAll();
					return users;
				}
				return default;
			}
			return users;
		}
	}
}
