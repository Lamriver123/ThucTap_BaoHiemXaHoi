using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Models
{
    [Table("TraCuuC12")]
    public class TraCuuC12Models
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(50)]
        public string? STT { get; set; }

        [MaxLength(500)]
        public string? NoiDung { get; set; }

        [MaxLength(50)]
        public string? BHXH_OD_TS { get; set; }

        [MaxLength(50)]
        public string? BHXH_HTTT { get; set; }

        [MaxLength(50)]
        public string? BHYT { get; set; }

        [MaxLength(50)]
        public string? BHTN { get; set; }

        [MaxLength(50)]
        public string? BHTNLD_BNN { get; set; }

        [MaxLength(50)]
        public string? Cong { get; set; }

        [MaxLength(50)]
        public string userName { get; set; }

        public DateTime Date { get; set; }

        public int Level { get; set; }
    }
}
