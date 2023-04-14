
int n = 5;

// ConstantTimeExample(n);
// LinearTimeExample(n);
// LogarithmicTimeExample(n);
// LogLinearTimeExample(n);
//ExponentialTimeExample(n);
FactorialTimeExample(n);

static void ConstantTimeExample(int n)
{
    System.Console.WriteLine($"Constant time example: {n}"); // One Step
}

static void LinearTimeExample(int n)
{
    for (int i = 1; i < n; i++)
    {
        System.Console.WriteLine($"Linear time example: {i}"); // N Step (Binary Tree)
    }
}

static void LogarithmicTimeExample(int n)
{
    for (int i = 1; i < n; i = i * 2)
    {
        System.Console.WriteLine($"Logarithmic time example: {i}");
    }
}


static void LogLinearTimeExample(int n)
{
    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j < n; j = j * 2)
        {
            System.Console.WriteLine($"Loglinear time: {i} and {j}");
        }
    }
}


static void QuadraticTimeExample(int n) // Polynominal Time O(n^p): O(n^2) Quadratic -  O(n^3): Cubic -  O(n^4): Quadric
{
    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= n; j = j++)
        {
            System.Console.WriteLine($"Quadratic time: {i} and {j}");
        }
    }
}

static void ExponentialTimeExample(int n)
{
    for (int i = 1; i <= Math.Pow(2, n); i++)
    {
        System.Console.WriteLine($"Exponential time: {i}");
    }
}

static void FactorialTimeExample(int n)
{
    for (int i = 1; i <= Factorial(n); i++)
    {
        System.Console.WriteLine($"Factorial time: {i}");
    }
}

static int Factorial(int n)
{
    if (n == 0)
        return 1;

    return n * Factorial(n - 1);
}