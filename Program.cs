// ==========================================
// 1. Lists (Dynamic Arrays - JS වල Arrays වලට සමානයි)
// ==========================================

// C# වල Fixed Arrays වෙනුවට ඩයිනමික් ලෙස ඩේටා එකතු කරන්න/මකන්න List පාවිච්චි කරනවා.
List<string> languages = new List<string> { "JavaScript", "Java", "PHP" };

// අලුත් අයිතමයක් එකතු කිරීම (JS වල push() වගේ)
languages.Add("C#");

Console.WriteLine("--- All Languages ---");
foreach (var lang in languages)
{
    Console.WriteLine($"- {lang}");
}


// ==========================================
// 2. LINQ Basics (Language Integrated Query)
// ==========================================
// MERN වල JavaScript වල .filter() හෝ .map() පාවිච්චි කරනවා වගේ, 
// C# වල ඩාටා කලෙක්ෂන්ස් ෆිල්ටර් කරන්න, සෝට් කරන්න LINQ පාවිච්චි කරනවා.

List<int> numbers = new List<int> { 5, 12, 8, 20, 3, 15 };

// උදාහරණයක් ලෙස: 10 ට වඩා වැඩි සංඛ්‍යා පමණක් ෆිල්ටර් කරගැනීම (JavaScript වල .filter() වගේමයි!)
var filteredNumbers = numbers.Where(n => n > 10).ToList();

Console.WriteLine("\n--- Numbers greater than 10 (using LINQ) ---");
foreach (var num in filteredNumbers)
{
    Console.WriteLine(num);
}






// ==========================================
// 1. Objects හදන සහ කෝල් කරන කොටස (උඩින්ම තියෙන්න ඕනේ)
// ==========================================

// Object 1
Developer dev1 = new Developer("Kavishka", "MERN Stack", 2);
dev1.Introduce();

// Object 2
Developer dev2 = new Developer("Alex", "C# / .NET", 4);
dev2.Introduce();

// FullStackDeveloper ඔબ્ஜெક્ટ එකක් හදා පරීක්ෂා කිරීම:
FullStackDeveloper myDev = new FullStackDeveloper("Kavishka", "MERN & .NET", 2, true);
myDev.Introduce();
myDev.CheckDesktopSkills();


// ==========================================
// 2. Classes අර්ථදැක්වීම (ෆයිල් එකේ අගටම තියෙන්න ඕනේ)
// ==========================================

class Developer
{
    public string Name { get; set; }
    public string PrimaryStack { get; set; }
    public int ExperienceYears { get; set; }

    public Developer(string name, string primaryStack, int experienceYears)
    {
        Name = name;
        PrimaryStack = primaryStack;
        ExperienceYears = experienceYears;
    }

    public void Introduce()
    {
        Console.WriteLine($"Hi, I'm {Name}. I work with {PrimaryStack} and have {ExperienceYears} years of experience.");
    }
}

class FullStackDeveloper : Developer
{
    public bool CanBuildDesktopApps { get; set; }

    public FullStackDeveloper(string name, string primaryStack, int experienceYears, bool canBuildDesktopApps) 
        : base(name, primaryStack, experienceYears)
    {
        CanBuildDesktopApps = canBuildDesktopApps;
    }

    public void CheckDesktopSkills()
    {
        string status = CanBuildDesktopApps ? "Yes, I can!" : "Not yet.";
        Console.WriteLine($"-> Can build desktop apps with .NET? {status}\n");
    }
}