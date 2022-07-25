using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    internal class Phone
    {
        public string Company;
        public string Model;
        public string ReleaseDay;
        public Phone()
        {
            Company = "unknown";
            Model = "unknown";
            ReleaseDay = "unknown";
        }

        //multiply constructor. 
        public Phone(string company, string model)
        {
            this.Company = company;
            this.Model = model;
            ReleaseDay = "unknown";
        }

        public Phone(string company, string model, string releaseDay) : this(company, model)
        {
            ReleaseDay=releaseDay;
        }




        // Place for your constructors
        public void Introduce()
        {
            Console.WriteLine("It is {0} created by {1}. It was released {2}.", Model, Company, ReleaseDay);
        }
    }
}
