using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AssignmentOOP2
{
    internal class Shipment
    {
      private  string trackingCode;
      private  string description;
      private  double weight;
      private  decimal delivaryFee;

        public Shipment()
        {
        }

        #region validation
            //public DelivaryAddress Destination { get; set; }
            //public string TrackingCode
            //{
            //    get { return trackingCode; }
            //    set {
            //        if (string.IsNullOrEmpty(value))
            //            Console.Write("value cannot be empty");
            //        else
            //            trackingCode= value;
            //    }
            //}
            //public string Description
            //{
            //    get { return description; }
            //    set
            //    {
            //        if (string.IsNullOrEmpty(value))
            //            Console.Write("value cannot be empty");
            //        else
            //            description = value;
            //    }
            //}
            //public double Weight
            //{
            //    get { return weight; }
            //    set
            //    {
            //        if (value<1)
            //            Console.Write("value cannot be empty");
            //        else
            //            weight = value;
            //    }
            //}

            //public decimal DelivaryFee
            //{
            //    get { return delivaryFee; }
            //    set
            //    {
            //        if (value < 1)
            //            Console.Write("value cannot be empty");
            //        else
            //            delivaryFee = value;
            //    }
            //} 
            #endregion
            #region prop
            #region constructors

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

        #endregion



        public DelivaryAddress Destination { get; set; }
        public string TrackingCode
        {
            get { return trackingCode; }
           private set
            {
                if (string.IsNullOrEmpty(value))
                    Console.Write("value cannot be empty");
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
                    Console.Write("value cannot be empty");
                else
                    description = value;
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                if (value <= 0  )
                    Console.Write("value cannot be empty");
                else
                    weight = value;
            }
        }

        public decimal DelivaryFee
        {
            get { return delivaryFee; }
           private set
            {
                if (value <= 0)
                    Console.Write("value cannot be empty");
                else
                    delivaryFee = value;
            }
        }


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

        public virtual double EstimatedCost => (double) DelivaryFee + (Weight * 5);

        #endregion
        public override string ToString()
        {
            return $"TrackingCode:{TrackingCode} \n Description:{Description} \n Weight:{Weight} \n DelivaryFee:{delivaryFee} \n Destination:{Destination}";
        }

        public void printShipment()
        {
            Console.WriteLine($"TrackingCode:{TrackingCode} \n Description:{Description} \n Weight:{Weight} \n DelivaryFee:{delivaryFee} \n Destination:{Destination} \n EstimatedCost:{EstimatedCost}");
        }

    }
}
