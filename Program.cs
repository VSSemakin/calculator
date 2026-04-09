using System;
class Program
{
    O references
    static int Add(int a, int b)
    { return a + b; }

    0 references
    static int Subtract(int a, int b)
    { return a - b; }

    O references
    static int Multiply(int a, int b)
    { return a * b; }

    O references
    static void Main(string[] args)
    {
        // VERSION: 2.0.0-FINAL
        // Здесь будет логика калькулятора
        
        Console.Write("Введите первое число: ");
        string input1 = Console.ReadLine();
        int num1 = int.Parse(input1);
        
        Console.Write("Введите второе число: ");
        string input2 = Console.ReadLine();
        int num2 = int.Parse(input2);
        
        Console.Write("Выберите операцию (+, -, *): ");
        string operation = Console.ReadLine();
        
        int result = 0;
        
        if (operation == "+")
            result = num1 + num2;
        else if (operation == "-")
            result = num1 - num2;
        else if (operation == "*")
            result = num1 * num2;
        
        Console.WriteLine($"Результат: {result}");
    }

}
