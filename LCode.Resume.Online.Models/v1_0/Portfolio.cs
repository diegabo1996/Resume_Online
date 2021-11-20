using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LCode.Resume.Online.Models.v1_0
{
    public class Portfolio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Guid_Portfolio { get; set; }
        [ForeignKey("General_Information")]
        public Guid Guid_Resume { get; set; }
        public virtual General_Information General_Information { get; set; }
        [ForeignKey("Category_Portfolio")]
        public Guid Guid_Category_Portolio { get; set; }
        public virtual Category_Portfolio Category_Portfolio { get; set; }
        [Required]
        [Column(TypeName = "varchar(250)")]
        public string Title { get; set; }
        [Required]
        [Column(TypeName = "varchar(250)")]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "varchar(250)")]
        public string Description { get; set; }
        public string Link_Img { get; set; }
        public string Link { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeModified { get; set; }
        [ForeignKey("Culture_Resume")]
        public Guid Guid_Culture_Resume { get; set; }
        public virtual Culture_Resume Culture_Resume { get; set; }
    }
    public class Category_Portfolio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Guid_Category_Portolio { get; set; }
        [Column(TypeName = "varchar(250)")]
        public string Title { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Code_Figure { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Group_Code { get; set; }
        [ForeignKey("Culture_Resume")]
        public Guid Guid_Culture_Resume { get; set; }
        public virtual Culture_Resume Culture_Resume { get; set; }
    }
}
