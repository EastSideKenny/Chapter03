using static System.Console;

for (int i = 1; i <= 100; i++)
{
    if (i % 15 == 0)
    {
        WriteLine("fizzbuzz");
    }
    else if (i % 5 == 0)
    {
        WriteLine("buzz");
    }
    else if (i % 3 == 0)
    {
        WriteLine("fizz");
    }else
    {
        WriteLine(i);
    }   
    
}