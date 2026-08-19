using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOOP2
{
    internal class InternationalShipment : Shipment
    {
        private string destinationCountry;
        private decimal customsFee;

        public InternationalShipment(string trackingCode, string description, double weight, decimal delivaryFee, DelivaryAddress destination, string destinationCountry, decimal customsFee)
            : base(trackingCode, description, weight, delivaryFee, destination)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }

        public string DestinationCountry
        {
            get
            {
                return destinationCountry;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    destinationCountry = value;
            }
        }

        public decimal CustomsFee
        {
            get { return customsFee; }
            set
            {
                if (value >= 0)
                    customsFee = value;
            }
        }

        public override double EstimatedCost
        {
            get
            {
                return (double)DelivaryFee + (Weight * 5) + (double)CustomsFee;
            }
        }

        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine($"Customs report generated for {DestinationCountry}. Fee: {CustomsFee}");
        }


        public override void printShipment()
        {
            Console.WriteLine(" International Shipment ");
            base.printShipment();
            Console.WriteLine($"Destination Country: {DestinationCountry} \nCustoms Fee: {CustomsFee}");
        }
    }
}