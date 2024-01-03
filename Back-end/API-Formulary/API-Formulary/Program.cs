using API_Formulary.DAL.DataContext;
using API_Formulary.DAL.Implementations;
using API_Formulary.DAL.Repository;
using API_Formulary.Utilities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AplicationDbContext>(opt => opt.UseMySql(builder.Configuration.GetConnectionString("CadenaMySQL"), ServerVersion.Parse("8.0.35-mysql")));
builder.Services.AddScoped<IContractRepository, ContractRepository>();
builder.Services.AddAutoMapper(typeof(AutoMapperProfile));

builder.Services.AddCors(opt => opt.AddPolicy("PolicyCors", build => {

	build.WithOrigins("*").AllowAnyHeader().AllowAnyMethod();

}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseAuthorization();

app.UseCors("PolicyCors");

app.MapControllers();

app.Run();
