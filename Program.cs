Console.WriteLine("===== USER PROFILE =====");

Console.Write("Enter your name: ");
string? name = Console.ReadLine();

Console.Write("Enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());
                  
Console.Write("Enter your favourite programming language: ");
string? language = Console.ReadLine();

Console.WriteLine();
Console.WriteLine("===== PROFILE =====");
Console.WriteLine($"Name     : {name}");
Console.WriteLine($"Age      : {age}");
Console.WriteLine($"Language : {language}");