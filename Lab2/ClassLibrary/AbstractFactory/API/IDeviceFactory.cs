namespace ClassLibrary.AbstractFactory
{
    public interface IDeviceFactory
    {
        IPhone CreatePhone();
        ILaptop CreateLaptop();
        IEbook CreateEbook();
    }
}
