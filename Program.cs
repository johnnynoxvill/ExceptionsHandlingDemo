using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string doAnother;
            do
            {
                try
                {
                    Console.Write("Please enter asocial security number: ");
                    String userInput = Console.ReadLine();
                    SocialSecurityNumber ssn = new SocialSecurityNumber();
                    ssn.SSN = userInput;
                }
                catch(SSNFormatException exc)
                {
                    Console.WriteLine("Please re-enter social security number in correct format.");
                }
                catch (Exception exc)
                {
                    Console.WriteLine("There was an error! " + exc.Message + "\nException type: " + exc.GetType());
                }
                finally
                {
                    Console.WriteLine("This section always executes!");
                }

                Console.Write("Do another (y/n): ");
                doAnother = Console.ReadLine();
            } while (doAnother == "y");
        }
    }
}
