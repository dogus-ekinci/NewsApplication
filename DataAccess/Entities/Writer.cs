using AppCore.Records.Bases;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Entities
{
    public class Writer : RecordBase
    {
        [Required(ErrorMessage = "{0} zorunlu")]
        [DisplayName("Yazar İsmi")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "{0} zorunlu")]
        [DisplayName("Yazar Soyismi")]
        public string? SurName { get; set; }

        [Column(TypeName = "image")]
        public byte[]? Image { get; set; }
        [StringLength(5)]
        public string? ImageExtension { get; set; }

        public List<CornerPost>? CornerPost { get; set; }
    }
}
