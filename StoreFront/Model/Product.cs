namespace StoreFront.Model
{
    public class Product
    {
        public string Name { get; }
        public string Description { get; }
        public decimal Price { get; }
        public int AgeRating { get; }
        public int StockCount { get; }
        public Product(string name, string description, decimal price, int ageRating, int stockCount)
        {
            Name = name;
            Description = description;
            Price = price;
            AgeRating = ageRating;
            StockCount = stockCount;
        }
    }
}