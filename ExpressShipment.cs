using System;
using System.Collections.Generic;
using System.Text;

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




        public decimal ExtraFee {
            get 
            {
                return extraFee;
            }
            set 
            {
                if (value >= 0) 
                    extraFee= value;
            }
            
        }

       public override double EstimatedCost 
        {
            get
            {
                return (double)(DelivaryFee + ExtraFee) + (Weight * 5);
            }
        }
        
            
        

    }
}
