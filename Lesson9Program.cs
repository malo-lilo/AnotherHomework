/*Создать двумерный массив целых чисел (4 * 5) и заполнить его рандомными значениями 
    Найти минимальный элемент в этом массиве (вывести его в консоль) + я добавила поиск максимального элемента*/



class Program
{
    static void Main()
    {
        
        int[,] array = new int[4, 5];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.WriteLine();
            for (int j = 0; j < array.GetLength(1); j++)
            {
                var random = new Random();
                array[i, j] = random.Next(50);
                Console.Write("{0, 3}", array[i, j]);
            }
        }
        int minVal = array[0, 0];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (minVal > array[i, j])
                    minVal = array[i, j];
                    
            }
        }
        Console.WriteLine();
        Console.Write("минимальный элемент = " + minVal);

        int maxVal = array[0, 0];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (maxVal < array[i, j])
                    maxVal = array[i, j];

            }
        }
        Console.WriteLine();
        Console.Write("максимальный элемент = " + maxVal);
    }
}