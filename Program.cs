using System;
class Program
{
    static void Main(string[] args)
{
    // VERSION: 2.0.0-MAIN
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
