using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLighter
{
    public class TrafficGraph
    {
        public List<Node> States = new List<Node>();

        public TrafficGraph() 
        {
            var i = 0;
            Global.States.ToList().ForEach(s =>
            {
                States.Add(new Node(i++));
            });

            //SН
            States.ElementAt(8)
                .Relations.Add(new Relation() { Predicates = new int[] { 0 }, Action = 0, Next = 1});

            //SK
            States.ElementAt(9)
                .Relations.Add(new Relation() { Predicates = new int[] { }, Action = -1, Next = -1 });

            //SA
            States.ElementAt(0)
                .Relations.Add(new Relation() { Predicates = new int[]{ 4 }, Action = 4, Next = 0 });
            States.ElementAt(0)
                .Relations.Add(new Relation() { Predicates = new int[] { 3 }, Action = 3, Next = 1 });

            //S1
            States.ElementAt(1)
                .Relations.Add(new Relation() { Predicates = new int[] { 0 }, Action = 1, Next = 9 });
            States.ElementAt(1)
                .Relations.Add(new Relation() { Predicates = new int[] { 17 }, Action = 16, Next = 6 });
            States.ElementAt(1)
               .Relations.Add(new Relation() { Predicates = new int[] { 5 }, Action = 5, Next = 2 });
            States.ElementAt(1)
                .Relations.Add(new Relation() { Predicates = new int[] { 2 }, Action = 2, Next = 0 });

            //S2
            States.ElementAt(2)
                .Relations.Add(new Relation() { Predicates = new int[] { 8 }, Action = 7, Next = 2 });
            States.ElementAt(2)
                .Relations.Add(new Relation() { Predicates = new int[] { 9 }, Action = 9, Next = 3 });
            States.ElementAt(2)
                .Relations.Add(new Relation() { Predicates = new int[] { 6 }, Action = 6, Next = 3 });

            //S3
            States.ElementAt(3)
                .Relations.Add(new Relation() { Predicates = new int[] { 11 }, Action = 11, Next = 3 });
            States.ElementAt(3)
                .Relations.Add(new Relation() { Predicates = new int[] { 7 , 9 }, Action = 9, Next = 2 });
            States.ElementAt(3)
                .Relations.Add(new Relation() { Predicates = new int[] { 9, 10 }, Action = 10, Next = 4 });

            //S4
            States.ElementAt(4)
                .Relations.Add(new Relation() { Predicates = new int[] { 15 }, Action = 14, Next = 4 });
            States.ElementAt(4)
                .Relations.Add(new Relation() { Predicates = new int[] { 12, 13 }, Action = 12, Next = 5 });
            States.ElementAt(4)
                .Relations.Add(new Relation() { Predicates = new int[] { 12, 14 }, Action = 13, Next = 1 });

            //S5
            States.ElementAt(5)
                .Relations.Add(new Relation() { Predicates = new int[] { 16 }, Action = 18, Next = 5 });
            States.ElementAt(5)
                .Relations.Add(new Relation() { Predicates = new int[] { 6 }, Action = 15, Next = 4 });

            //S6
            States.ElementAt(6)
                .Relations.Add(new Relation() { Predicates = new int[] { 18 }, Action = 14, Next = 6 });
            States.ElementAt(6)
                .Relations.Add(new Relation() { Predicates = new int[] { 12 }, Action = 17, Next = 7 });

            //S7
            States.ElementAt(7)
                .Relations.Add(new Relation() { Predicates = new int[] { 19 }, Action = 11, Next = 7 });
            States.ElementAt(7)
                .Relations.Add(new Relation() { Predicates = new int[] { 9 }, Action = 13, Next = 1 });
        }
    }
}
