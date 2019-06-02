using System.Linq;

namespace DaltonsBreadShop.Mvc.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Breads.Any())
            {
                context.AddRange
                (
                    new Bread { Name = "Onion Bread", Price = 10.5M, ShortDescription = "Onion", LongDescription = "The Best Onion Bread at all", ImageUrl = "~/Images/Breads/Onion.jpg", ImageThumbinailUrl = "~/Images/Breads/OnionThumb.jpg", IsBreadOfTheWeek = false },
                    new Bread { Name = "House Bread", Price = 9.8M, ShortDescription = "House", LongDescription = "The Best Bread at all", ImageUrl = "~/Images/Breads/House.jpg", ImageThumbinailUrl = "~/Images/Breads/HouseThumb.jpg", IsBreadOfTheWeek = false },
                    new Bread { Name = "Olive Oil & Herbs Bread", Price = 9.5M, ShortDescription = "Olive Oil & Herbs", LongDescription = "The Best Olive Oil & Herbs Bread at all", ImageUrl = "~/Images/Breads/OliveOilAndHerbs.jpg", ImageThumbinailUrl = "~/Images/Breads/OliveOilAndHerbsThumb.jpg", IsBreadOfTheWeek = true },
                    new Bread { Name = "Carrot & Chocolate Bread", Price = 13.5M, ShortDescription = "Carrot & Chocolate", LongDescription = "The Best Carrot & Chocolate at all", ImageUrl = "~/Images/Breads/CarrotAndChocolate.jpg", ImageThumbinailUrl = "~/Images/Breads/CarrotAndChocolateThumb.jpg", IsBreadOfTheWeek = false }
                );

                context.SaveChanges();
            }
        }
    }
}
