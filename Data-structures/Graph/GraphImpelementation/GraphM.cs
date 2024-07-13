using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphImpelementation
{
    public class GraphM : Graph
    {
        private int[][] matrix;             // The edge matrix
        private int numEdge;                // number of Edges
        private int[] Mark;                 // The mark array

        //Constrcutors
        public GraphM(){}  // Empty Constructor
        public GraphM(int n)
        {
            Init(n);
        }
        public void Init(int n)
        {
            matrix = new int[n][];
            Mark = new int[n];
            numEdge = 0;
        }
        public int n() // # of vertices
        {
            return Mark.Length;
        }
        public int e()  // # of edges
        {
            return numEdge;
        }
        /** @return v’s first neighbor */
        public int first(int v)
        {
            int num;
            for (int i = 0; i < Mark.Length; i++)
            {
                num = matrix[v][i];
                if (num != 0)
                {
                    return i;
                }
            }
            return Mark.Length;     // No edge for this vertex
        }
        /** @return v’s next neighbor after w */
        public int next(int v, int w)
        {
            int num;
            for (int i = w + 1; i < Mark.Length; i++)
            {
                num = matrix[v][i];
                if (num != 0) return i;
            }
            return Mark.Length; // No next edge;
        }
        /** Set the weight for an edge */
        public void setEdge(int i, int j, int wght)
        {
            if (matrix[i][j] != 0)
            {
                Console.WriteLine("Can't Cannot set weight ");
                return;
            }
            else
            {
                numEdge++;
                matrix[i][j] = wght;
            }
        }
        public void delEdge(int i, int j)
        {
            if (matrix[i][j] != 0)
                numEdge--;
            matrix[i][j] = 0;
        }

        /** Determine if an edge is in the graph */
        public bool isEdge(int i, int j)
        {
            return matrix[i][j] != 0;
        }
        /** @return an edge’s weight */
        public int weight(int i, int j)
        {
            return matrix[(int)i][j];
        }
        /** Set/Get the mark value for a vertex */
        public void setMark(int v, int val) { Mark[v] = val; }
        public int getMark(int v) { return Mark[v]; }
    }
}
