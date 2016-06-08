using SmartHouse_WebForms.Controlls;
using SmartHouse_WebForms.Controls;
using SmartHouse_WebForms.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartHouse_WebForms
{
    public partial class RoomInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["CurrentRoom"] != null)
            {
//                this.create.ID = " " + "create";
                using (SmartHouseContext context = new SmartHouseContext())
                {
                    int currentRoomId = int.Parse(Session["CurrentRoom"].ToString());
                    Room currentRoom = context.Rooms.FirstOrDefault(r => r.Id == currentRoomId);
                    IDictionary<int, Device> deviceList = GetDeviceList(currentRoom);
                    for (int i = 0; i < deviceList.Count; i++)
                    {
                        if (i % 3 == 0)
                        {
                            PlaceHolder1.Controls.Add(new LiteralControl("<div class=\"col-xs-12\">"));
                            PlaceHolder1.Controls.Add(new LiteralControl("</div>"));
                        }
                        DeviceControl c = (DeviceControl)Page.LoadControl(@"~\Controls\DeviceControl.ascx");
                        Device dev = null;
                        deviceList.TryGetValue(i, out dev);
                        if (dev is Lamp)
                        {
                            Lamp dev1 = (Lamp)dev;
                            c.Initialize(dev, currentRoomId);
                        }
                        else
                        {
                            c.Initialize(dev, currentRoomId);
                        }
                        PlaceHolder1.Controls.Add(c);
                    }
                }
            }
            else
            { }
        }

        private IDictionary<int, Device> GetDeviceList(Room room)
        {
            IDictionary<int, Device> deviceList = new SortedDictionary<int, Device>();
            int i = 0;
            foreach (Alarm item in room.Alarm)
            {
                deviceList.Add(i, item);
                i++;
            }
            foreach (var item in room.Conditioner)
            {
                deviceList.Add(i, item);
                i++;
            }
            foreach (var item in room.Exhauster)
            {
                deviceList.Add(i, item);
                i++;
            }
            foreach (var item in room.Fridge)
            {
                deviceList.Add(i, item);
                i++;
            }
            foreach (var item in room.Jalousie)
            {
                deviceList.Add(i, item);
                i++;
            }
            foreach (var item in room.Lamp)
            {
                deviceList.Add(i, item);
                i++;
            }
            foreach (var item in room.Radiator)
            {
                deviceList.Add(i, item);
                i++;
            }
            foreach (var item in room.Router)
            {
                deviceList.Add(i, item);
                i++;
            }
            foreach (var item in room.StereoSystem)
            {
                deviceList.Add(i, item);
                i++;
            }
            foreach (var item in room.TV)
            {
                deviceList.Add(i, item);
                i++;
            }
            return deviceList;
        }

    }
}