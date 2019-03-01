﻿namespace SoftUni.Models
{
    using System.Collections.Generic;

    public class Address
    {
        public Address()
        {
            Employees = new HashSet<Employee>();
        }

        public Address(string addressText, int townId)
        {
            this.AddressText = addressText;
            this.TownId = townId; 
        }

        public int AddressId { get; set; }

        public string AddressText { get; set; }

        public int? TownId { get; set; }
        public Town Town { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
