using System;

namespace GraphImpelementation
{
    public class GraphL : Graph
    {
        private GraphList[] vertex;
        private int numEdge;
        private int[] mark;

        // Constructors
        public GraphL() { }
        public GraphL(int n)
        {
            Init(n);
        }
        public void Init(int n)
        {
            vertex = new GraphList[n];
            mark = new int[n];
            numEdge = 0;
        }
        // # of Vertices
        public int n()
        {
            return mark.Length;
        }
        // # of Edges
        public int e()
        {
            return numEdge;
        }
        // @return v’s first neighbor 
        public int first(int v)
        {
            if (vertex[v] == null) { return mark.Length; }  // no neighbor
            vertex[v].MoveToStart();
            Edge it = vertex[v].getValue(); //
            return it.vertex();

        }
        public void delEdge(int i, int j)
        {
            throw new NotImplementedException();
        }
        

        public int getMark(int v)
        {
            throw new NotImplementedException();
        }

        
        public bool isEdge(int i, int j)
        {
            throw new NotImplementedException();
        }


        /** @return v’s next neighbor after w */
        public int next(int v, int w)
        {
            Edge it = null;
            if(isEdge(v, w))
            {
                vertex[v].Next();
                it = vertex[v].getValue();
            }
            if (it == null) return mark.Length; // no neighbor
            else return it.vertex();
            throw new NotImplementedException();
        }

        public void setEdge(int i, int j, int wght)
        {
            throw new NotImplementedException();
        }

        public void setMark(int v, int val)
        {
            throw new NotImplementedException();
        }

        public int weight(int i, int j)
        {
            throw new NotImplementedException();
        }
    }
}
