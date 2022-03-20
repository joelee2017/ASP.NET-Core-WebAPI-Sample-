using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

// 建立 WebApplicationBuilder 物件
var builder = WebApplication.CreateBuilder(args);

// 透過 builder.Services 將服務加入 DI 容器
builder.Services.AddControllers();

//在 ASP.NET Core 中，資料庫內容等服務必須向相依性插入 (DI) 容器註冊。 此容器會將服務提供給控制器。
builder.Services.AddDbContext<TodoContext>(opt => opt.UseInMemoryDatabase("TodoList"));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 建立 WebApplication 物件
var app = builder.Build();

// 透過 app 設定 Middlewares (HTTP request pipeline)
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    //app.UseSwagger();
    //app.UseSwaggerUI();
}

// 設定應用程式以 提供靜態 檔案，並 啟用預設檔案對應。
app.UseDefaultFiles();
app.UseStaticFiles();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

// 啟動 ASP.NET Core 應用程式
app.Run();
