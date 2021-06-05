using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorksSales.Web.ViewModels
{
    public class SummaryViewModel
    {
        public string Totalorders { get; set; }
        public string HighestLineTotal { get; set; }
        public string FrontBrakesSalesTotal { get; set; }
    }
}