﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Blazor.Shared
{
    public class MonthlyLedgerViewModel
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public double Expenses { get; set; }
        public double Income { get; set; }
        public double Total { get; set; }
    }
}
