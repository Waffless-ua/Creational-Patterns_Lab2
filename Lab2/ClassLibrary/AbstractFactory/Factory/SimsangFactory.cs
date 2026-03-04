namespace ClassLibrary.AbstractFactory
{
    public class SimsangFactory : IDeviceFactory
    {
        public IEbook CreateEbook() => new SimsangEbook();

        public ILaptop CreateLaptop() => new SimsangLaptop();

        public IPhone CreatePhone() => new SimsangPhone();
    }
}
