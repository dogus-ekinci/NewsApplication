using AppCore.Records.Bases;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Entities
{
    public class News : RecordBase
    {
        [Required(ErrorMessage = "{0} zorunlu")]
        [DisplayName("Haber Başlığı")]
        [MinLength(10, ErrorMessage = "{0} en az {1} karakter içermeli!")]
        [MaxLength(200, ErrorMessage = "{0} en fazla {1} karakter içermeli!")]
        public string? Header { get; set; }

        [Required(ErrorMessage = "{0} zorunlu")]
        [DisplayName("Haber İçeriği")]
        public string? Content { get; set; }

        [DisplayName("Manşet")]
        public bool IsCuff { get; set; }

        [Column(TypeName = "image")]
        public byte[]? Image { get; set; }
        [StringLength(5)]
        public string? ImageExtension { get; set; }

        [Required(ErrorMessage = "{0} zorunlu")]
        [DisplayName("Kategori")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
