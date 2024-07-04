using System;
using System.Linq;

class Program
{
    static void Main()
    {
        double size;
        while (true)
        {
            Console.Write("Введите размерность массива: ");
            if (double.TryParse(Console.ReadLine(), out size) && size > 0)
                break;
            Console.WriteLine("Некорректное значение. Попробуйте снова.");
        }

        int[] array = new int[size];
        Random rand = new Random();
        for (int i = 0; i < size; i++)
        {
            array[i] = rand.Next(1, 101); 
        }

        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Массив: " + string.Join(", ", array));
            Console.WriteLine("Меню:");
            Console.WriteLine("1. Найти и вывести сумму всех элементов массива");
            Console.WriteLine("2. Найти и вывести максимальное значение из всех элементов в массиве");
            Console.WriteLine("3. Найти и вывести второе по величине значение в массиве");
            Console.WriteLine("4. Найти и вывести количество уникальных элементов в массиве");
            Console.WriteLine("5. Найти и вывести первый уникальный элемент массива");
            Console.WriteLine("6. Поменять местами элементы с максимальным и минимальным значениями в массиве и вывести результат");
            Console.WriteLine("7. Обменять местами значение первого и последнего элементов массива и вывести полученный массив на экран");
            Console.WriteLine("8. Отсортировать массив по возрастанию и вывести отсортированный массив");
            Console.WriteLine("9. Отсортировать массив по убыванию и вывести отсортированный массив");
            Console.WriteLine("10. Переместить все четные элементы массива в начало, а нечетные — в\r\nконец массива и вывести его на консоль");
            Console.WriteLine("11. Выход");
            Console.Write("Выберите пункт: ");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Вы выбрали Пункт 1");
                        int sum = array.Sum();
                        Console.WriteLine("Сумма элементов массива: " + sum);
                        break;
                    case 2:
                        Console.WriteLine("Вы выбрали Пункт 2");
                        int maxValue = array.Max();
                        Console.WriteLine("Максимальный эллемент массива: " + maxValue);
                        break;
                    case 3:
                        Console.WriteLine("Вы выбрали Пункт 3");
                        int maxValue1 = array.Max();
                        int secondMaxValue = array.Where(x => x != maxValue1).Max();
                        Console.WriteLine("Второе по величине значение в массиве: " + secondMaxValue);
                        break;
                    case 4:
                        Console.WriteLine("Вы выбрали Пункт 4");
                        int uniqueCount = array.Distinct().Count();
                        Console.WriteLine("Количество уникальных элементов в массиве: " + uniqueCount);
                        break;
                    case 5:
                        Console.WriteLine("Вы выбрали Пункт 5");
                        int firstUnique = array.GroupBy(x => x)
                               .Where(g => g.Count() == 1)
                               .Select(g => g.Key)
                               .FirstOrDefault();
                        if (firstUnique != 0)
                        {
                            Console.WriteLine("Первый уникальный элемент в массиве: " + firstUnique);
                        }
                        else
                        {
                            Console.WriteLine("Уникальных элементов нет.");
                        }
                        break;
                    case 6:
                        Console.WriteLine("Вы выбрали Пункт 6");
                        int maxIndex = Array.IndexOf(array, array.Max());
                        int minIndex = Array.IndexOf(array, array.Min());
                        int temp = array[maxIndex];
                        array[maxIndex] = array[minIndex];
                        array[minIndex] = temp;
                        Console.WriteLine("Массив после замены:");
                        foreach (int item in array)
                        {
                            Console.Write(item + " ");
                        }
                        break;
                    case 7:
                        Console.WriteLine("Вы выбрали Пункт 7");
                        int temp1 = array[0];
                        array[0] = array[array.Length - 1];
                        array[array.Length - 1] = temp1;
                        Console.WriteLine("Массив после замены:");
                        foreach (int item in array)
                        {
                            Console.Write(item + " ");
                        }
                        break;
                    case 8:
                        Console.WriteLine("Вы выбрали Пункт 8");
                        Array.Sort(array);
                        Console.WriteLine("Отсортированный массив:");
                        foreach (int item in array)
                        {
                            Console.Write(item + " ");
                        }
                        break;
                    case 9:
                        Console.WriteLine("Вы выбрали Пункт 9");
                        array = array.OrderByDescending(x => x).ToArray();
                        Console.WriteLine("Отсортированный массив:");
                        foreach (int item in array)
                        {
                            Console.Write(item + " ");
                        }
                        break;
                    case 10:
                        Console.WriteLine("Вы выбрали Пункт 10");
                        int[] sortedArray = array.OrderBy(x => x % 2 != 0).ToArray();
                        Console.WriteLine("Массив после перемещения четных и нечетных элементов:");
                        foreach (int item in sortedArray)
                        {
                            Console.Write(item + " ");
                        }
                        break;
                    case 11:
                        exit = true;
                        Console.WriteLine("Выход из программы...");
                        break;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Пожалуйста, введите число.");
            }
        }
    }
}
