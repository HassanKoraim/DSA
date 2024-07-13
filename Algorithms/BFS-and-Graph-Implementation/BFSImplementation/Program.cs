namespace BFSImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            // Perform BFS traversal starting from vertex 0
            Console.Write(
                "Breadth First Traversal starting from vertex 0: ");
            graph.BFS(0);
        }
    }
}
