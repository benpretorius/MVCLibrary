using Microsoft.EntityFrameworkCore;
using MVCLibrary.Data;

namespace MVCLibrary.Models
{
    public class SeedData
    {
      public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LibraryContext(
                serviceProvider.GetRequiredService<DbContextOptions<LibraryContext>>()))
            {
                context.RemoveRange(context.Books);
                context.SaveChanges();
                if (context.Books.Any())
                {
                    return;
                }
                context.Books.AddRange(
                    new Book { Title = "Code Chronicles", CallNumber = "AXD 2029" },
                    new Book { Title = "Perfume", CallNumber = "AKQ 2229 " }
                    );
                context.SaveChanges();
            }
           

        }
    }

}



