using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LCode.Resume.Online.Models.v1_0
{
    public class Resume_Knowledge_General
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Guid_Resume_Knowledge_General { get; set; }
        [ForeignKey("General_Information")]
        public Guid Guid_Resume { get; set; }
        public virtual General_Information General_Information { get; set; }
        [Required]
        [Column(TypeName = "varchar(75)")]
        public string Title { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeModified { get; set; }
        [ForeignKey("Culture_Resume")]
        public Guid Guid_Culture_Resume { get; set; }
        public virtual Culture_Resume Culture_Resume { get; set; }
    }
}
