
using System;

namespace CS03CompClone
{
    public class Task: IComparable<Task>, ICloneable
    {
        // Класс задания в рассписании. Состоит из номера дня в году, года и описания задания.
        private string description;
        private int day;
        private int year;

        public Task(int day, int year, string description)
        {
            this.day = day;
            this.year = year;
            this.description = description;
        }

        public override string ToString()
        {
            return "Day " + this.day + " of " + this.year + " Task: " 
                                + this.description;
        }

        public int CompareTo(Task other)
        {
            switch (this.year > other.year) { // Проверяем по году
                case true: // Если год у этого объекта больше ставим его вперёд
                    return 1; 
                case false:
                    if (this.year == other.year) // Если года одинаковые, проверяем по дням
                        break;
                    else
                        return -1;
            }

            switch (this.day > other.day) { // Тоже самое, но по дням
                case true:
                    return 1;
                case false:
                    if (this.day == other.day)
                        return 0;
                    else
                        return -1;
            }

            return 0; // Компилятор ругается, будто не во всех случаях возвращается значение :\
        }

        public object Clone() // Клонируем 
        {
            int c_day = this.day;
            int c_year = this.year;
            string c_description = this.description;

            Task cloned = new Task(c_day, c_year, c_description);
            return cloned;
        }

        public void SetDay(int day) // Для дебагинга Clone()
        {
            this.day = day;
        }
    }
}
