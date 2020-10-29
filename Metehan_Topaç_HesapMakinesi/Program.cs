using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Console = Colorful.Console;
using System.Threading;
using Colorful;
using System.Diagnostics;

namespace Metehan_Topaç_HesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Title();
            ProgressBar();
            Console.WriteLine();
            for (int j = 1; j <= 5; j++)
            {
                for (int k = 1; k <= j; k++)
                {
                    Console.Write("*", Color.DarkOrchid);
                    Thread.Sleep(30);
                }
                Console.WriteLine();
            }
            for (int g = 1; g <= 4; g++)
            {
                for (int h = 4; h >= g; h--)
                {
                    Console.Write("*", Color.DarkOrchid);
                    Thread.Sleep(30);
                }
                Console.WriteLine();
            }
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Calculator();
            }
        }

        private static void Calculator()
        {
            Console.WriteAscii("Calculator", Color.DarkOrange);
            Console.WriteLine("Lütfen hesap makinesi türünü numaraları kullanarak seçiniz.", Color.LightBlue);
            Console.WriteLine("1) BilgeAdam Teknoloji Klasik Hesap Makinesi", Color.LightBlue);
            Console.WriteLine("2) İkiden fazla sayıyı toplama işlemi", Color.LightBlue);
            Console.WriteLine("3) İkiden fazla sayıyı çarpma işlemi", Color.LightBlue);
            Console.WriteLine("4) Çıkış", Color.IndianRed);
            Console.Write("Hesap Makinesi Numarası: ", Color.LightBlue);
            int calculatorNo = int.Parse(Console.ReadLine());
            switch (calculatorNo)
            {
                case 1:
                    SimpleCalculator();
                    break;
                case 2:
                    AddNumbers();
                    break;
                case 3:
                    MultiplyNumbers();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
            }
            SimpleCalculator();
            
            Console.ReadLine();
        }

        static void MultiplyNumbers()
        {
            double sonuc;
            sonuc = 1;
            Console.Write("Çarpılacak Sayı Adedi: ", Color.WhiteSmoke);
            int howmany = int.Parse(Console.ReadLine());
            double[] input = new double[howmany];
            for (int i = 1; i <= howmany; i++)
            {
                Console.Write(i + ". Sayı: ", Color.WhiteSmoke);
                input[i-1] = double.Parse(Console.ReadLine());
                
            }
            foreach (var number in input)
            {
                sonuc = sonuc * number;
            }
            Console.WriteLine("Sonuç: " + sonuc, Color.Green);
            Console.WriteLine("Programdan çıkmak için ESC'ye, yeni bir işlem yapmak için ENTER'a ve ana menüye dönmek için TAB'e tıklayınız.", Color.DarkCyan);
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.Tab:
                    Calculator();
                    break;
                case ConsoleKey.Enter:
                    MultiplyNumbers();
                    break;
                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;
            }
        }

        static void AddNumbers()
        {
            double sonuc;
            sonuc = 0;
            Console.Write("Toplanacak Sayı Adedi: ", Color.WhiteSmoke);
            int howmany = int.Parse(Console.ReadLine());
            double[] input = new double[howmany];
            for (int i = 1; i <= howmany; i++)
            {
                Console.Write(i + ". Sayı: ", Color.WhiteSmoke);
                input[i - 1] = double.Parse(Console.ReadLine());

            }
            foreach (var number in input)
            {
                sonuc = sonuc + number;
            }
            Console.WriteLine("Sonuç: " + sonuc, Color.Green);
            Console.WriteLine("Programdan çıkmak için ESC'ye, yeni bir işlem yapmak için ENTER'a ve ana menüye dönmek için TAB'e tıklayınız.", Color.DarkCyan);
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.Tab:
                    Calculator();
                    break;
                case ConsoleKey.Enter:
                    AddNumbers();
                    break;
                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;
            }
        }

        private static void SimpleCalculator()
        {
            double input1, input2, sonuc;
            sonuc = 0;
            char symbol;
            Console.Write("1. Sayı: ", Color.WhiteSmoke);
            input1 = double.Parse(Console.ReadLine());
            Console.Write("2. Sayı: ", Color.WhiteSmoke);
            input2 = double.Parse(Console.ReadLine());
            Console.Write("İşaret: ", Color.WhiteSmoke);
            symbol = char.Parse(Console.ReadLine());
            switch (symbol)
            {
                case '+':
                    sonuc = input1 + input2;
                    break;
                case '-':
                    sonuc = input1 - input2;
                    break;
                case '*':
                    sonuc = input1 * input2;
                    break;
                case '/':
                    sonuc = input1 / input2;
                    break;
                default:
                    Console.WriteLine("Lütfen +,-,*,/ işaretlerinden birini giriniz.", Color.Red);
                    break;
            }
            Console.WriteLine("Sonuç: " + sonuc, Color.Green);
            Console.WriteLine("Programdan çıkmak için ESC'ye, yeni bir işlem yapmak için ENTER'a ve ana menüye dönmek için TAB'e tıklayınız.", Color.DarkCyan);
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.Tab:
                    Calculator();
                    break;
                case ConsoleKey.Enter:
                    SimpleCalculator();
                    break;
                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;
            }

        }

        static void Title()
        {
            Console.WriteAscii("Welcome to", Color.Aqua);
            Console.WriteAscii("    Epic Calculator", Color.Purple);
            Console.WriteLine("                                         Coded by Metehan Topac", Color.Red);
        }
        static void ProgressBar()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.Write($"\rInitializing: {i}%   ", Color.Blue);
                Thread.Sleep(30);
            }

            Console.Write("\rDone! Please click ENTER to continue.", Color.Green);
        }
    }
}
