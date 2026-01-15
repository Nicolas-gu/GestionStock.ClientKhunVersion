using System.ComponentModel.DataAnnotations;

namespace GestionStock.Client.Models
{
    public class ProductForm
    {
        // validation client
        [Required(ErrorMessage = "Ce champs est requis")]
        [MaxLength(255, ErrorMessage = "Trop long")]
        public required string Name { get; set; }

        public string? Description { get; set; }

        [Required(ErrorMessage = "Ce champs est requis")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Ce champs est requis")]
        public int Quantity { get; set; }
        public IEnumerable<int> Categories { get; set; } = [4];
    }
}
