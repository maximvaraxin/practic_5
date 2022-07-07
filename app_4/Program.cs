/*
 *   Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке 
 *   [10,99].
 *   Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
 *   [5, 18, 123, 6, 2] -> 1
 *   [1, 2, 3, 6, 2] -> 0
 *   [10, 11, 12, 13, 14] -> 5
 */



namespace App_4
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write($"Введите длину массива: ");
            int len = Convert.ToInt32(Console.ReadLine());

            int[] mass = GetRandomMass( len );

            Console.Write($"Массив: ");
            PrintMass(mass);
            
            Console.WriteLine( $"Количество элементов в диапазоне [10,99] = { QuantityElement( mass ) } "); 
        }

        // заполняет массив рандомными в диапазоне 10 : 99
        static int[] GetRandomMass( int len )
        {   
            int[] mass = new int[len];

            for (int i = 0; i < mass.Length; i++)
			{
                mass[i] = new Random().Next( 1,200 );
			}

            return mass;

        }

        // возвращает массив в консоль
        static void PrintMass( int[] mass )
        {
            for (int i = 0; i < mass.Length; i++)
			{
                Console.Write($"{mass[i]} ");
			}

            Console.WriteLine();
        }
        
        // определяет коичество элементов массива в диапазоне [10,99]
        static int QuantityElement( int[] mass )
        {   
            int count = 0;

            for (int i = 0; i < mass.Length; i++)
			{   
                if ( mass[i] >= 10 && mass[i] <= 99)
                {
                    count++;
                }
			}

            return count;
        }    
    }
}