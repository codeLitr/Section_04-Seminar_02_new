int number = new Random().Next(100, 1000); // 100-999

int firstDigit = number / 100; // 1 цифра

int thirdDigit = number % 10; // 3 цифра

int result = firstDigit * 10 + thirdDigit;
Console.WriteLine("Исходное число: " + number);
Console.WriteLine("Первая и третья цифра числа: " + result);
