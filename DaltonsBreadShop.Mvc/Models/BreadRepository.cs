using System.Collections.Generic;
using System.Linq;

namespace DaltonsBreadShop.Mvc.Models
{
    public class BreadRepository : IBreadRepository
    {
        private readonly AppDbContext _appDbContext;

        public BreadRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Bread> GetAllBreads()
        {
            return _appDbContext.Breads;
        }

        public Bread GetBreadById(int breadId)
        {
            return _appDbContext.Breads.FirstOrDefault(b => b.Id == breadId);
        }
    }
}
