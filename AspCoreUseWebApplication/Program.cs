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


// 2
//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("<p>Hello world!</p>");
//    await next.Invoke();
//});
//app.Run(async (context) =>
//{
//    //await Task.Delay(10000);
//    await context.Response.WriteAsync("<p>Good bye, World...</p>");
//});

//3
//app.UseWhen(
//    context => context.Request.Path == "/time",
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
//app.UseWhen(
//    context => context.Request.Path == "/time",
//    appBuilder =>
//    {
//        appBuilder.Use(async (context, next) =>
//        {
//            var time = DateTime.Now.ToShortTimeString();
//            Console.WriteLine($"Time: {time}");
//            await next();
//        });
//    });

//app.Run(async context =>
//{
//    await context.Response.WriteAsync("Home page");
//});



app.Run();
