using System;
using System.Linq;

namespace LiveCode4
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new NorthwindContex())
            {
                
                var categories = db.Categories
                    .Where(x => x.Id < 8);
                

                foreach (var category in categories)
                {
                    Console.WriteLine(category.Id + "|\t|" + category.Name + "\t|" + category.Description);
                }

                

                //var category = db.Categories.FirstOrDefault(
                //    x => x.Id == 11);

                // update
                //if (category != null)
                //{
                //    category.Name = "2017 Testing";
                //}

                // delete
                //db.Categories.Remove(category);

                 var addCategory = new Category
                {
                    Name = "Cake",
                    Description = "cupcake"
                };

                db.Categories.Add(addCategory);
                db.SaveChanges(); 
            }
            Console.ReadLine();
        }
    }
}
