var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

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

//middleware at run time
app.Use(async (mycontext, nextfunc) =>
{
	mycontext.Request.Headers.Add("myheader","myheadervalue") ;
	mycontext.Response.Headers.Add("myresponceheader", "some response value");
	mycontext.Response.Headers.XPoweredBy = "Anurag";

	await nextfunc.Invoke(mycontext);
});
//http logging
app.UseHttpLogging();   //change appsettings log level to info

app.Run();
