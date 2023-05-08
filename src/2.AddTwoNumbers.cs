// 2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yu_LeetCode.Problems
{
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

    public class AddTwoNumbers
    {
        public static ListNode Solution(ListNode l1, ListNode l2)
        {
            int carry = 0;
            ListNode res = new ListNode(0);
            var map = res;
            while(l1!=null || l2!=null || carry>0)
            {
                if(l1!=null)
                {
                    carry+=l1.val;
                    l1 = l1.next;
                }
                if (l2!=null)
                {
                    carry+=l2.val;
                    l2 = l2.next;
                }                            
                map.next = new ListNode(carry%10);
                carry = carry/10;
                map = map.next;
            }          
            // 0123
            return res.next;
        }

        /*
        class Solution {
        public:
            ListNode* addTwoNumbers(ListNode* l1, ListNode* l2) {
                int carry = 0;
                ListNode *res = new ListNode(0);
                ListNode *l3 = res;
                while(l1!=NULL || l2!=NULL || carry>0)
                {
                    if(l1!=NULL)
                    {
                        carry+=l1->val;
                        l1=l1->next;
                    }
                    if(l2!=NULL)
                    {
                        carry+=l2->val;
                        l2=l2->next;
                    }
                    l3->next=new ListNode(carry%10);
                    carry/=10;
                    l3=l3->next;
                }
                return res->next;
            }
        };
        */
    }
}
