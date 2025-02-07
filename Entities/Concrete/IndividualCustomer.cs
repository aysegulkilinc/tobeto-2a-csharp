﻿using Core.Entities;
using Entities.Concrete;
using System;
    public class IndividualCustomer : Entity<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalIdentity { get; set; }

        public IndividualCustomer() { }

        public IndividualCustomer(
            string firstName,
            string lastName,
            string nationalIdentity
        )
        {
            FirstName = firstName;
            LastName = lastName;
            NationalIdentity = nationalIdentity;
        }
    public Customers? Customers { get; set; } = null;

}
