using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryService.Models;

[Table("Product")]
public class Product
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("Product_Id")]
    public long ProductId { get; set; }

    //value object
    public ProductDescription ProductDescription { get; set; }
    [Column("SKU")]
    public string SKU { get; set; }

    [ForeignKey("Category")]
    [Column("Category_Id_FK")]
    public long CategoryId { get; set; }
    public Category Category { get; set; }
}
