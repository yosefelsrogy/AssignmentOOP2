using System;

namespace AssignmentOOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Theoretical Questions
            // class ==> for big and complex logic 
            // struct ==> for small and simple logic
            #endregion

            DelivaryCinter center = new DelivaryCinter();

 
            Driver driver = new Driver(101, "Ahmed Ali", "01012345678");
            center.Driver = driver;

            Console.Write("Enter delivery center name: ");
            center.CenterName = Console.ReadLine();

           
            Console.WriteLine("\n--- Standard Shipment ---");
            string track1;
            do
            {
                Console.Write("Tracking code: ");
                track1 = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(track1));

            Console.Write("Description: ");
            string desc1 = Console.ReadLine();
            bool flag;
            double weight1;
            do
            {
                Console.Write("Weight: ");
                flag = double.TryParse(Console.ReadLine(), out weight1);
            }
            while (!flag);

            Console.Write("Delivery fee: ");
            decimal fee1 = decimal.Parse(Console.ReadLine());
            DelivaryAddress addr1 = ReadAddress();
            StandardShipment standard = new StandardShipment(track1, desc1, weight1, fee1, addr1);

           
            Console.WriteLine("\n--- Express Shipment ---");
            Console.Write("Tracking code: ");
            string track2 = Console.ReadLine();
            Console.Write("Description: ");
            string desc2 = Console.ReadLine();
            Console.Write("Weight: ");
            double weight2 = double.Parse(Console.ReadLine());
            Console.Write("Delivery fee: ");
            decimal fee2 = decimal.Parse(Console.ReadLine());
            Console.Write("Extra fee: ");
            decimal extraFee = decimal.Parse(Console.ReadLine());
            DelivaryAddress addr2 = ReadAddress();
            ExpressShipment express = new ExpressShipment(track2, desc2, weight2, fee2, extraFee, addr2);

            Console.WriteLine("\n--- International Shipment ---");
            Console.Write("Tracking code: ");
            string track3 = Console.ReadLine();
            Console.Write("Description: ");
            string desc3 = Console.ReadLine();
            Console.Write("Weight: ");
            double weight3 = double.Parse(Console.ReadLine());
            Console.Write("Delivery fee: ");
            decimal fee3 = decimal.Parse(Console.ReadLine());
            Console.Write("Destination country: ");
            string destCountry = Console.ReadLine();
            Console.Write("Customs fee: ");
            decimal customsFee = decimal.Parse(Console.ReadLine());
            DelivaryAddress addr3 = ReadAddress();
            InternationalShipment international = new InternationalShipment(
                track3, desc3, weight3, fee3, addr3, destCountry, customsFee);


            center.AddShipment(standard);
            center.AddShipment(express);
            center.AddShipment(international);

            Console.WriteLine("\n=== All Shipments ===");
            center.PrintAllShipments();


            Console.WriteLine("\n=== Testing DeliveryHelper ===");
            DeliveryHelper.PrintShipmentDetails(standard);


            Console.WriteLine("=== Testing UpdateWeight (Overloading) ===");
            standard.UpdateWeight(5.0);
            standard.UpdateWeight(5.0, 1.5);
            Console.WriteLine("\n=== Testing Sealed Features ===");
            CompletedShipment completed = new CompletedShipment("CMP99", "Fragile Glassware", 2.0, 50m, addr1);
            completed.printShipment();

            PriorityInternationalShipment priority = new PriorityInternationalShipment("PRI100", "Medical Supplies", 10.0, 200m, addr3, "Germany", 150m);
            priority.GenerateCustomsReport();

            Console.Write("\nEnter tracking code to search: ");
            string searchCode = Console.ReadLine();
            Shipment found = center[searchCode];
            Console.WriteLine(found != null ? "Found:" : "Shipment not found.");
            found?.printShipment();

            Console.Write("\nEnter tracking code to remove: ");
            string removeCode = Console.ReadLine();
            bool removed = center.RemoveShipment(removeCode);
            Console.WriteLine(removed ? "Shipment removed." : "Shipment not found.");

            Console.WriteLine("\n=== Remaining Shipments ===");
            center.PrintAllShipments();

            Console.ReadKey();
        }

        static DelivaryAddress ReadAddress()
        {
            Console.Write("City: ");
            string city = Console.ReadLine();
            Console.Write("Street: ");
            string street = Console.ReadLine();
            Console.Write("Building number: ");
            int buildingNumber = int.Parse(Console.ReadLine());
            return new DelivaryAddress(city, street, buildingNumber);
        }
    }
}