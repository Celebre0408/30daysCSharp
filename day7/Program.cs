using System.Globalization;
// mini project simple calculator and grade checker
Console.Clear();
Console.WriteLine("Choose app by choosing number:");

Console.WriteLine("1. Calculator");
Console.WriteLine("2. Grade Checker");

Console.Write("Enter your choice: ");
int choice = Console.ReadKey().KeyChar - '0';

Console.Clear();

if (choice == 1)
{
    // Code for Calculator
    int a, b;

    Console.Write("\nEnter first number:");
    a = int.Parse(Console.ReadLine()!);
    Console.Write("Enter second number:");
    b = int.Parse(Console.ReadLine()!);

    Console.Write("Choose Operator (+ - / *)");
    char operators = Console.ReadKey().KeyChar;
    Console.WriteLine();
    switch (operators)
    {
        case '+':
            Console.WriteLine("Answer: ", a + b);
            break;
        case '-':
            Console.WriteLine("Answer: ", a - b);
            break;
        case '*':
            Console.WriteLine("Answer: ", a * b);
            break;
        case '/':
            Console.WriteLine("Answer: ", a / b);
        break;
    }
}
else if (choice == 2)
{
    // average grader
    Console.WriteLine("Enter your grade in every subeject to calculate your average grade");
    Console.Write("Math: ");
    double math = double.Parse(Console.ReadLine()!);
    Console.Write("Science: ");
    double science = double.Parse(Console.ReadLine()!);
    Console.Write("English: ");
    double english = double.Parse(Console.ReadLine()!);
    Console.Write("History: ");
    double history = double.Parse(Console.ReadLine()!);
    Console.Write("MAPEH: ");
    double mapeh = double.Parse(Console.ReadLine()!);
    Console.Write("TLE: ");
    double tle = double.Parse(Console.ReadLine()!);
    Console.Write("Filipino: ");
    double filipino = double.Parse(Console.ReadLine()!);
    Console.Write("Edukasyon sa Pagpapakatao: ");
    double esp = double.Parse(Console.ReadLine()!);

    double average = (math + science + english + history + mapeh + tle + filipino + esp) / 8;

    Console.WriteLine("Your average grade is : {0:F2}", average);

    switch (average)
    {
        case double n when (n >= 95 && n <=100):
            Console.WriteLine("Congratulations! you passed with Highest Honors");
            break;
        case double n when (n >= 90 && n < 95):
            Console.WriteLine("Congratulations! you passed with Honors");
            break;
        case double n when (n >= 85 && n < 90):
            Console.WriteLine("Congratulations! you passed with a good grade, keep it up");
            break;
        case double n when (n >= 75 && n < 85):
            Console.WriteLine("Congratulations! you passed but you need to work harder");
            break;
    }

}
else
{
    Console.Clear();
    Console.WriteLine("Sorry the number you enter is not valid please restrat the program and try again");
}