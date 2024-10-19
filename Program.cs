using System.Data;
using System.Diagnostics;
using System.IO.Pipes;

namespace Array_Object
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Task1

            int[] numbers = new int[] { 1, 2, 17, 20, 5, 6, 7, 8, 9, 10, 11 };
            int max = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {

                if (numbers[i] > max)
                {
                    max = numbers[i];

                }

            }

            foreach (int num in numbers)
            {
                if (num > max)
                {

                    max = num;
                }

            }

            Console.WriteLine(max);
            #endregion


            #region Task2


            var products = new (int Id, string Name , double Price, int StockCount)[]
          {
            (1, "Apple", 300.3 ,12),
            (2, "Banana", 200, 13),
            (3, "Cherry", 700.3, 14)
          };

            double sum = 0;
            

            for (int i = 0; i < products.Length; i++) {

                if (products[i].Id % 2 != 0)
                {

                    sum += products[i].Price;
                   
                }

               

            }
            double avg = sum / 2;
            Console.WriteLine($"Sayi: {avg}");

            #endregion

           
        }
    }

}