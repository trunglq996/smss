using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smss.model
{
    class classObj
    {
        public string code { get; set; }
        public string name { get; set; }
        public string staffcode { get; set; }
        public string gradecode { get; set; }
        public string note { get; set; }
        public gradeObj _gradecode { get; set; }
        public string codeview { get; set; }
    }
}
