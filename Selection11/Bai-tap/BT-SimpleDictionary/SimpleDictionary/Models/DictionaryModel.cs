using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleDictionary.Models
{
    public class DictionaryModel
    {
        public Dictionary<string, string> libs = new Dictionary<string, string>();
        public string word { get; set; }
        public DictionaryModel()
        {
            libs = new Dictionary<string, string>();
            libs.Add("hello", "xin Chào");
            libs.Add("book", "quyển sách");
            libs.Add("school", "trường học");
            libs.Add("employee", "nhân viên");

        }
    }
}
