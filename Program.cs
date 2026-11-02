using System;
using System.Threading.Tasks;

// ==========================================
// Asynchronous Programming (অසිංක්‍රනස් ක්‍රමවේදය)
// ==========================================

class Program
{
    // C# වල Main method එකත් 'async Task' විදිහට ලියන්න පුළුවන් (Modern .NET වල)
    static async Task Main(string[] args)
    {
        Console.WriteLine("1. Starting data fetching from Database / API...");

        // අනුක්‍රමිකව (Asynchronously) ඩේටා ගෙන්වා ගැනීම සෙකන්ඩ් 2කට ප්‍රමාද කිරීම (Delay)
        // JavaScript වල setTimeout හෝ await fetch() වගේමයි!
        string result = await FetchDataFromApiAsync();

        Console.WriteLine($"3. Received: {result}");
        Console.WriteLine("4. Process Completed!");
    }

    // Async Method එකක් නිර්මාණය කිරීම
    static async Task<string> FetchDataFromApiAsync()
    {
        Console.WriteLine("2. Fetching in progress (Waiting for server response)...");
        
        // Task.Delay කියන්නේ C# වල thread එක බ්ලොක් නොකර ටික වේලාවක් බලා සිටීමට (await කරන්න) පාවිච්චි කරන එකක්
        await Task.Delay(2000); 

        return "User data retrieved successfully from backend!";
    }
}