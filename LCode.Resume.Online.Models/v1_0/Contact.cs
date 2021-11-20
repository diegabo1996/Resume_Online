using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LCode.Resume.Online.Models.v1_0
{
    public class Contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Guid_Contact { get; set; }
        [ForeignKey("General_Information")]
        public Guid Guid_Resume { get; set; }
        public virtual General_Information General_Information { get; set; }
        [Required]
        [Column(TypeName = "varchar(150)")]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string EMail { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Cellphone { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Subject { get; set; }
        [Required]
        [Column(TypeName = "varchar(max)")]
        public string Message { get; set; }
        public DateTime DateTimeRegistred { get; set; }
        [Required]
        public bool Notified { get; set; }
        [NotMapped]
        [BindProperty(Name = "g-recaptcha-response")]
        public string Recaptcha { get; set; }
        
    }
}
