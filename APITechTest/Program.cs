using APITechTest.DatabaseContext;
using APITechTest.Repositories;
;

var builder = WebApplication.CreateBuilder(args);

//Just to create some dummy data to the tables
builder.Services.AddSingleton<DummyData>();
DummyData DummyData = new DummyData();

// Add services to the container.
builder.Services.AddTransient<ICompanyRepository, CompanyRepository>();
builder.Services.AddTransient<IClaimRepository, ClaimRepository>();
builder.Services.AddTransient<IClaimTypeRepository, ClaimTypeRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Datbase context - we are using InMemory database here
builder.Services.AddDbContext<MyDatabaseContext>();

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
