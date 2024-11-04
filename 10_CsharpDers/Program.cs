using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CsharpDers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("------------------------");

            #region Katagori Ekleme İşlemi 
            //Console.Write("Eklemek istediğiniz kategori adı :");
            //string categoryName=Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source = HDFAVR890\\SQLEXPRESS; initial Catalog = EgitimKampiDB; integrated security = true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory(CategoryName) values(@p1)",connection);
            //command.Parameters.AddWithValue("@p1",categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Kategori Başarıyla Eklendi");
            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;

            //Console.WriteLine("Ürün Adı :");
            //productName =Console.ReadLine();
            //Console.WriteLine("Ürün Fiyatı Giriniz :");
            //productPrice=decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source = HDFAVR890\\SQLEXPRESS; initial Catalog = EgitimKampiDB; integrated security = true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connection);
            //command.Parameters.AddWithValue("productName",productName);
            //command.Parameters.AddWithValue("productPrice",productPrice);
            //command.Parameters.AddWithValue("productStatus",true);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Ürün Eklemesi Başarılı ");

            #endregion

            #region Ürün Listeleme İşlemi
            //SqlConnection connection = new SqlConnection("Data Source = HDFAVR890\\SQLEXPRESS; initial Catalog = EgitimKampiDB; integrated security = true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From  TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dt = new DataTable(); 
            //adapter.Fill(dt);
            //foreach (DataRow row in dt.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //            Console.Write(item.ToString()+" ");
            //    }
            //    Console.WriteLine();
            //}
            //connection.Close();
            #endregion

            #region Ürün Silme
            //Console.Write("Silinecek Ürün Id :");
            //int  productId=int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source = HDFAVR890\\SQLEXPRESS; initial Catalog = EgitimKampiDB; integrated security = true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productId",productId);
            //command.ExecuteNonQuery();

            //connection.Close();
            //Console.WriteLine("Silme İşlemi Yapıldı");
            #endregion

            #region Ürün Güncelleme

            Console.Write("Güncellenecek Ürün Id :");
            int productId = int.Parse(Console.ReadLine());

            Console.Write("Güncellenecek Ürün Adı :");
            string productName = Console.ReadLine();

            Console.Write("Güncellenecek Ürün Fiyat :");
            decimal productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source = HDFAVR890\\SQLEXPRESS; initial Catalog = EgitimKampiDB; integrated security = true");

            connection.Open();
            SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName,ProductPrice=@productPrice where  ProductId=@productId", connection);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productId", productId);
            command.ExecuteNonQuery();

            connection.Close();
            Console.WriteLine("Güncelleme Başarılı ");
            Console.WriteLine();

            #endregion

            Console.Read();
        }
    }
}
