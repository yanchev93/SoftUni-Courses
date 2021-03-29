using System;
using System.Linq;

namespace P03.Telephony
{
    public class StationeryPhone : ICaller
    {
        public string Call(string number)
        {
            if (!number.All(Char.IsDigit))
            {
                return "Invalid number!";
            }

            return $"Dialing... {number}";
        }
    }
}
