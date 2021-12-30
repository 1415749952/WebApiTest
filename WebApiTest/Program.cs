using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo 
        { 
            Title = "这是文档标题",
            Version = "文档版本编号",
            Description = "文档描述"
        });
        var file = Path.Combine(AppContext.BaseDirectory, "WebApiTest.xml");  // xml文档绝对路径
        var path = Path.Combine(AppContext.BaseDirectory, file); // xml文档绝对路径
        c.IncludeXmlComments(path, true); // true : 显示控制器层注释
        c.OrderActionsBy(o => o.RelativePath); // 对action的名称进行排序，若是有多个，就能够看见效果了。

    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();