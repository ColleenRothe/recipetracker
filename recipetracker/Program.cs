using recipetracker.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IRecipeService, RecipeService>();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();


var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();

app.Run();

