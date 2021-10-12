using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryTest
{
    public class MobileClient
    {
        ISmartPhone _smartPhone;
        INormalPhone _normalPhone;

        public MobileClient(IMobilePhone factory)
        {
            _smartPhone = factory.GetSmartPhone();
            _normalPhone = factory.GetNormalPhone();
        }

        public string GetSmartPhoneModelDetails()
        {
            return _smartPhone.GetModelDetail();
        }

        public string GetNormalPhoneModelDetails()
        {
            return _normalPhone.GetModelDetail();
        }
    }
}
