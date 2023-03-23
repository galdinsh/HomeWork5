void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(new Random().NextDouble() * (50 - 1) + 1, 2); // [1, 50]
}

double NumberDifference (double[] array)
{
    double max = 0; double min = array[0]; double dif = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
        if  (array[i] > max)
            max = array[i]; 
    dif = Math.Round((max - min), 2);  
    }
    return dif;
}
Console.Clear();
Console.Write("Введите кол-во элементов в массив: ");
int n = int.Parse(Console.ReadLine()!);
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join("; ", array)}]");
Console.WriteLine($"Разница максимального и минимального элементов массива: {NumberDifference(array)}");