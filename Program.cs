// ==========================================
// 1. Basic Data Types (ප්‍රධාන ඩාටා ටයිප්ස්)
// ==========================================

// Java වල වගේම C# වලත් Data Types explicit ලෙස කියන්න පුළුවන්
int age = 25;                       // Whole numbers (පූර්ණ සංඛ්‍යා)
double height = 5.9;                // Decimal numbers (දශම සංඛ්‍යා)
char grade = 'A';                   // Single character
string name = "Kavishka";           // Text / String
bool isDeveloper = true;            // Boolean (true/false)

// C# වල මූලික Console Output
Console.WriteLine($"Name: {name}, Age: {age}, Height: {height}ft");


// ==========================================
// 2. Type Inference with 'var'
// ==========================================

// JavaScript වල 'let' / 'const' වගේ C# වල 'var' පාවිච්චි කරන්න පුළුවන්.
// හැබැයි වෙනස: C# වල 'var' කියන්නේ තවමත් Static Type එකක්! 
// ඒ කියන්නේ එක් වරක් Assign කළ පසු Data Type එක වෙනස් කරන්න බැහැ.

var city = "Colombo";  // C# විසින් ස්වයංක්‍රීයව මෙය string ලෙස හඳුනා ගනී
var count = 100;       // integer ලෙස හඳුනා ගනී

// city = 123; // ❌ ERROR: JS වල වගේ වෙනස් කරන්න බැහැ! (Type safety)


// ==========================================
// 3. Null Safety & Nullable Types
// ==========================================

// C# වල සාමාන්‍ය Value Types (int, double, bool) වලට 'null' දාන්න බැහැ.
// 'null' දාන්න ඕනේ නම් Data Type එක අගට '?' ලකුණ යොදන්න ඕනේ.

int? nullableAge = null; // ✅ Nullable integer
string? nullableName = null; // ✅ Nullable string

Console.WriteLine($"Nullable Age: {nullableAge ?? 0}"); // '??' කියන්නේ Null Coalescing Operator එක (JS වල Nullish coalescing වගේමයි)


// ==========================================
// 4. User Input (ටර්මිනල් එකෙන් Input එකක් ලබා ගැනීම)
// ==========================================

Console.Write("\nEnter your favorite programming language: ");
string? inputLanguage = Console.ReadLine(); // User input එකක් string එකක් විදිහට ගන්නවා

Console.WriteLine($"Awesome! You love {inputLanguage}.");