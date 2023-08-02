// See https://aka.ms/new-console-template for more information

using System.Numerics;

int CheckNum(int num1, int num2)
{
    if (num1 == num2)
    {
        return 0;
    }

    if (num1 < 100 &&  num2 < 100)
    {
        return num1 > num2 ? num1 : num2;
    }
    else
    {
        return num1 < num2 ? num1 : num2;
    }
}

bool CheckNumArr(int[] ints, int specNum)
{
    return ints.Contains(specNum);
}

bool CheckSeq(int[] ints)
{
    int[] seq = { 1, 2, 3 };
    int count = 0;
    foreach (int i in ints)
    {
        if (seq.Contains(i))
        {
            count++;
        }
    }

    return count == 3;
}

bool CheckMulti(int num)
{
    if (num % 3 == 0)
    {
        return true;
    } else if (num % 7 == 0)
    {
        return true;
    } else
    {
        return false;
    }
}

string SubStr(string str)
{
    if (str.Length >= 2)
    {
        return str.Substring(0, 2);
    }
    else
    {
        return str;
    }
}

void Operation(int num1, int num2, string op)
{
    if (op == "+")
    {
        Console.WriteLine($"Expected Output : {num1} + {num2} = {num1 + num2}");
    } else if (op == "-")
    {
        Console.WriteLine($"Expected Output : {num1} - {num2} = {num1 - num2}");
    } else if (op == "*")
    {
        Console.WriteLine($"Expected Ouput : {num1} * {num2} = {num1 * num2}");
    } else
    {
        Console.WriteLine($"Expected Output : {num1} / {num2} = {num1 / num2}");
    }
}

bool TwoNums(int num1, int num2)
{
    string result1 = num1 % 2 == 0 ? "Even" : "Odd";
    string result2 = num2 % 2 == 0 ? "Even" : "Odd";

    if (result1 == result2)
    {
        return true;
    }
    else
    {
        return false;
    }
}

string MiddleStr(string str)
{
    int strLength = str.Length;
    bool isEven = str.Length % 2 == 0;
    if (strLength >= 2 && isEven)
    {
        return str.Substring(strLength / 2 - 1, 2);
    } else
    {
        return str;
    }
}

string BinaryForm(int num)
{
    return Convert.ToString(num, 2);
}

void TempState(int temp)
{
    if (temp < 0)
    {
        Console.WriteLine("Freezing Weather");
    } else if (temp < 10)
    {
        Console.WriteLine("Very Cold Weather");
    } else if (temp < 20)
    {
        Console.WriteLine("Cold Weather");
    } else if (temp < 30)
    {
        Console.WriteLine("Normal in Temp");
    } else if (temp < 40)
    {
        Console.WriteLine("Its Hot");
    } else
    {
        Console.WriteLine("Its Very Hot");
    }
}

void OutputDay(int day)
{
    switch (day)
    {
        case 1:
            Console.WriteLine("Monday");
            break;
        case 2:
            Console.WriteLine("Tuesday");
            break;
        case 3:
            Console.WriteLine("Wednesday");
            break;
        case 4:
            Console.WriteLine("Thursday");
            break;
        case 5:
            Console.WriteLine("Friday");
            break;
        case 6:
            Console.WriteLine("Saturday");
            break;
        case 7:
            Console.WriteLine("Sunday");
            break;
    }
}

bool IsPrime(int n)
{
    for (int i = 2; i < n - 1; i++)
    {
        if (n % i == 0)
        {
            return false;
        }
    }
    return true;
}

int CountSpaces(string str)
{
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str.ElementAt(i) == ' ')
        {
            count++;
        }
    }
    return count;
}

bool CanVote(int age)
{
    if (age >= 21)
    {
        return true;
    }
    else
    {
        return false;
    }
}