/*
 *   Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество 
 *   чётных чисел в массиве.
 *   [345, 897, 568, 234] -> 2
 */



namespace App_6
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
            
            Console.WriteLine( $"Количество чётных чисел в массиве = { QuantityElement( mass ) } "); 
        }

        // заполняет массив рандомными в диапазоне 1 : 200
        static int[] GetRandomMass( int len )
        {   
            int[] mass = new int[len];

            for (int i = 0; i < mass.Length; i++)
			{
                mass[i] = new Random().Next( 100,200 );
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
        
        // определяет коичество количество чётных чисел в массиве
        static int QuantityElement( int[] mass )
        {   
            int count = 0;

            for (int i = 0; i < mass.Length; i++)
			{   
                if ( mass[i] % 2 == 0)
                {
                    count++;
                }
			}

            return count;
        }    
    }
}