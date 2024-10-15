using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CsharpDers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            //double tomato =5.98;
            //double potato =6.98;
            //double mulberry =20.50;
            //double grapes =18.75;

            //Console.WriteLine();
            //Console.WriteLine("********** FİYAT LİSTESİ **********");
            //Console.WriteLine();
            //Console.WriteLine("Domates Fiyatı:"+tomato + "TL");
            //Console.WriteLine("Patates Fiyatı:"+potato + "TL");
            //Console.WriteLine("Dut Fiyatı:"+ mulberry + "TL");
            //Console.WriteLine("Üzüm Fiyatı:"+grapes + "TL");

            //double tomatoGram = 1.250;
            //double potatoGram = 6.500;
            //double mulberryGram = 8.800;
            //double grapesGram = 4.230;

            //Console.WriteLine("------------------------------");
            //Console.WriteLine();

            //double tomatoTotalPrice=tomato*tomatoGram;
            //Console.WriteLine("Domatesin Kilosu :"+ tomato+" "+"Kaç Kilo Aldın:"+tomatoGram+" "+"Ödenecek fiyat:"+tomatoTotalPrice);
            //Console.WriteLine();

            //double potatoTotalPrice=potato*potatoGram;
            //Console.WriteLine("Patatesin Kilosu :" + potato + " " + "Kaç Kilo Aldın:" + potatoGram + " " + "Ödenecek fiyat:" + potatoTotalPrice);
            //Console.WriteLine();

            //double mulberryTotalPrice =mulberry*mulberryGram;
            //Console.WriteLine("Dutun  Kilosu :" + mulberry + " " + "Kaç Kilo Aldın:" + mulberryGram + " " + "Ödenecek fiyat:" + mulberryTotalPrice);
            //Console.WriteLine();

            //double grapesTotalPrice =grapes*grapesGram;
            //Console.WriteLine("Üzümün  Kilosu :" + grapes + " " + "Kaç Kilo Aldın:" + grapesGram + " " + "Ödenecek fiyat:" + grapesTotalPrice);
            //Console.WriteLine();

            //Console.WriteLine("------------------------------");

            //double shoppingTotalPrice = tomatoTotalPrice+potatoTotalPrice+mulberryTotalPrice+grapesTotalPrice;
            //Console.WriteLine("Alışveriş Tutarı:"+shoppingTotalPrice);
            //Console.WriteLine();

            #endregion

            #region Char Değişkenler

            // ''   

            //char symbol= 'A';
            //Console.Write(symbol);

            #endregion

            #region Klavyeden String Değişken Girişi

            //Console.WriteLine();
            //Console.WriteLine("**********YOLCU BİLGİLERİ**********");

            //string name, surname, city, age;

            //Console.Write("Yolcu Adı:");
            //name = Console.ReadLine();

            //Console.Write("Yolcu Soyadı:");
            //surname = Console.ReadLine();

            //Console.Write("Yolcu yaşı:");
            //age = Console.ReadLine();

            //Console.Write("ilçe bilgisi:");
            //city = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("************************************");
            //Console.WriteLine("Yolcu Adı Soyadı:" + name + surname + "  -" + "Yolcunun yaşı ve ilçe bilgisi:" + age + "/" + city);

            #endregion

            #region Klavyeden İnt Değişken Girişi

            //int tvPrice, chairPrice, laptopPrice, toyPrice;

            //tvPrice = 5000;
            //chairPrice = 700;
            //laptopPrice = 20000;
            //toyPrice = 200;


            //int tvCount, chairCount, laptopCount, toyCount;

            //Console.Write("Aldığın Televizyon Sayısını Gir:");
            //tvCount =int.Parse(Console.ReadLine());

            //Console.Write("Aldığın Sandalye Sayısını Gir:");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Aldığın laptop Sayısını Gir:");
            //laptopCount = int.Parse(Console.ReadLine());

            //Console.Write("Aldığın Oyuncak Sayısını Gir:");
            //toyCount = int.Parse(Console.ReadLine());

            //int tvTotalPrice=tvPrice*tvCount;
            //int chairTotalPrice=chairPrice*chairCount;
            //int laptopTotalPrice=laptopPrice*laptopCount;
            //int toyTotalPrice =toyPrice*toyCount;

            //int shoppingTotalPrice=tvTotalPrice+chairTotalPrice+laptopTotalPrice+toyTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine("--------------------");

            //Console.WriteLine("Alışveriş Tutarı:"+" "+shoppingTotalPrice);

            #endregion

            #region  Klavyeden ondalıklı Değişken Girişi

            //double exam1,exam2;

            //Console.WriteLine("Birinci sınavı giriniz:");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("İkinci sınavı giriniz:");
            //exam2 = double.Parse(Console.ReadLine());

            //double ortalama = (exam1 + exam2)/2;

            //Console.WriteLine("İki sınavın ortalaması:" + ortalama);

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Cinsiyet girin:");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz cinsiyet:" + gender);
            #endregion

            Console.Read();
        }
    }
}
