using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMC.Model.Models
{
    [Table("Recruiments")]
    public class RecruimentInfor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { set; get; }

        [Required]
        [MaxLength(500)]
        public string Name { set; get; }

        [Required]
        public int Quantity { set; get; }

        [Required]
        [MaxLength(200)]
        public string Department { set; get; }

        [Required]
        [MaxLength(200)]
        public string Level { set; get; }

        [Required]
        [MaxLength(3000)]
        public string Required { set; get; }

        public DateTime? CreatedDate { set; get; }

        public DateTime? UpdatedDate { set; get; }

        [Required]
        public DateTime? PostDate { set; get; }

        [Required]
        public DateTime? ExpireDate { set; get; }

        [Required]
        [MaxLength(1000)]
        public string Contact { set; get; }

        [Required]
        public int RecruimentType { set; get; }

        public bool IsTop { set; get; }

        public bool IsDeleted { set; get; }

        public bool Status { set; get; }
    }
}
