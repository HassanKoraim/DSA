namespace BFSImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Make a Graph 
            // Number of vertices in the graph
            int vertices = 5;

            // Create a graph
            Graph graph = new Graph(vertices);

            // Add edges to the graph
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(1, 4);
            graph.AddEdge(2, 4);
            #endregion

            #region Try the BFS Algorithm
            // Perform BFS traversal starting from vertex 0
            Console.Write(
             "Breadth First Traversal starting from vertex 0: ");
            graph.BFS(0);
            #endregion

            #region Try the DFS Algorithm
            graph.DFS(1);
            #endregion

            #region make a new graph
            Graph g = new Graph(4);

            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(1, 2);
            g.AddEdge(2, 0);
            g.AddEdge(2, 3);
            g.AddEdge(3, 3);
            #endregion

            #region Try the DFS Algorithm on the new graph 
            g.DFS(2); // 2 0 1 3 
            #endregion
            Console.ReadKey();
        }
    }
}