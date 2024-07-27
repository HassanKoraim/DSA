/*
 * Find the level of given node in an Undirected Graph
 * You can find the problem in this link :
 * https://www.geeksforgeeks.org/find-the-level-of-given-node-in-an-undirected-graph/
*/

using BFSImplementation;

namespace FindLevel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph(5);
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(2, 4);
            Console.WriteLine($"The Level of the Node {graph.BFS(5)}");
        }
    }
}
