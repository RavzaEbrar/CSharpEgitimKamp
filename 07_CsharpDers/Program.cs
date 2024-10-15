using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_CsharpDers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Foreach Döngüsü

            //1
            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //2
            //int[] number = { 1, 2, 3 };

            //foreach (int i in number)
            //{
            //    Console.WriteLine(i);
            //}

            //3
            //int[] number = { 1, 2, 3,46,57,900 };

            //foreach (int i in number)
            //{
            //    if (i%2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //4
            //int[] number = { 23, 252, 25, 134, 13, 790, 8078, 5617, 68 };
            //int total = 0;

            //foreach (int i in number)
            //{
            //    total += i;
            //}Console.WriteLine(total);


            //5
            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5
            //};

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //6
            //string word = "merhaba";
            //foreach (char r in word)
            //{
            //    Console.WriteLine(r);
            //}


            #endregion

            #region Örnek Sınav

            //Console.WriteLine("--------------------C# SINAV--------------------");
            //Console.WriteLine();

            //Console.Write("Sınıfta Kaç Öğrenci Vardır: ");
            //int studentCount=int.Parse(Console.ReadLine());

            //string[] studentName = new string[studentCount];
            //double[] studentexam = new double[studentCount];

            //for(int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine() ;
            //    Console.Write($"{ i+1}.öğrencinin ismini giriniz: ");
            //    studentName[i] = Console.ReadLine();

            //    double totalexamResult=0;

            //    //her öğrenci için 3 sınav notu girişi
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{studentName[i]} isimli öğrencinin {j+1}.sınav notunu giriniz: ");
            //        double value=double.Parse(Console.ReadLine());
            //        totalexamResult+=value;
            //    }
            //    studentexam[i]= totalexamResult/3;
            //}

            //for(int i = 0;i < studentCount;i++)
            //{
            //    Console.WriteLine() ;
            //    Console.WriteLine($"{studentName [i]} adlı öğrencinin ortalaması: {studentexam[i]}");

            //    if (studentexam[i] > 50)
            //    {
            //        Console.WriteLine($"{studentName[i]} adlı öğrenci geçti");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentName[i]} adlı öğrenci kaldı");

            //    }
            //}

            #endregion

            Console.Read();
        }
    }
}
