using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rarozweb.models
{
    //[Table("Post")] rarozweb.models.Article
    public class Article{
        [Key]
        public int Id {set; get;}

        [StringLength(255)]
        [Required(ErrorMessage = "{0} phải nhập")]
        [Column(TypeName = "nvarchar")]
        [DisplayName("Tiêu đề")]
        public string Title {set; get;}

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "{0} phải nhập")]
        [DisplayName("Ngày tạo")]
        public DateTime Created {set; get;}

        [Column(TypeName = "ntext")]
        [DisplayName("Nội dung")]
        public string Content {set; get;}
    }
}