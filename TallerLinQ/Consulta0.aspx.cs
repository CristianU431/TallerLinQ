using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TallerLinQ
{
    public partial class Consulta0 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCategorias_Click(object sender, EventArgs e)
        {
            NorthDataContext north = new NorthDataContext();
            var consulta = from C in north.Categories
                           select C;
            gvlist.DataSource = consulta;
            gvlist.DataBind();
        }

        protected void btnProductos_Click(object sender, EventArgs e)
        {
            NorthDataContext north = new NorthDataContext();
            var consulta = from P in north.Products
                           select P;
            gvlist.DataSource = consulta;
            gvlist.DataBind();
        }

        protected void btnDetalles_Click(object sender, EventArgs e)
        {
            NorthDataContext north = new NorthDataContext();
            var consulta = from D in north.Order_Details
                           orderby D.OrderID
                           select D;
            gvlist.DataSource = consulta;
            gvlist.DataBind();
        }

        protected void btnConsulta_Click(object sender, EventArgs e)
        {
            int nro = int.Parse(txtNro.Text);
            NorthDataContext north = new NorthDataContext();
            var consulta = from P in north.Products
                           where P.UnitsInStock >= nro
                           select new { P.ProductID, P.ProductName, P.UnitsInStock};
            
            gvlist.DataSource = consulta;
            gvlist.DataBind();
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            int nro = int.Parse(txtNro.Text);
            NorthDataContext north = new NorthDataContext();
            var consulta = from D in north.Order_Details
                           where D.Quantity >= nro
                           select new { D.OrderID, D.ProductID, D.Quantity };

            gvlist.DataSource = consulta;
            gvlist.DataBind();
        }

        protected void ddlproductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = ddlproductos.SelectedIndex;
            NorthDataContext north = new NorthDataContext();
            if (indice == 0)
            {
                var consulta = from C in north.Categories
                               select C;
                gvlist.DataSource = consulta;
                gvlist.DataBind();
            }
            else if (indice == 1)
            {
                var consulta = from C in north.Categories
                               where C.CategoryID == 1
                               select C;
                gvlist.DataSource = consulta;
                gvlist.DataBind();
            }
            else if (indice == 2)
            {
                var consulta = from C in north.Categories
                               where C.CategoryID == 2
                               select C;
                gvlist.DataSource = consulta;
                gvlist.DataBind();
            }
            else if (indice == 3)
            {
                var consulta = from C in north.Categories
                               where C.CategoryID == 3
                               select C;
                gvlist.DataSource = consulta;
                gvlist.DataBind();
            }
            else if (indice == 4)
            {
                var consulta = from C in north.Categories
                               where C.CategoryID == 4
                               select C;
                gvlist.DataSource = consulta;
                gvlist.DataBind();
            }
            else if (indice == 5)
            {
                var consulta = from C in north.Categories
                               where C.CategoryID == 5
                               select C;
                gvlist.DataSource = consulta;
                gvlist.DataBind();
            }
            else if (indice == 6)
            {
                var consulta = from C in north.Categories
                               where C.CategoryID == 6
                               select C;
                gvlist.DataSource = consulta;
                gvlist.DataBind();
            }
            else if (indice == 7)
            {
                var consulta = from C in north.Categories
                               where C.CategoryID == 7
                               select C;
                gvlist.DataSource = consulta;
                gvlist.DataBind();
            }
            else if (indice == 8)
            {
                var consulta = from C in north.Categories
                               where C.CategoryID == 8
                               select C;
                gvlist.DataSource = consulta;
                gvlist.DataBind();
            }
            else if (indice == 12)
            {
                var consulta = from C in north.Categories
                               where C.CategoryID == 12
                               select C;
                gvlist.DataSource = consulta;
                gvlist.DataBind();
            }
        }

        protected void btnconlambda_Click(object sender, EventArgs e)
        {
            using (NorthDataContext north = new NorthDataContext())
            {
                int num = int.Parse(txtnum.Text);
                var consulta = north.Products.Where(P => P.UnitsInStock > num);
                gvlist.DataSource = consulta;
                gvlist.DataBind();
            }
        }

        protected void btnConsultaNu_Click(object sender, EventArgs e)
        {
            using (NorthDataContext north = new NorthDataContext())
            {
                int num = int.Parse(txtnum1.Text);
                var consulta = north.Products.Where(P => P.UnitsInStock < num);
                gvlist.DataSource = consulta;
                gvlist.DataBind();
            }
        }

        protected void btnmax_Click(object sender, EventArgs e)
        {
            using (NorthDataContext norht = new NorthDataContext())
            {
                var consulta = from P in norht.Products
                               group P by P.Categories.CategoryID into C
                               select new { CategoryID = C.Key, Promedio = C.Max(P => P.UnitPrice) };
                gvlist.DataSource = consulta;
                gvlist.DataBind();
            }
        }

        protected void btnmin_Click(object sender, EventArgs e)
        {
            using (NorthDataContext norht = new NorthDataContext())
            {
                var consulta = from P in norht.Products
                               group P by P.Categories.CategoryID into C
                               select new { CategoryID = C.Key, Promedio = C.Min(P => P.UnitPrice) };
                gvlist.DataSource = consulta;
                gvlist.DataBind();
            }
        }

        protected void btnprimpro_Click(object sender, EventArgs e)
        {
            using (NorthDataContext norht = new NorthDataContext())
            {
                int nro = int.Parse(txtnumber.Text);
                var consulta = norht.Products.Where(C => C.ProductID >= 0).Take(nro);

                gvlist.DataSource = consulta;
                gvlist.DataBind();
            }
        }

        protected void btndatos_Click(object sender, EventArgs e)
        {
            using (NorthDataContext norht = new NorthDataContext())
            {
                var consulta = from P in norht.Products
                               select new
                               {
                                   P.ProductID,
                                   nombre_Productos = P.NombreProductos(),
                                   P.UnitsOnOrder

                               };
                gvlist.DataSource = consulta;
                gvlist.DataBind();
            }
        }

        protected void btnprecio_Click(object sender, EventArgs e)
        {
            using (NorthDataContext norht = new NorthDataContext())
            {
                var consulta = from O in norht.Order_Details
                               select new
                               {
                                   O.OrderID,
                                   Cantidad_de_Descuento = O.global(),
                                   O.Quantity

                               };
                gvlist.DataSource = consulta;
                gvlist.DataBind();
            }
        }

        protected void btncat_Click(object sender, EventArgs e)
        {
            using (NorthDataContext norht = new NorthDataContext())
            {
                var consulta = from C in norht.Categories
                               select new
                               {
                                   C.CategoryID,
                                   Descripcion = C.descripciones(),
                                   C.Picture

                               };
                gvlist.DataSource = consulta;
                gvlist.DataBind();
            }
        }
    }
}