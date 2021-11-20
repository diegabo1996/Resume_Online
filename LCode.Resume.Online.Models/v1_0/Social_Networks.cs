using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LCode.Resume.Online.Models.v1_0
{
    public class Social_Networks
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Guid_SocialNetwork { get; set; }
        [ForeignKey("General_Information")]
        public Guid Guid_Resume { get; set; }
        public virtual General_Information General_Information { get; set; }
        public string SocialNetwork_Icon_Code { get; set; }
        [Required]
        public string Link { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeModified { get; set; }
        [ForeignKey("Culture_Resume")]
        public Guid Guid_Culture_Resume { get; set; }
        public virtual Culture_Resume Culture_Resume { get; set; }
    }

    public enum SocialNetwork
    {
        WhatsApp,
        Facebook,
        Twitter,
        Github,
        Linkedin,
        Instagram
    }
}
