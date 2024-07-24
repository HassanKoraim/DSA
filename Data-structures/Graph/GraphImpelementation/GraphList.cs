using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphImpelementation
{
    internal class GraphList : LList<Edge>
    {      
        public Link<Edge> currLink() { return getCurr(); }
        public void setCurr(Link<Edge> who) { setCurr(who); }
    
    }
}
