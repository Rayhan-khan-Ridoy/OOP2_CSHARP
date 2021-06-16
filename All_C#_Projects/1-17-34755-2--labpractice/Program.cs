using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1st_Lab_For_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            Date visit1 = new Date(2, 3, 2015);
            Date nextVisit1 = new Date(8, 6, 2015);
            Date visit2 = new Date(3, 3, 2015);
            Date nextVisit2 = new Date(0, 0, 0);
            Date visit3 = new Date(10, 3, 2015);
            Date nextVisit3 = new Date(31, 3, 2015);
            Date visit4 = new Date(31, 3, 2015);
            Date nextVisit4 = new Date(30, 4, 2015);

            Appointment appointment1 = new Appointment(visit1, nextVisit1, "S12345", "Tan Ah Asm", 45.00);
            Appointment appointment2 = new Appointment(visit2, nextVisit2, "S34567", "Lee Tao San", 60.00);
            Appointment appointment3 = new Appointment(visit3, nextVisit3, "S56783", "Sam Ting", 120.50);
            Appointment appointment4 = new Appointment(visit4, nextVisit4, "S98761", "Anthony Chin", 78.50);
            appointment1.displayAppt();
            appointment2.displayAppt();
            appointment3.displayAppt();
            appointment4.displayAppt();

            appointment1.displayAppt("S56783");
            appointment2.displayAppt("S56783");
            appointment3.displayAppt("S56783");
            appointment4.displayAppt("S56783");
            Console.ReadKey();

        }

    }
}

