using System;

namespace AssignmentOOP2
{
    internal class ExpressShipment : Shipment
    {
        private decimal extraFee;

        public ExpressShipment(string trackingCode, string description, double weight, decimal delivaryFee, decimal extraFee, DelivaryAddress destination)
            : base(trackingCode, description, weight, delivaryFee, destination)
        {
            ExtraFee = extraFee;
        }

        public decimal ExtraFee
        {
            get
            {
                return extraFee;
            }
            set
            {
                if (value >= 0)
                    extraFee = value;
            }
        }

        public override double EstimatedCost
        {
            get
            {
                return (double)(DelivaryFee + ExtraFee) + (Weight * 5);
            }
        }

        public override void printShipment()
        {
            Console.WriteLine("=== Express Shipment ===");
            base.printShipment();
            Console.WriteLine($"Extra Fee: {ExtraFee}");
        }
    }
}