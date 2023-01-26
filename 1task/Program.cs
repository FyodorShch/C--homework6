/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */

Console.Clear();

int[] CreateArray(string StringArr, int M)
{
    string[] array = StringArr.Split(" ", ' ', StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[M];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = int.Parse(array[i]);
    }
    return result;
}
void CountOfNotNull(int[] mass)
{
    int count = 0;
    for (int k = 0; k < mass.Length; k++)
    {
        if (mass[k] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Количество чисел введённых чисел > 0 равно {count}");
}

int N = int.Parse(Console.ReadLine());
int[] Array = CreateArray(Console.ReadLine(), N);
CountOfNotNull(Array);