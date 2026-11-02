var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

// ==========================================
// අපේ In-Memory Data List එක (Temporary Database)
// ==========================================
var developers = new List<string>
{
    "Kavishka (MERN / .NET)",
    "Alex (Backend Dev)",
    "Sarah (Fullstack)"
};


// ==========================================
// 1. GET Request: /api/developers
// Express වල app.get('/api/developers', (req, res) => ...) වගේමයි!
// ==========================================
app.MapGet("/api/developers", () =>
{
    return Results.Ok(developers);
});


// ==========================================
// 2. POST Request: /api/developers
// Express වල app.post('/api/developers', (req, res) => ...) වගේමයි!
// ==========================================
app.MapPost("/api/developers", (DeveloperRequest request) =>
{
    if (string.IsNullOrWhiteSpace(request.Name))
    {
        return Results.BadRequest(new { Message = "Developer name cannot be empty!" });
    }

    developers.Add(request.Name);
    return Results.Ok(new { Message = "Developer added successfully!", Data = developers });
});


app.Run();

// Request body එකෙන් එන JSON එක map කරගන්න record එකක්
record DeveloperRequest(string Name);