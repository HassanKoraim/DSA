using System;
using System.Collections.Generic;


namespace BFSImplementation
{
    public class Graph
    {
        int vertices;    // # of Vertices
        List<int>[] adjList;

        // Constructor
        public Graph(int vertices) 
        {
            this.vertices = vertices;
            adjList = new List<int>[vertices];
            for(int i = 0; i < vertices; i++)
            {
                adjList[i] = new List<int>();
            }
        }
        // Function to add an edge to the graph
        public void AddEdge(int u , int v) { adjList[u].Add(v); }

        // Function to perform Breadth First Search on a graph
        public void BFS(int startNode)
        {
            // Create a queue for BFS
            Queue<int> queue = new Queue<int>();
            bool[] visted = new bool[vertices];
            // Mark the current node as visited and enqueue it
            visted[startNode] = true;
            queue.Enqueue(startNode);

            // Iterate over the queue
            while (queue.Count > 0)
            {
                // Dequeue a vertex from queue and print it
                int currentNode = queue.Dequeue();
                Console.WriteLine(currentNode + " ");

                foreach(int neighbor in adjList[currentNode])
                {
                    // if the neibor didn't visted
                    if (!visted[neighbor])
                    {
                        // Enqueue to the Queue and Mark it as Visted
                        queue.Enqueue(neighbor);
                        visted[neighbor] = true;
                    }
                }

                // for(int i = 0; i < adjList[][].)
            }
        }
    }
}
