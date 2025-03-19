﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping.Core.Enums
{
    public enum OrderStatus
    {
        New,
        Assigned,
        InProgress,
        Delivered,
        Returned,
        Cancelled
    }
}
