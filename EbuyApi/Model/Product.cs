using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EbuyApi.Model
{
    public class Product
    {
        [Key]
        public long Upc { get; set; }

        [Required]
        public string ProductDescription { get; set; }

        public string Category { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public decimal Price { get; set; }
        public string Brand { get; set; }

    }
}
