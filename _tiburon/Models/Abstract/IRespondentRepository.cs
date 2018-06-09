using _tiburon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _tiburon.Abstract.Models
{
    public interface IRespondentRepository
    {
        void AddRespondentAnswer(string gender, string[] items);
        List<PhoneMark> GetAllPhonesMarks();
    }
}
