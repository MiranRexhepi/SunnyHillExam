namespace SunnyHillTest.Models.products
{
    public class ProductsModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long Price { get; set; }
        public DateTime DateTimeOfOrder { get; set; }
    }
}
