#region Using Directives
using System;
#endregion

namespace GrafosMap.Business
{
    public class DijkstraMax
    {
        #region Fields
        private int verticesCount;
        double[] distance;
        private bool[] largestPathTreeSet;
        private int[] path;
        private double[,] graph;
        private int source;
        #endregion

        #region Constructors
        public DijkstraMax(double[,] graph, int source)
        {
            this.verticesCount = (int)Math.Sqrt(graph.Length);
            this.distance = new double[verticesCount];
            this.largestPathTreeSet = new bool[verticesCount];
            this.path = new int[verticesCount];
            this.graph = graph;
            this.source = source;
        }
        #endregion

        #region Private
        public int[] RunDijkstraMax()
        {
            for (int i = 0; i < this.verticesCount; ++i)
            {
                this.distance[i] = int.MinValue;
                this.largestPathTreeSet[i] = false;
                this.path[i] = -1;
            }

            this.distance[this.source] = 0;

            for (int count = 0; count < this.verticesCount - 1; ++count)
            {
                int u = MaximumDistance();
                largestPathTreeSet[u] = true;

                for (int v = 0; v < verticesCount; ++v)
                {
                    if (!largestPathTreeSet[v] && Convert.ToBoolean(graph[u, v]) && distance[u] != int.MaxValue && distance[u] + graph[u, v] > distance[v])
                    {
                        distance[v] = distance[u] + graph[u, v];
                        path[v] = u;
                    }
                }
            }

            return this.path;
        }

        private int MaximumDistance()
        {
            double max = int.MinValue;
            int maxIndex = int.MaxValue;

            for (int v = 0; v < verticesCount; ++v)
            {
                if (largestPathTreeSet[v] == false && distance[v] >= max)
                {
                    max = distance[v];
                    maxIndex = v;
                }
            }

            return maxIndex;
        }
        #endregion
    }
}
