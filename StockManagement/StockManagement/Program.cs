using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            CategoryImp implCat = new CategoryImp();
            ProductServiceImp implProd = new ProductServiceImp();
            IncomingLineServiceImp implIncomingLine = new IncomingLineServiceImp();
            OutcomingLineServiceImp implOutcomingLine = new OutcomingLineServiceImp();
            Category cat1 = new Category(1, "phone");
            Category cat2 = new Category(2, "PC");
            Category cat3 = new Category(3, "Print");
            Category cat4 = new Category(4, "Laptop");
            implCat.AddCategory(cat1);
            implCat.AddCategory(cat2);
            implCat.AddCategory(cat3);
            implCat.AddCategory(cat4);
            implCat.ModifyCategory(cat3);
            implCat.DeleteCategory(2);
            implCat.ModifyCategory(cat3);
            Console.WriteLine(implCat.GetCategoryById(3).Lib_Cat);
            Console.WriteLine("Add products");
            Product product = new Product(1, "Iphone 12", "Iphone 12", new DateTime(), 0, cat1);
            Product product2 = new Product(2, "Iphone 11", "Iphone 11", new DateTime(), 2, cat1);
            Product product3 = new Product(3, "Iphone X", "Iphone X", new DateTime(), 7, cat1);
            Product product4 = new Product(4, "Iphone 8", "Iphone 8", new DateTime(), 11, cat1);
            implProd.AddProduct(product);
            implProd.AddProduct(product2);
            implProd.AddProduct(product3);
            implProd.AddProduct(product4);
            foreach (Product pro in implProd.GetProductList())
            {
                Console.WriteLine("prod Id " + pro.Id + " Name " + pro.Name + " Quantity " + pro.Quantity);
            }

            Console.WriteLine("--------------------Incomming-----------------------");
            IncomingLine incomingLine = new IncomingLine(12, 160000, product, new Incoming(1, new DateTime()));
            implIncomingLine.AddIIncomingLine(incomingLine);
            IncomingLine incomingLine2 = new IncomingLine(6, 150000, product2, new Incoming(1, new DateTime()));
            implIncomingLine.AddIIncomingLine(incomingLine2);
            IncomingLine incomingLine3 = new IncomingLine(22, 10000, product3, new Incoming(1, new DateTime()));
            implIncomingLine.AddIIncomingLine(incomingLine3);
            Console.WriteLine("--------------------List products-----------------------");
            foreach(Product pro in implProd.GetProductList())
            {
                Console.WriteLine("prod Id "+pro.Id+" Name "+pro.Name+" Quantity "+pro.Quantity);
            }

            Console.WriteLine("--------------------Outcomming-----------------------");
            OutcomingLine outcomingLine = new OutcomingLine(5, 160000, product, new Outcoming(1, new DateTime()));
            implOutcomingLine.AddOutcomingLine(outcomingLine);
            OutcomingLine outcomingLine2 = new OutcomingLine(1, 150000, product3, new Outcoming(2, new DateTime()));
            implOutcomingLine.AddOutcomingLine(outcomingLine2);
            OutcomingLine outcomingLine3 = new OutcomingLine(45, 10000, product2, new Outcoming(3, new DateTime()));
            implOutcomingLine.AddOutcomingLine(outcomingLine3);
            Console.WriteLine("--------------------List products-----------------------");
            foreach (Product pro in implProd.GetProductList())
            {
                Console.WriteLine("prod Id " + pro.Id + " Name " + pro.Name + " Quantity " + pro.Quantity);
            }
            Console.ReadKey();

        }
    }
}
