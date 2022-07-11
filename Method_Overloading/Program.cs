// Exercise Method Overloading
static int Add(int x, int y)
{
    int answer = x + y;
    return answer;
}

static decimal Add(decimal x, decimal y)
{
    decimal answer = x + y;
    return answer;
}

static string Add(int x, int y, bool choice)
{
    int answer = x + y;
    

    if (choice == true && answer > 1)
    {
        return $"You have {answer} dollars.";
    }
    else if (choice == true && answer == 1)
    {
        return $"You have {answer} dollar.";
    }
    else if (choice == true && answer < 1)
    {
       return $"You have {answer} dollars.";
    }
    else
    {
        return answer.ToString();
    }
}



// Exercise Method Overloading corrected
static int Add1(int x, int y)
{
    int answer = x + y;
    return answer;
}

static decimal Add2(decimal x, decimal y)
{ 
    decimal answer = x + y;
    return answer;
}

static string Add3(int x, int y, bool choice)
{
    int answer = x + y;

    if (choice == true && answer > 1)
    {
        Console.WriteLine($"You have {answer} dollars.");
        return $"You have {answer} dollars.";
    }
    else if (choice == true && answer == 1)
    {
        Console.WriteLine($"You have {answer} dollar.");
        return $"You have {answer} dollar.";
    }
    else if (choice == true && answer < 1)
    {
        Console.WriteLine($"You have {answer} dollars.");
        return $"You have {answer} dollars.";
    }
    else
    {
        return answer.ToString();
    }
}
Add3(1, 0, true);