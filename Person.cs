﻿namespace VirtualOffice
{
    /* =======================================MODEL================================================== */
    internal class Person
    {
        public string Förnamn { get; set; }
        public string EfterNamn { get; set; }

        public int Age { get; set; }
        public virtual string Bakgrund { get; set; } // can be overridden. 
        public decimal Salary { get; set; }

        public Person(string namn, string efternamn, int age, decimal salary)
        {
            Förnamn = namn;
            EfterNamn = efternamn;
            Bakgrund = "(Not yet filled in)";
            Salary = salary;
            Age = age;
        }

        public Person(string namn, string efternamn, int age, string background, decimal salary)
        {
            Förnamn = namn;
            EfterNamn = efternamn;
            Bakgrund = background;
            Salary = salary;
            Age = age;
        }


        public string ShowBio()
        {
            return $"Background: {this.Bakgrund}";
        }



        public class Employee : Person
        {
            // In the context of a property setter, the value keyword represents the value being assigned to the property.
            public override string Bakgrund { get => base.Bakgrund; set => base.Bakgrund = value; }

            // inhämtar konstruktorn där background sätts till default direkt inuti blocket. 
            public Employee(string namn, string efternamn, int age, decimal salary) : base(namn, efternamn, age, salary)
            {

            }


            public Employee(string namn, string efternamn, int age, string personalBackground, decimal salary) : base(namn, efternamn, age, salary)
            {
                Bakgrund = personalBackground;
            }

        }
    }
}
