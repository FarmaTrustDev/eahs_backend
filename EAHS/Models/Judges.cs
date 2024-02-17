using System.ComponentModel.DataAnnotations.Schema;

namespace EAHS.Models
{
    public class Judges : BaseModel
    {
        public string JudgeName { get; set; }
        [Column(TypeName = "nvarchar(Max)")]
        public string CountryFlag { get; set; }
        public string CountryName { get; set; }
        public bool IsMember { get; set; }
        public bool IsConflict { get; set; }
    }
}
