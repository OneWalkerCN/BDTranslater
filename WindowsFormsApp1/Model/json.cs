using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Json
    {
        public string from { get; set; }
        public string to { get; set; }
        public List<Trans_result> trans_result { get; set; }
        public Int32 error_code { get; set; }

      
    }
    public class Trans_result {
        public string src { get; set; }
        public string dst { get; set; }

      
    }
}
