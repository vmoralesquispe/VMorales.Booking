﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMorales.Booking.Application.DataBase.Customer.Queries.GetCustomerByDocumentNumber
{
    public interface IGetCustomerByDocumentNumberQuery
    {
        Task<GetCustomerByDocumentNumberModel> Execute(string documentNumber);
    }
}
