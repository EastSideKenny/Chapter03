using static System.Console;

Write("Enter a number between 0 and 255:");
string? firstNumber = ReadLine();

Write("Enter another number between 0 and 255:");
string? secondNumber = ReadLine();

try
{
    byte b1 = byte.Parse(firstNumber);
    byte b2 = byte.Parse(secondNumber);

    int answer = b1 / b2;

    WriteLine($"{b1} divided by {b2} is {answer}");

} catch (Exception ex)
{
    WriteLine($"{ex.GetType().Name}: {ex.Message}");
}
