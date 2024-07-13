# BFS-and-Graph-Implementation

## Overview

`BFS-and-Graph-Implementation` is a C# project demonstrating the implementation of a graph data structure and the Breadth-First Search (BFS) algorithm. The project includes classes to create and manipulate a graph using an adjacency list.

## Project Structure

- **Graph.cs**: This class represents a graph using an adjacency list and provides a method to perform BFS.
- **Program.cs**: This is the main entry point of the application, which creates a graph, adds edges, and performs a BFS traversal starting from a specified vertex.

## Classes

### Graph

The `Graph` class represents a graph using an adjacency list and includes methods to add edges and perform BFS.

#### Fields

- **int vertices**: The number of vertices in the graph.
- **List<int>[] adjList**: The adjacency list representing the graph.

#### Constructor

- **Graph(int vertices)**: Initializes a new instance of the `Graph` class with the specified number of vertices.

#### Methods

- **void AddEdge(int u, int v)**: Adds an edge from vertex `u` to vertex `v`.
- **void BFS(int startNode)**: Performs a BFS traversal starting from the specified vertex.

### Program

The `Program` class is the entry point of the application.

#### Main Method

```csharp
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
    Console.Write("Breadth First Traversal starting from vertex 0: ");
    graph.BFS(0);
}
