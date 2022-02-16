using static System.Console;


// While loop

int x = 0;

while (x < 10)
{
    WriteLine(x);
    x++;
}

WriteLine();

// do while loop

//string? password;

//do
//{
//    Write("Enter your password: ");
//    password = ReadLine();
    
//}
//while (password != "Pa$$w0rd");

//WriteLine("Correct!");

WriteLine();

// for loop

for (int y = 1; y <= 10; y++)
{
    WriteLine(y);
}

WriteLine();

// foreach loop

string[] names = { "Jemp", "Claude", "Annette" };

foreach (string name in names)
{
    WriteLine($"{name} has {name.Length} characters.");
}

WriteLine();