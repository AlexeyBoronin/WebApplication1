namespace WebApplication1
{
    public static class TokenExtensions
    {
        public static IApplicationBuilder UseToken(this IApplicationBuilder builder, string p)
        {
            return builder.UseMiddleware<TokenMiddleware>(p);
        }
    }
}
