using _tiburon.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _tiburon.Models
{
    public class PhoneMark
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<RespondetnPhoneMark> RespondetnPhoneMarks { get; set; }

        public PhoneMark()
        {
            RespondetnPhoneMarks = new List<RespondetnPhoneMark>();
        }
    }
}
