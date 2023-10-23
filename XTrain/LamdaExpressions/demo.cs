using System;
using System.Collections.Generic;

public class Graph
{
    private Dictionary<string, Dictionary<string, int>> vertices = new Dictionary<string, Dictionary<string, int>>();
    private Dictionary<string, string> previous = new Dictionary<string, string>(); // Declare 'previous' here.

    public void AddVertex(string vertex)
    {
        if (!vertices.ContainsKey(vertex))
        {
            vertices[vertex] = new Dictionary<string, int>();
        }
    }

    public void AddEdge(string source, string destination, int weight)
    {
        if (!vertices.ContainsKey(source))
        {
            AddVertex(source);
        }

        if (!vertices.ContainsKey(destination))
        {
            AddVertex(destination);
        }

        vertices[source][destination] = weight;
        vertices[destination][source] = weight; // Assuming an undirected graph.
    }

    public Dictionary<string, int> Dijkstra(string start)
    {
        var distances = new Dictionary<string, int>();
        var queue = new List<string>();

        foreach (var vertex in vertices)
        {
            distances[vertex.Key] = int.MaxValue;
            previous[vertex.Key] = null;
            queue.Add(vertex.Key);
        }

        distances[start] = 0;

        while (queue.Count > 0)
        {
            string u = null;
            foreach (var vertex in queue)
            {
                if (u == null || distances[vertex] < distances[u])
                {
                    u = vertex;
                }
            }

            queue.Remove(u);

            if (distances[u] == int.MaxValue)
            {
                break;
            }

            foreach (var neighbor in vertices[u])
            {
                var alt = distances[u] + neighbor.Value;
                if (alt < distances[neighbor.Key])
                {
                    distances[neighbor.Key] = alt;
                    previous[neighbor.Key] = u;
                }
            }
        }

        return distances;
    }

    public List<string> ShortestPath(string start, string end)
    {
        var path = new List<string>();
        var distances = Dijkstra(start);

        if (!distances.ContainsKey(end) || distances[end] == int.MaxValue)
        {
            return path; // No path found.
        }

        var at = end;
        while (at != null)
        {
            path.Insert(0, at);
            at = previous[at]; // Use the 'previous' dictionary here.
        }

        return path;
    }
}

class Program
{
    static void Main()
    {
        var graph = new Graph();

        // Add vertices and edges to the graph.
        graph.AddEdge("A", "B", 2);
        graph.AddEdge("A", "C", 4);
        graph.AddEdge("B", "C", 1);
        graph.AddEdge("B", "D", 7);
        graph.AddEdge("C", "E", 3);
        graph.AddEdge("D", "E", 2);

        // Find the shortest path from "A" to "E".
        List<string> shortestPath = graph.ShortestPath("A", "E");

        if (shortestPath.Count > 0)
        {
            Console.WriteLine("Shortest Path: " + string.Join(" -> ", shortestPath));
        }
        else
        {
            Console.WriteLine("No path found.");
        }
    }
}
