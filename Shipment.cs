using System;

namespace AssignmentOOP2
{
    internal class Shipment
    {
        private string trackingCode;
        private string description;
        private double weight;
        private decimal delivaryFee;


        public Shipment()
        {
        }

        public Shipment(string trackingCode)
        {
            TrackingCode = trackingCode;
            Description = "unknown";
            Destination = new DelivaryAddress();
            Weight = 1;
            DelivaryFee = 50m;
        }

        public Shipment(string track, string desc, double we, decimal deli, DelivaryAddress dest)
        {
            TrackingCode = track;
            Description = desc;
            Weight = we;
            DelivaryFee = deli;
            Destination = dest;
        }

        public DelivaryAddress Destination { get; set; }

        public string TrackingCode
        {
            get { return trackingCode; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    Console.WriteLine("Value cannot be empty.");
                else
                    trackingCode = value;
            }
        }

        public string Description
        {
            get { return description; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    Console.WriteLine("Value cannot be empty.");
                else
                    description = value;
            }
        }

        public double Weight
        {
            get { return weight; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Weight must be greater than zero.");
                else
                    weight = value;
            }
        }

        public decimal DelivaryFee
        {
            get { return delivaryFee; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Delivery fee must be greater than zero.");
                else
                    delivaryFee = value;
            }
        }

        public virtual double EstimatedCost => (double)DelivaryFee + (Weight * 5);

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                DelivaryFee = newFee;
            }
            else
            {
                Console.WriteLine("Delivery fee must be greater than zero.");
            }
        }

       
        public void UpdateWeight(double newWeight)
        {
            Weight = newWeight;
        }

       
        public void UpdateWeight(double newWeight, double extraPackingWeight)
        {
            Weight = newWeight + extraPackingWeight;
        }

        public override string ToString()
        {
            return $"TrackingCode:{TrackingCode} \n Description:{Description} \n Weight:{Weight} \n DelivaryFee:{DelivaryFee} \n Destination:{Destination}";
        }

        public virtual void printShipment()
        {
            Console.WriteLine($"TrackingCode:{TrackingCode} \n Description:{Description} \n Weight:{Weight} \n DelivaryFee:{DelivaryFee} \n Destination:{Destination} \n EstimatedCost:{EstimatedCost}");
        }
      
    }
}