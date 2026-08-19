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

        public Driver Driver { get; set; }

        public string CenterName
        {
            get { return centerName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    centerName = value;
            }
        }



        public Shipment this[int position]
        {
            get
            {
                if (position >= 0 && position < shipments.Length)
                    return shipments[position];

                return null;
            }
        }

        public Shipment this[string code]
        {
            get
            {
                if (!string.IsNullOrEmpty(code))
                {
                    for (int i = 0; i < shipments.Length; i++)
                    {
                        if (shipments[i] != null && shipments[i].TrackingCode == code)
                        {
                            return shipments[i];
                        }
                    }
                }
                return null;
            }
        }



        public bool AddShipment(Shipment shipment)
        {
            if (shipment == null) return false;

            if (this[shipment.TrackingCode] != null)
            {
                Console.WriteLine($"Shipment with tracking code '{shipment.TrackingCode}' already exists!");
                return false;
            }

            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] == null)
                {
                    shipments[i] = shipment;
                    return true;
                }
            }
            return false;
        }

        public bool RemoveShipment(string trackingCode)
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
            Console.WriteLine($"=== Delivery Center: {CenterName ?? "Unnamed"} ===");

    
            if (Driver != null)
            {
                Console.WriteLine($"Assigned Driver: {Driver.FullName} (ID: {Driver.DriverId}, Phone: {Driver.PhoneNumber})");
            }
            Console.WriteLine("----------------------------------------------");

            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null)
                {
                    shipments[i].printShipment();
                    Console.WriteLine("----------------------------------------------");
                }
            }
        }

    }
}