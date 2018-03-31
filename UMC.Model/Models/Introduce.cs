using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMC.Model.Models
{
    [Table("Introduces")]
    public class Introduce
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { set; get; }

        [Required]
        [MaxLength(500)]
        public string Name { set; get; }

        [Required]
        public string Content { set; get; }

        public bool Status { set; get; }
    }
}
