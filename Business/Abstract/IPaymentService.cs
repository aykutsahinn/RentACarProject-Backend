﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IPaymentService
    {
        IResult CreditPayment(Payment paymentCredit);
    }
}
