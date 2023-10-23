using System;
using System.Linq;

namespace ArrayAndStringsTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            // 26. Дано четырехзначное число. Найти:
            Console.WriteLine("Введите четырехзначное число:");
            string fourDigitNumber = Console.ReadLine();
            if (fourDigitNumber.Length == 4 && int.TryParse(fourDigitNumber, out int number))
            {
                int sumOfDigits = 0;
                int productOfDigits = 1;
                foreach (char digit in fourDigitNumber)
                {
                    int digitValue = int.Parse(digit.ToString());
                    sumOfDigits += digitValue;
                    productOfDigits *= digitValue;
                }
                Console.WriteLine($"a. Сумма его цифр: {sumOfDigits}");
                Console.WriteLine($"b. Произведение его цифр: {productOfDigits}");
            }
            else
            {
                Console.WriteLine("Введено некорректное число.");
            }

            // 27 и 28. Логические выражения
            bool X = false, Y = true, Z = false;
            Console.WriteLine($"27a. X или Z: {X || Z}");
            Console.WriteLine($"27b. X и Y: {X && Y}");
            Console.WriteLine($"27c. X и Z: {X && Z}");

            bool A = true, B = false, C = false;
            Console.WriteLine($"28a. не A и B: {!A && B}");
            Console.WriteLine($"28b. A или не B: {A || !B}");
            Console.WriteLine($"28c. A и B или C: {(A && B) || C}");

            // 29. Определение символов, отличающихся от букв и цифр
            Console.WriteLine("Введите текст для проверки наличия символов, отличных от букв и цифр:");
            string textForSymbolsCheck = Console.ReadLine();
            bool containsOtherSymbols = textForSymbolsCheck.Any(ch => !char.IsLetterOrDigit(ch));
            Console.WriteLine(containsOtherSymbols ? "Текст содержит символы, отличные от букв и цифр." : "Текст состоит только из букв и цифр.");

            // 30. Определение буквы, на которую начинается больше всего слов
            Console.WriteLine("Введите текст:");
            string textToAnalyze = Console.ReadLine();
            var wordGroups = textToAnalyze.Split(new[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).GroupBy(w => w[0]).OrderByDescending(g => g.Count());
            char commonStartingLetter = wordGroups.First().Key;
            Console.WriteLine($"Больше всего слов начинается на букву: {commonStartingLetter}");

            // 31. Подсчет слов, у которых первый и последний символы совпадают
            Console.WriteLine("Введите текст:");
            string textToCheck = Console.ReadLine();
            int matchingCharWordsCount = textToCheck.Split(new[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).Count(w => w[0] == w[w.Length - 1]);
            Console.WriteLine($"Количество слов, у которых первый и последний символы совпадают: {matchingCharWordsCount}");

            // ... и так далее

            Console.ReadKey(); // Ожидание ввода, чтобы консоль не закрывалась сразу
        }
    }
}
