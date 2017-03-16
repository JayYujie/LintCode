namespace DeleteLinkList
{
    using System;

    public class LinkList<T>
    {
        private LinkListNode<T> _headLinkListNode;


        /// <summary>
        ///     构造函数
        /// </summary>
        public LinkList()
        {
            this._headLinkListNode = null;
        }

        public LinkListNode<T> HeadLinkListNode
        {
            get { return this._headLinkListNode; }
            set { this._headLinkListNode = value; }
        }

        /// <summary>
        ///     获取链表长度
        /// </summary>
        /// <returns></returns>
        public int GetLength()
        {
            LinkListNode<T> p = this._headLinkListNode;
            int len = 0;
            while (p != null)
            {
                ++len;
                p = p.Next;
            }
            return len;
        }

        /// <summary>
        ///     清空链表
        /// </summary>
        public void ClearLinkList()
        {
            this._headLinkListNode = null;
        }

        /// <summary>
        ///     判断链表是否为空。true为空  false不为空
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            if (this._headLinkListNode == null)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        ///     在End Node之后追加Node
        /// </summary>
        /// <param name="item"></param>
        public void AppendToLinkListEndNode(T item)
        {
            var q = new LinkListNode<T>(item);
            var p = new LinkListNode<T>();
            if (this._headLinkListNode == null)
            {
                this._headLinkListNode = q;
                return;
            }

            p = this._headLinkListNode;
            while (p.Next != null)
            {
                p = p.Next;
            }
            p.Next = q;
        }

        /// <summary>
        ///     在链表第i个索引之前插入一个值为item的Node
        /// </summary>
        public void InsertBeforeToLinkList(T item, int i)
        {
            if (this.IsEmpty() || i < 1 || i > this.GetLength())
            {
                Console.WriteLine("LinkList is empty or Position is error!");
                return;
            }
            if (i == 1)
            {
                var q = new LinkListNode<T>(item);
                q.Next = this._headLinkListNode;
                this._headLinkListNode = q;
                return;
            }
            LinkListNode<T> p = this._headLinkListNode;
            var r = new LinkListNode<T>();
            int j = 1;
            while (p.Next != null && j < i)
            {
                r = p;
                p = p.Next;
                ++j;
            }
            if (j == i)
            {
                var q = new LinkListNode<T>(item);
                q.Next = p;
                r.Next = q;
            }
        }

        /// <summary>
        ///     在链表第i个索引之后插入一个值为item的Node
        /// </summary>
        public void InsertAfterToLinkList(T item, int i)
        {
            if (this.IsEmpty() || i < 1 || i > this.GetLength())
            {
                Console.WriteLine("LinkList is empty or Position is error!");
                return;
            }
            if (i == 1)
            {
                var q = new LinkListNode<T>(item);
                q.Next = this._headLinkListNode.Next;
                this._headLinkListNode.Next = q;
                return;
            }
            LinkListNode<T> p = this._headLinkListNode;
            int j = 1;
            while (p != null && j < i)
            {
                p = p.Next;
                ++j;
            }
            if (j == i)
            {
                var q = new LinkListNode<T>(item);
                q.Next = p.Next;
                p.Next = q;
            }
        }

        /// <summary>
        ///     删除LinkList第i个Node
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public T DeleteForIndex(int i)
        {
            if (this.IsEmpty() || i < 0 || i > this.GetLength())
            {
                Console.WriteLine("LinkList is empty or Position is error!");
                return default(T);
            }
            var q = new LinkListNode<T>();
            if (i == 1)
            {
                q = this._headLinkListNode;
                this._headLinkListNode = this._headLinkListNode.Next;
                return q.Data;
            }
            LinkListNode<T> p = this._headLinkListNode;
            int j = 1;
            while (p.Next != null && j < i)
            {
                ++j;
                q = p;
                p = p.Next;
            }
            if (j == i)
            {
                q.Next = p.Next;
                return p.Data;
            }
            Console.WriteLine("The " + i + "th doubleLinkedListNode is not exist!");
            return default(T);
        }

        /// <summary>
        ///     获取第i个Node的Element
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public T GetElementForIndex(int i)
        {
            if (this.IsEmpty() || i < 0)
            {
                Console.WriteLine("LinkList is empty or position is error! ");
                return default(T);
            }
            var p = new LinkListNode<T>();
            p = this._headLinkListNode;
            int j = 1;
            while (p.Next != null && j < i)
            {
                ++j;
                p = p.Next;
            }
            if (j == i)
            {
                return p.Data;
            }
            Console.WriteLine("The " + i + "th doubleLinkedListNode is not exist!");
            return default(T);
        }

        /// <summary>
        ///     根据Value值查找Element
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int GetElementForValue(T value)
        {
            if (this.IsEmpty())
            {
                Console.WriteLine("LinkList is Empty!");
                return -1;
            }
            var p = new LinkListNode<T>();
            p = this._headLinkListNode;
            int i = 1;
            while (!p.Data.Equals(value) && p.Next != null)
            {
                p = p.Next;
                ++i;
            }
            return i;
        }

        /// <summary>
        ///     显示链表数据
        /// </summary>
        public void ShowtheLinkList()
        {
            var p = new LinkListNode<T>();
            p = this._headLinkListNode;
            int index = 0;
            int index2 = 0;
            while (p != null)
            {
                Console.Write("{0},{1}\n", p.Data, index);
                p = p.Next;

                ++index;
            }
        }
    }
}