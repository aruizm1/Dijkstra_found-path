#region Using Directives
using System;
#endregion

namespace GrafosMap.Business
{
    public class DijkstraMin
    {
        #region Fields
        private int verticesCount;
        double[] distance;
        private bool[] shortestPathTreeSet;
        private int[] path;
        private double[,] graph;
        private int source;
        #endregion

        #region Constructors
        public DijkstraMin(double[,] graph, int source)
        {
            this.verticesCount = (int)Math.Sqrt(graph.Length);
            this.distance = new double[verticesCount];
            this.shortestPathTreeSet = new bool[verticesCount];
            this.Path = new int[verticesCount];
            this.graph = graph;
            this.source = source;
        }
        #endregion

        #region Private
        public void RunDijkstraMin()
        {
            for (int i = 0; i < this.verticesCount; ++i)
            {
                this.distance[i] = int.MaxValue;
                this.shortestPathTreeSet[i] = false;
                this.Path[i] = -1;
            }

            this.distance[this.source] = 0;

            for (int count = 0; count < this.verticesCount - 1; ++count)
            {
                int u = MinimumDistance();
                shortestPathTreeSet[u] = true;

                for (int v = 0; v < verticesCount; ++v)
                {
                    if (!shortestPathTreeSet[v] && Convert.ToBoolean(graph[u, v]) && distance[u] != int.MaxValue && distance[u] + graph[u, v] < distance[v])
                    {
                        distance[v] = distance[u] + graph[u, v];
                        Path[v] = u;
                    }
                }
            }
        }

        private int MinimumDistance()
        {
            double min = int.MaxValue;
            int minIndex = 0;

            for (int v = 0; v < verticesCount; ++v)
            {
                if (shortestPathTreeSet[v] == false && distance[v] <= min)
                {
                    min = distance[v];
                    minIndex = v;
                }
            }

            return minIndex;
        }
        #endregion

        #region Properties
        public int[] Path { get => path; set => path = value; }
        #endregion
    }
}
