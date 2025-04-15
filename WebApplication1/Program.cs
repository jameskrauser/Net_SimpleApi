var builder = WebApplication.CreateBuilder(args);

// 加入 CORS 服務
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
 

var app = builder.Build();

// 使用 CORS
app.UseCors("AllowAll");

app.UseAuthorization();
app.MapControllers();
app.Run();