using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VetorExeFixacao
{
    public class Room
    {
        public string NameStudent { get; set; }
        public string EmailStudent { get; set; }

        public override string ToString()
        {
            return NameStudent + ", " + EmailStudent;
        }
    }
}