using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CsharpDers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //1.ORNEK
            //Console.WriteLine("Lütfen şifrenizi giriniz :");
            //string password= Console.ReadLine();

            //if (password == "abcd" )
            //{
            //    Console.WriteLine("şifre doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış");
            //}



            //2.ORNEK
            //Console.Write("Başkenti giriniz:");
            //string Capital=Console.ReadLine();
            //Console.Write("Ülkeyi giriniz:");
            //string Country =Console.ReadLine();

            //if(Capital == "ankara" & Country == "türkiye")
            //{
            //    Console.WriteLine("veriler doğru");
            //}
            //else
            //{
            //    Console.WriteLine("hatalı bilgi");
            //}



            //3.ORNEK
            //int number;
            //Console.Write("Sayıyı giriniz:");
            //number = int.Parse(Console.ReadLine());

            //if (number == 10)
            //{
            //    Console.WriteLine("sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("sayı yanlıs");
            //}


            //4.ORNEK
            //int not1, not2,ortalama;
            //string result;

            //Console.Write("Birinci Notu Giriniz:");
            //not1 =int.Parse(Console.ReadLine());

            //Console.Write("İkinci Kodu Giriniz :");
            //not2 = int.Parse(Console.ReadLine());

            //ortalama = (not1 + not2)/2;
            //Console.WriteLine("ortalamanız:"+ortalama);
            // if (ortalama >= 50 )
            //{
            //    result = "geçtin";
            //}
            //else
            //{
            //    result = "kaldın";
            //}
            //Console.WriteLine(result);



            //5.ORNEK
            //string city;
            //Console.Write("Şehir giriniz:");
            //city =Console.ReadLine();

            //if( city=="ankara" | city=="istanbul" | city=="adana" | city=="sivas")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("mevcut değil");
            //}


            //6.ORNEK
            //string username;
            //Console.Write("Kullanıcı adınızı girin: ");
            //username = Console.ReadLine();

            //if(username != "ravza")
            //{
            //    Console.WriteLine("kullanıcı adı yanlış");
            //}
            //else
            //{
            //    Console.WriteLine("hoşgeldiniz");
            //}


            #endregion

            #region Mod Alma İşlemleri

            //1.ORNEK
            //int number;
            //number = 219;
            //int result = number % 20;
            //Console.WriteLine(result);


            //2.ORNEK
            ////Console.Write("birinci sayıyı giriniz: ");
            ////int number1=int.Parse(Console.ReadLine());

            ////Console.Write("ikincisayıyı giriniz: ");
            ////int number2 = int.Parse(Console.ReadLine());

            ////int mod = number1 % number2;

            ////Console.WriteLine("birinci sayının ikinci sayıya bölümünden kalan "+mod); 


            //2.ORNEK
            //Console.Write("sayı giriniz: ");
            //int number =int.Parse(Console.ReadLine());

            //if (number%2==0)
            //{
            //    Console.WriteLine("sayı çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("sayı tektir");
            //}

            #endregion

            #region Char Değişkenler ile Karar Yapıları

            //char team;
            //Console.Write("takım sembolunu giriniz: ");
            //team=char.Parse(Console.ReadLine());

            //if (team=='g'| team=='G')
            //{
            //    Console.Write("Takım Galatasaraydır ");
            //}
            //if (team=='f'|team=='F')
            //{
            //    Console.Write("Takım Fenerbahcedir");

            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Takım Beşiktaştır");

            //}
            #endregion

            #region Örnek Proje Uygulaması
            //Console.WriteLine("********************Restorant********************");
            //Console.WriteLine("--------------------");
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana yemekler");
            //Console.WriteLine("3-içecekler");
            //Console.WriteLine("4-Tatlılar");
            //Console.WriteLine("--------------------");

            //Console.Write
            //    ("Detayını görmek istediğiniz menüyü seçin: ");
            //string item=Console.ReadLine();

            //if(item == "1")
            //{
            //    Console.WriteLine("----------Çorbalar----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Ezogelin");
            //    Console.WriteLine("2-mercimek");
            //    Console.WriteLine("3-tarhana");
            //    Console.WriteLine();
            //    Console.WriteLine("----------Çorbalar----------");

            //}
            //if (item == "2")
            //{
            //    Console.WriteLine("----------Ana Yemekler----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-kavurma");
            //    Console.WriteLine("2-patlıcan dolması");
            //    Console.WriteLine("3-kebap");
            //    Console.WriteLine();
            //    Console.WriteLine("----------Ana Yemekler----------");

            //}
            //if (item == "3")
            //{
            //    Console.WriteLine("----------İçecekler----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-su");
            //    Console.WriteLine("2-cola");
            //    Console.WriteLine("3-ayran");
            //    Console.WriteLine();
            //    Console.WriteLine("----------İçecekler----------");

            //}
            //if (item == "4")
            //{
            //    Console.WriteLine("----------Tatlılar----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-triliçe");
            //    Console.WriteLine("2-suffle");
            //    Console.WriteLine("3-brownie");
            //    Console.WriteLine();
            //    Console.WriteLine("----------Tatlılar----------");

            //}
            #endregion

            #region Switch Case
            //Console.WriteLine("ay girişi yapınız: ");
            //int mothnumber = int.Parse(Console.ReadLine());

            //switch (mothnumber)
            //{
            //    case 1: Console.WriteLine("ocak");break;
            //    case 2: Console.WriteLine("şubat");break;
            //    case 3: Console.WriteLine("mart");break;
            //    case 4: Console.WriteLine("nisan");break;
            //    case 5: Console.WriteLine("mayıs");break;
            //    case 6: Console.WriteLine("haziran");break;
            //    case 7: Console.WriteLine("temmuz");break;
            //    case 8: Console.WriteLine("agustos");break;
            //    case 9: Console.WriteLine("eylül");break;
            //    case 10: Console.WriteLine("ekim");break;
            //    case 11: Console.WriteLine("kasım");break;
            //    case 12: Console.WriteLine("aralık");break;
            //        default: Console.WriteLine("hatalı giriş");break;
            //}

            #endregion

            #region Switch Case Hesap Makinesi

            // int number1, number2,result;
            //Char symbol;

            //Console.WriteLine("1.sayıyı giriniz: ");
            //number1 =int.Parse(Console.ReadLine());

            //Console.WriteLine("2.sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("yapmak istediğiniz işlemi giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result= number1 + number2;
            //        Console.WriteLine("toplam: "+ result);
            //            break;

            //    case '-':
            //        result= number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;

            //    case '*':
            //        result= number1 * number2;
            //        Console.WriteLine("çarpım: " + result);
            //        break;

            //    case '/':
            //        result= number1 / number2;
            //        Console.WriteLine("bölüm: " + result);
            //        break;

            //}

            #endregion

            Console.Read();
        }
    }
}
