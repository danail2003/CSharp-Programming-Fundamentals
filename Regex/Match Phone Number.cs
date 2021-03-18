using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace Match_Phone_Number
{
    class Program
    {
        static void Main()
        {
            string phoneNumber = Console.ReadLine();
            string pattern = @"\+359( |-)2\1[\d]{3}\1[\d]{4}\b";

            Regex regex = new Regex(pattern);
            MatchCollection match = regex.Matches(phoneNumber);
            var phones = match.Cast<Match>().Select(x => x.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ", phones));
        }
    }
}
