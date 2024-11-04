using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_CsharpDers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region geriye değer döndürmeyen int parametreli metotlar
            //1
            //void CustomerList()
            //{
            //    Console.WriteLine("aa");
            //    Console.WriteLine("bb");
            //    Console.WriteLine("cc");
            //    Console.WriteLine("dd");
            //}
            //CustomerList();

            //2
            //void sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x+y;
            //    Console.WriteLine(z);
            //}
            //sum();

            //3
            //void writeMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //writeMethod("Ravza Ebrar");

            //4
            //void CustomerCard(string name,string surname)
            //{
            //    Console.WriteLine("Müşteri :"+name+" "+surname);
            //}
            //CustomerCard("mehmet","yıldız");
            //CustomerCard("ayşe","naz");

            #endregion

            #region geriye değer döndürmeyen string parametreli metotlar

            //1
            //void sum(int number1,int number2,int number3)
            //{
            //    int result= number1+number2+number3;
            //    Console.WriteLine(result);
            //}
            //sum(1,2,3);

            #endregion

            #region geriye değer döndüren  metotlar

            //1
            //string CustomerName()
            //{
            //    return "ali fatma";
            //}
            //CustomerName();   

            //2
            //string StudentCard()
            //{
            //    string name = "fırat";
            //    string surname = "acar";
            //    return name+" "+surname;
            //}
            //Console.WriteLine(StudentCard());

            #endregion

            #region geriye değer döndüren string parametreli metotlar

            //string countryCard(string countryname,string capital,string flagcolor)
            //{
            //    string cardinfo ="ülke :"+countryname+"- başkent :" + capital+"- bayrak :"+flagcolor;
            //    return cardinfo;
            //}
            //string x, y, z;
            //Console.Write("ülke adını giriniz :");
            //x= Console.ReadLine();
            //Console.Write("baskenti giriniz :");
            //y= Console.ReadLine();
            //Console.Write("bayrak rengi giriniz :");
            //z= Console.ReadLine();

            //Console.WriteLine( countryCard(x,y,z));

            #endregion

            #region geriye değer döndüren int parametreli metotlar

            //int sum(int number1,int number2)
            //{
            //    int result=number1+ number2;
            //    return result;
            //}
            //Console.WriteLine(sum(1,98));
            //Console.WriteLine(sum(415,68));
            //Console.WriteLine(sum(47,18));
            //Console.WriteLine(sum(64,60));

            #endregion

            string ExamResult(string student,int exam1,int  exam2,int exam3)
            {
                int result=(exam1+exam2+exam3)/3;
                if (result >= 50)
                {
                    return "öğrenci sınavı geçti"+"ortalama :"+result;
                }
                else
                {
                    return "öğrenci başarısız oldu"+"ortalama :"+result;
                }
            }
            Console.WriteLine(ExamResult("ali",25,41,85));
            Console.WriteLine(ExamResult("ayşe",10,88,33));


            Console.Read();
        }
    }
}
