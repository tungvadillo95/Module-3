using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WBD_Demo.Models
{
    public interface ILanguageRepository
    {
        IEnumerable<Language> Gets();
    }
}
