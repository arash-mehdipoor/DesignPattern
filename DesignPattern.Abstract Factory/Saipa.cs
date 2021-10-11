namespace DesignPattern.Abstract_Factory
{
    public class Saipa : IVehicleFactory
    {
        public IDiesel GetDiesel() { return new Foton(); }
        public IMotorCar GetMotorCar() { return new Peride(); }
    }
}
