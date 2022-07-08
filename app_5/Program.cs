/*
 *   Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
 *   Результат запишите в новом массиве.
 *   [1 2 3 4 5] -> 5 8 3
 *   [6 7 3 6] -> 36 21
 */



namespace App_5
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write($"Введите длину массива: ");
            int len = Convert.ToInt32(Console.ReadLine());

            int[] mass = GetRandomMass( len );
            Console.Write($"Массив: ");
            PrintMass( mass );

            int[] result = ResMass( mass );
            Console.Write($"Произведение пар чисел в одномерном массиве: ");
            PrintMass( result );
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
        
        // возвращает произведение пар чисел массива
        static int[] ResMass( int[] mass )
        {   
             int[] resultMass = new int[mass.Length / 2 + 1];
             int count = 0;

             if ( mass.Length % 2 != 0)
             {   
                while( count < -(-mass.Length / 2))
                {
                    resultMass[count] = mass[count] * mass[mass.Length - ( count + 1 )];
                    count+=1;
                }
                resultMass[count] = mass[count];             
             }
             else
             {  
                while( count < -(-mass.Length / 2))
                {
                    resultMass[count] = mass[count] * mass[mass.Length - ( count + 1 )];
                    count++;
                }  
             }

            return resultMass;
        }    
    }
}