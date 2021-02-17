namespace P03.Telephony
{
    public class Smartphone : ISmartphone
    {
        public string Browse(string site)
        {
            for (int i = 0; i < site.Length; i++)
            {
                if (char.IsDigit(site[i]))
                {
                    return $"Invalid URL!";
                }
            }

            return $"Browsing: {site}!";
        }

        public string Calling(string number)
        {
            for (int i = 0; i < number.Length; i++)
            {
                if (!char.IsDigit(number[i]))
                {
                    return "Invalid number!";
                }
            }

            return $"Calling... {number}";
        }
    }
}
