// Task 1

int n = int.Parse(Console.ReadLine()!);

if (n > 0)
    Console.WriteLine("Musbat");
else if (n < 0)
    Console.WriteLine("Manfiy");
else
    Console.WriteLine("Nol");
    
// Task 2 

int n = int.Parse(Console.ReadLine()!);

if (n % 2 == 0)
    Console.WriteLine("Juft");
else
    Console.WriteLine("Toq");
    
// Task 3

int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);

if (a > b)
    Console.WriteLine($"Kattasi: {a}");
else if (b > a)
    Console.WriteLine($"Kattasi: {b}");
else
    Console.WriteLine("Sonlar teng");
    
// Task 4

int ball = int.Parse(Console.ReadLine()!);

if (ball < 0 || ball > 100)
    Console.WriteLine("Noto'g'ri ball");
else if (ball >= 90)
    Console.WriteLine("A'lo");
else if (ball >= 70)
    Console.WriteLine("Yaxshi");
else if (ball >= 60)
    Console.WriteLine("Qoniqarli");
else
    Console.WriteLine("Qoniqarsiz");

// Task 5

int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
string amal = Console.ReadLine()!;

switch (amal)
{
    case "+":
        Console.WriteLine(a + b);
        break;
    case "-":
        Console.WriteLine(a - b);
        break;
    case "*":
        Console.WriteLine(a * b);
        break;
    case "/":
        Console.WriteLine(a / b);
        break;
    default:
        Console.WriteLine("Noto'g'ri amal");
        break;
}

// Task 6

int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);

if (a + b <= c || a + c <= b || b + c <= a)
{
    Console.WriteLine("Uchburchak hosil qilmaydi");
}
else if (a == b && b == c)
{
    Console.WriteLine("Uchburchak: teng tomonli");
}
else if (a == b || a == c || b == c)
{
    Console.WriteLine("Uchburchak: teng yonli");
}
else
{
    Console.WriteLine("Uchburchak: turli tomonli");
}

// Task 7

int n = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= n; i++)
{
    Console.Write(i);

    if (i < n)
        Console.Write(" ");
}

// Task 8

int n = int.Parse(Console.ReadLine()!);

while (n >= 1)
{
    Console.Write(n);

    if (n > 1)
        Console.Write(" ");

    n--;
}

// Task 9

int n = int.Parse(Console.ReadLine()!);
int sum = 0;

for (int i = 1; i <= n; i++)
{
    sum += i;
}

Console.WriteLine($"Yig'indi: {sum}");

// Task 10

int n = int.Parse(Console.ReadLine()!);
int sum = 0;
bool found = false;

for (int i = 2; i <= n; i += 2)
{
    if (found)
        Console.Write(" ");

    Console.Write(i);
    sum += i;
    found = true;
}

if (!found)
    Console.WriteLine("Juft son yo'q");
else
    Console.WriteLine();

Console.WriteLine($"Yig'indi: {sum}");

// Task 11

int n = int.Parse(Console.ReadLine()!);

for (int i = 5; i <= n; i += 5)
{
    Console.Write(i);

    if (i + 5 <= n)
        Console.Write(" ");
}

// Task 12

int n = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{n} x {i} = {n * i}");
}

// Task 13

int n = int.Parse(Console.ReadLine()!);
int count = 0;
int sum = 0;

for (int i = 1; i <= n; i++)
{
    if (i % 3 == 0)
    {
        count++;
        sum += i;
    }
}

Console.WriteLine($"Soni: {count}");
Console.WriteLine($"Yig'indi: {sum}");

// Task 14

int n = int.Parse(Console.ReadLine()!);
int factorial = 1;

for (int i = 1; i <= n; i++)
{
    factorial *= i;
}

Console.WriteLine($"Faktorial: {factorial}");

// Task 15

int n = int.Parse(Console.ReadLine()!);
int sum = 0;

while (n > 0)
{
    sum += n % 10;
    n /= 10;
}

Console.WriteLine($"Yig'indi: {sum}");

// Task 16

int n = int.Parse(Console.ReadLine()!);
bool isPrime = true;

if (n < 2)
{
    isPrime = false;
}
else
{
    for (int i = 2; i < n; i++)
    {
        if (n % i == 0)
        {
            isPrime = false;
            break;
        }
    }
}

if (isPrime)
    Console.WriteLine("Tub son");
else
    Console.WriteLine("Tub son emas");
    