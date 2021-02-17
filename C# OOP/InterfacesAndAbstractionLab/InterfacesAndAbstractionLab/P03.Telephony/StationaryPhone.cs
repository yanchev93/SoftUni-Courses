namespace P03.Telephony
{
    class StationaryPhone : IStationaryPhone
    {
        
        public string Dialing(string number)
        {
            return $"Dialing... {number}";
        }
    }
}
