using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dapper.Entities
{
    public class DapperDbModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public long Id { get; set; }

        [Column(TypeName = "NVARCHAR")]
        [MaxLength(100)]

        public string name { get; set; } = "";

        [Column(TypeName = "NVARCHAR")]
        [MaxLength(100)]

        public string email { get; set; } = "";

        public int age { get; set; }
    }
}
