﻿using System;

namespace Logo.DataType.Infrastructure
{
    public interface IApprove
    {
        Nullable<short> Approve { get; set; }
        Nullable<DateTime> ApproveDate { get; set; }
    }
}
