
using System;
using System.Collections.Generic;

namespace CS03CompClone
{
    public class Schedule: ICloneable
    {
        private List<Task> list;

        public Schedule()
        {
            list = new List<Task>();
        }

        public void Add(Task newTask) // Функция добавления задания в рассписание
        {
            if (this.list.Count == 0) // Если в списке нет заданий то просто добавляем элемент
            {
                this.list.Add(newTask);
                return;
            }

            int res = 0;
            for (int i = 0; i < this.list.Count; i++)
            {
                res = newTask.CompareTo(this.list[i]);
                if (res >= 0) // Если в списке нашли элемент ниже по приоритету,
                {
                    this.list.Insert(i, newTask); // то добавляем новый элемент впереди найденного
                    return;
                }
            }

            if (res < 0) // Если не нашли, то просто добавляем в конец
                this.list.Insert(this.list.Count - 1, newTask);
        }

        public void Print()
        {
            for (int i = 0; i < this.list.Count; i++)
            {
                Console.WriteLine(this.list[i].ToString());
            }
        }

        public object Clone() // Клонируем, используя собственный метод класса Task 
        {
            Schedule cloned = new Schedule();

            for (int i = 0; i < this.list.Count; i++)
            {
                cloned.Add((Task) this.list[i].Clone());
            }

            return cloned;
        }

        public Task this[int index]
        {
            get => this.list[index];
        }
    }
}
