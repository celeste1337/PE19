using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YostCeleste_PE19
{
    class Node
    {
        ///fields
        ///data int
        ///left node
        ///right node
        ///
        private int data;
        private Node left;
        private Node right;

        ///constructor
        public Node(int p_data)
        {
            this.data = p_data;
        }

        ///properties go here
        ///
        public int Data
        {
            get
            {
                return data;
            }
        }

        public Node Left
        {
            get
            {
                return left;
            }
        }

        public Node Right
        {
            get
            {
                return right;
            }
        }

        ///display
        public void Display()
        {
            Console.WriteLine(data);
        }

    }
}
