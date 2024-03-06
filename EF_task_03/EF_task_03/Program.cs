using EF_task_03.Data;
using EF_task_03.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EF_task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ApplicationDbContext context = new ApplicationDbContext();


            //    //*****1
            //    //Retrieve all categories from the production.categories table.

            try
            {
                var categories = context.Categories1.ToList();

                Console.WriteLine("Retrieve all categories from the production.categories table.");

                foreach (var category in categories)
                {
                    Console.WriteLine(category.ToString());
                }
            }
            catch
            {
                Console.WriteLine("not found");

            }

            //// //****2

            //// ////Retrieve the first product from the production.products table.

            try
            {

                Console.WriteLine("Retrieve the first product from the production.products table");
                var products = context.Products.First();

                Console.WriteLine(products.ToString());


            }
            catch
            {
                Console.WriteLine("not found");

            }

            //  ///***3
            //////Retrieve a specific product from the production.products table by ID.

            try
            {
                Console.WriteLine("Retrieve a specific product from the production.products table by ID.");
                Console.WriteLine("Enter the ID :");
                int id = Convert.ToInt32(Console.ReadLine());
                var oneProduct = context.Products.Find(id);
                Console.WriteLine(oneProduct.ToString());

            }
            catch
            {
                Console.WriteLine("not found");

            }


            // ///***4

            // ////Retrieve all products from the production.products table with a certain model year.

            try
            {

                Console.WriteLine("Retrieve all products from the production.products table with a certain model year.");
                Console.WriteLine("Enter model year : ");
                var model = Convert.ToInt32(Console.ReadLine());
                var result = context.Products.Where(e => e.ModelYear == model);

                foreach (var product in result)
                {
                    Console.WriteLine(product.ToString());
                }



            }
            catch
            {
                Console.WriteLine("not found");

            }


            //// ///*****5

            //// ///Retrieve a specific customer from the sales.customers table by ID.

            try
            {
                Console.WriteLine("Retrieve a specific customer from the sales.customers table by ID.");

                Console.WriteLine("Enter the ID :");
                int id = Convert.ToInt32(Console.ReadLine());

                var customer = context.Customers.Find(id);
                Console.WriteLine(customer.ToString());

            }
            catch
            {
                Console.WriteLine("not found");

            }

            //// //*****6

            //// //Retrieve a list of product names and their corresponding brand names.

            try
            {

                Console.WriteLine("Retrieve a list of product names and their corresponding brand names.");

                var productsresult = context.Products.Select(e => new { e.ProductName, e.Brand.BrandName }).ToList();
                foreach (var product in productsresult)
                {
                    Console.WriteLine($"product name :{product.ProductName}, Brand name : {product.BrandName} ");
                }

            }
            catch
            {
                Console.WriteLine("not found");

            }


            //    // ////***7

            //    // ////Count the number of products in a specific category.

            try
            {

                Console.WriteLine("Count the number of products in a specific category.");
                Console.WriteLine("Enter ID : ");
                int categoryId = Convert.ToInt32(Console.ReadLine());
                var noProducts = context.Products.Count(e => e.CategoryId == categoryId);
                Console.WriteLine(noProducts);


            }
            catch
            {
                Console.WriteLine("not found");

            }

            //// //****8
            //// ////Calculate the total list price of all products in a specific category.

            try
            {


                Console.WriteLine("Calculate the total list price of all products in a specific category.");
                Console.WriteLine("Enter ID : ");
                int categoryId = Convert.ToInt32(Console.ReadLine());

                var listPrices = context.Products.Where(e => e.CategoryId == categoryId).Sum(e => e.ListPrice);

                Console.WriteLine(listPrices);


            }
            catch
            {
                Console.WriteLine("not found");

            }

            //// ///****9
            //// ///
            //// ////Calculate the average list price of products

            try
            {

                Console.WriteLine("Calculate the average list price of products");

                var avg = context.Products.Average(e => e.ListPrice);
                Console.WriteLine(avg);


            }
            catch
            {
                Console.WriteLine("not found");

            }
           
            
            //// //***10
            //// //Retrieve orders that are completed.

            try
            {

                Console.WriteLine("Retrieve orders that are completed.");
                var orders = context.Orders.Where(e => e.OrderStatus == 1);
                foreach (var order in orders)
                {
                    Console.WriteLine(order.ToString());
                }

            }
            catch
            {
                Console.WriteLine("not found");

            }




        }


        }
}
