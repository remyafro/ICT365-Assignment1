using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form2 : Form
    {
        private double mouseX;
        private double mouseY;
        private String eventType = "twitter";
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(double mouseX, double mouseY)
        {
            InitializeComponent();
            this.mouseX = mouseX;
            this.mouseY = mouseY;
        }

        public String EventType
        {
            get { return eventType; }
            set { eventType = value; }
        }

        public double MouseX
        {
            get { return mouseX; }
            set { mouseX = value; }
        }

        public double MouseY
        {
            get { return mouseY; }
            set { mouseY = value; }
        }

        private void fbChecked(object sender, EventArgs e)
        {
            panelTwitter.Visible = false;
            panelPhoto.Visible = false;
            panelVideo.Visible = false;
            panelTrackLog.Visible = false;

            panelFb.Visible = true;
            panelFb.BringToFront();

            eventType = "facebook";

            String a = mouseX.ToString();
            String b = mouseY.ToString();

        }

        private void tweetChecked(object sender, EventArgs e)
        {
            panelFb.Visible = false;
            panelPhoto.Visible = false;
            panelVideo.Visible = false;
            panelTrackLog.Visible = false;

            panelTwitter.Visible = true;
            panelTwitter.BringToFront();

            eventType = "twitter";
        }

        private void photoChecked(object sender, EventArgs e)
        {
            panelFb.Visible = false;
            panelTwitter.Visible = false;
            panelVideo.Visible = false;
            panelTrackLog.Visible = false;

            panelPhoto.Visible = true;
            panelPhoto.BringToFront();

            eventType = "photo";
        }

        private void videoChecked(object sender, EventArgs e)
        {
            panelFb.Visible = false;
            panelTwitter.Visible = false;
            panelPhoto.Visible = false;
            panelTrackLog.Visible = false;

            panelVideo.Visible = true;
            panelVideo.BringToFront();

            eventType = "video";
        }

        private void tracklogChecked(object sender, EventArgs e)
        {
            panelFb.Visible = false;
            panelTwitter.Visible = false;
            panelVideo.Visible = false;
            panelPhoto.Visible = false;

            panelTrackLog.Visible = true;
            panelTrackLog.BringToFront();

            eventType = "tracklog";
        }

        private void cancelBtnClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtnClick(object sender, EventArgs e)
        {
            AddEvent addEvent = new AddEvent();
            if(eventType == "twitter")
            {
                
                addEvent.AddTweet(textTwitterText.Text, textTwitterDate.Text, MouseX, MouseY);
                Application.Restart();
                Console.WriteLine("RESTART");
            }
            else if(eventType == "facebook")
            {
                addEvent.AddFacebook(textFbText.Text, textFbDate.Text, MouseX, MouseY);
                Application.Restart();
            }
            else if(eventType == "photo")
            {
                addEvent.AddPhoto(textPhotoFilePath.Text, MouseX, MouseY);
                Application.Restart();
            }
            else if (eventType == "video")
            {
                addEvent.AddVideo(textBoxVideoFilePath.Text, MouseX, MouseY);
                Application.Restart();
            }
            else if (eventType == "tracklog")
            {
                addEvent.AddTrackLog(textBoxFilepathTracklog.Text, MouseX, MouseY, textBoxLat2Tracklog.Text, textBoxLongi2Tracklog.Text);
                Application.Restart();
            }
            else
            {
                this.Close();
            }
        }



    }
}
