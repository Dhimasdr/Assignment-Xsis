using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class ResponseResult
    {
        public bool success { get; set; }
        public string message { get; set; }
        public object list { get; set; }

    }
}
