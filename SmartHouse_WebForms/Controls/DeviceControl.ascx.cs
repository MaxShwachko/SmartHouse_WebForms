using SmartHouse_WebForms.Models.Classes;
using SmartHouse_WebForms.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartHouse_WebForms.Controls
{
    public partial class DeviceControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void Initialize(Device dev, int roomId)
        {
            string name = dev.Name;
            int id = dev.Id;
            string deviceType = dev.GetType().ToString();
            bool state = dev.State;
            this.Label1.Text = "<h3 class=\"text-center\">" + name + "</h3>";
            this.OnOff.Click += ButtonClick;
            this.OnOff.ID = "OnOff" + " " + id.ToString() + " " + deviceType + " " + roomId.ToString();
            //            this.CheckBox1.Attributes.Add("data-id", id.ToString());
            //          this.CheckBox1.CheckedChanged += ButtonClick;
            if (state)
            {
    //            CheckBox1.Attributes.Add("checked", "true");
            }
            else { }
      //      this.CheckBox1.CssClass = "my-switch";
        //    this.CheckBox1.ID = id.ToString() + " " + "state" + " " + deviceType + " " + roomId.ToString();
          //  this.Label2.Attributes.Add("for", "MainContent_ctl00_" + id.ToString() + " " + "state" + " " + deviceType + " " + roomId.ToString());
            //MainContent_ctl00_
            //"ctl00$MainContent$ctl00$"
            this.Delete.Click += ButtonClick;
            this.Rename.Click += ButtonClick;
            this.Delete.ID = id.ToString() + " " + "delete" + " " + deviceType + " " + roomId.ToString();
            this.Rename.ID = id.ToString() + " " + "rename" + " " + deviceType + " " + roomId.ToString();


            using (SmartHouseContext context = new SmartHouseContext())
            {
                if (context.Alarms.Any())
                {
                    if (deviceType == context.Alarms.FirstOrDefault().GetType().ToString())
                    {
                        this.img.Attributes.Add("data-action", "Alarm");
                        this.img.Attributes.Add("data-on", "/Content/Images/Alarm_on.jpg");
                        this.img.Attributes.Add("data-off", "/Content/Images/Alarm.jpg");
                        if (state)
                        {
                            this.img.Attributes.Add("src", "/Content/Images/Alarm_on.jpg");
                        }
                        else
                        {
                            this.img.Attributes.Add("src", "/Content/Images/Alarm.jpg");
                        }
                    }
                    else { }
                }
                else { }
                if (context.Conditioners.Any())
                {
                    if (deviceType == context.Conditioners.FirstOrDefault().GetType().ToString())
                    {
                        img.Attributes.Add("data-action", "Conditioner");
                        img.Attributes.Add("data-on", "/Content/Images/Cond_on.jpg");
                        img.Attributes.Add("data-off", "/Content/Images/Cond.jpg");
                        if (state)
                        {
                            img.Attributes.Add("src", "/Content/Images/Cond_on.jpg");
                        }
                        else
                        {
                            img.Attributes.Add("src", "/Content/Images/Cond.jpg");
                        }
                        Conditioner dev2 = (Conditioner)dev;
                        TemperatureDeviceBuilder(id,deviceType,roomId,dev2.CurrentTemperature);
                    }
                    else { }
                }
                else { }
                if (context.Exhausters.Any())
                {
                    if (deviceType == context.Exhausters.FirstOrDefault().GetType().ToString())
                    {
                        img.Attributes.Add("data-action", "Exhauster");
                        img.Attributes.Add("data-on", "/Content/Images/Exhauster_on.jpg");
                        img.Attributes.Add("data-off", "/Content/Images/Exhauster.jpg");
                        if (state)
                        {
                            img.Attributes.Add("src", "/Content/Images/Exhauster_on.jpg");
                        }
                        else
                        {
                            img.Attributes.Add("src", "/Content/Images/Exhauster.jpg");
                        }
                        Exhauster dev2 = (Exhauster)dev;
                        PowerDeviceBuilder(id, deviceType, roomId, dev2.CurrentPower);
                    }
                    else { }
                }
                else { }
                if (context.Fridges.Any())
                {
                    if (deviceType == context.Fridges.FirstOrDefault().GetType().ToString())
                    {
                        img.Attributes.Add("data-action", "Fridge");
                        img.Attributes.Add("data-on", "/Content/Images/Fridge_on.jpg");
                        img.Attributes.Add("data-off", "/Content/Images/Fridge.jpg");
                        if (state)
                        {
                            img.Attributes.Add("src", "/Content/Images/Fridge_on.jpg");
                        }
                        else
                        {
                            img.Attributes.Add("src", "/Content/Images/Fridge.jpg");
                        }
                        Fridge dev2 = (Fridge)dev;
                        TemperatureDeviceBuilder(id, deviceType, roomId, dev2.CurrentTemperature);
                    }
                    else { }
                }
                else { }
                if (context.Jalousies.Any())
                {
                    if (deviceType == context.Jalousies.FirstOrDefault().GetType().ToString())
                    {
                        img.Attributes.Add("data-action", "Jalousie");
                        img.Attributes.Add("data-on", "/Content/Images/Jalousie.jpg");
                        img.Attributes.Add("data-off", "/Content/Images/Jalousie_off.jpg");
                        if (state)
                        {
                            img.Attributes.Add("src", "/Content/Images/Jalousie.jpg");
                        }
                        else
                        {
                            img.Attributes.Add("src", "/Content/Images/Jalousie_off.jpg");
                        }
                    }
                    else { }
                }
                else { }
                if (context.Lamps.Any())
                {
                    if (deviceType == context.Lamps.FirstOrDefault().GetType().ToString())
                    {
                        Lamp dev2 = (Lamp)dev;
                        string lampType = dev2.LampType;
                        img.Attributes.Add("data-action", "Lamp");
                        if (lampType == LampTypes.Chandelier.ToString())
                        {
                            img.Attributes.Add("data-on", "/Content/Images/Lamp_on.jpg");
                            img.Attributes.Add("data-off", "/Content/Images/Lamp.jpg");
                            if (state)
                            {
                                img.Attributes.Add("src", "/Content/Images/Lamp_on.jpg");
                            }
                            else
                            {
                                img.Attributes.Add("src", "/Content/Images/Lamp.jpg");
                            }
                        }
                        else
                        if (lampType == LampTypes.Table.ToString())
                        {
                            img.Attributes.Add("data-on", "/Content/Images/Lamp_table_on.jpg");
                            img.Attributes.Add("data-off", "/Content/Images/Lamp_table.jpg");
                            if (state)
                            {
                                img.Attributes.Add("src", "/Content/Images/Lamp_table_on.jpg");
                            }
                            else
                            {
                                img.Attributes.Add("src", "/Content/Images/Lamp_table.jpg");
                            }
                        }
                        else
                        if (lampType == LampTypes.Wall.ToString())
                        {
                            img.Attributes.Add("data-on", "/Content/Images/Lamp_wall_on.jpg");
                            img.Attributes.Add("data-off", "/Content/Images/Lamp_wall.jpg");
                            if (state)
                            {
                                img.Attributes.Add("src", "/Content/Images/Lamp_wall_on.jpg");
                            }
                            else
                            {
                                img.Attributes.Add("src", "/Content/Images/Lamp_wall.jpg");
                            }
                        }
                        else
                        if (lampType == LampTypes.Floor.ToString())
                        {
                            img.Attributes.Add("data-on", "/Content/Images/Lamp_floor_on.jpg");
                            img.Attributes.Add("data-off", "/Content/Images/Lamp_floor.jpg");
                            if (state)
                            {
                                img.Attributes.Add("src", "/Content/Images/Lamp_floor_on.jpg");
                            }
                            else
                            {
                                img.Attributes.Add("src", "/Content/Images/Lamp_floor.jpg");
                            }
                        }
                        LightDeviceBuilder(id, deviceType, roomId, dev2.CurrentBrightness);
                    }
                    else { }
                }
                else { }
                if (context.Radiators.Any())
                {
                    if (deviceType == context.Radiators.FirstOrDefault().GetType().ToString())
                    {
                        img.Attributes.Add("data-action", "Radiator");
                        img.Attributes.Add("data-on", "/Content/Images/Radiator_on.jpg");
                        img.Attributes.Add("data-off", "/Content/Images/Radiator.jpg");
                        if (state)
                        {
                            img.Attributes.Add("src", "/Content/Images/Radiator_on.jpg");
                        }
                        else
                        {
                            img.Attributes.Add("src", "/Content/Images/Radiator.jpg");
                        }
                        Radiator dev2 = (Radiator)dev;
                        TemperatureDeviceBuilder(id, deviceType, roomId, dev2.CurrentTemperature);
                    }
                    else { }
                }
                else { }
                if (context.Routers.Any())
                {
                    if (deviceType == context.Routers.FirstOrDefault().GetType().ToString())
                    {
                        img.Attributes.Add("data-action", "Router");
                        img.Attributes.Add("data-on", "/Content/Images/Router_on.jpg");
                        img.Attributes.Add("data-off", "/Content/Images/Router.jpg");
                        if (state)
                        {
                            img.Attributes.Add("src", "/Content/Images/Router_on.jpg");
                        }
                        else
                        {
                            img.Attributes.Add("src", "/Content/Images/Router.jpg");
                        }
                    }
                    else { }
                }
                else { }
                if (context.StereoSystems.Any())
                {
                    if (deviceType == context.StereoSystems.FirstOrDefault().GetType().ToString())
                    {
                        img.Attributes.Add("data-action", "StereoSystem");
                        img.Attributes.Add("data-on", "/Content/Images/StereoSystem_on.jpg");
                        img.Attributes.Add("data-off", "/Content/Images/StereoSystem.jpg");
                        if (state)
                        {
                            img.Attributes.Add("src", "/Content/Images/StereoSystem_on.jpg");
                        }
                        else
                        {
                            img.Attributes.Add("src", "/Content/Images/StereoSystem.jpg");
                        }
                        StereoSystem dev2 = (StereoSystem)dev;
                        SoundDeviceBuilder(id, deviceType, roomId, dev2.CurrentVolume);
                    }
                    else { }
                }
                else { }
                if (context.TVs.Any())
                {
                    if (deviceType == context.TVs.FirstOrDefault().GetType().ToString())
                    {
                        img.Attributes.Add("data-action", "TV");
                        img.Attributes.Add("data-on", "/Content/Images/TV_on.jpg");
                        img.Attributes.Add("data-off", "/Content/Images/TV.jpg");
                        if (state)
                        {
                            img.Attributes.Add("src", "/Content/Images/TV_on.jpg");
                        }
                        else
                        {
                            img.Attributes.Add("src", "/Content/Images/TV.jpg");
                        }
                        TV dev2 = (TV)dev;
                        LightDeviceBuilder(id, deviceType, roomId, dev2.CurrentBrightness);
                        SoundDeviceBuilder(id, deviceType, roomId, dev2.CurrentVolume);
                        ChannelDeviceBuilder(id, deviceType,roomId, dev2.GetCurrentChannelName());
                    }
                    else { }
                }
                else { }
            }
        }

        private void TemperatureDeviceBuilder(int id, string deviceType, int roomId, int currentTemperature)
        {
            PlaceHolder1.Controls.Add(new LiteralControl("<h5 class=\"text-left\">Температура</h5>"));
            Button btn = new Button();
            btn.CssClass = "btn";
            btn.Attributes.Add("style", "padding: 2 px, 7px");
            btn.Text = "-";
            btn.Click += ButtonClick;
            btn.ID = " " + id.ToString() + " " + "temperature" + " " + "minus" + " " + deviceType + " " + roomId.ToString();
            PlaceHolder1.Controls.Add(btn);
            TextBox tb = new TextBox();
            tb.Attributes.Add("style", "width: 65px; text-align: center");
            tb.Attributes.Add("value", currentTemperature.ToString());
            tb.ID = id.ToString() + " " + "temperature" + " " + deviceType + " " + roomId.ToString();
            PlaceHolder1.Controls.Add(tb);
            Button btn2 = new Button();
            btn2.CssClass = "btn";
            btn2.Attributes.Add("style", "padding: 2 px, 7px");
            btn2.Text =  "+";
            btn2.Click += ButtonClick;
            btn2.ID = " " + id.ToString() + " " + "temperature" + " " + "plus" + " " + deviceType + " " + roomId.ToString();
            PlaceHolder1.Controls.Add(btn2);
        }
        private void LightDeviceBuilder(int id, string deviceType, int roomId, int currentBrightness)
        {
            PlaceHolder1.Controls.Add(new LiteralControl("<h5 class=\"text-left\">Яркость</h5>"));
            Button btn = new Button();
            btn.CssClass = "btn";
            btn.Attributes.Add("style", "padding: 2 px, 7px");
            btn.Text = "-";
            btn.Click += ButtonClick;
            btn.ID = " " + id.ToString() + " " + "brightness" + " " + "minus" + " " + deviceType + " " + roomId.ToString();
            PlaceHolder1.Controls.Add(btn);
            TextBox tb = new TextBox();
            tb.Attributes.Add("style", "width: 65px; text-align: center");
            tb.Attributes.Add("value", currentBrightness.ToString());
            tb.ID = id.ToString() + " " + "brightness" + " " + deviceType + " " + roomId.ToString();
            PlaceHolder1.Controls.Add(tb);
            Button btn2 = new Button();
            btn2.CssClass = "btn";
            btn2.Attributes.Add("style", "padding: 2 px, 7px");
            btn2.Text = "+";
            btn2.Click += ButtonClick;
            btn2.ID = " " + id.ToString() + " " + "brightness" + " " + "plus" + " " + deviceType + " " + roomId.ToString();
            PlaceHolder1.Controls.Add(btn2);
        }
        private void PowerDeviceBuilder(int id, string deviceType, int roomId, int currentPower)
        {
            PlaceHolder1.Controls.Add(new LiteralControl("<h5 class=\"text-left\">Мощность</h5>"));
            Button btn = new Button();
            btn.CssClass = "btn";
            btn.Attributes.Add("style", "padding: 2 px, 7px");
            btn.Text = "-";
            btn.Click += ButtonClick;
            btn.ID = " " + id.ToString() + " " + "power" + " " + "minus" + " " + deviceType + " " + roomId.ToString();
            PlaceHolder1.Controls.Add(btn);
            TextBox tb = new TextBox();
            tb.Attributes.Add("style", "width: 65px; text-align: center");
            tb.Attributes.Add("value", currentPower.ToString());
            tb.ID = id.ToString() + " " + "power" + " " + deviceType + " " + roomId.ToString();
            PlaceHolder1.Controls.Add(tb);
            Button btn2 = new Button();
            btn2.CssClass = "btn";
            btn2.Attributes.Add("style", "padding: 2 px, 7px");
            btn2.Text = "+";
            btn2.Click += ButtonClick;
            btn2.ID = " " + id.ToString() + " " + "power" + " " + "plus" + " " + deviceType + " " + roomId.ToString();
            PlaceHolder1.Controls.Add(btn2);
        }
        private void SoundDeviceBuilder(int id, string deviceType, int roomId, int currentVolume)
        {
            PlaceHolder1.Controls.Add(new LiteralControl("<h5 class=\"text-left\">Громкость</h5>"));
            Button btn = new Button();
            btn.CssClass = "btn";
            btn.Attributes.Add("style", "padding: 2 px, 7px");
            btn.Text = "-";
            btn.Click += ButtonClick;
            btn.Controls.Add(new LiteralControl("<span class=\"glyphicon glyphicon-minus\"></span>"));
            btn.ID = " " + id.ToString() + " " + "volume" + " " + "minus" + " " + deviceType + " " + roomId.ToString();
            PlaceHolder1.Controls.Add(btn);
            TextBox tb = new TextBox();
            tb.Attributes.Add("style", "width: 65px; text-align: center");
            tb.Attributes.Add("value", currentVolume.ToString());
            tb.ID = id.ToString() + " " + "volume" + " " + deviceType + " " + roomId.ToString();
            PlaceHolder1.Controls.Add(tb);
            Button btn2 = new Button();
            btn2.CssClass = "btn";
            btn2.Attributes.Add("style", "padding: 2 px, 7px");
            btn2.Text = "+";
            btn2.Click += ButtonClick;
            btn2.ID = " " + id.ToString() + " " + "volume" + " " + "plus" + " " + deviceType + " " + roomId.ToString();
            PlaceHolder1.Controls.Add(btn2);
        }
        private void ChannelDeviceBuilder(int id, string deviceType, int roomId, string currentChannel)
        {
            PlaceHolder1.Controls.Add(new LiteralControl("<h5 class=\"text-left\">Канал</h5>"));
            Button btn = new Button();
            btn.CssClass = "btn";
            btn.Attributes.Add("style", "padding: 2 px, 7px");
            btn.Text = "-";
            btn.Click += ButtonClick;
            btn.Controls.Add(new LiteralControl("<span class=\"glyphicon glyphicon-minus\"></span>"));
            btn.ID = " " + id.ToString() + " " + "channel" + " " + "minus" + " " + deviceType + " " + roomId.ToString();
            PlaceHolder1.Controls.Add(btn);
            TextBox tb = new TextBox();
            tb.Attributes.Add("style", "width: 65px; text-align: center");
            tb.Attributes.Add("value", currentChannel);
            tb.ID = id.ToString() + " " + "channel" + " " + deviceType + " " + roomId.ToString();
            PlaceHolder1.Controls.Add(tb);
            Button btn2 = new Button();
            btn2.CssClass = "btn";
            btn2.Attributes.Add("style", "padding: 2 px, 7px");
            btn2.Text = "+";
            btn2.Click += ButtonClick;
            btn2.ID = " " + id.ToString() + " " + "channel" + " " + "plus" + " " + deviceType + " " + roomId.ToString();
            PlaceHolder1.Controls.Add(btn2);
        }

        public void ButtonClick(object sender, EventArgs e)
        {
            string[] data = null;
            //if (sender is CheckBox)
            //{

            //}
            //else
            if (sender is Button)
            {
                Button btn = (Button)sender;
                data = btn.ID.Split(' ');
            }

            if (data[0] == "OnOff")
            {
                OnOffDevice(int.Parse(data[1]), data[2], int.Parse(data[3]));
                Device dev = FindDevice(int.Parse(data[1]), data[2]);
                if (dev.State)
                {
                    this.img.Attributes["src"] = this.img.Attributes["data-on"];
                }
                else
                {
                    this.img.Attributes["src"] = this.img.Attributes["data-off"];
                }
            }
            else
            if (data[1] == "delete")
            {
                Session["CurrentRoom"] = data[3];
                Session["CurrentDevice"] = data[0];
                Session["DeviceType"] = data[2];
                Response.Redirect("DeleteDevice.aspx");
            }
            else
            if (data[1] == "rename")
            {
                Session["CurrentRoom"] = data[3];
                Session["CurrentDevice"] = data[0];
                Session["DeviceType"] = data[2];
                Response.Redirect("RenameDevice.aspx");
            }
            else
            {
                int deviceId = int.Parse(data[1]);
                string property = data[2];
                bool action = false;
                if (data[3] == "plus")
                {
                    action = true;
                }
                else { }

                string deviceType = data[4];
                int roomId = int.Parse(data[5]);

                TextBox tb = (TextBox)this.PlaceHolder1.FindControl(deviceId.ToString() + " " + property + " " + deviceType + " " + roomId.ToString());
                tb.Text = RegulateDevice(property, action, deviceId, deviceType, roomId);
            }
        }

        
        private string RegulateDevice(string onChange, bool sign, int id, string type, int roomId)
        {
            using (SmartHouseContext context = new SmartHouseContext())
            {
                if (context.Conditioners.Any())
                {
                    if (type == context.Conditioners.FirstOrDefault().GetType().ToString())
                    {
                        Conditioner device = context.Conditioners.Find(id);
                        if (sign)
                        {
                            device.IncreeseTemperature();
                        }
                        else
                        {
                            device.DecreeseTemperature();
                        }
                        device.Room = context.Rooms.Find(roomId);
                        context.SaveChanges();
                        return device.CurrentTemperature.ToString();
                    }
                    else { }
                }
                else { }
                if (context.Exhausters.Any())
                {
                    if (type == context.Exhausters.FirstOrDefault().GetType().ToString())
                    {
                        Exhauster device = context.Exhausters.Find(id);
                        if (sign)
                        {
                            device.IncreesePower();
                        }
                        else
                        {
                            device.DecreesePower();
                        }
                        device.Room = context.Rooms.Find(roomId);
                        context.SaveChanges();
                        return device.CurrentPower.ToString();
                    }
                    else { }
                }
                else { }
                if (context.Fridges.Any())
                {
                    if (type == context.Fridges.FirstOrDefault().GetType().ToString())
                    {
                        Fridge device = context.Fridges.Find(id);
                        if (sign)
                        {
                            device.IncreeseTemperature();
                        }
                        else
                        {
                            device.DecreeseTemperature();
                        }
                        device.Room = context.Rooms.Find(roomId);
                        context.SaveChanges();
                        return device.CurrentTemperature.ToString();
                    }
                    else { }
                }
                else { }
                if (context.Lamps.Any())
                {
                    if (type == context.Lamps.FirstOrDefault().GetType().ToString())
                    {
                        Lamp device = context.Lamps.Find(id);
                        if (sign)
                        {
                            device.IncreeseBrightness();
                        }
                        else
                        {
                            device.DecreeseBrightness();
                        }
                        device.Room = context.Rooms.Find(roomId);
                        context.SaveChanges();
                        return device.CurrentBrightness.ToString();
                    }
                    else { }
                }
                else { }
                if (context.Radiators.Any())
                {
                    if (type == context.Radiators.FirstOrDefault().GetType().ToString())
                    {
                        Radiator device = context.Radiators.Find(id);
                        if (sign)
                        {
                            device.IncreeseTemperature();
                        }
                        else
                        {
                            device.DecreeseTemperature();
                        }
                        device.Room = context.Rooms.Find(roomId);
                        context.SaveChanges();
                        return device.CurrentTemperature.ToString();
                    }
                    else { }
                }
                if (context.StereoSystems.Any())
                {
                    if (type == context.StereoSystems.FirstOrDefault().GetType().ToString())
                    {
                        StereoSystem device = context.StereoSystems.Find(id);
                        if (sign)
                        {
                            device.IncreeseVolume();
                        }
                        else
                        {
                            device.DecreeseVolume();
                        }
                        device.Room = context.Rooms.Find(roomId);
                        context.SaveChanges();
                        return device.CurrentVolume.ToString();
                    }
                    else { }
                }
                else { }
                if (context.TVs.Any())
                {
                    if (type == context.TVs.FirstOrDefault().GetType().ToString())
                    {
                        TV device = context.TVs.Find(id);
                        if (onChange == "volume")
                        {
                            if (sign)
                            {
                                device.IncreeseVolume();
                            }
                            else
                            {
                                device.DecreeseVolume();
                            }
                        }
                        else
                        if (onChange == "channel")
                        {
                            if (sign)
                            {
                                device.NextChannel();
                            }
                            else
                            {
                                device.PrevChannel();
                            }
                        }
                        else
                        {
                            if (sign)
                            {
                                device.IncreeseBrightness();
                            }
                            else
                            {
                                device.DecreeseBrightness();
                            }
                        }
                        device.Room = context.Rooms.Find(roomId);
                        context.SaveChanges();
                        if (onChange == "volume")
                        {
                            return device.CurrentVolume.ToString();
                        }
                        else
                        if (onChange == "channel")
                        {
                            return device.GetCurrentChannelName();
                        }
                        else
                        {
                            return device.CurrentBrightness.ToString();
                        }
                    }
                    else { }
                }
                else { }
            }
            return null;
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
        private void OnOffDevice(int id, string type, int roomId)
        {
            using (SmartHouseContext context = new SmartHouseContext())
            {
                if (context.Alarms.Any())
                {
                    if (type == context.Alarms.FirstOrDefault().GetType().ToString())
                    {
                        Alarm device = context.Alarms.Find(id);
                        device.OnOff();
                        device.Room = context.Rooms.Find(roomId);
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
                        Conditioner device = context.Conditioners.Find(id);
                        device.OnOff();
                        device.Room = context.Rooms.Find(roomId);
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
                        Exhauster device = context.Exhausters.Find(id);
                        device.OnOff();
                        device.Room = context.Rooms.Find(roomId);
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
                        Fridge device = context.Fridges.Find(id);
                        device.OnOff();
                        device.Room = context.Rooms.Find(roomId);
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
                        Jalousie device = context.Jalousies.Find(id);
                        device.OnOff();
                        device.Room = context.Rooms.Find(roomId);
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
                        Lamp device = context.Lamps.Find(id);
                        device.OnOff();
                        device.Room = context.Rooms.Find(roomId);
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
                        Radiator device = context.Radiators.Find(id);
                        device.OnOff();
                        device.Room = context.Rooms.Find(roomId);
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
                        Router device = context.Routers.Find(id);
                        device.OnOff();
                        device.Room = context.Rooms.Find(roomId);
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
                        StereoSystem device = context.StereoSystems.Find(id);
                        device.OnOff();
                        device.Room = context.Rooms.Find(roomId);
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
                        TV device = context.TVs.Find(id);
                        device.OnOff();
                        device.Room = context.Rooms.Find(roomId);
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