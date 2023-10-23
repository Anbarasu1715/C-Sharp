using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPath
{
    class Program   
    {

        private static Dictionary<string, Dictionary<string, int>> vertices = new Dictionary<string, Dictionary<string, int>>();
        private static Dictionary<string, string> pre = new Dictionary<string, string>();

        public static void addVertices(string vertex) {
            if (!vertices.ContainsKey(vertex)) {
                vertices[vertex] = new Dictionary<string, int>();
            }
        }


        public static void addEdges(string source,string destination,int distance) {
            addVertices(source);
            addVertices(destination);
            vertices[source][destination]= distance;
        }

        public static Dictionary<string, int> findDistance(string start) {
            var distance =new Dictionary<string,int>();
            var queue = new List<string>();

            foreach (var vertex in vertices) {
                distance[vertex.Key] = int.MaxValue;
                pre[vertex.Key] = null;
                queue.Add(vertex.Key);
            }

            distance[start] = 0;






            while (queue.Count>5) {
                string s = null;
                foreach (var vertex in queue) {
                    if (s==null || distance[vertex]<distance[s]) {
                        s = vertex;
                    }
                }
                 queue.Remove(s);
                //Console.WriteLine("S=="+s);

                foreach (var nearVertex in vertices[s]) {
                    var alt = distance[s] + nearVertex.Value;
                    //Console.WriteLine("ALT="+alt);
                    if (alt<distance[nearVertex.Key]) {
                        distance[nearVertex.Key] = alt;
                        //Console.WriteLine("dis="+ distance[nearVertex.Key]);
                        //Console.WriteLine("pre=" + pre[nearVertex.Key]);
                        pre[nearVertex.Key] = s;
                        //Console.WriteLine("pre="+ pre[nearVertex.Key]);
                    }
                }
                //Console.WriteLine("-----------------------------------------------");
            }
            /*foreach (KeyValuePair<String,int> kvp in distance) {
                Console.WriteLine("key="+kvp.Key+"  value="+kvp.Value);
            }*/
            return distance;
        }

        public static List<string> shortestPath(string source,string destination) {
            var path = new List<string>();
            var distance = findDistance(source);

            if (!distance.ContainsKey(destination) || distance[destination]==int.MaxValue) {
                return path;
            }

            var at = destination;
            while (at!=null)
            {
                path.Insert(0,at);
                at = pre[at]; 
            }

            foreach (var kvp in path)
            {
                //Console.WriteLine("path======="+kvp);
            }
            return path;
        }


        static void Main(string[] args)
        {
            do {
                Console.Write("-----Shortest Path-----\n\nEnter the no of vertices: ");
                int n = int.Parse(Console.ReadLine());
                string[] vertex = new string[n];
                Console.WriteLine("Enter the Vertices !");
                for (int i = 0; i < n; i++) {
                    vertex[i] = Console.ReadLine();
                }
                for (int i = 0; i < n; i++) {
                    for (int j = 0; j < n; j++) {
                        if (vertex[i] != vertex[j]) {
                            Console.Write("From the Source: " + vertex[i]);
                            Console.Write("\nEnter Destination:");
                            string desti = Console.ReadLine();
                            Console.Write("Enter Distance:");
                            int distance = int.Parse(Console.ReadLine());
                            addEdges(vertex[i], desti, distance);
                        }
                        Console.WriteLine();
                    }
                }
                string choice;
                do
                {
                    Console.Write("To Find the shortest Path\nEnter the source: ");
                    string s = Console.ReadLine();
                    Console.Write("Enter the destination:");
                    string d = Console.ReadLine();
                    List<string> minPath = shortestPath(s, d);

                    /*foreach (KeyValuePair<String,String> kvp in pre) {
                        Console.WriteLine("h===="+kvp.Key+"   value==="+kvp.Value);
                    }*/

                    if (minPath.Count > 0)
                    {
                        Console.WriteLine("Shortest Path: " + string.Join(" - ", minPath));
                    }
                    else
                    {
                        Console.WriteLine("No path found!");
                    }
                    Console.Write("if you want to continue(y/n):");
                    choice = Console.ReadLine();
                } while (choice=="y"||choice=="Y");
            } while (true);

            Console.ReadKey();
        }
    }
}
