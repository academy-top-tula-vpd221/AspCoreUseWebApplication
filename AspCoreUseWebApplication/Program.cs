using static System.Net.Mime.MediaTypeNames;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


// 1
//string date = "";

//app.Use(async (context, next) =>
//{
//    date = DateTime.Now.ToShortDateString();
//    await next.Invoke();
//    await context.Response.WriteAsync($"Date: {date}");
//});

//app.Run(async (context) => await context.Response.WriteAsync($"Current Date: {date}\n"));


//2
//app.Use(UseOne);

//app.Use(async (HttpContext context, RequestDelegate next) =>
//{
//    await context.Response.WriteAsync("<p>Hello two!</p>");
//    //await next.Invoke();
//    await context.Response.WriteAsync("<p>Good by two!</p>");
//});

//app.Run(async (context) =>
//{
//    await Task.Delay(5000);
//    await context.Response.WriteAsync("<p>Hello abd Good by</p>");
//});

//3
//app.UseWhen(
//    (context) => context.Request.Path == "/time",
//    appBuilder =>
//    {
//        appBuilder.Use(async (context, next) =>
//        {
//            var time = DateTime.Now.ToShortTimeString();
//            Console.WriteLine($"Time: {time}");
//            await next();
//        });

//        appBuilder.Run(async context =>
//        {
//            var time = DateTime.Now.ToShortTimeString();
//            await context.Response.WriteAsync($"Time: {time}");
//        });
//    });

//app.Run(async context =>
//{
//    await context.Response.WriteAsync("Home page");
//});


//4
app.UseWhen(
    context => context.Request.Path == "/time",
    appBuilder =>
    {
        appBuilder.Use(async (context, next) =>
        {
            var time = DateTime.Now.ToShortTimeString();
            await context.Response.WriteAsync($"Time: {time}");
            Console.WriteLine($"Time: {time}");
            await next();
        });
    });

app.Run(async context =>
{
    await context.Response.WriteAsync("Home page");
});



app.Run();



async Task UseOne(HttpContext context, Func<Task> next)
{
    await context.Response.WriteAsync("<p>Hello one!</p>");
    await next.Invoke();
    await context.Response.WriteAsync("<p>Good one!</p>");
}
