using SmartHouse_WebForms.Models.Classes;
using SmartHouse_WebForms.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartHouse_WebForms
{
    public partial class CreateDevice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                    int currentRoomId = int.Parse(Session["CurrentRoom"].ToString());
                    string deviceType = DeviceList.SelectedValue;
                    string lampType = LampTypeList.SelectedValue;
                    string name = InputForName.Text;
                    CreateNewDevice(deviceType, lampType, name);
                    Response.Redirect("RoomInfo.aspx");
            }
            else
            {
                CreateSelectItemList();
            }
        }

        private void CreateNewDevice(string type, string lampType, string name)
        {
            using (SmartHouseContext context = new SmartHouseContext())
            {
                int id = int.Parse(Session["CurrentRoom"].ToString());
                switch (type)
                {
                    case "Alarm":
                        Alarm newAlarm = new Alarm(name);
                        context.Rooms.FirstOrDefault(d => d.Id == id).Alarm.Add(newAlarm);
                        break;
                    case "Conditioner":
                        Conditioner newConditioner = new Conditioner(name);
                        context.Rooms.FirstOrDefault(d => d.Id == id).Conditioner.Add(newConditioner);
                        break;
                    case "Exhauster":
                        Exhauster newExhauster = new Exhauster(name);
                        context.Rooms.FirstOrDefault(d => d.Id == id).Exhauster.Add(newExhauster);
                        break;
                    case "Fridge":
                        Fridge newFridge = new Fridge(name);
                        context.Rooms.FirstOrDefault(d => d.Id == id).Fridge.Add(newFridge);
                        break;
                    case "Jalousie":
                        Jalousie newJalousie = new Jalousie(name);
                        context.Rooms.FirstOrDefault(d => d.Id == id).Jalousie.Add(newJalousie);
                        break;
                    case "Lamp":
                        Lamp newLamp = new Lamp(name, lampType);
                        context.Rooms.FirstOrDefault(d => d.Id == id).Lamp.Add(newLamp);
                        break;
                    case "Radiator":
                        Radiator newRadiator = new Radiator(name);
                        context.Rooms.FirstOrDefault(d => d.Id == id).Radiator.Add(newRadiator);
                        break;
                    case "Router":
                        Router newRouter = new Router(name);
                        context.Rooms.FirstOrDefault(d => d.Id == id).Router.Add(newRouter);
                        break;
                    case "StereoSystem":
                        StereoSystem newStereoSystem = new StereoSystem(name);
                        context.Rooms.FirstOrDefault(d => d.Id == id).StereoSystem.Add(newStereoSystem);
                        break;
                    case "TV":
                        TV newTV = new TV(name);
                        context.Rooms.FirstOrDefault(d => d.Id == id).TV.Add(newTV);
                        break;
                    default:
                        Alarm newAlarma = new Alarm(name);
                        context.Rooms.FirstOrDefault(d => d.Id == id).Alarm.Add(newAlarma);
                        break;
                }
                context.SaveChanges();
            }
        }
        private void CreateSelectItemList()
        {
            DeviceList.Items.Add( new ListItem{ Text = "Сигнализация", Value = "Alarm"});
            DeviceList.Items.Add(new ListItem { Text = "Кондиционер", Value = "Conditioner" });
            DeviceList.Items.Add(new ListItem { Text = "Вытяжка", Value = "Exhauster" });
            DeviceList.Items.Add(new ListItem { Text = "Холодильник", Value = "Fridge" });
            DeviceList.Items.Add(new ListItem { Text = "Жалюзи", Value = "Jalousie" });
            DeviceList.Items.Add(new ListItem { Text = "Лампа", Value = "Lamp", Selected = true });
            DeviceList.Items.Add(new ListItem { Text = "Батарея", Value = "Radiator" });
            DeviceList.Items.Add(new ListItem { Text = "Роутер", Value = "Router" });
            DeviceList.Items.Add(new ListItem { Text = "Стерео система", Value = "StereoSystem" });
            DeviceList.Items.Add(new ListItem { Text = "Телевизор", Value = "TV" });
            

            LampTypeList.Items.Add( new ListItem { Text = "Настольная", Value = LampTypes.Table.ToString() });
            LampTypeList.Items.Add(new ListItem { Text = "Настенная", Value = LampTypes.Wall.ToString() });
            LampTypeList.Items.Add(new ListItem { Text = "Напольная", Value = LampTypes.Floor.ToString() });
            LampTypeList.Items.Add(new ListItem { Text = "Люстра", Value = LampTypes.Chandelier.ToString() });
        }

    }
}