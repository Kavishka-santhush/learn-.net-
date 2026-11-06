using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// 1. SQLite Database එක Register කිරීම (Prisma connection string වගේ)
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=developers.db"));

builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

// ==========================================
// API Endpoints with Database (EF Core)
// ==========================================

// 1. GET: සියලුම ඩෙවලොපර්ස්ලා ඩාටාබේස් එකෙන් ලබා ගැනීම (Prisma: prisma.developer.findMany())
app.MapGet("/api/developers", async (AppDbContext db) =>
{
    var devs = await db.Developers.ToListAsync();
    return Results.Ok(devs);
});

// 2. POST: අලුත් ඩෙවලොපර් කෙනෙක් ඩාටාබේස් එකට સેව් කිරීම (Prisma: prisma.developer.create())
app.MapPost("/api/developers", async (DeveloperRequest request, AppDbContext db) =>
{
    if (string.IsNullOrWhiteSpace(request.Name))
    {
        return Results.BadRequest(new { Message = "Name is required!" });
    }

    var newDev = new DeveloperModel
    {
        Name = request.Name,
        Stack = request.Stack
    };

    db.Developers.Add(newDev);
    await db.SaveChangesAsync(); // ඩාටාබේස් එකට සේව් කිරීම

    return Results.Ok(new { Message = "Developer saved to Database successfully!", Data = newDev });
});


// ==========================================
// 3. GET Request (ID එක අනුව නිශ්චිත Developer කෙනෙක් ලබා ගැනීම)
// Express වල app.get('/api/developers/:id', ...) වගේමයි!
// ==========================================
app.MapGet("/api/developers/{id}", async (int id, AppDbContext db) =>
{
    var dev = await db.Developers.FindAsync(id);

    if (dev is null)
    {
        return Results.NotFound(new { Message = $"Developer with ID {id} not found!" });
    }

    return Results.Ok(dev);
});


// ==========================================
// 4. DELETE Request (ID එක අනුව Developer කෙනෙක් ඩාටාබේස් එකෙන් ඉවත් කිරීම)
// Express වල app.delete('/api/developers/:id', ...) වගේමයි!
// ==========================================
app.MapDelete("/api/developers/{id}", async (int id, AppDbContext db) =>
{
    var dev = await db.Developers.FindAsync(id);

    if (dev is null)
    {
        return Results.NotFound(new { Message = $"Developer with ID {id} not found!" });
    }

    db.Developers.Remove(dev);
    await db.SaveChangesAsync(); // ඩාටාබේස් එකෙන් මකා දැමීම

    return Results.Ok(new { Message = $"Developer with ID {id} deleted successfully!" });
});

app.Run();

// Request Body එකට අදාළ record එක
record DeveloperRequest(string Name, string Stack);

// Database Models
public class DeveloperModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Stack { get; set; }
}

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<DeveloperModel> Developers => Set<DeveloperModel>();
}