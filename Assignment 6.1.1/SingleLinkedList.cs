using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6._1._1
{
    internal class Node
    {
        public House House { get; set; }
        public Node NextHouse { get; set; }
        public Node(House newHouse)
        {
            House = newHouse; NextHouse = null;
        }
    }
    internal class SingleLinkedList
    {
        private Node head;
        private Node tail;

        public void AddFirst(House house)
        {
            Node newNode = new Node(house);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.NextHouse = head;
                head = newNode;
            }
        }
        public void AddLast(House house)
        {
            Node newNode = new Node(house);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.NextHouse = newNode;
                tail = newNode;
            }
        }
        public House Search(int searchId) 
        {
            Node temp = head;
            if (head == null)
            {
                Console.WriteLine("List is empty. Item not found.");
                return null;
            }
            else
            {
                while (temp != null)
                {
                    if (temp.House.Number == searchId)
                    {
                        return temp.House;
                    }
                    else temp = temp.NextHouse;
                }
                return null;
            }
        }
        public void DisplayAll()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                while (temp != null)
                {
                    if (temp.NextHouse != null)
                    {
                        Console.Write($"Number: {temp.House.Number} \n Address: {temp.House.Address} \n Type: {temp.House.Type}\n-->\n");
                        temp = temp.NextHouse;
                    }
                    else
                    {
                        Console.Write($"Number: {temp.House.Number} \n Address: {temp.House.Address} \n Type: {temp.House.Type}");
                        return;
                    }
                }
            }
        }

        #region AdditionalMethods
        //public void AddBefore(House house, House newHouse)
        //{
        //    Node newNode = new Node(newHouse);
        //    Node temp = head;
        //    if (head.House == house)
        //    {
        //        this.AddFirst(newHouse);
        //        return;
        //    }

        //    if (!this.Contains(house))
        //    {
        //        Console.WriteLine("Reference Value does not exist in current list.");
        //    }
        //    else
        //    {
        //        while (temp.NextHouse != null)
        //        {
        //            if (temp.NextHouse.House == house)
        //            {
        //                newNode.NextHouse = temp.NextHouse;
        //                temp.NextHouse = newNode;
        //                return;
        //            }
        //            else temp = temp.NextHouse;
        //        }
        //    }
        //}
        //public void AddAfter(House value, House newValue)
        //{
        //    Node newNode = new Node(newValue);
        //    Node temp = head;
        //    if (tail.House == value)
        //    {
        //        this.AddLast(newValue);
        //        return;
        //    }
        //    if (!this.Contains(value))
        //    {
        //        Console.WriteLine("Reference Value does not exist in current list.");
        //    }
        //    else
        //    {
        //        while (temp != null)
        //        {
        //            if (temp.House == value)
        //            {
        //                newNode.NextHouse = temp.NextHouse;
        //                temp.NextHouse = newNode;
        //                return;
        //            }
        //            else temp = temp.NextHouse;
        //        }
        //    }
        //}
        //public void RemoveFirst()
        //{
        //    if (head == null)
        //    {
        //        Console.WriteLine("List is empty. No items removed.");
        //    }
        //    else
        //    {
        //        head = head.NextHouse;
        //        if (head == null)
        //        {
        //            tail = null;
        //        }
        //    }
        //}
        //public void RemoveLast()
        //{
        //    Node temp = head;
        //    if (head == null)
        //    {
        //        Console.WriteLine("List is empty. No items removed.");
        //    }
        //    else
        //    {
        //        while (temp != null)
        //        {
        //            if (temp.NextHouse != tail)
        //            {
        //                temp = temp.NextHouse;
        //            }
        //            else
        //            {
        //                tail = temp;
        //                temp.NextHouse = null;
        //                return;
        //            }
        //        }
        //    }
        //} 
        //public bool Contains(House value)
        //{
        //    Node temp = head;
        //    if (head == null)
        //    {
        //        Console.WriteLine("List is empty. Item not found.");
        //        return false;
        //    }
        //    else
        //    {
        //        while (temp != null)
        //        {
        //            if (temp.House == value)
        //            {
        //                return true;
        //            }
        //            else temp = temp.NextHouse;
        //        }
        //        return false;
        //    }
        //}
        #endregion
    }
}
