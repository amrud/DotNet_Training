using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryService.Models
{
    [Owned]
    public class ProductDescription
    {
        [Column("Summary")]
        public string Summary { get; set; }
        [Column("Purchase_Date")]
        public DateTime PurchaseDate { get; set; }
        [Column("Expiry_Date")]
        public DateTime ExpiryDate { get; set; }
        [Column("Cost")]
        public long Cost{ get; set; }
    
    }
}
