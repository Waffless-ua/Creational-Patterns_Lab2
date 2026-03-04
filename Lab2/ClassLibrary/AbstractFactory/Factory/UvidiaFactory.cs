namespace ClassLibrary.AbstractFactory
{
    public class UvidiaFactory : IDeviceFactory
    {
        public IEbook CreateEbook() => new UvidiaEbook();

        public ILaptop CreateLaptop() => new UvidiaLaptop();

        public IPhone CreatePhone() => new UvidiaPhone();
    }
}