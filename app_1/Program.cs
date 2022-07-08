/*
 *  Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
 *  Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
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
            
            Console.WriteLine($"Cумма отрицательных элементов: { SumElementNegative(mass) }");
            Console.WriteLine($"Cумма отрицательных элементов: { SumElement(mass) }");
            
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

        // возвращает сумму отрицательных элементов
        static int SumElementNegative( int[] mass)
        {   
            int result = 0;

            for (int i = 0; i < mass.Length; i++)
			{
                if ( mass[i] < 0)
	            {
                    result = result + mass[i];  
	            }
			}

            return result;
        }
        
        // возвращает сумму положительных элементов
        static int SumElement( int[] mass)
        {   
            int result = 0;

            for (int i = 0; i < mass.Length; i++)
			{
                if ( mass[i] > 0)
	            {
                    result = result + mass[i];  
	            }
			}

            return result;
        }
    }
}