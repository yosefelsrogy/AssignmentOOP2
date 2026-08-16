using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOOP2
{
    internal class InternationalShipment :Shipment
    {
        private string destinationCountry;
        private decimal customsfee;



        //prop


        public InternationalShipment(string trackingCode, string description, double weight, decimal delivaryFee, DelivaryAddress destination, string destinationCountry, decimal customsfee)
            : base(trackingCode, description, weight, delivaryFee, destination)
        {
            DestinationCountry = destinationCountry;
            CustomesFee = customsfee;
        }
        public string DestinationCountry
        {
            get 
            { 
                return destinationCountry;
            }
            
            set 
            { 
             if(!string.IsNullOrEmpty(value))
                    destinationCountry= value;
            } 
        }


        public decimal CustomesFee
        {
            get { return customsfee; }

            set {
                if(value>=0)
                customsfee = value;

            }
        }

        public override double EstimatedCost
        {
            get
            {
               return (double)(DelivaryFee) + (Weight * 5) + ((double)(CustomesFee));
            }
        }

    }
}
