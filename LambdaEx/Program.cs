int Add(int a, int b)
{
    return a + b;
}

Func<int, int , int> sum = (a,b)=> a+b;

bool IsEven(int n)
{
    return n % 2 == 0;
}

Func<int, bool> isEven  = n=>  n % 2 == 0;

string FormatCurrency(double amount)
{
    return $"${amount:N2}";
}

Func<double, string> currency = amount => $"${amount}";


void Log(string message)
{
    Console.WriteLine("[LOG]: " + message);
}

Action<string> logging = log => Console.WriteLine(log);

double GetPercentage(double part, double total)
{
    return (part / total) * 100;
}

Func<double,double,double> percentage = (part, total) => (part / total) * 100;


Func<int, int> getDiscount = age =>
{
    if (age > 60) return 20;
    else return 0;
};

int getDiscount1 (int age)
{
    if (age > 60) 
    {
        return 60;
    } else { 
        return 0; 
    }
} 

