﻿using SupermarketEF.Data;
using SupermarketEF.Models;

namespace SupermarketEF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using SupermarketContext context = new SupermarketContext();

            // Se crea el objeto oilCategory de tipo Category
            Category oilCategory = new Category()
            {
                Name = "Oil",
                Description = "Oil Category"
            };

            // Se agrega el objeto creado al contexto de la BD
            context.Categories.Add(oilCategory);

            // Se crea el objeto grainsCategory de tipo Category
            Category grainsCategory = new Category()
            {
                Name = "Grains",
                Description = "Grains Category"
            };

            // Se agrega el objeto creado al contexto de la BD
            //context.Categories.Add(grainsCategory);

            // Se graban los cambios realizados al contexto
            //context.SaveChanges();

            var grainCategory = context.Categories
             .Where(p => p.Name == "Grains")
             .FirstOrDefault();

            if (grainCategory is Category)
            {
                grainCategory.Description = "New description applied";
                context.Remove(grainCategory);
            }

            context.SaveChanges();

            // Recupera todas las categorías y las ordena por el nombre
            var categories = context.Categories.OrderBy(p => p.Name);
            foreach (var category in categories)
            {
                Console.WriteLine($"{category.Name} | {category.Description}");
            }
        }
    }
}

