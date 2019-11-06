using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode
{
    public class _146_LRU缓存
    {
        public class LRUCache
        {
            public class Node
            {
                public int key;
                public int val;
                public Node prev, next;
                public Node(int key, int val)
                {
                    this.key = key;
                    this.val = val;
                }
            }

            public class DLinkList
            {
                public Node head;
                private Node tail;
                public int count;

                public void RemoveFront()
                {
                    head = head.next;
                    if (head != null)
                    {
                        head.prev = null;
                    }
                    count--;
                }

                public void Remove(Node n)
                {
                    if (n.prev != null)
                    {
                        n.prev.next = n.next;
                    }
                    if (n.next != null)
                    {
                        n.next.prev = n.prev;
                    }
                    if (n == head)
                    {
                        head = n.next;
                    }
                    if (n == tail)
                    {
                        tail = n.prev;
                    }
                    n.prev = null;
                    n.next = null;
                    count--;
                }

                public void AddTail(Node n)
                {
                    if (count == 0)
                    {
                        head = n;
                        tail = n;
                    }
                    else
                    {
                        n.prev = tail;
                        tail.next = n;
                        tail = n;
                    }
                    count++;
                }
            }

            private DLinkList list;
            private Dictionary<int, Node> dic;
            private int _capacity;

            public LRUCache(int capacity)
            {
                list = new DLinkList();
                dic = new Dictionary<int, Node>();
                _capacity = capacity;
            }

            public int Get(int key)
            {
                if (dic.ContainsKey(key))
                {
                    var node = dic[key];
                    list.Remove(node);
                    list.AddTail(node);
                    return dic[key].val;
                }
                return -1;
            }

            public void Put(int key, int value)
            {
                if (dic.ContainsKey(key))
                {
                    list.Remove(dic[key]);
                    var node = new Node(key, value);
                    list.AddTail(node);
                    dic[key] = node;
                }
                else
                {
                    if (list.count >= _capacity)
                    {
                        dic.Remove(list.head.key);
                        list.RemoveFront();
                    }
                    var node = new Node(key, value);
                    list.AddTail(node);
                    dic.Add(key, node);
                }
            }
        }
    }
}

