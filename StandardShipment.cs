using System;

namespace AssignmentOOP2
{
    internal class StandardShipment : Shipment
    {
        public StandardShipment(string trackingCode, string description, double weight, decimal delivaryFee, DelivaryAddress destination)
            : base(trackingCode, description, weight, delivaryFee, destination)
        {
        }

        public StandardShipment(string trackingCode) : base(trackingCode)
        {
        }

        public override void printShipment()
        {
            Console.WriteLine("=== Standard Shipment ===");
            base.printShipment();
        }
    }
}