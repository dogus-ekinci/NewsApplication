using AppCore.Records.Bases;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities
{
    public class CornerPost : RecordBase
    {
        [Required(ErrorMessage = "{0} zorunlu!")]
        [DisplayName("Köşe Yazısı Başlığı")]
        [MinLength(10, ErrorMessage = "{0} en az {1} karakter içermeli!")]
        [MaxLength(200, ErrorMessage = "{0} en fazla {1} karakter içermeli!")]
        public string? Header { get; set; }

        [Required(ErrorMessage = "{0} zorunlu")]
        [DisplayName("Yazar")]
        public int? WriterId { get; set; }
        public Writer? Writer { get; set; }

        public CornerPostDetail? CornerPostDetails { get; set; }
    }
}
