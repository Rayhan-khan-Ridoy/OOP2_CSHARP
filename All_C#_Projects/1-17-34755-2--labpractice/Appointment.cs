using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1st_Lab_For_Final
{
    class Appointment
    {
        Date date = new Date();

        readonly private string NRIC;
        private string name;
        private double fees;

        private Date visit;
        private Date nextVisit;

        public Appointment(Date visit, Date nextVisit, string nRIC = null, string name = null, double fees = 0.0)
        {
            NRIC = nRIC;
            this.name = name;
            this.fees = fees;
            this.visit = visit;
            this.nextVisit = nextVisit;
        }

        public string Name { get => name; }
        internal Date Visit { get => visit; }
        internal Date NextVisit { get => nextVisit; }

        public void SetAppt(string name, double fees, Date visit, Date nextVisit)
        {
            this.name = name;
            this.fees = fees;
            this.visit = visit;
            this.nextVisit = nextVisit;
        }

        public void displayAppt()
        {
            Console.Write("Patient ID: " + NRIC);
            Console.Write("\t" + name);
            Console.WriteLine("\t$" + fees);
            Console.WriteLine("Date of visit : " + visit.Dd + "/" + visit.Mm + "/" + visit.Yy);
            Console.WriteLine("Date of Next Visit : " + nextVisit.Dd + "/" + nextVisit.Mm + "/" + nextVisit.Yy);
            Console.WriteLine("-----------------------\n ");

        }
        public void displayAppt(string NRIC)
        {
            if (NRIC == this.NRIC)
            {
                Console.WriteLine("\n\nPrint single appoinment : " + NRIC);
                displayAppt();
            }

        }




    }
}