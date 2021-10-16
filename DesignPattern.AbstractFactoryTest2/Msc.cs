using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryTest2
{
    //1
    public abstract class Packaging { }
    public class StandardPackaging : Packaging { };
    public class ShockProofPackaging : Packaging { };


    //1
    public abstract class DeliveryDocument { }
    public class PostalLabel : DeliveryDocument { }
    public class CourierManifest : DeliveryDocument { }


    //2
    public abstract class PurchaseFactory
    {
        public abstract Packaging CreatePackaging();
        public abstract DeliveryDocument CreateDeliveryDocument();
    }


    //3
    public class DelicatePurchaseFactory : PurchaseFactory
    {
        public override DeliveryDocument CreateDeliveryDocument()
        {
            return new CourierManifest();
        }

        public override Packaging CreatePackaging()
        {
            return new StandardPackaging();
        }
    }

    //3
    public class StandardPurchaseFactory : PurchaseFactory
    {
        public override DeliveryDocument CreateDeliveryDocument()
        {
            return new PostalLabel();
        }

        public override Packaging CreatePackaging()
        {
            return new ShockProofPackaging();
        }
    }

    //4 
    public class Client
    {
        private Packaging _packaging;
        private DeliveryDocument _deliveryDocument;

        public Client(PurchaseFactory factory)
        {
            _packaging = factory.CreatePackaging();
            _deliveryDocument = factory.CreateDeliveryDocument();
        }

        public Packaging ClientPackaging
        {
            get { return _packaging; }
        }

        public DeliveryDocument ClientDocument
        {
            get { return _deliveryDocument; }
        }
    }
}
