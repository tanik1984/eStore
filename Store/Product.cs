namespace Store
{
    public class Product
    {
        public Product(string name, string description, decimal price)
        {
            Name = name;
            Description = description;
            Price = price;
        }

        public string Name { get; }

        public string Description { get; }

        public decimal Price { get; }

        public int Count { get; set; }
    }
}