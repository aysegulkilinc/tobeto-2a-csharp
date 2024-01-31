﻿using Business.Dtos.Customers;

namespace Business.Dtos.IndividualCustomer;

public class IndividualCustomerListItemDto : CustomersListItemDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string NationalIdentity { get; set; }

}