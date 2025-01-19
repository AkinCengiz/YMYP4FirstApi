
using Microsoft.EntityFrameworkCore;
using YMYP4FirstApi.Business.Abstract;
using YMYP4FirstApi.Business.Concrete;
using YMYP4FirstApi.DataAccess.Abstract;
using YMYP4FirstApi.DataAccess.Concrete.EntityFramework;

namespace YMYP4FirstApi.WebApi;

public class Program
{
	public static void Main(string[] args)
	{
		var builder = WebApplication.CreateBuilder(args);

		// Add services to the container.

		builder.Services.AddControllers();

		builder.Services.AddDbContext<FirstApiDbContext>(option =>
		{
			option.UseSqlServer(builder.Configuration.GetConnectionString("akincengiz"));
		});

		builder.Services.AddScoped<ICategoryDal, EfCategoryDal>();
		builder.Services.AddScoped<ICategoryService, CategoryManager>();
		builder.Services.AddScoped<IProductDal, EfProductDal>();
		builder.Services.AddScoped<IProductService, ProductManager>();


		// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
		builder.Services.AddEndpointsApiExplorer();
		builder.Services.AddSwaggerGen();

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
	}
}
