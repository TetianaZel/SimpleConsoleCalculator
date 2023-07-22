using Calc;

bool endApp = false;
Console.WriteLine( "C# simple calculator");
Console.WriteLine(  "___________________________");
while (!endApp)
{
    string input1 = "";
    string input2 = "";
    double result = 0;

    Console.WriteLine("Please enter number 1 and press Enter");
    input1 = Console.ReadLine();

    double num1 = 0;
    while (!double.TryParse(input1, out num1))
    {
        Console.WriteLine("Input is not valid. Please try again");
        input1 = Console.ReadLine();
    }

    Console.WriteLine("Please enter number 2 and press Enter");
    input2 = Console.ReadLine();

    double num2 = 0;
    while (!double.TryParse(input2, out num2))
    {
        Console.WriteLine("Input is not valid. Please try again");
        input2 = Console.ReadLine();
    }

    Console.WriteLine("Choose an operator from the following list:");
    Console.WriteLine("\ta - Add");
    Console.WriteLine("\ts - Subtract");
    Console.WriteLine("\tm - Multiply");
    Console.WriteLine("\td - Divide");
    Console.Write("Your option? ");

    string op = Console.ReadLine();

    try
    {
        result = Calculator.DoOperation(num1, num2, op);
        if (double.IsNaN(result))
        {
            Console.WriteLine("Error in math operation");
        }

        else
        {
            Console.WriteLine("Your result: {0:0.##}\n", result);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Exception has occured when trying to do the math. \n  - Details: " + ex.Message);
    }

    Console.WriteLine("____________________________\n");
    Console.WriteLine("To close the app press 'n' and Enter, or press any other key and Enter to continue: ");
    if (Console.ReadLine() == "n")
    {
        endApp = true;
    }

}

