using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCode.Resume.Online.Models
{
    public class RecaptchaResponse
    {
            public bool success { get; set; }
            public DateTime challenge_ts { get; set; }
            public string hostname { get; set; }
    }
}
