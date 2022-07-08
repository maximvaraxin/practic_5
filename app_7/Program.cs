/*
 *   Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
 *   [3, 7, 23, 12] -> 19
 *   [-4, -6, 89, 6] -> 0
 */



namespace App_7
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
            
            Console.WriteLine( $"Cумма элементов, стоящих на нечётных позицияхе = { SumElement( mass ) } "); 
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
        
        // определяет сумму элементов, стоящих на нечётных позициях
        static int SumElement( int[] mass )
        {   
            int result = 0;

            for (int i = 0; i < mass.Length; i++)
			{   
                if ( (i + 1 ) % 2 == 1)
                {
                    result = result + mass[i];
                }
			}

            return result;
        }    
    }
}