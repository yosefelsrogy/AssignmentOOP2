using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOOP2
{
    internal sealed class CompletedShipment : Shipment
    {
        public DateTime CompletionDate { get; private set; }

        public CompletedShipment(string trackingCode, string description, double weight, decimal delivaryFee, DelivaryAddress destination)
            : base(trackingCode, description, weight, delivaryFee, destination)
        {
            CompletionDate = DateTime.Now;
        }

        public override void printShipment()
        {
            Console.WriteLine("=== Completed Shipment (CLOSED) ===");
            base.printShipment();
            Console.WriteLine($"Completion Date: {CompletionDate}");
        }
    }
}