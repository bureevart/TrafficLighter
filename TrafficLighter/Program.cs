namespace TrafficLighter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startIndx = 8;
            int curIndex = startIndx;
            string relationInfo = "Текущее действие/информация: Начало работы";
            Console.WriteLine("Модель управления движением автотранспорта");

            TrafficGraph graph = new TrafficGraph();

            while (curIndex != -1) 
            {
                Console.WriteLine(relationInfo);
                var curNode = graph.States[curIndex];
                Console.WriteLine(curNode.ToString());
                Console.WriteLine("\n\nВыберите путь по которому пойдете: ");
                if(!int.TryParse(Console.ReadLine(), out var relId))
                {
                    Console.WriteLine("Введите корректные данные!");
                    continue;
                }

                relId--;

                var relationToGo = curNode.Relations.FirstOrDefault(relation => curNode.Relations.IndexOf(relation) == relId);

                if (relationToGo == null)
                {
                    Console.WriteLine("Введите корректные данные!");
                    continue;
                }

                relationInfo = "Текущее действие/информация: " + Global.Actions[relationToGo.Action];

                curIndex = relationToGo.Next;
            }

        }
    }
}