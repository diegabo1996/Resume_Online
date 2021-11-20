using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LCode.Resume.Online.Models.v1_0
{
    public class Culture_Resume
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Guid_Culture_Resume { get; set; }
        [ForeignKey("General_Information")]
        public Guid Guid_Resume { get; set; }
        public virtual General_Information General_Information { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]
        public string Culture_Code { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Description { get; set; }
        [Required]
        public bool Enable { get; set; }
        public DateTime DateTimeCreated { get; set; }
    }
}
