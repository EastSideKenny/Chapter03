using static System.Console;
using static System.Convert;

// implicit casting

int a = 10;
double b = a; // an int can be safely cast into a double
WriteLine(b);

WriteLine();

// explicit casting

double c = 9.8;
int d = (int)c; // compiler gives an error for this line (int d = c;  // trying to implicitly cast a double into an int)
WriteLine(d); // d is 9 losing  the .8 part

long e = 5_000_000_000;
int f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}");
e = long.MaxValue;
f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}");

WriteLine();

// Converting using System.Convert type

double g = 9.8;
int h = ToInt32(g); // a method of System.Convert
WriteLine($"g is {g} and h is {h}");

WriteLine();

// default rounding rules

double[] doubles = new[] { 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 };

foreach (double n in doubles)
{
    WriteLine($"ToInt32({n}) is {ToInt32(n)}");
}

WriteLine();

// taking control of the rounding rules 

foreach (double n in doubles)
{
    WriteLine(format:
        "Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}",
        arg0: n,
        arg1: Math.Round(value: n, digits: 0, 
                mode: MidpointRounding.AwayFromZero));
}

WriteLine();

// any type to a string

int number = 12;
WriteLine(number.ToString());

bool boolean = true;
WriteLine(boolean.ToString());

DateTime now = DateTime.Now;
WriteLine(now.ToString());

object me = new();
WriteLine(me.ToString());

WriteLine();

// Converting from binary object to string