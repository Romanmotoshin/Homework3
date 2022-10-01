
void Coordinates(int[] first, int[] second ) {
    double answer = Math.Sqrt(Math.Pow((second[0] - first[0]), 2) + Math.Pow((second[1] - first[1]), 2) + Math.Pow((second[2] - first[2]), 2));

    Console.WriteLine("Расстояние равно: " + answer);
}

Coordinates(new int[] {1,2,3}, new int[] {3,4,5});