using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Entities
{
    public class CornerPostDetail
    {
        [Key]
        public int? CornerPostId { get; set; }
        public CornerPost? CornerPost { get; set; }

        [Required(ErrorMessage = "{0} zorunlu")]
        [DisplayName("Köşe Yazısı İçeriği")]
        public string? Content { get; set; }

        [Column(TypeName = "image")]
        public byte[]? Image { get; set; }

        [StringLength(5)]
        public string? ImageExtension { get; set; }
    }
}
