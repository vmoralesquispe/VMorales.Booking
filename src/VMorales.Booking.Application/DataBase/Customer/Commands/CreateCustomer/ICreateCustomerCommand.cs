﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMorales.Booking.Application.DataBase.Customer.Commands.CreateCustomer
{
    public interface ICreateCustomerCommand
    {
        Task<CreateCustomerModel> Execute(CreateCustomerModel model);
    }
}
