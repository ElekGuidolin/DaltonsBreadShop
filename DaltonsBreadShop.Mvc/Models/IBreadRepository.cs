using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DaltonsBreadShop.Mvc.Models
{
    public interface IBreadRepository
    {
        IEnumerable<Bread> GetAllBreads();
        Bread GetBreadById(int breadId);
    }
}
