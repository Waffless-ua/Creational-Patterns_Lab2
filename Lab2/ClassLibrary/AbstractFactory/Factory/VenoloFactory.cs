namespace ClassLibrary.AbstractFactory
{
    public class VenoloFactory : IDeviceFactory
    {
        public IEbook CreateEbook() => new VenoloEbook();

        public ILaptop CreateLaptop() => new VenoloLaptop();

        public IPhone CreatePhone() => new VenoloPhone();
    }
}