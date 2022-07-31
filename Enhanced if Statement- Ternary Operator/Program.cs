using System;

namespace Enhanced_if_Statement__Ternary_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///<summary>
            ///
            /// 
            /// Condition ?  first expression : second expression.
            /// condition has not to be either true or false. 
            /// The conditional operator is right -assosiative.
            /// The expression a ? b : c ? d : e. 
            /// is evaluated as a ? b : (c ? d : e ). 
            /// not as (a? b : (c ? d : e), 
            /// the conditional operator cannot be overloaded. 
            /// 
            /// </summary>
            /// 

            // in celcius. 

            //int Temperature = 5;


            //if (-Temperature < 0)
            //    stateOfMatter = "Solid";
            //else if (-Temperature > 100)
            //    stateOfMatter = "Gas";
            //else
            //    stateOfMatter = "Liquid";

            //Console.WriteLine("State of Matter is {0}", stateOfMatter);

            ////The same result can be achieved by this

            ////The enhanced Version of the If-Else-Statement from above

            //stateOfMatter = Temperature < 0 ? "Solid" : (Temperature >  100 ? "gas" : "liquid");

            //Console.WriteLine("State of Matter is {0}", stateOfMatter);
            Console.Write("Input the temps : ");
            string Temperature = Console.ReadLine();

            int Temps = int.Parse(Temperature);
            string stateOfMatter = String.Empty;

            InputTemps(Temperature,Temps,stateOfMatter);

            Console.ReadKey();


        }

        public static void InputTemps(string Tempsstring, int Tempsint, string State  )
        {
            Tempsstring = String.Empty;

            var Temporary = int.TryParse(Tempsstring, out Tempsint); 

            State = Tempsint <= 15 ? "it is too cold here" : Tempsint >= 16  && Tempsint <= 28 ? "it is ok" : Tempsint > 28 ? "it is hot here" : "Not a valid Temperature";

            Console.WriteLine("So the states is {0}  and it's {1}",  State, Temporary);
        }
    }
}
