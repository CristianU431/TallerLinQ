using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TallerLinQ
{
    public partial class Order_Details
    {
        public string global()
        {
            return UnitPrice + " - " + Discount;
        }
    }
}