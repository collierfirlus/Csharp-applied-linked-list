using System;
using System.Collections.Generic;
using System.Text;

namespace CollierFirlus_1322Lab14
{
    class BluRayCollection
    {
        double totalcost;
        int numDiscs;

        private Node DiscNode;
        public BluRayCollection()
        {
            DiscNode = null;
        }

        public void Add(BluRayDisc DiscData)
        {
            Node node = new Node(DiscData);
            node.next = DiscNode;
            DiscNode = node;

            numDiscs++;
            totalcost+= DiscData.cost;
        }

        public void Print()
        {
            Node current = DiscNode;
            while (current.next != null)
            {
                Console.WriteLine(current.Disc.toString());
                current = current.next;
            }
            Console.WriteLine(current.Disc.toString());
        }

        public string toString()
        {
            return "My BluRay Collection \n" +
                "Number of BluRayDiscs: " + numDiscs + "\nTotal cost: $" + totalcost + "\nAverage cost: $" + (totalcost / numDiscs) + "\n";
        }
    }
}
