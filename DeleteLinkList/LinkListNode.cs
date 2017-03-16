namespace DeleteLinkList
{
    public class LinkListNode<T>
    {
        //数据域，当前Node  Data

        /// <summary>
        ///     指针域：头结点
        /// </summary>
        /// <param name="p"></param>
        public LinkListNode(LinkListNode<T> p)
        {
            this.Next = p;
        }

        /// <summary>
        ///     数据域+指针域：普通Node
        /// </summary>
        /// <param name="item"></param>
        /// <param name="p"></param>
        public LinkListNode(T item, LinkListNode<T> p)
        {
            this.Data = item;
            this.Next = p;
        }

        /// <summary>
        ///     数据域：尾节点
        /// </summary>
        /// <param name="val"></param>
        public LinkListNode(T val)
        {
            this.Data = val;
            this.Next = null;
        }

        /// <summary>
        ///     无参构造函数 实例化该节点只有默认值且->null
        /// </summary>
        public LinkListNode()
        {
            this.Data = default(T);
            this.Next = null;
        }

        public T Data { get; set; }

        //指针域：Next LinkListNode        
        public LinkListNode<T> Next { get; set; }
    }
}