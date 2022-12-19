using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe5_20210140044_Kelompok8
{
    class Node
    {

        public Node next;
        public string ell;

        public Node(string ell)
        {
            this.ell = ell;
            this.next = null;
        }
    }
    class Queue 
    {
        public Node adit;
        public Node rozi;

        public Queue()
        {
            this.adit = this.rozi = null;
        }
        public void Insert(string ell)
        {
            Node temp = new Node(ell);

            if(this.rozi == null)
            {
                this.adit = this.rozi = temp;
                return;
            }
            this.rozi.next = temp;
            this.rozi = temp;
        }
        public void Delete()
        {
            if (this.adit == null)
            {
                Console.WriteLine("Queue is empty");
            }

            if (this.adit == null)
                return;

            this.adit = this.adit.next;

            if (this.adit == null)
                this.rozi = null;
        }
        public void display()
        {
            if(this.adit == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Console.WriteLine("Queue Front: " + this.adit.ell);
            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}
