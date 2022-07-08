/*
 *   Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
 *   [1 2 3 4 5] -> 5 8 3
 *   [6 7 3 6] -> 36 21
 */



namespace App_4
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write($"Введите длину массива: ");
            int len = Convert.ToInt32(Console.ReadLine());

            double[] mass = GetRandomMass( len );

            Console.Write($"Массив: ");
            PrintMass(mass);
            Console.WriteLine();
            Console.WriteLine( $" { СompositionElements( ref mass ) } "); 
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
        static int[] СompositionElements( ref int[] mass )
        {   
            int count = 0;
            int[] reversMass = new int[mass.Length];

            for (double i = 0; i < Math.Ceiling(mass.Length) / 2; i++)
			{
                ( reversMass[i], mass[mass.Length - ( i + 1 )] ) = ( mass[mass.Length - ( i + 1 )], reversMass[i] );
			
  
                Console.Write($" { reversMass[i] } ");
            }
            
            return reversMass;
        }    
    }
}