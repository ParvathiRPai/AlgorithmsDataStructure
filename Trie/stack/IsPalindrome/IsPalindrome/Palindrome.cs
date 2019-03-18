using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPalindrome
{
    public class Node
    {
        public char data;
        public Node next;
        public Node (char data)
        {
            this.data = data;
        }
    }
    class Palindrome
    {
        private Node slow;
        private Node fast;
        public bool CheckIsPalindrome(Node start)
        {

        Stack<char> s = new Stack<char>();
        
            while(fast != null && fast.next != null)
            {
                s.Push(start.data);
                slow = slow.next;
                fast = fast.next.next;
                
            }
            if(fast !=null)
            {
                slow = slow.next;
            }

            while(slow != null)
            {
                char top = s.Pop();
                if(top != slow.data)
                {
                    return false;
                }
                slow = slow.next;
            }
            return true;
      

        }
    }
}
