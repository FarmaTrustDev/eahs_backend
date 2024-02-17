using System.ComponentModel.DataAnnotations.Schema;

namespace EAHS.Models
{
    public class User : BaseModel
    {
        [Column(TypeName = "nvarchar(40)")]
        public string UserName { get; set; }

        [Column(TypeName = "nvarchar(256)")]
        public string Password { get; set; }

        [Column(TypeName = "nvarchar(40)")]
        public string Email { get; set; }
    }
}
