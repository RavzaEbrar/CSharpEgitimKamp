using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_CsharpDers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("***** C# Veri Tabanlı Ürün Kategori Bilgi Sistemi *****");
            //Console.WriteLine();
            //Console.WriteLine();

            //string TableNumber;

            //Console.WriteLine("------------------------");
            //Console.WriteLine("1-Kategoriler");
            //Console.WriteLine("2-Ürünler");
            //Console.WriteLine("3-Siparişler");
            //Console.WriteLine("4-Çıkış Yap");
            //Console.WriteLine("Lütfen Getirmek İstediğiniz Tablo Numarasını Yazınız :");
            //TableNumber = Console.ReadLine();
            //Console.WriteLine("------------------------");

            //SqlConnection Connection = new SqlConnection("Data Source=HDFAVR890\\SQLEXPRESS;initial Catalog=EgitimKampiDB;integrated security=true"); 
            //SqlCommand command  =new SqlCommand("Select * FROM TblCategory",Connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);

            //Connection.Close();

            //foreach (DataRow row in dt.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write($"{item.ToString()}");
            //    }
            //    Console.WriteLine();
            //}

            Console.Read();
        }
    }
}
