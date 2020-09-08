using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WBD_Demo.Models
{
    public class LanguageRepository : ILanguageRepository
    {
        private AppDbContext context;

        public LanguageRepository(AppDbContext context)
        {
            this.context = context;
        }
        public IEnumerable<Language> Gets()
        {
            return context.Languages;
        }
    }
}
