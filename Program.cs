// ==========================================
// 1. If-Else Statements (කොන්ඩිෂන්ස්)
// ==========================================

int score = 85;

if (score >= 75)
{
    Console.WriteLine("Grade: Distinction (A)");
}
else if (score >= 65)
{
    Console.WriteLine("Grade: Credit (B)");
}
else
{
    Console.WriteLine("Grade: Pass/Fail");
}


// ==========================================
// 2. Switch Statement / Switch Expressions
// ==========================================

string role = "Developer";

// නවීන C# වල switch එක ගොඩක් පවර්ෆුල් (Pattern Matching සමඟ)
string department = role switch
{
    "Developer" => "Engineering Department",
    "Designer" => "UI/UX Department",
    _ => "General Staff" // '_' කියන්නේ JS වල 'default' වගේ එකක්
};

Console.WriteLine($"Role: {role} -> {department}");


// ==========================================
// 3. Loops (for, foreach, while)
// ==========================================

// --- For Loop ---
Console.WriteLine("\n--- For Loop Counting ---");
for (int i = 1; i <= 3; i++)
{
    Console.WriteLine($"Count: {i}");
}


// --- Foreach Loop (JavaScript වල for...of වගේ, මාරම වැදගත්!) ---
// C# වල Arrays හෝ Lists හරහා යන්න 'foreach' ගොඩක් පාවිච්චි කරනවා.
Console.WriteLine("\n--- Tech Stack List (foreach) ---");
string[] techStack = { "JavaScript", "React", "Node.js", "C# / .NET" };

foreach (var tech in techStack)
{
    Console.WriteLine($"Learning/Using: {tech}");
}


// --- While Loop ---
Console.WriteLine("\n--- While Loop Countdown ---");
int countdown = 2;
while (countdown > 0)
{
    Console.WriteLine($"Countdown: {countdown}");
    countdown--;
}