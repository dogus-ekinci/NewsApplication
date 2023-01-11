using AppCore.Records.Bases;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities
{
    public class Category : RecordBase
    {
        [Required(ErrorMessage = "{0} zorunlu!")]
        [StringLength(100)]
        public string? Name { get; set; }
        public List<News>? News { get; set; }
    }
}
