namespace WebApplication1
{
    public class TokenMiddleware
    {
        private readonly RequestDelegate next;
        string p;

        public TokenMiddleware(RequestDelegate next, string p)
        {
            this.next = next;
            this.p = p;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var token = context.Request.Query["t"];
            if (token !=p)
            {
                context.Response.StatusCode = 403;
                await context.Response.WriteAsync("Token is invalid");
            }
            else
            {
                await next.Invoke(context);
            }
        }
    }
}
