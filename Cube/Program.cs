
void Cube() {
    Console.WriteLine("Введите число больше нуля");
    int number = int.Parse(Console.ReadLine());
    for(int i = 1; i <= number; i++) {
        Console.WriteLine(i + "--->" + Math.Pow(i, 3));
    }
    
}

Cube();
