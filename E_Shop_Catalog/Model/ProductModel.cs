using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace E_Shop_Catalog.Model
{
    public class ProductModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Product_Id { get; }
        public string Product_Name { get; set; }
        public int Category_Id { get; set; }
        
    }
}
