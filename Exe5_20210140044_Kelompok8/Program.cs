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
            Queue q = new Queue();
            char ch;
            while (true)
            {
                try
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Implement insert operation");
                    Console.WriteLine("2. Implement delete operation");
                    Console.WriteLine("3. Display");
                    Console.WriteLine("4. exit");
                    Console.Write("\nEnter your choice: ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            Console.WriteLine("Enter a name;  ");
                            string num = Convert.ToString(Console.ReadLine());
                            q.Insert(num);
                            break;
                        case '2':
                            q.Delete();
                            break;
                        case '3':
                            q.display();
                            break;
                        case '4':
                            return;
                        
                        default:
                            Console.WriteLine("Invalid Option");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Check for the values entered.");
                }
            }
        }
    }
}
