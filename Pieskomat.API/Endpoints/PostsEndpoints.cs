namespace Pieskomat.API.Endpoints;

public static class PostsEndpoints
{
    public static RouteGroupBuilder MapPostsEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("posts").WithParameterValidation();

        group.MapGet("/", () =>
        {
            return Results.Ok();
        }).RequireAuthorization();

        return group;
    }

}
