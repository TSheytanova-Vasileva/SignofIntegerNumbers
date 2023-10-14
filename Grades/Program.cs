double grade = double.Parse(Console.ReadLine());

if (grade >= 2.00 && grade <= 2.99)
{
    Console.WriteLine("Fail");
}
else if (grade >=3 && grade <= 3.49)
{
    Console.WriteLine("Average");
}
else if (grade >= 3.5 && grade <= 4.49)
{
    Console.WriteLine("Good");
}
else if (grade >=4.5 && grade <=5.49)
{
    Console.WriteLine("Very good");
}
else
{
    Console.WriteLine("Excellent");
}
static void StudenGrades (double grade)
{
    Console.WriteLine(StudenGrades);
}