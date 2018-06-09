using _tiburon.Abstract.Models;
using _tiburon.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _tiburon.Models.Concrete
{
    public class RespondentRepository : IRespondentRepository
    {
        private RespondentContext context;

        public RespondentRepository(RespondentContext context)
        {
            this.context = context;
        }
        public void AddRespondentAnswer(string gender, string[] items)
        {

            Respondent resp = new Respondent();
            resp.Gender = gender;

            context.Respondents.Add(resp);
            context.SaveChanges();
            
            List<PhoneMark> phoneMarks = GetAllPhonesMarks();
            foreach (var PhoneMark in phoneMarks)
            {
                if (items.Contains(PhoneMark.Name))
                    resp.RespondetnPhoneMarks.Add(new RespondetnPhoneMark { RespondentId = resp.Id, PhoneMarkId = PhoneMark.Id });
            }
            context.SaveChanges();
        }

        public List<PhoneMark> GetAllPhonesMarks()
        {
            var phoneMarks = context.PhoneMarks.OrderBy(p => p.Name).ToList();
            return phoneMarks;
        }
    }
}
