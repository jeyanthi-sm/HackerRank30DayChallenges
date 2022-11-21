using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
class emailclass
{
    public string fName;
    public string emailaddress;
}


class Solution
{
    public static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine().Trim());
              List<emailclass> emails = new List<emailclass> ();

        for (int NItr = 0; NItr < N; NItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            string firstName = firstMultipleInput[0];

            string emailID = firstMultipleInput[1];
                        string fNpattern = @"^\w+[a-z]"; 
            bool ismatched = Regex.IsMatch(firstName, fNpattern);

            
                        string emailpat = @"^\w+[a-z]+([.][a-z]+)*@\w[a-z]+.\w[a-z]+"; 

            Regex re = new Regex(emailpat);
            if ((ismatched == true) && (re.IsMatch(emailID)) && emailID.Length < 50 && firstName.Length < 20)
            {
              emails.Add(new emailclass() { fName =firstName,emailaddress =emailID});
            }
            else
                Console.WriteLine("Pattern not matched");


        }
        //  linq QUERY
        var gmailcand = (from x in emails
                         where x.emailaddress.Contains("@gmail.com")
                         orderby x.fName
                         select x).ToList();
        foreach (var email in gmailcand)
            Console.WriteLine(email.fName);
        Console.Read();
        }
    }

