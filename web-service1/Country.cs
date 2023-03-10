using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web_service1
{
    public class Country
    {
        public string code { get; set; }
        public string name { get; set; }
        public string tostring()
        {
            return "Nation: " + name + "(" + code + ")";
        }
    }
}