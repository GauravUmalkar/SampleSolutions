using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DelvifyMatchPattern_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 1. Read the user response as an argument
            Console.WriteLine("Please enter user input:-");
            string userReponse = Console.ReadLine();
            try
            {
                if (!string.IsNullOrEmpty(userReponse) && userReponse.Length > 0)
                {
                    //Step 2. Call GetUserMatchingToken to return matching token to user
                    string parseToken = "{word}";
                    string returnToken = new UserToken().GetUserMatchingToken(parseToken, userReponse);
                    if (!string.IsNullOrEmpty(returnToken))
                        Console.WriteLine(string.Format("user valid token is :- '{0}'", returnToken));
                    else
                        Console.WriteLine("No Matching toked found in repository");
                }
                else
                {
                    Console.Write("Invalid response from user.");
                }

                Console.WriteLine("Press enter to close");                
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.Write(string.Format("Error in generating User token. Error details are {0}",ex.ToErrorMessage()));
                Console.WriteLine("Press enter to close");
                Console.ReadLine();
            }
        }

    }

}
