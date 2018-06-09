using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _tiburon.Models.Entities
{
    public class RespondetnPhoneMark
    {
        public int PhoneMarkId { get; set; }
        public PhoneMark PhoneMark { get; set; }

        public int RespondentId { get; set; }
        public Respondent Respondent { get; set; }
    }
}
