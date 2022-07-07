/*
 *   Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
 *   4; массив [6, 7, 19, 345, 3] -> нет
 *   -3; массив [6, 7, 19, 345, 3] -> да
 */



namespace App_3
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write($"Введите длину массива: ");
            int len = Convert.ToInt32(Console.ReadLine());
            
            Console.Write($"Введите значение элемента для поиска: ");
            int elem = Convert.ToInt32(Console.ReadLine());

            int[] mass = GetRandomMass( len );

            Console.Write($"Массив: ");
            PrintMass(mass);
            
            Console.WriteLine( FindElement( mass, elem ) ); 
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
        
        // проверяет наличие элемента в массиве
        static string FindElement( int[] mass, int elem )
        {   
            string result = string.Empty;
            int count = 0;

            for (int i = 0; i < mass.Length; i++)
			{   
                count = ( mass[i] == elem ) ? count+=1 : count = count;
			}

            return result = ( count > 0 ) ? $"элемент найден" : $"элемент не найден";
        }    
    }
}