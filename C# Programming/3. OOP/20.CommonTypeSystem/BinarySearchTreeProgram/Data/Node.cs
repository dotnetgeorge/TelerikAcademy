using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeProgram.Data
{
    partial class BinarySearchTree<T>
    {
        private class Node
        {
            public T Key
            {
                get;
                private set;
            }

            public Node Left
            {
                get;
                set;
            }

            public Node Right
            {
                get;
                set;
            }

            public Node(T key)
            {
                this.Key = key;
            }
        }
    }
}
