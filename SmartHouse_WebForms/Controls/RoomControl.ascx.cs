using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SmartHouse_WebForms;

namespace SmartHouse_WebForms.Controlls
{
    public partial class RoomControl : System.Web.UI.UserControl
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public void Initialize(string name, int id)
        {
            this.Label1.Text = "<h3 class=\"text-center\">" + name + "</h3>";
            this.ImageButton1.ImageUrl = "/Content/Images/door.jpg";
            this.ImageButton1.ID = "open " + id;
            this.ImageButton1.Click += ButtonClick;
            this.RenameButton.ID = "rename " + id;
            this.RenameButton.Click += ButtonClick;
            this.DeleteButton.ID = "delete " + id;
            this.DeleteButton.Click += ButtonClick;
        }

        public void ButtonClick(object sender, EventArgs e)
        {
            string[] data = null;
            if (sender is Button)
            {
                Button btn = (Button)sender;
                data = btn.ID.Split(' ');
            }
            else
            if (sender is ImageButton)
            {
                ImageButton btn = (ImageButton)sender;
                data = btn.ID.Split(' ');
            }
            else { }

            Session["CurrentRoom"] = data[1];
            if (data[0] == "delete")
            {
                Response.Redirect("DeleteRoom.aspx");
            }
            else
            if (data[0] == "rename")
            {
                Response.Redirect("RenameRoom.aspx");
            }
            else
            if (data[0] == "open")
            {
                Response.Redirect("RoomInfo.aspx");
            }
            else { }
        }
    }
}