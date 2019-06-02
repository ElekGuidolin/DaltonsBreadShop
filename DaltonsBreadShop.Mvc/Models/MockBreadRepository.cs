using System.Collections.Generic;
using System.Linq;

namespace DaltonsBreadShop.Mvc.Models
{
    public class MockBreadRepository : IBreadRepository
    {
        private List<Bread> _breads;

        public MockBreadRepository()
        {
            if (_breads == null)
            {
                InitializeBreads();
            }
        }

        private void InitializeBreads()
        {
            _breads = new List<Bread>
            {
                new Bread {Id = 1, Name="Onion Bread", Price=10.5M, ShortDescription="Onion", LongDescription="The Best Onion Bread at all", ImageUrl="~/Images/Breads/Onion.jpg", ImageThumbinailUrl="~/Images/Breads/OnionThumb.jpg", IsBreadOfTheWeek=false},
                new Bread {Id = 2, Name="House Bread", Price=10.5M, ShortDescription="House", LongDescription="The Best Bread at all", ImageUrl="~/Images/Breads/House.jpg", ImageThumbinailUrl="~/Images/Breads/HouseThumb.jpg", IsBreadOfTheWeek=false},
                new Bread {Id = 3, Name="Olive Oil & Herbs Bread", Price=10.5M, ShortDescription="Olive Oil & Herbs", LongDescription="The Best Olive Oil & Herbs Bread at all", ImageUrl="~/Images/Breads/OliveOilAndHerbs.jpg", ImageThumbinailUrl="~/Images/Breads/OliveOilAndHerbsThumb.jpg", IsBreadOfTheWeek=true},
                new Bread {Id = 4, Name="Carrot & Chocolate Bread", Price=10.5M, ShortDescription="Carrot & Chocolate", LongDescription="The Best Carrot & Chocolate at all", ImageUrl="~/Images/Breads/CarrotAndChocolate.jpg", ImageThumbinailUrl="~/Images/Breads/CarrotAndChocolateThumb.jpg", IsBreadOfTheWeek=false},
            };
        }

        public IEnumerable<Bread> GetAllBreads()
        {
            return _breads;
        }

        public Bread GetBreadById(int breadId)
        {
            return _breads.FirstOrDefault(b => b.Id == breadId);
        }
    }
}
