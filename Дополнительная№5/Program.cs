void Odd(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 1)
            Console.Write($" {string.Join(" ", array[i])}");
    }
}
void Even(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
            Console.Write($" {string.Join(" ", array[i])}");
    }
}
void dif(int[] array)
{
    int s = 0; int m = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0) s++;
        else m++;        
    }
    if(s <= m)
    Console.Write(" Yes");
    else
    Console.Write(" No");
}
Console.Clear();
Console.Write("Введите кол-во дней от 1 до 31: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
Console.WriteLine("Введите даты: ");
for (int i = 0; i < array.Length; i++)
    array[i] = Convert.ToInt32(Console.ReadLine());           
Even(array);
Console.WriteLine();
Odd(array);
Console.WriteLine();
dif(array);
