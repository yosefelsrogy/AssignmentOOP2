using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOOP2
{
    public struct DelivaryAddress
    {
        private string City;
        private string Street;
        private int BuildingNumber;


        public DelivaryAddress(string city, string street, int buildingNumber)
        {

            City = city;
            Street = street;
            BuildingNumber = buildingNumber;

        }

        public string GetFullAddress()
        {
            return $"city:{City} + Street:{Street} + BuildingNumber:{BuildingNumber}";
        }

        public override string ToString()
        {
            return $"{ City}\t{Street}\t{BuildingNumber}";
        }


 } }
