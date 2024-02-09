using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteNode
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class Solution
    {
        public void DeleteNode(ListNode node)
        {
            while (node != null)
            {
                node.val = node.next.val;
                if (node.next.next == null)
                {
                    node.next = null;
                }
                node = node.next;
            }

        }
    }
}
