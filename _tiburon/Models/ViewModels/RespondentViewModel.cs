using _tiburon.Abstract.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _tiburon.Models.ViewModels
{
    public class RespondentViewModel
    {
        public string FirstQuestion { get; set; }
        public string SecondQuestion { get; set; }
        public Respondent Respondent { get; set; }
        public List<PhoneMark> PhoneMarks { get; set; }

        public RespondentViewModel(IRespondentRepository respondentRepository)
        {
            FirstQuestion = "Укажите ваш пол:";
            SecondQuestion = "Марка вашего телефона:";
            Respondent = new Respondent();
            PhoneMarks = respondentRepository.GetAllPhonesMarks();
        }
    }
}
