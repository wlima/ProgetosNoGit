using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public abstract class Base
    {

        public int Id{ get; set; }
        public bool Status { get; set; }
        public string log { get; set; }
    }
}
