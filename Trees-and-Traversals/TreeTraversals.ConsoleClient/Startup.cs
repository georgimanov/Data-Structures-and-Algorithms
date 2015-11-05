namespace TreeTraversals.ConsoleClient
{
   /*
    * Write a program to read the tree and find:
    *  - the root node
    *  - all leaf nodes
    *  - all middle nodes
    *  - the longest path in the tree
    *  - (*) all paths in the tree with given sum `S` of their nodes
    *  - (*) all subtrees with given sum `S` of their nodes
    */
    using System;
    using Trees_and_Traversals;

    public class Startup
    {
        static void Main()
        {
            Tree<int> tree =
            new Tree<int>(3,
                          new Tree<int>(5,
                                        new Tree<int>(0),
                                        new Tree<int>(1),
                                        new Tree<int>(6)),
                          new Tree<int>(2,
                                        new Tree<int>(4)));

            Console.WriteLine("Depth-First Search (DFS) traversal (recursive):");
            tree.TraverseDFS();
            Console.WriteLine();

            Console.WriteLine("Breadth-First Search (BFS) traversal (with queue):");
            tree.TraverseBFS();
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Depth-First Search (DFS) traversal (with stack):");
            tree.TraverseDFSWithStack();
            Console.WriteLine();

            Console.WriteLine("Root: {0}", tree.Root.Value);

            Console.Write("Leafs: ");
            tree.TraverseLeafs(tree.Root);
            Console.WriteLine();
        }
    }
}
