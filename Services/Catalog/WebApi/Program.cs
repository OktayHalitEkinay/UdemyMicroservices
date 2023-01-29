using Autofac.Core;
using Business.Abstract;
using Business.Concrete;
using Core.DataAccess.Abstract;
using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.Mongo;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;
builder.Services.Configure<MongoDbSettings>(configuration.GetRequiredSection("MongoDbSettings"));


//News

builder.Services.AddScoped<IMongoDbSettings>(serviceProvider =>
        serviceProvider.GetRequiredService<IOptions<MongoDbSettings>>().Value); ;
builder.Services.AddScoped<ICategoryDal,MongoCategoryDal >();
builder.Services.AddScoped<ICategoryService,CategoryManager>();

//

//Olds

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
