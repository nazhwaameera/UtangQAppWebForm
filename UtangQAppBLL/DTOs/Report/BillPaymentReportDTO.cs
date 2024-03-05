﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UtangQAppBLL.DTOs.Report
{
    public class BillPaymentReportDTO
    {
        public decimal BillAmount { get; set; }
        public DateTime BillDate { get; set; }
        public string BillDescription { get; set; }
        public string PaymentStatus { get; set; }
    }
}
