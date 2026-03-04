namespace ClassLibrary.AbstractFactory
{
    public class UvidiaPhone : IPhone
    {
        public void Call(string phoneNumber)
        {
            Console.WriteLine($"Call made with UvidiaPhone on {phoneNumber}");
        }
    }
}
