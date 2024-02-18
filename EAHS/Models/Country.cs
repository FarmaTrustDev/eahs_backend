using System.ComponentModel.DataAnnotations.Schema;

namespace EAHS.Models
{
    public class Country : BaseModel
    {
        [Column(TypeName = "nvarchar(200)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string CountryCode { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string ISO { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string FlagPath { get; set; }

    }
}
