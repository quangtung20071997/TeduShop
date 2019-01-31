using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Model
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key]
        public int OrderID { set; get; }
        [Key]
        public int ProductID { set; get; }
        [Required]
        public int Quantity { set; get; }

        // Khóa ngoại order
        [ForeignKey("OrderID")]
        public virtual Order Order { get; set; }

        // khóa ngoại Product
        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }

    } 
}
