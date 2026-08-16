using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOOP2
{
    internal class DelivaryCinter 
    {
        private string centerName;
        
        private Shipment[] shipments;

        public DelivaryCinter()
        {
            shipments = new Shipment[20];
        }

            public Shipment this[int position]
        {
            get
            {
                if (position >= 0 && position < 20)
                    return shipments[position];

                return null;//لو الشرط متحققش
            }
        }


        public string CenterName
        {
            get { return centerName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    centerName = value;
            }
        }

        public Shipment this[string code]
        {
            get {
                if ( !string.IsNullOrEmpty(code))
                {
                    for (int i = 0; i < shipments.Length; i++)//x object of shipment
                    {
                        if(shipments[i] != null && shipments[i].TrackingCode == code)
                        {
                            return shipments[i];
                        }
                        
                    }
                  
                }
                return null;

             }

        }

        public bool RemoveShipment(string  trackingCode)
        {

            
            
                if (!string.IsNullOrEmpty(trackingCode))
                {
                    for (int i = 0; i < shipments.Length; i++)
                    {
                        if (shipments[i] != null && shipments[i].TrackingCode == trackingCode)
                        {
                            shipments[i] = null;
                            return true;
                        }
                    }
      
                }
                return false;
                
            
        }

        public void PrintAllShipments()
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null)
                {
                    shipments[i].printShipment();
                    Console.WriteLine("------------------------------");
                }
            }
        }

        public bool AddShipment(Shipment Shipment)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] == null)
                {
                    shipments[i] = Shipment;
                    return true;
                }
               
            }
            return false;

        }

    }
}
