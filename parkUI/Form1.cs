using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace parkUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int locNum = 0;
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (localSelect.Text == "Emerson Street")
            {
                //change image to mcmaster innovation park
                //update parking status
                statusLabel.Text = "Mostly Full";
                statusLabel.ForeColor = Color.Orange;
                locNum = 1;
                mapPicture.Image = parkUI.Properties.Resources.Image1;
            }
            else if (localSelect.Text == "Downtown King St.")
            {
                //change image to mcmaster innovation park
                //update parking status
                statusLabel.Text = "Mostly Available";
                statusLabel.ForeColor = Color.Lime;
                locNum = 2;
                mapPicture.Image = parkUI.Properties.Resources.kingSt_;
            }
            else if (localSelect.Text == "McMaster Innovation Park")
            {
                //change image to mcmaster innovation park
                //update parking 
                statusLabel.Text = "Available";
                statusLabel.ForeColor = Color.GreenYellow;
                locNum = 3;
                mapPicture.Image = parkUI.Properties.Resources.kingSt_;
            }
            
            else if (localSelect.Text == "Westdale Public Parking")
            {
                //change image to mcmaster innovation park
                //update parking status
                statusLabel.Text = "Full";
                statusLabel.ForeColor = Color.Red;
                locNum = 4;
                mapPicture.Image = parkUI.Properties.Resources.kingSt_;
            }
            else
            {
                statusLabel.ForeColor = Color.Black;
                statusLabel.Text = "Select valid location";
                locNum = 0;
                mapPicture.Visible = false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }
        private void VisitLink()
        {
            //Change the color of the link text by setting LinkVisited
             //to true.
            linkLabel1.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
            switch (locNum)
            {
                case 0:
                    System.Diagnostics.Process.Start("https://www.google.com/maps/@43.2585902,-79.9098796,14z");
                    break;
                case 1:
                    System.Diagnostics.Process.Start("https://www.google.com/maps/place/Emerson+St+%26+Main+St+W,+Hamilton,+ON+L8S+2X3/@43.2577205,-79.921733,17z/data=!3m1!4b1!4m5!3m4!1s0x882c84b2cd62a705:0x3f36c88de3765be9!8m2!3d43.2577205!4d-79.919539");
                    break;
                case 2:
                    System.Diagnostics.Process.Start("https://www.google.com/maps/place/James+St+N+%26+King+St+W,+Hamilton,+ON+L8N+4A9/@43.256687,-79.8712529,17z/data=!3m1!4b1!4m5!3m4!1s0x882c9b8363caaadb:0xd80c82fb392b0d19!8m2!3d43.256687!4d-79.8690589");
                    break;
                case 3:
                    System.Diagnostics.Process.Start("https://www.google.com/maps/place/McMaster+Innovation+Park/@43.2569618,-79.9030148,17z/data=!3m1!4b1!4m5!3m4!1s0x882c9b436c3d0fc7:0xace89ae4989d82dc!8m2!3d43.2569618!4d-79.9008208");
                    break;
                case 4:
                    System.Diagnostics.Process.Start("https://www.google.com/maps/place/Westdale+South,+Hamilton,+ON/@43.2617393,-79.9062534,18.17z/data=!4m5!3m4!1s0x882c9b5bb0fdce01:0x692f944ac5c646ea!8m2!3d43.2607343!4d-79.9052768");
                    break;
                default:
                    break;
            }
            //System.Diagnostics.Process.Start("https://www.google.com/maps/@43.2585902,-79.9098796,14z");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            weatherLabel.Text = "Partly Cloudy";
            pictureBox1.Image = parkUI.Properties.Resources.partlyCloudy;
        }

        
    }
}
