using SmartHouse_WebForms.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartHouse_WebForms
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                if (Session["CurrentRoom"] != null)
                {
                    int currentId = int.Parse(Session["CurrentRoom"].ToString());
                    using (SmartHouseContext context = new SmartHouseContext())
                    {
                        context.Rooms.Remove(context.Rooms.FirstOrDefault(r => r.Id == currentId));
                        context.SaveChanges();
                        Response.Redirect("Default.aspx");
                    }
                }
                else
                { }
            }
            else
            {
                if (Session["CurrentRoom"] != null)
                {
                    int currentId = int.Parse(Session["CurrentRoom"].ToString());
                    Room currentRoom = null;
                    using (SmartHouseContext context = new SmartHouseContext())
                    {
                        currentRoom = context.Rooms.FirstOrDefault(r => r.Id == currentId);
                    }
                    Label2.Text = currentRoom.Name;
                }
                else { }
            }
        }
    }
}