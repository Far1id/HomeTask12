using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask12._2
{
    internal class Worker:Person
    {
        public Worker(int oneHourPay, double hoursMonth, string name, string surname, byte age):base(name, surname, age)
        {
            this.OneHourPay = oneHourPay;
            this.HoursMonth = hoursMonth;
            if (age<18)
                Console.WriteLine("Ishlemek ucun minimum yash 18 olmalidir ve senin yashin " + age + "dir.");
            else
                Console.WriteLine("Sizin yashiniz ish ucun uygundur ve sizin maasiniz " + Salary(OneHourPay,HoursMonth) + " manatdir.");

        }
        public int OneHourPay;
        public double HoursMonth;

        public double Salary(int OneHourPay, double HoursMonth)
        {
            return OneHourPay * HoursMonth;
        }
    }
}
