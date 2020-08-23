using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WBD_Demo.ViewModels
{
    public class HomeEditViewModel : HomeCreateViewModel
    {
        public int ID { get; set; }
        public string AvatarPath { get; set; }
    }
}
