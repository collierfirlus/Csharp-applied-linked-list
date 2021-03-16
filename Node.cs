using System;
using System.Collections.Generic;
using System.Text;

namespace CollierFirlus_1322Lab14
{
    class Node
    {
        public BluRayDisc Disc;
        public Node next;
        public Node(BluRayDisc Disc)
        {
            this.Disc = Disc;
            next = null;
        }
    }
}
