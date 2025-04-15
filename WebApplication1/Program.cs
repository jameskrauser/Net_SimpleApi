var builder = WebApplication.CreateBuilder(args);

// �[�J CORS �A��
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

// �ϥ� CORS
app.UseCors("AllowAll");

app.UseAuthorization();
app.MapControllers();
app.Run();