using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WBD_Demo.Models;

namespace WBD_Demo.ViewModels
{
    public class HomeEditViewModel : HomeCreateViewModel
    {
        public int ID { get; set; }
        public List<Language> SelectedLanguages { get; set; }
    }
}
