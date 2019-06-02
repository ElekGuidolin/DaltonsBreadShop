namespace DaltonsBreadShop.Mvc.Models
{
    public class Bread
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbinailUrl { get; set; }
        public bool IsBreadOfTheWeek { get; set; }
        public bool IsInStock { get; set; }
    }
}
