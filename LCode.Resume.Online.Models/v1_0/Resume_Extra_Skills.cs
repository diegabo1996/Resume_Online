using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LCode.Resume.Online.Models.v1_0
{
    public class Resume_Extra_Skills
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Guid_Resume_Extra_Skill { get; set; }
        [ForeignKey("General_Information")]
        public Guid Guid_Resume { get; set; }
        public virtual General_Information General_Information { get; set; }
        [Required]
        [Column(TypeName = "varchar(250)")]
        public string Skill_Title { get; set; }
        [Required]
        [Column(TypeName = "varchar(250)")]
        public string Skill_Name { get; set; }
        [Required]
        public short Percent_Experience { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeModified { get; set; }
        [ForeignKey("Culture_Resume")]
        public Guid Guid_Culture_Resume { get; set; }
        public virtual Culture_Resume Culture_Resume { get; set; }
    }
}
