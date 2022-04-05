namespace AngularApp.Models
{
    public class ProductInfo
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string Manufacturer { get; set; }

        public ProductInfo() { }
        public ProductInfo(string name, decimal price, string category, string manufacturer)
        {
            Name = name;
            Price = price;
            Category = category;
            Manufacturer = manufacturer;
        }
    }
}
