using SmartHouse_WebForms.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartHouse_WebForms
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                using (SmartHouseContext context = new SmartHouseContext())
                {
                    Room newRoom = new Room(InputForName.Text);
                    context.Rooms.Add(newRoom);
                    context.SaveChanges();
                    Response.Redirect("Default.aspx");
                }
            }
        }
    }
}