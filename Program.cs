Console.Write("Введите элементы: ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int x = 0;
 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        x++;
    }
}
 
Console.WriteLine($"Кол-во элементов больше нуля: {x}");