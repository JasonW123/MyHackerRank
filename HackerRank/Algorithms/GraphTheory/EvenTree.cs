using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.GraphTheory
{
    public static class EvenTree
    {
        public static void Run()
        {
            var temp = Console.ReadLine();
            if (temp == null) return;
            var temps = temp.Split(' ');
            var vertexCount = Convert.ToInt32(temps[0]);
            var edgeCount = Convert.ToInt32(temps[1]);

            //var edges = new List<Tuple<int, int>>();
            //for (var i = 0; i < edgeCount; i++)
            //{
            //    temp = Console.ReadLine();
            //    if (temp == null) continue;
            //    temps = temp.Split(' ');
            //    var a = Convert.ToInt32(temps[0]);
            //    var b = Convert.ToInt32(temps[1]);
            //    edges.Add(new Tuple<int, int>(a, b));
            //}
            var edges = new List<Tuple<int, int>>();
            edges.Add(new Tuple<int, int>(2, 1));
            edges.Add(new Tuple<int, int>(3, 1));
            edges.Add(new Tuple<int, int>(4, 3));
            edges.Add(new Tuple<int, int>(5, 2));
            edges.Add(new Tuple<int, int>(6, 1));
            edges.Add(new Tuple<int, int>(7, 2));
            edges.Add(new Tuple<int, int>(8, 6));
            edges.Add(new Tuple<int, int>(9, 8));
            edges.Add(new Tuple<int, int>(10, 8));

            var result = 0;
            for (var i = edgeCount - 1; i >=0; i--)
            {
                var tempEdges = new List<Tuple<int, int>>(edges);
                tempEdges.Remove(edges[i]);
                if(AreAllTreesEven(tempEdges))
                {
                    edges.Remove(edges[i]);
                    result++;
                }
            }

            Console.WriteLine(result);
        }

        private static bool AreAllTreesEven(List<Tuple<int, int>> edges)
        {
            var forest = MakeForest(edges);
            var result = 0;
            return forest.All(t => Math.DivRem(t.Count, 2, out result) == 0);
        }

        private static List<List<TreeNode>> MakeForest(List<Tuple<int, int>> edges)
        {
            var forest = new List<List<TreeNode>>();
            var temp = new List<Tuple<int, int>>(edges);
            while (temp.Any())
            {
                var treeNodes = new List<TreeNode>();
                var preCount = treeNodes.Count;

                var firstEdge = temp.FirstOrDefault();
                if (firstEdge == null) return forest;
                var a = firstEdge.Item1;
                var b = firstEdge.Item2;
                var nodeA = new TreeNode(a);
                var nodeB = new TreeNode(b);
                nodeA.Children.Add(nodeB);
                treeNodes.Add(nodeA);
                treeNodes.Add(nodeB);
                temp.Remove(firstEdge);

                var currentCount = treeNodes.Count;
                while (preCount != currentCount)
                {
                    preCount = treeNodes.Count;
                    for (var i = temp.Count - 1; i >= 0; i--)
                    {
                        var edge = temp[i];
                        if (edge == null) continue;
                        var valueA = edge.Item1;
                        var valueB = edge.Item2;

                        var nodeEqualA = treeNodes.FirstOrDefault(n => n.Value == valueA);
                        if (nodeEqualA != null)
                        {
                            var newNodeB = new TreeNode(valueB);
                            nodeEqualA.Children.Add(newNodeB);
                            treeNodes.Add(newNodeB);
                            temp.Remove(edge);
                            continue;
                        }
                        var nodeEqualB = treeNodes.FirstOrDefault(n => n.Value == valueB);
                        if (nodeEqualB != null)
                        {
                            var newNodeA = new TreeNode(valueA);
                            nodeEqualB.Children.Add(newNodeA);
                            treeNodes.Add(newNodeA);
                            temp.Remove(edge);
                            continue;
                        }
                    }
                    currentCount = treeNodes.Count;
                }

                if(treeNodes.Any()) forest.Add(treeNodes);
            }
            return forest;
        }

        private class TreeNode
        {
            public TreeNode(int value)
            {
                Value = value;
                Children = new List<TreeNode>();
            }

            public int Value { get; set; }

            public List<TreeNode> Children { get; set; }

            public IEnumerable<TreeNode> Flatten()
            {
                return new List<TreeNode> { this }.Union(Children.SelectMany(c => c.Children).ToList());
            }
        }
    }
}
