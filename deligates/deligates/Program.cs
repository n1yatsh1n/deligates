using System;
using System.Collections.Generic;

namespace deligates
{
    interface IMath
    {
        double Plus(double num1, double num2);
        double Subtract(double num1, double num2);
        double Multiply(double num1, double num2);
        double Division(double num1, double num2);

    }

    public class Action : IMath
    {
        public double Plus(double num1, double num2)
        {
            return num1 + num2;
        }
        
        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }
        
        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        
        public double Division(double num1, double num2)
        {
            return num1 / num2;
        }
    }
    
    
    class Program
    {
        delegate double ActionMath(double number_1, double number_2);

        static Action mathClass = new Action();
        public static void Main()
        {
            ActionMath math;
            Console.WriteLine("Введите первое число:");
            var number_1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            var number_2 = Convert.ToDouble(Console.ReadLine());
            Menu();
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    math = mathClass.Plus;
                    var result_1 = math(number_1, number_2);
                    Console.WriteLine(result_1);
                    Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
                    Console.ReadKey();
                    Console.Clear();
                    Main();
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    math = mathClass.Subtract;
                    var result_2 = math(number_1, number_2);
                    Console.WriteLine(result_2);
                    Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
                    Console.ReadKey();
                    Console.Clear();
                    Main();
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    math = mathClass.Multiply;
                    var result_3 = math(number_1, number_2);
                    Console.WriteLine(result_3);
                    Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
                    Console.ReadKey();
                    Console.Clear();
                    Main();
                    break;
                case ConsoleKey.D4:
                    Console.Clear();
                    math = mathClass.Division;
                    var result_4 = math(number_1, number_2);
                    Console.WriteLine(result_4);
                    Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
                    Console.ReadKey();
                    Console.Clear();
                    Main();
                    break;
                case ConsoleKey.D5:
                    Console.Clear();
                    Console.WriteLine("бб");
                    break;
            }
             
        }

        public static void Menu()
        {
            Console.WriteLine("МЕНЮ\n" +
                              "1. Сложить\n" +
                              "2. Вычесть\n" +
                              "3. Умножить \n" +
                              "4. Делить");
        }

        
    }
    

}