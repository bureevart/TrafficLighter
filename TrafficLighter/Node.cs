using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLighter
{
    public class Node
    {

        public Node(int state) 
        { 
            State = state;
            Relations = new List<Relation>();
        }

        public int State { get; set; }

        public List<Relation> Relations { get; set; }

        public override string ToString()
        {
            var relIndex = 0;
            var str = "";
            Relations.ForEach(state => 
            {
                str += $"Связь {++relIndex}\n";
                str += state + " \n";
            });
            return 
                $"Текущее состояние S{State}: {Global.States[State]}\n" +
                $"Возможные связи: \n" + str;
        }
    }
}
