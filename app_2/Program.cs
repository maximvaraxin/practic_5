/*
 *  Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
 *  [-4, -8, 8, 2] -> [4, 8, -8, -2]
 */



namespace App_1
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
            
            ReverseElements( ref mass );
            PrintMass(mass); 
        }

        // заполняет массив рандомными в диапазоне -9 : 9
        static int[] GetRandomMass( int len )
        {   
            int[] mass = new int[len];

            for (int i = 0; i < mass.Length; i++)
			{
                mass[i] = new Random().Next( -9,9 );
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
        
        // реверс знаков элементов массива
        static void ReverseElements( ref int[] mass )
        {   
            int[] result = new int[ mass.Length ];

            for (int i = 0; i < mass.Length; i++)
			{
                if ( mass[i] < 0 )
	            {
                    result[i] = Math.Abs(mass[i]);
	            }
                else
                {
                    result[i] = -mass[i];
                }
			}

            mass = result;
        }
        
    }
}