using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverTheHillH
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone();

            Teletubbies tb = new Teletubbies(phone);

            while (true)
            {
                int intTemp = Convert.ToInt32(Console.ReadLine());

                phone.SetTimeOfDay(intTemp);
            }
        }
    }
}
