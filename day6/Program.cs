// switch statements
// string day = "";
// day = Console.ReadLine().ToLower();

// switch (day)
// {
//     case "monday":
//     Console.WriteLine("Today is Monday");
//     break;
//     case "tuesday":
//     Console.WriteLine("Today is Tuesday");
//     break;
//     case "wednesday":
//     Console.WriteLine("Today is Wednesday");
//     break;
//     case "thursday":
//     Console.WriteLine("Today is Thursday");
//     break;
//     case "friday":
//     Console.WriteLine("Today is Friday");
//     break;
//     case "saturday":
//     Console.WriteLine("Today is Saturday");
//     break;
//     case "sunday":
//     Console.WriteLine("Today is Sunday");
//     break;
//     default:
//     Console.WriteLine("Invalid day");
//     break;
// }
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("");

        // sample activity of case statements

        Console.WriteLine("Send this to your: \n1. Crush \n2. Friend \n3. Family \n4. Classmate");

        Console.Write("Enter a number: ");
        int sendthis = Convert.ToInt32(Console.ReadLine());

        switch (sendthis)
        {
            case 1:
                Console.Write("Name of your crush:");
                string crush = Console.ReadLine()!;
                System.Console.Clear();
                Console.WriteLine("Hello " + crush + ", I just wanted to say that I like you");
                break;
            case 2:
                Console.Write("Name of your friend:");
                string friend = Console.ReadLine()!;
                System.Console.Clear();
                Console.WriteLine("Hello " + friend + ", I just wanted to say that I am grateful to have you as my friend");
                break;
            case 3:
                Console.Write("Name of your family member:");
                string family = Console.ReadLine()!;
                System.Console.Clear();
                Console.WriteLine("Hello " + family + ", I just wanted to say that I am grateful that you are part of my family");
                break;
            case 4:
                Console.Write("Name of your classmate:");
                string classmate = Console.ReadLine()!;
                System.Console.Clear();
                Console.WriteLine("Hello " + classmate + ", can I copy your homework? you have no choice but to say yes");
                break;
        }
    }
}