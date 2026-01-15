namespace GestionStock.Client.Models
{
    public class ProductsResponse
    {
        public int Id { get; set; }
        public string Reference { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public List<Category> Categories { get; set; }

        public class Category
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }



    }
}
