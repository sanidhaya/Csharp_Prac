using sandy_coll.DoubleLinkedList;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandy_coll
{
    internal class Sandy_col<T>:IEnumerable<T>
    {
        private DLinkedList<Node<T>>[] levels;
        private int maxHeight;
        private Random random;


        public Sandy_col(int maxHeight)
        {
            void SkipList(int maxHeight,IEqualityComparer<T> comparer)
            {
            this.maxHeight = maxHeight;
            this.levels = new DLinkedList<Node<T>>[maxHeight + 1];
            for(int i =0; i <= maxHeight; i++)
            {
                levels[i] = new DLinkedList<Node<T>>();
            }
            this.random = new Random();
            }

             public IEnumerator<T> GetEnumerator()
             {
                return levels[0].GetEnumerator();
             }

            IEnumerator IEnumerable.GetEnumerator()
                {
                return GetEnumerator();
            }

        //insert
        //search
        //Delete
    }
        //private node
        /*
         properties => data,next, up , down
         */
    }
