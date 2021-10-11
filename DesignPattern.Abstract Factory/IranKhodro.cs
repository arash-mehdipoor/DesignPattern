using System;

namespace DesignPattern.Abstract_Factory
{
    // دیزلی
    public class Foton : IDiesel { public string GetName() { return "This is Foton"; } }
    public class Arena : IDiesel { public string GetName() { return "This is Arena"; } }
    public class Peugeot206 : IMotorCar { public string GetName() { return "This is Peugeot206"; } }
    public class Peride : IMotorCar { public string GetName() { return "This is Peride"; } }

    public class IranKhodro : IVehicleFactory
    {
        public IDiesel GetDiesel()
        {
            return new Arena();
        }
        public IMotorCar GetMotorCar()
        {
            return new Peugeot206();
        }
    }
}
