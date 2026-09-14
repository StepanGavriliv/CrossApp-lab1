using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("CrossApp - практикум з крос-платформного програмування");
        Console.WriteLine("Студент: Гаврилів Степан, група Феі-37");
        Console.WriteLine(new string('-', 52));

        Console.WriteLine($"OC (OSDescription): {RuntimeInformation.OSDescription}");
        Console.WriteLine($"OC (Environment): {Environment.OSVersion}");
        Console.WriteLine($"Архітектура процесу: {RuntimeInformation.ProcessArchitecture}");
        Console.WriteLine($".NET CLR Version: {Environment.Version}");
        Console.WriteLine($"Runtime: {RuntimeInformation.FrameworkDescription}");
        Console.WriteLine($"Каталог застосунку: {AppContext.BaseDirectory}");
        Console.WriteLine($"Поточний каталог: {Environment.CurrentDirectory}");
        Console.WriteLine(new string('-', 52));

        // Предметна область (обери одну з варіантів: Склад / Бібліотека / Замовлення)
        Console.WriteLine("Предметна область: Бібліотека (Book, BookCopy, Reader, Loan)");
    }
}