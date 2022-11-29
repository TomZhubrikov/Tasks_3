// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool F = true;
while (F) {
    Console.Write("Еnter a five-digit number: ");
    int n = int.Parse(Console.ReadLine());
    if (n > 9999 && n < 100000) {
        if (n / 10000 == n % 10    &&    (n / 1000) % 10 == (n % 100) / 10) {
            Console.WriteLine("Yes!");
            F = false;
        }
        else Console.WriteLine("No!");
    }
}
