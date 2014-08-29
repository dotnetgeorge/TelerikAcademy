using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeProgram.Data
{
    partial class BinarySearchTree<T> : ICloneable, IEnumerable<T> 
        where T : IComparable<T>, IEquatable<T>
    {
        public static bool operator ==(BinarySearchTree<T> firstArray, BinarySearchTree<T> secondArray)
        {
            return BinarySearchTree<T>.Equals(firstArray, secondArray);
        }

        public static bool operator !=(BinarySearchTree<T> firstArray, BinarySearchTree<T> secondArray)
        {
            return !BinarySearchTree<T>.Equals(firstArray, secondArray);
        }

        private IEnumerable<T> Traverse(Node root)
        {
            if (root != null)
            {
                foreach (T item in Traverse(root.Left))
                {
                    yield return item;
                }

                yield return root.Key;

                foreach (T item in Traverse(root.Right))
                {
                    yield return item;
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return Traverse(root).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public object Clone()
        {
            BinarySearchTree<T> tree = new BinarySearchTree<T>();

            foreach (T item in this)
            {
                tree.Add(item);
            }

            return tree;
        }

        public override int GetHashCode()
        {
            int hashCode = 17;

            unchecked
            {
                foreach (T item in this)
                {
                    hashCode = hashCode * 23 + item.GetHashCode();
                }
            }

            return hashCode;
        }

        public override bool Equals(object obj)
        {
            IEnumerator<T> firstTree = this.GetEnumerator();
            IEnumerator<T> secondTree = (obj as BinarySearchTree<T>).GetEnumerator();

            while (firstTree.MoveNext() && secondTree.MoveNext())
            {
                if (!firstTree.Current.Equals(secondTree.Current))
                {
                    return false;
                }
            }

            return (!firstTree.MoveNext() && !secondTree.MoveNext());
        }

        public override string ToString()
        {
            return String.Join(" ", this);
        }
    }
}
