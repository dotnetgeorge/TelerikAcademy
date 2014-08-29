/*
 * * Define the data structure binary search tree with operations for
 * "adding new element", "searching element" and "deleting elements".
 * It is not necessary to keep the tree balanced. 
 * Implement the standard methods from System.Object – 
 * ToString(), Equals(…), GetHashCode() and the operators for comparison  == and !=.
 * Add and implement the ICloneable interface for deep copy of the tree. 
 * Remark: Use two types – structure BinarySearchTree (for the tree)
 * and class TreeNode (for the tree elements). 
 * Implement IEnumerable<T> to traverse the tree.
 */
using System;
using BinarySearchTreeProgram.Data;

namespace BinarySearchTreeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> firstTree = new BinarySearchTree<int>();

            for (int i = 0; i < 14; i++)
            {
                firstTree.Add(i);
            }

            firstTree.Add(-5);

            BinarySearchTree<int> secondTree = new BinarySearchTree<int>();

            for (int i = 0; i < 14; i++)
            {
                secondTree.Add(i);
            }

            Console.WriteLine(firstTree);
            //Console.WriteLine(firstTree.Contains(11));

            Console.WriteLine((firstTree.Clone() as BinarySearchTree<int>) == firstTree);
        }
    }
}
