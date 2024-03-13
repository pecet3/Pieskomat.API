using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Pieskomat.API.Endpoints;

public static class PostsEndpoints
{
    public static RouteGroupBuilder MapPostsEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("posts").WithParameterValidation();

        group.MapGet("/", async (DataContext dbContext) =>
        {
            await dbContext.Posts.ToListAsync();
        }).RequireAuthorization();

        group.MapGet("/users", async (DataContext dbContext, UserManager<IdentityUser> userManager) =>
            await userManager.Users.ToListAsync()
        );

        return group;
    }

}
