using _4Point1_EF.Models;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Linq;

namespace _4Point1_EF
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize our database interaction
            /*
            using (CarsContext context = new CarsContext())
             {
                 string make, model, colour;
                 Console.WriteLine(context.Cars.Count(x => x.Manufacturer.Name == "BMW"));
                 Console.WriteLine(context.Cars.Count(x => x.Manufacturer.Name == "Mercedes-Benz"));
                 Console.Write("Please enter a make for your new Car:");
                 make = Console.ReadLine();
                 Console.Write("Please enter a model for your new Car:");
                 model = Console.ReadLine();
                 Console.Write("Please enter a colour for your new Car:");
                 colour = Console.ReadLine();
                 context.Add(new Car()
                 {
                     Manufacturer = context.Manufacturers.Where(x => x.Name == make).SingleOrDefault(),
                     Model = model,
                     Colour = colour
                 });
                 context.SaveChanges();
             }*/
            using (CarsContext context = new CarsContext())
            {
                string model;
                Console.Write("Please enter a model to remove: ");
                model = Console.ReadLine();

                context.Cars.Remove(context.Cars.Where(x => x.Model == model).SingleOrDefault());

                context.SaveChanges();
            }
        }
    }
}
