using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Model
{
    [Table("PostTags")]
    public class PostTag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // ID tự động tăng
        public int PostID { get; set; }

        [Key]
        [Column(TypeName="varchar")]
        [MaxLength(50)]
        public string TagID { get; set; }

        // khóa ngoại cho Post

        [ForeignKey("PostID")]
        public virtual Post Post { get; set; }

        // khóa ngoại cho Tag
        [ForeignKey("TagID")]
        public virtual Tag Tag { get; set; }


    }
}
