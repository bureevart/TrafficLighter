using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLighter
{
    public class Relation
    {
        public int[] Predicates { get; set; }
        public int Action { get; set; }
        public int Next { get; set; }

        public override string ToString()
        {
            var str = "";
            var strInfo = "";
            foreach (int predicate in Predicates)
            {
                str += $"p{predicate + 1} ";
                strInfo += $"/{Global.Predicates[predicate]}/";
            }

            if (Action == -1)
            {
                return
                    $"\tНеобходимые условия: {str}: {strInfo}\n" +
                    $"\tДействие: Нет действий\n" +
                    $"\tПереход в состояние: {Next}";
            }

            return 
                $"\tНеобходимые условия: {str}: {strInfo}\n" +
                $"\tДействие с{Action + 1}: {Global.Actions[Action]}\n" +
                $"\tПереход в состояние: S{Next}";
        }
    }
}
