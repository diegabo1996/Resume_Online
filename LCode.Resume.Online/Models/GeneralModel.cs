using LCode.Resume.Online.Models.v1_0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCode.Resume.Online.Models
{
    public class GeneralModel
    {
        public General_Information General_Information { get; set; }
        public List<Culture_Resume> CultureResume { get; set; }
        public About_Info About_Info { get; set; }
        public List<Personal_Titles> Personal_Titles { get; set; }
        public List<WhatIDo> WhatIDo { get; set; }
        public List<Resume_Section> Resume_Section { get; set; }
        public List<IGrouping<string,Resume_Extra_Skills>> Resume_Extra_Skills_Groups { get; set; }
        public List<Resume_Knowledge_General> Resume_Knowledge_General { get; set; }
        public List<Social_Networks> Social_Networks { get; set; }
        public List<IGrouping<Category_Portfolio, Portfolio>> Portfolio_Group { get; set; }
    }
}
