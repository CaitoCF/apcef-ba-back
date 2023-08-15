using Apcef.IoC;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//builder.Services.ConfigureSwaggerGen(setup =>
//{
//    setup.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
//    {
//        Title = "APCEF Api",
//        Version = "v1"
//    });
//});

builder.Services.AddDependencyResolver();

var app = builder.Build();

//app.UseSwagger();
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
