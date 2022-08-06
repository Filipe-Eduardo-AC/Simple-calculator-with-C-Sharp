do
{
    double num1;
    double num2;
    string op;
    double result;

    Console.WriteLine("------------------");
    Console.WriteLine("Simple C# Calculator");
    Console.WriteLine("------------------");

    Console.Write("\nEnter a number: ");
    num1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter Operator: ");
    op = Console.ReadLine();

    Console.Write("Enter another number: ");
    num2 = Convert.ToDouble(Console.ReadLine());

    switch (op)
    {
        case "+":
            result = num1 + num2;
            Console.WriteLine("Result = " + result);
            break;
        case "-":
            result = num1 - num2;
            Console.WriteLine("Result = " + result);
            break;
        case "*":
            result = num1 * num2;
            Console.WriteLine("Result = " + result);
            break;
        case "/":
            result = num1 / num2;
            Console.WriteLine("Result = " + result);
            break;
        default:
            Console.WriteLine("Invalid Operator");
            break;
    }

    Console.WriteLine("\nWant to use the calculator again? (Y/N): ");
} while (Console.ReadLine().ToUpper() == "Y");