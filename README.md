# BlazingApple.Blog :apple:

:fire:  A totally copacetic, easy-to-use front-end Blazor WordPress Rendering Blog package.
This front-end Razor Class Library is intended to be used by Blazor WASM projects, and targets .NET 5. It easily allows you to render your WordPress Blogs.

## About BlazingApples
BlazingApples is an open-source set of packages that aims to speed application development for Blazor WebAssembly organizations.

:zap: Check out the [demo site here](https://blazorsimplesurvey.azurewebsites.net/displaysurvey), [or this blog post on how the components work](https://blazorhelpwebsite.com/ViewBlogPost/44)!

:clap: Special thanks to [wp-Net](https://github.com/wp-net) for creating the [WordPressPCL](https://github.com/wp-net/WordPressPCL) API service on which this library primarily consumes.

# Demo :video_camera:
  <img alt="Demo of BlazingApple.Survey" src="https://github.com/BlazingApple/Blog/blob/main/README/BlogDemo.gif?raw=true" style="max-width:1000px;">

# Installation :wrench:

## 1. Get the required dependencies.

1. On Client Project, right click and get to the NuGet Package Manager ("Manage NuGetPackages").
2. Install `WordPressPCL`. This provides the client service to request data from your site.
3. Add the following to `Program.cs's Main`:
```
			builder.Services.AddScoped(pcl => new WordPressClient("https://old.taylorchasewhite.com/wp-json/"));
```
4. Install `BlazingApple.Blog`. This provides the client components to render the requested data.
<img alt="Blog Administration" src="https://github.com/BlazingApple/Survey/blob/main/README/InstallBlazingApplePackage.png?raw=true" style="max-width:1000px;">


Now you should be all set to use the components!

# Usage :muscle:

Once the setup is complete, using the components is straightforward:

1. In a component, inject the WordPressPCL client, `@inject WordPressPCL.WordPressClient client`.
2. Add the `<Blog Client="client"></Blog>` component to render all the posts in your blog.


## Credits :white_flower:

- Build with love :blue_heart:, using [WordPressPCL](https://github.com/wp-net/WordPressPCL).

## Authors :pencil:

1. [Taylor White](https://twitter.com/taychasewhite)

## License :scroll:

![License: GPL v2](https://img.shields.io/badge/License-GPL%20v2-blue.svg)

- **[GPLv2](https://www.gnu.org/licenses/old-licenses/gpl-2.0.en.html)**

## Blog Home :camera:
<img alt="Survey Administration" src="https://github.com/BlazingApple/Blog/blob/main/README/2020-12-28%20Blog%20Home.png?raw=true" style="max-width:1000px;">

## Categories (Pages Looks Similar) :camera:
<img alt="Taking a Survey" src="https://github.com/BlazingApple/Blog/blob/main/README/2020-12-28%20Categories.png.png?raw=true" style="max-width:1000px;">

## Posts For a Category :camera:
<img alt="Survey Responses" src="https://github.com/BlazingApple/Blog/blob/main/README/2020-12-28%20Individual%20Category.png?raw=true" style="max-width:1000px;">

