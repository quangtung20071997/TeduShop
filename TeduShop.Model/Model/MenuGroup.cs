using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Model
{
    [Table("MenuGroups")]
    public class MenuGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // ID tự động tăng
        public int ID { set; get; }

        [Required]
        [MaxLength(50 )]
        public string Name { set; get; }

        // thiết lập quan hệ IEnumerable Kiểu Menu để sử dụng khóa ngoại Menu. 
        public virtual IEnumerable<Menu> Menus { set; get; }
    }
}