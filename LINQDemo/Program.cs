using System;
using System.Linq;
namespace LINQDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            var sortedDays = daysOfWeek.OrderBy(day => Array.IndexOf(daysOfWeek, day));

            Console.WriteLine("Days of the Week:");

            foreach (var day in sortedDays)
            {
                Console.WriteLine(day);
            }
        }
    }
}