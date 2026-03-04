namespace ClassLibrary.AbstractFactory
{
    interface IDeviceFactory
    {
        IPhone CreatePhone();
        ILaptop CreateLaptop();
        IEbook CreateEbook();
    }
}
