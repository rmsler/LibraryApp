using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library2._0.Models
{
    public class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Books.Any())
            {
                context.AddRange(
                    new Book { Name = "Pride and Prejudice", Description = "One of the best book of Jane Austen", State = true },
                    new Book { Name = "Great Expectations", Description = "One of the best book of Charles Dickens", State = true },
                    new Book { Name = "Memoirs Of A Geisha", Description = "One of the best book of Arthur Golden", State = true },
                    new Book { Name = "Divergent", Description = "One of the best book of Veronica Roth", State = false },
                    new Book { Name = "The Picture of Dorian Gray", Description = "One of the best book of Oscar Wilde", State = true },
                    new Book { Name = "The Neverending Story", Description = "One of the best book of Michael Ende", State = true }
                );
                context.SaveChanges();
            }
        }
    }
}
