using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

// �إ� WebApplicationBuilder ����
var builder = WebApplication.CreateBuilder(args);

// �z�L builder.Services �N�A�ȥ[�J DI �e��
builder.Services.AddControllers();

//�b ASP.NET Core ���A��Ʈw���e���A�ȥ����V�̩ۨʴ��J (DI) �e�����U�C ���e���|�N�A�ȴ��ѵ�����C
builder.Services.AddDbContext<TodoContext>(opt => opt.UseInMemoryDatabase("TodoList"));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// �إ� WebApplication ����
var app = builder.Build();

// �z�L app �]�w Middlewares (HTTP request pipeline)
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    //app.UseSwagger();
    //app.UseSwaggerUI();
}

// �]�w���ε{���H �����R�A �ɮסA�� �ҥιw�]�ɮ׹����C
app.UseDefaultFiles();
app.UseStaticFiles();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

// �Ұ� ASP.NET Core ���ε{��
app.Run();
