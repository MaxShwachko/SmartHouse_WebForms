using SmartHouse_WebForms.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartHouse_WebForms
{
    public partial class DeleteDevice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                if (Session["CurrentRoom"] != null && Session["CurrentDevice"] != null && Session["DeviceType"] != null)
                {
                    int currentRoomId = int.Parse(Session["CurrentRoom"].ToString());
                    int currentDeviceId = int.Parse(Session["CurrentDevice"].ToString());
                    string deviceType = Session["DeviceType"].ToString();
                    RemoveDevice(currentDeviceId, deviceType);
                    Response.Redirect("RoomInfo.aspx");
                }
                else
                { }
            }
            else
            {
                if (Session["CurrentRoom"] != null && Session["CurrentDevice"] != null && Session["DeviceType"] != null)
                {
                    int currentRoomId = int.Parse(Session["CurrentRoom"].ToString());
                    int currentDeviceId = int.Parse(Session["CurrentDevice"].ToString());
                    string deviceType = Session["DeviceType"].ToString();
                    Device currentDevice = FindDevice(currentDeviceId, deviceType);
                    Label2.Text = currentDevice.Name;
                }
                else { }
            }
        }

        private Device FindDevice(int id, string type)
        {
            Device device = null;
            using (SmartHouseContext context = new SmartHouseContext())
            {
                if (context.Alarms.Any())
                {
                    if (type == context.Alarms.FirstOrDefault().GetType().ToString())
                    {
                        return device = context.Alarms.FirstOrDefault(d => d.Id == id);
                    }
                    else { }
                }
                else { }
                if (context.Conditioners.Any())
                {
                    if (type == context.Conditioners.FirstOrDefault().GetType().ToString())
                    {
                        return device = context.Conditioners.FirstOrDefault(d => d.Id == id);
                    }
                    else { }
                }
                else { }
                if (context.Exhausters.Any())
                {
                    if (type == context.Exhausters.FirstOrDefault().GetType().ToString())
                    {
                        return device = context.Exhausters.FirstOrDefault(d => d.Id == id);
                    }
                    else { }
                }
                else { }
                if (context.Fridges.Any())
                {
                    if (type == context.Fridges.FirstOrDefault().GetType().ToString())
                    {
                        return device = context.Fridges.FirstOrDefault(d => d.Id == id);
                    }
                    else { }
                }
                else { }
                if (context.Jalousies.Any())
                {
                    if (type == context.Jalousies.FirstOrDefault().GetType().ToString())
                    {
                        return device = context.Jalousies.FirstOrDefault(d => d.Id == id);
                    }
                    else { }
                }
                else { }
                if (context.Lamps.Any())
                {
                    if (type == context.Lamps.FirstOrDefault().GetType().ToString())
                    {
                        return device = context.Lamps.FirstOrDefault(d => d.Id == id);
                    }
                    else { }
                }
                else { }
                if (context.Radiators.Any())
                {
                    if (type == context.Radiators.FirstOrDefault().GetType().ToString())
                    {
                        return device = context.Radiators.FirstOrDefault(d => d.Id == id);
                    }
                    else { }
                }
                else { }
                if (context.Routers.Any())
                {
                    if (type == context.Routers.FirstOrDefault().GetType().ToString())
                    {
                        return device = context.Routers.FirstOrDefault(d => d.Id == id);
                    }
                    else { }
                }
                else { }
                if (context.StereoSystems.Any())
                {
                    if (type == context.StereoSystems.FirstOrDefault().GetType().ToString())
                    {
                        return device = context.StereoSystems.FirstOrDefault(d => d.Id == id);
                    }
                    else { }
                }
                else { }
                if (context.TVs.Any())
                {
                    if (type == context.TVs.FirstOrDefault().GetType().ToString())
                    {
                        return device = context.TVs.FirstOrDefault(d => d.Id == id);
                    }
                    else { }
                }
                else { }
            }
            return device;
        }
        private void RemoveDevice(int id, string type)
        {
            using (SmartHouseContext context = new SmartHouseContext())
            {
                if (context.Alarms.Any())
                {
                    if (type == context.Alarms.FirstOrDefault().GetType().ToString())
                    {
                        context.Alarms.Remove(context.Alarms.FirstOrDefault(d => d.Id == id));
                        context.SaveChanges();
                        return;
                    }
                    else { }
                }
                else { }
                if (context.Conditioners.Any())
                {
                    if (type == context.Conditioners.FirstOrDefault().GetType().ToString())
                    {
                        context.Conditioners.Remove(context.Conditioners.FirstOrDefault(d => d.Id == id));
                        context.SaveChanges();
                        return;
                    }
                    else { }
                }
                else { }
                if (context.Exhausters.Any())
                {
                    if (type == context.Exhausters.FirstOrDefault().GetType().ToString())
                    {
                        context.Exhausters.Remove(context.Exhausters.FirstOrDefault(d => d.Id == id));
                        context.SaveChanges();
                        return;
                    }
                    else { }
                }
                else { }
                if (context.Fridges.Any())
                {
                    if (type == context.Fridges.FirstOrDefault().GetType().ToString())
                    {
                        context.Fridges.Remove(context.Fridges.FirstOrDefault(d => d.Id == id));
                        context.SaveChanges();
                        return;
                    }
                    else { }
                }
                else { }
                if (context.Jalousies.Any())
                {
                    if (type == context.Jalousies.FirstOrDefault().GetType().ToString())
                    {
                        context.Jalousies.Remove(context.Jalousies.FirstOrDefault(d => d.Id == id));
                        context.SaveChanges();
                        return;
                    }
                    else { }
                }
                else { }
                if (context.Lamps.Any())
                {
                    if (type == context.Lamps.FirstOrDefault().GetType().ToString())
                    {
                        context.Lamps.Remove(context.Lamps.FirstOrDefault(d => d.Id == id));
                        context.SaveChanges();
                        return;
                    }
                    else { }
                }
                else { }
                if (context.Radiators.Any())
                {
                    if (type == context.Radiators.FirstOrDefault().GetType().ToString())
                    {
                        context.Radiators.Remove(context.Radiators.FirstOrDefault(d => d.Id == id));
                        context.SaveChanges();
                        return;
                    }
                    else { }
                }
                else { }
                if (context.Routers.Any())
                {
                    if (type == context.Routers.FirstOrDefault().GetType().ToString())
                    {
                        context.Routers.Remove(context.Routers.FirstOrDefault(d => d.Id == id));
                        context.SaveChanges();
                        return;
                    }
                    else { }
                }
                else { }
                if (context.StereoSystems.Any())
                {
                    if (type == context.StereoSystems.FirstOrDefault().GetType().ToString())
                    {
                        context.StereoSystems.Remove(context.StereoSystems.FirstOrDefault(d => d.Id == id));
                        context.SaveChanges();
                        return;
                    }
                    else { }
                }
                else { }
                if (context.TVs.Any())
                {
                    if (type == context.TVs.FirstOrDefault().GetType().ToString())
                    {
                        context.TVs.Remove(context.TVs.FirstOrDefault(d => d.Id == id));
                        context.SaveChanges();
                        return;
                    }
                    else { }
                }
                else { }
            }
            return;
        }

    }
}