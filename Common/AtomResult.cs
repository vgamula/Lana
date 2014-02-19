using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class AtomResult
    {
        public User User { get; set; }
        public int Mark { get; set; }
        public int TasksDone { get; set; }

        public AtomResult()
        {
            this.User = null;
        }
    }
}
