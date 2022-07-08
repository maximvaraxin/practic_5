/*
 *   Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
 *   [3 7 22 2 78] -> 76
 */



namespace App_8
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
            
            Console.WriteLine( $"Cумма максимального и минимального элемента массива = { SumElement( mass ) } "); 
        }

        // заполняет массив рандомными в диапазоне 1 : 200
        static double[] GetRandomMass( int len )
        {   
            double[] mass = new double[len];

            for (int i = 0; i < mass.Length; i++)
			{
                mass[i] = new Random().Next( 100,200 );
			}

            return mass;

        }

        // возвращает массив в консоль
        static void PrintMass( double[] mass )
        {
            for (int i = 0; i < mass.Length; i++)
			{
                Console.Write($"{mass[i]} ");
			}

            Console.WriteLine();
        }
        
        // определяет сумму максимального и минимального элемента массива
        static double SumElement( double[] mass )
        {   
            double result = 0;
            double maxElem = mass[0];
            double minElem = mass[0];    

            for (int i = 0; i < mass.Length; i++)
			{   
                if (mass[i] < minElem)
                {
                    minElem = mass[i];
                }
                else if( mass[i] > maxElem )
                {
                    maxElem = mass[i];
                }
			}
            Console.WriteLine( $"Максимальный элемент массива: {maxElem}" );
            Console.WriteLine( $"Максимальный элемент массива: {minElem}" );
            result = maxElem + minElem;

            return result;
        }    
    }
}