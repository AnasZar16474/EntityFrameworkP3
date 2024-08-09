using EntityFrameworkP3.Data;
using EntityFrameworkP3.Models;
using System.Net.Sockets;
using System.Runtime.Versioning;

namespace EntityFrameworkP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext dbContext = new ApplicationDbContext();
            Product p = new Product() { Name = "BeachBall", Price = 300 };
            Product p1 = new Product() { Name = "BasketBall", Price = 500 };
            Product p2 = new Product() { Name = "Football", Price = 700 };
            Product p3 = new Product() { Name = "GolfBall", Price = 100 };
            Product p4 = new Product() { Name = "TennisBall", Price = 1000 };
            Product p5 = new Product() { Name = "PoolBall", Price = 2000 };
            Order O = new Order() {Address="Nablus" };
            Order O1 = new Order() { Address = "Nablus" };
            Order O2= new Order() { Address = "Damascus" };
            Order O3= new Order() { Address = "Qalqilia" };
            Order O4 = new Order() { Address = "Cairo" };
            Order O5 = new Order() { Address = "Aleppo" };


            var changeName = dbContext.Products.FirstOrDefault(p => p.Id == 1);
            if (changeName != null)
            {
                changeName.Name = "SquashBall";
                Console.WriteLine("rename success");

            }
            else { Console.WriteLine("not exist"); }
            var changeCreatedAt = dbContext.Orders.FirstOrDefault(O => O.Id == 4);
            if (changeCreatedAt != null)
            {
                changeCreatedAt.CreatedAt = DateTime.Now;
                Console.WriteLine("rename success");

            }
            else { Console.WriteLine("not exist"); }
            var removeProduct = dbContext.Products.FirstOrDefault(p => p.Id == 2);
            if (removeProduct != null)
            {
                dbContext.Products.Remove(removeProduct);
                Console.WriteLine("Remove success");

            }
            else { Console.WriteLine("remove is completed"); }
            var removeOrder = dbContext.Orders.FirstOrDefault(p => p.Id == 3);
            if (removeOrder != null)
            {
                dbContext.Orders.Remove(removeOrder);
                Console.WriteLine("Remove success");

            }
            else { Console.WriteLine("remove is completed"); }
            var Product = dbContext.Products.ToList();
            foreach(var pro in Product)
            {
                Console.WriteLine(pro);
            }
            var orderss = dbContext.Orders.ToList();
            foreach(var ord in orderss)
            {
                Console.WriteLine(ord);
            };
            dbContext.SaveChanges();
      



            Console.WriteLine("Done");
        }
    }
}
