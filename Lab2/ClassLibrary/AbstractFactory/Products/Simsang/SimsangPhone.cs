namespace ClassLibrary.AbstractFactory
{
    public class SimsangPhone : IPhone
    {
        public void Call(string phoneNumber)
        {
            Console.WriteLine($"Call made with SimsangPhone on {phoneNumber}");
        }
    }
}
