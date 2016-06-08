using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SmartHouse_WebForms.Models.Classes;
using System.Text;
using SmartHouse_WebForms.Controlls;

namespace SmartHouse_WebForms
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["CurrentRoom"] != null)
            {
                Session["CurrentRoom"] = null;
            }
            else
            { }
            if (Session["CurrentDevice"] != null)
            {
                Session["CurrentDevice"] = null;
            }
            else
            { }
            if (Session["DeviceType"] != null)
            {
                Session["DeviceType"] = null;
            }
            else
            { }

            GetRoomsList();
        }

        protected void GetRoomsList()
        {
            List<Room> RoomsList = new List<Room>();
            using (SmartHouseContext context = new SmartHouseContext())
            {
                RoomsList = context.Rooms.ToList();
            }

            foreach (Room room in RoomsList)
            {
                RoomControl c = (RoomControl)Page.LoadControl(@"~\Controls\RoomControl.ascx");
                c.Initialize(room.Name, room.Id);
                PlaceHolder1.Controls.Add(c);
            }
        }


    }
}