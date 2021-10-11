using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Abstract_Factory
{
    // Abstract Factory: در کشور، صنعت خودروسازی داریم که خودرو‌ها را در دو دسته‌ی دیزلی و سواری تولید می‌کنند
    public interface IDiesel { string GetName(); }
    public interface IMotorCar { string GetName(); }

    public interface IVehicleFactory
    {
        IDiesel GetDiesel();
        IMotorCar GetMotorCar();
    }
}
