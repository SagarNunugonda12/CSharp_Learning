Console.WriteLine("===== Student Grade Calculator =====");
Console.Write("Student Name:");
string? Name = Console.ReadLine();
Console.Write("Marks:");
double Marks = Convert.ToDouble(Console.ReadLine());

if(Marks > 90)
{
    Console.Write("Grade: A");
}
else if(Marks >= 75 && Marks < 90)
{
    Console.Write("Grade B");
}
else if(Marks >= 50 && Marks < 75)
{
    Console.Write("Grade C");
}
else if(Marks >= 35 && Marks < 50)
{
    Console.Write("Grade D");
}
else
{
    Console.Write("Fail");
}


