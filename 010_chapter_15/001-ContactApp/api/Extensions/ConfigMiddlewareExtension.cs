public static class ConfigMiddlewareExtension
{
    public static IApplicationBuilder useConfigMiddleware(this IApplicationBuilder app)
    {
        return app.UseMiddleware<ConfigMiddleware>();
    }
}