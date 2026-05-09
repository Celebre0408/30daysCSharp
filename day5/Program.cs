Console.WriteLine("Hi age checker");

String name = "";
int myage;

Console.Write("name: ");
name = Console.ReadLine();

Console.Write("age: ");
myage = int.Parse(Console.ReadLine());

if (myage <= 12){
    Console.WriteLine(name + " Your are a Child because you are " + myage + " years old");  
    }
else if (myage > 12 && myage <=19){
        Console.WriteLine(name + " Your are a Teenager because you are " + myage + " years old");
    }
else if (myage > 19 && myage <= 64){
        Console.WriteLine(name + " Your are an Adult because you are " + myage + " years old");
    }
else{
        Console.WriteLine(name + " Your are a Senior because you are " + myage + " years old");
    }

