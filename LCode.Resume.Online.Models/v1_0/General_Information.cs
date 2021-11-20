using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LCode.Resume.Online.Models.v1_0
{
    public class General_Information
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Guid_Resume { get; set; }
        [Column(TypeName = "varchar(500)")]
        public string Domain { get; set; }
        [Required]
        [Column(TypeName = "varchar(500)")]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "varchar(500)")]
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        [Required]
        [Column(TypeName = "varchar(500)")]
        public string ActualLocation { get; set; }
        [Required]
        [Column(TypeName = "varchar(150)")]
        public string EMail { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string CellPhoneNumber { get; set; }
        //[Required]
        //[Column(TypeName = "varchar(max)")]
        //public string About { get; set; }
        //[Required]
        //[Column(TypeName = "varchar(250)")]
        //public string Title { get; set; }
        public byte[] Photo { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeModified { get; set; }
    }
}
