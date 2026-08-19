using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOOP2
{
    internal class PriorityInternationalShipment : InternationalShipment
    {
        public PriorityInternationalShipment(string trackingCode, string description, double weight, decimal delivaryFee, DelivaryAddress destination, string destinationCountry, decimal customsFee)
            : base(trackingCode, description, weight, delivaryFee, destination, destinationCountry, customsFee)
        {
        }

        public sealed override void GenerateCustomsReport()
        {
            Console.WriteLine($"[PRIORITY] Fast-track customs report generated for {DestinationCountry}.");
        }
    }
}
