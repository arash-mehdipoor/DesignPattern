namespace DesignPattern.AbstractFactoryTest
{
    public interface IMobilePhone
    {
        ISmartPhone GetSmartPhone();
        INormalPhone GetNormalPhone();
    }
}
