
using System;

namespace CS03CompClone
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Task t1 = new Task(25, 2020, "Sample task 1");
            Task t2 = new Task(20, 2020, "Sample task 2");
            Task t3 = new Task(71, 2020, "Sample task 3");
            Task t4 = new Task(25, 2020, "Sample task 4");

            Task t1_c = (Task) t1.Clone(); // Работа Clone() у Task
            t1.SetDay(0);
            Console.WriteLine(t1.ToString());
            Console.WriteLine(t1_c.ToString());
            Console.Write("\n");

            Schedule schedule = new Schedule();
            schedule.Add(t1);
            schedule.Add(t2);
            schedule.Add(t3);
            schedule.Add(t4);

            Schedule schedule_c = (Schedule) schedule.Clone(); // Работа Clone() у Schedule
            schedule.Add(new Task(0, 2019, "Debug"));
            schedule.Print();
            Console.Write("\n");
            schedule_c.Print();
            Console.Write("\n");

            Console.Write(schedule[0].ToString()); // Работа индексатора     
        }
    }
}
