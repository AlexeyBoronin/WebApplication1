using System.Text.RegularExpressions;
using  WebApplication1;


var builder = WebApplication.CreateBuilder();
var app = builder.Build();



/*app.UseWhen(
    context => context.Request.Path == "/time", // ���� ���� ������� "/time"
    appBuilder =>
    {
        /* 1.// ��������� ������ - ������� �� ������� ����������
         appBuilder.Use(async (context, next) =>
         {
             var time = DateTime.Now.ToShortTimeString();
             Console.WriteLine($"Time: {time}");
             await next();   // �������� ��������� middleware
         });

         // ���������� �����
         appBuilder.Run(async context =>
         {
             var time = DateTime.Now.ToShortTimeString();
             await context.Response.WriteAsync($"Time: {time}");
         });*/
/* 2. var time=DateTime.Now.ToShortTimeString();
 appBuilder.Use(async (context, next) =>
 {
     Console.WriteLine($"Time: {time}");
     await next();
 });
 appBuilder.Run(async context=> await context.Response.WriteAsync($"Time: {time}"));*/
/* appBuilder.Use(async (context, next) =>
 {
     var time = DateTime.Now.ToShortDateString();
     Console.WriteLine($"Time: {time}");
     await next();
 });
});*/

app.UseMiddleware<ErrorHandlingMiddleware>();
app.UseMiddleware<AuthenticationMiddleware>();
app.UseMiddleware<RoutingMiddleware>();
app.Run();
//MapWhen

/*async Task HandlerRequest(HttpContext context)
{
    await context.Response.WriteAsync("������ ����");
}
//context.Response.Headers.ContentDisposition = "attachment; filename=��� �����.jpg";
//await context.Response.SendFileAsync(��� �����)*/

/*
 * public static IApplicationBuilder Use(this IApplicationBuilder app, Func<HttpContext, Func<Task>, 
 * Task> middleware);
public static IApplicationBuilder Use(this IApplicationBuilder app, Func<HttpContext, RequestDelegate, 
Task> middleware)*/
//ublic static IApplicationBuilder Map (this IApplicationBuilder app, string pathMatch,
//Action<IApplicationBuilder> configuration);