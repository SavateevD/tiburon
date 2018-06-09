using _tiburon.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _tiburon.Models
{
    public class Respondent
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Gender must be selected")]
        public string Gender { get; set; }
        public List<RespondetnPhoneMark> RespondetnPhoneMarks { get; set; }

        public Respondent()
        {
            RespondetnPhoneMarks = new List<RespondetnPhoneMark>();
        }

    }
}
