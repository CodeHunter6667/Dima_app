using Dima.Api.Common.Api;
using Dima.Api.Endpoints.Categories;
using Dima.Api.Migrations;

namespace Dima.Api.Endpoints;

public static class Endpoint
{
    public static void MapEndpoints(this WebApplication app)
    {
        var endpoint = app
            .MapGroup("");

        endpoint.MapGroup("v1/categories")
            .WithTags("Categories")
            .RequireAuthorization()
            .MapEndpoint<CreateCategoryEndpoint>()
            ;
    }

    private static IEndpointRouteBuilder MapEndpoint<TEndpoint>(this IEndpointRouteBuilder app) where TEndpoint : IEndpoint
    {
        TEndpoint.Map(app);
        return app;
    }
}
