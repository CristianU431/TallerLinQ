using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TallerLinQ
{
    public partial class Products
    {
        public string NombreProductos()
        {
            return ProductName + " - " + UnitPrice;
        }
    }
}