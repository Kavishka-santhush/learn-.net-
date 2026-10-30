// ==========================================
// 1. Defining a Class (කෝඩ් එකේ පන්තියක් නිර්මාණය කිරීම)
// ==========================================

class Developer
{
    // Properties (Java වල private variables + getters/setters වලට වඩා C# වල කෙටියෙන් Auto-properties පාවිච්චි කරන්න පුළුවන්)
    public string Name { get; set; }
    public string PrimaryStack { get; set; }
    public int ExperienceYears { get; set; }

    // Constructor (অবject එකක් හදනකොට ස්වයංක්‍රීයව කෝල් වෙන ක්‍රමවේදය - Java වල වගේමයි)
    public Developer(string name, string primaryStack, int experienceYears)
    {
        Name = name;
        PrimaryStack = primaryStack;
        ExperienceYears = experienceYears;
    }

    // Method (පන්තියට අයිති හැසිරීමක් / Function එකක්)
    public void Introduce()
    {
        Console.WriteLine($"Hi, I'm {Name}. I work with {PrimaryStack} and have {ExperienceYears} years of experience.");
    }
}


// ==========================================
// 2. Creating Objects and Using the Class
// ==========================================

// ප්‍රධාන Main වැඩසටහන ඇතුළේ Developer ඔબ્જેક્ટස් (Objects) හදන හැටි:

// Object 1
Developer dev1 = new Developer("Kavishka", "MERN Stack", 2);
dev1.Introduce(); // Method එක කෝල් කිරීම

// Object 2
Developer dev2 = new Developer("Alex", "C# / .NET", 4);
dev2.Introduce();


// ==========================================
// 3. Inheritance (පරම්පරාගත භාවය - OOP Core Concept)
// ==========================================

// Base class එකෙන් තවත් Class එකක් extend කරගැනීම (Java වල 'extends' වගේ C# වල ':' ලකුණ පාවිච්චි කරනවා)
class FullStackDeveloper : Developer
{
    public bool CanBuildDesktopApps { get; set; }

    // Constructor chaining (base කීවොත් මව් කෝඩ් එකේ constructor එකට ඩේටා යවනවා)
    public FullStackDeveloper(string name, string primaryStack, int experienceYears, bool canBuildDesktopApps) 
        : base(name, primaryStack, experienceYears)
    {
        CanBuildDesktopApps = canBuildDesktopApps;
    }

    // අලුත් Method එකක්
    public void CheckDesktopSkills()
    {
        string status = CanBuildDesktopApps ? "Yes, I can!" : "Not yet.";
        Console.WriteLine($"-> Can build desktop apps with .NET? {status}\n");
    }
}

// FullStackDeveloper ඔબ્જેક્ટ එකක් හදා පරීක්ෂා කිරීම:
FullStackDeveloper myDev = new FullStackDeveloper("Kavishka", "MERN & .NET", 2, true);
myDev.Introduce();
myDev.CheckDesktopSkills();