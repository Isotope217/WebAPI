namespace WebAPI.Entities
{
    public class Fruit
    {
        public Fruit(int id, string name, string description, string image, decimal price)
        {
            Id = id;
            Name = name;
            Description = description;
            Image = image;
            Price = price; 
             
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
    }
}
