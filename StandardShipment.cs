using AssignmentOOP2;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOOP2
{
    internal class StandardShipment : Shipment
    {
        public StandardShipment(string trackingCode, string description, double weight, decimal delivaryFee, DelivaryAddress destination)
            : base(trackingCode, description, weight, delivaryFee, destination)
        {

        }
        public StandardShipment(string trackingCode) :base(trackingCode)
        {

        }
    }
}
