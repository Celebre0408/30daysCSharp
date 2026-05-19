// loop 
using C = System.Console;
//use clear to show output only in terminal
Console.Clear();
// sample loop
for (int i = 1; i <= 5; i++)
{
     Console.WriteLine(i);
}

 Console.WriteLine("How many times do you want to print I Love you?");
 Console.Write("enter a number: ");
 int v = int.Parse(Console.ReadLine()!);
 // int n;
 int j;
 for (j=1; j<v + 1 ; j++)
 {   
         C.WriteLine(j + ". I Love you");
 }
