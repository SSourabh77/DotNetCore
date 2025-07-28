var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

//Middleware 1 


//  Run  method  execute the first middleware only  second  he not able to execute  
//app.Run( async(context) =>
//{
//    await context.Response.WriteAsync("Welcome Shubham  Sourabh \n");
//});                     

app.Use(async (context ,Next) =>
{
    await context.Response.WriteAsync("Welcome Shubham  Sourabh \n");
    await Next(context);
});
app.Run(async(x) =>
{
    await x.Response.WriteAsync("How Are You ");

});

app.Run();
