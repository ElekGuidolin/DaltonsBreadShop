using DaltonsBreadShop.Mvc.Models;
using System.Collections.Generic;

namespace DaltonsBreadShop.Mvc.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Bread> Breads { get; set; }
    }
}
