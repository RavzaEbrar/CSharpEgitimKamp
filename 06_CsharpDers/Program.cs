using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_CsharpDers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //1
            //string[] colors = new string[4];
            //colors[0] = "red";
            //colors[1] = "green";
            //colors[2] = "blue";
            //colors[3] = "brown";
            //Console.WriteLine(colors[2]);


            //2
            //string[] city = new string[5];

            //city[0] = "istanbul";
            //city[1] = "paris";
            //city[2] = "milano";
            //city[3] = "sivas";
            //city[4] = "seoul";

            //Console.WriteLine(city[4]);


            //3
            //int[] numbers = new int[10];
            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;
            //numbers[3] = 4;
            //numbers[4] = 5;
            //numbers[5] = 6;
            //numbers[6] = 7;
            //numbers[7] = 8;

            //Console.WriteLine(numbers[7]);

            //4
            //string[] cities = { "roma","prag","atina","ankara" };
            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //1
            //string[] colors = {"blue","pink","brown","white" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //2
            //int[] number = { 341, 235, 36, 453, 238 };
            //for (int i = 0; i < number.Length; i++)
            //{
            //    if (number[i]%3 ==0)
            //    {
            //        Console.WriteLine(number[i]);
            //    }
            //}

            //3
            //char[] symbol = { 'A', 'b', 'c', '*', '+', '/', '-' };
            //for (int i = 0; i < symbol.Length; i++)
            //{
            //    Console.WriteLine(symbol[i]);
            //}

            //4
            //int[] myArray = { 1, 2, 3, 38,4, 5 };
            // int maxnumber=myArray[0];
            //for (int i = 0; i <myArray.Length; i++)
            //{
            //    if (myArray[i] > maxnumber)
            //    {
            //        maxnumber = myArray[i];
            //    }
            //}Console.WriteLine(maxnumber);

            //5
            //string[] persons = {"ali","ahmet","ayse","akif","elif" };
            //Console.WriteLine(persons.Length);

            //6
            //int[] numbers = { 12, 24, 53, 4, 5,6 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //7
            //int[] numbers = { 12, 24, 53, 4, 5, 6 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region Dizi Metotlar

            //1
            //string[] customers = { "ayse", "ali", "buse", "merve" };
            //int index = Array.IndexOf(customers, "ali");
            //Console.WriteLine(index);

            //2
            //int[] numbers = { 923, 948, 07, 783, 745 };
            //Console.WriteLine("dizininen büyük elemanı: " + numbers.Max()+"   "+"dizinin en küçük elemanı: "+numbers.Min());

            #endregion

            #region Kullanıcıdan Değer Alma

            //1
            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"lütfen{i+1}.şehri giriniz: ");
            //    cities[i]=Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("---------------------------");

            //for (int i = 0;i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //2
            //int[] number = { 1, 2, 3, 4, 5 };
            //int sum = 0;
            //for (int i = 0; i < number.Length; i++)
            //{
            //    sum += number[i];
            //}Console.WriteLine(sum);


            //3
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine("Çift Sayılar");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] %2==0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("Tek Sayılar");
            //for (int i = 0;i < numbers.Length; i++)
            //{
            //    if(numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


            #endregion

            Console.Read();
        }
    }
}
