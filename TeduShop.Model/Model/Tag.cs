using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Model
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // ID tự động tăng
        [MaxLength(50)]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Type { get; set; }

        // khóa ngoại cho PostTag

        public virtual IEnumerable<PostTag> PostTags { get; set; }

        // khóa ngoại cho ProductTag
        public virtual IEnumerable<ProductTag> ProductTags { get; set; }

    }
}
