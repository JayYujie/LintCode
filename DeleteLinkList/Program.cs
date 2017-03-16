namespace DeleteLinkList
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            #region Access LinkList 实例化LinkList并访问输出

            //实例化一个LinkList对象
            var linkList = new LinkList<string>();
            //获取LinkList Length



            Console.WriteLine(linkList.GetLength());

            //添加元素
            linkList.AppendToLinkListEndNode("1");
            linkList.AppendToLinkListEndNode("2");
            linkList.AppendToLinkListEndNode("3");
            linkList.AppendToLinkListEndNode("3");
            linkList.AppendToLinkListEndNode("4");
            linkList.AppendToLinkListEndNode("5");
            linkList.AppendToLinkListEndNode("3");

            RemoveElements(linkList, 3);

            #endregion
        }

        public static void RemoveElements(LinkList<string> head, int val)
        {
            string value = val.ToString();
            if (head.IsEmpty())
            {
                Console.WriteLine("LinkList is Empty!");
            }
            var p = new LinkListNode<string>();
            var q = new LinkListNode<string>();
            p = head.HeadLinkListNode;
            q = head.HeadLinkListNode.Next;
            int length = head.GetLength();
            /********************for 循环***********************************/
            for (int j = 1; j <= length; j++)
            {
                if (q == null)
                {
                    break;
                }
                if (q.Data.Equals(value))
                {
                    p.Next = q.Next;
                    q = q.Next;
                }
                else
                {
                    p = p.Next;
                    q = q.Next;
                }
            }
            /**************************while 循环****************************/
            //while (q != null)
            //{
            //    if (q.Data.Equals(value))
            //    {
            //        p.Next = q.Next;
            //        q = q.Next;
            //    }
            //    else
            //    {
            //        p = p.Next;
            //        q = q.Next;
            //    }
            //}
            if (head.HeadLinkListNode.Data == value)
            {
                head.HeadLinkListNode = head.HeadLinkListNode.Next;
            }
        }

        //public ListNode removeElements(ListNode head, int val)
        //{
        //    // Write your code here  
        //    if (head == null)
        //    {
        //        return head;
        //    }
        //    else 
        //    { 
        //    ListNode p = head, q = head.next;
        //    while (q != null)
        //    {
        //        if (q.val == val)
        //        {
        //            p.next = q.next;
        //            q = q.next;
        //        }
        //        else
        //        {
        //            p = p.next;
        //            q = q.next;
        //        }
        //    }
        //    if (head.val == val) head = head.next;
        //    return head;
        //    }
        //}  
    }
}

/*
 head ==null  
 * 
 * 定义head 和head.next
 * 
 * 后置不为空则循环
 * 后置匹配择置换
 */