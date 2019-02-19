using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smss.model
{
    class studentObj
    {
        public string code { get; set; }
        public string name { get; set; }
        public string userpass { get; set; }
        public string photo { get; set; }
        public DateTime birthday { get; set; }
        public string note { get; set; }
        public string gradecode { get; set; }
        public string classcode { get; set; }
        public gradeObj _gradecode { get; set; }
        public classObj _classcode { get; set; }
        public string codeview { get; set; }

    }
}
