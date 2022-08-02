using CalculatingTheAreaOfShapesASPNET;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async context => 
{
    InformationAboutTheObject currentObject = new InformationAboutTheObject();
    currentObject.MethodToUse(context);
    
});
app.Run();

struct InformationAboutTheObject
{
    double commonRadius { get; set; }
    double commonFirstSide { get; set; }
    double commonSecondSide { get; set; }
    double commonThirdSide { get; set; }
    double commonFirstBaseLength { get; set; }
    double commonSecondBaseLength { get; set; }
    double commonHeight { get; set; }
    void DefiningObjectInformation(HttpContext context) 
    {
        context.Response.ContentType = "text/html; charset=utf-8";
        context.Response.SendFileAsync("Html/MainPage.html");
        var form = context.Request.Form; 
        commonRadius = Convert.ToDouble(form["commonRadius"]);
        commonFirstSide = Convert.ToDouble(form["commonFirstSide"]);
        commonSecondSide = Convert.ToDouble(form["commonSecondSide"]);
        commonThirdSide = Convert.ToDouble(form["commonThirdSide"]);
        commonFirstBaseLength = Convert.ToDouble(form["commonFirstBaseLength"]);
        commonSecondBaseLength = Convert.ToDouble(form["commonSecondBaseLength"]);
        commonHeight = Convert.ToDouble(form["commonHeight"]);
    }
    string DataFalculation(HttpContext context) 
    {
       return AreaСalculation.UsingClassMethods(commonRadius, commonFirstSide, commonSecondSide, commonThirdSide, 
            commonFirstBaseLength, commonSecondBaseLength, commonHeight);
    }
    void displayingTheAreaValue(HttpContext context, string commonInformation)
    { context.Response.WriteAsync(commonInformation);}
    public void MethodToUse(HttpContext context) 
    {
        DefiningObjectInformation(context);
        displayingTheAreaValue(context,DataFalculation(context));
    }
}

//app.Use(async (context, next) => 
//{
//    if (context.Request.Path != "/Figure")
//    {
//        context.Response.ContentType = "text/html; charset=utf-8";
//        await context.Response.SendFileAsync("Html/MainPage.html");
//    }
//    else
//    {
//        await next.Invoke();
//    }       
//});
//app.Map("/Figure", async appBuilder =>
//{       
//    appBuilder.Use(async (context, next) =>
//    {
//        var form = context.Request.Form; string selectedFigure = form["ListOfFigures"];
//        switch (selectedFigure)
//        {
//            case "Круг": context.Request.Path = "/Circle"; break;
//            case "Треугольник": await context.Response.SendFileAsync("Html/TrianglePage.html"); break;
//            case "Квадрат": await context.Response.SendFileAsync("Html/SquarePage.html"); break;
//            case "Трапеция": await context.Response.SendFileAsync("Html/TrapezePage.html"); break;
//            case "Цилиндр": await context.Response.SendFileAsync("HtmlCylinderPage.html"); break;
//            default: await context.Response.SendFileAsync("Html/TrianglePage.html"); break;

//        }
//        await next();
//    });
//});
//app.Map("/time", appBuilder =>
//{
//    var time = DateTime.Now.ToShortTimeString();

//    // логгируем данные - выводим на консоль приложения
//    appBuilder.Use(async (context, next) =>
//    {
//        Console.WriteLine($"Time: {time}");
//        await next();   // вызываем следующий middleware
//    });

//});
//app.Map("/Circle", async appBuilder =>
//{
//    IFormCollection form; string selectedFigure;
//    appBuilder.Use(async (context, next) =>
//    {
//        int radius = 0;
//        if (radius != 0)
//        {
//            appBuilder.Run(async context => { displayingTheAreaValue(context, AreaСalculation.UsingClassMethods("Круг", radius)); });
//        }
//        else
//        {
//            appBuilder.Run(async context =>
//            {
//                context.Response.ContentType = "text/html; charset=utf-8";
//                await context.Response.SendFileAsync("Html/CirclePage.html");
//                form = context.Request.Form; radius = Convert.ToInt32(form["radius"]);
//            });
//        }
//        await next();
//    });
    
//});


