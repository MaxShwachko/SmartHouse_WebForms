using SmartHouse_WebForms.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartHouse_WebForms
{
    public partial class RenameRoom : System.Web.UI.Page
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
                        context.Rooms.FirstOrDefault(r => r.Id == currentId).Name = RoomName.Text;
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
                    RoomName.Text = currentRoom.Name;
                }
                else { }
            }
        }
    }
}