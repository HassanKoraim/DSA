using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphImpelementation
{
    public class Edge
    {
        private int vert, wt;

        //Constructor
        public Edge(int v , int w)
        {
            vert = v;
            wt = w;
        }

        //Methods
        public int vertex() {  return vert; }
        public int Weight() { return wt; }  
    }
}
