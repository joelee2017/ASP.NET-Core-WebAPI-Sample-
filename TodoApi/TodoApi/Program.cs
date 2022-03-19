// �إ� WebApplicationBuilder ����
var builder = WebApplication.CreateBuilder(args);

// �z�L builder.Services �N�A�ȥ[�J DI �e��
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// �إ� WebApplication ����
var app = builder.Build();

// �z�L app �]�w Middlewares (HTTP request pipeline)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

// �Ұ� ASP.NET Core ���ε{��
app.Run();
