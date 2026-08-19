using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOOP2
{
    internal static class DeliveryHelper
    {
        public static void PrintShipmentDetails(Shipment shipment)
        {
            if (shipment == null)
            {
                Console.WriteLine("Shipment data is null!");
                return;
            }

            Console.WriteLine("========================================");
            Console.WriteLine("        DELIVERY HELPER PRINT           ");
            Console.WriteLine("========================================");

            shipment.printShipment();

            Console.WriteLine("========================================\n");
        }
    }
}