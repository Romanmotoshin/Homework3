

void Palindrom() {
    Console.WriteLine("Введите пятизначное число:");
    int number = int.Parse(Console.ReadLine());
    if (number > 9999 && number < 100000) {
        if (number / 10000 == number % 10 && number / 1000 % 10 == number % 100 / 10) {
            Console.WriteLine("Является палиндромом");
        } else {
            Console.WriteLine("Не Является палиндромом");
        }
    } else {
        Console.WriteLine("Число не пятизначное");
    }
    
}

Palindrom();