using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ReadEvent readEvent = new ReadEvent();
            readEvent.ReadXML();

            AddEvent addEvent = new AddEvent();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 Form1 = new Form1();

            Console.WriteLine("Start of prog");
            foreach (var pair in readEvent.TweetDict)
            {

                Console.WriteLine("TWITTER");
                double longi = readEvent.TweetDict[pair.Key].Longi;
                double lat = readEvent.TweetDict[pair.Key].Lat;
                String text = readEvent.TweetDict[pair.Key].Text;
                String date = readEvent.TweetDict[pair.Key].DateTimeStamp;

                Bitmap twitterMarker = (Bitmap)Image.FromFile("img/twitterIcon.png");

                Form1.addMarker(lat, longi, text, date, twitterMarker);
            }

            foreach (var pair in readEvent.FacebookDict)
            {
                Console.WriteLine("FACEBOOK");
                double longi = readEvent.FacebookDict[pair.Key].Longi;
                double lat = readEvent.FacebookDict[pair.Key].Lat;
                String text = readEvent.FacebookDict[pair.Key].Text;
                String date = readEvent.FacebookDict[pair.Key].DateTimeStamp;

                Bitmap fbMarker = (Bitmap)Image.FromFile("img/fbIcon.png");

                Form1.addMarker(lat, longi, text, date, fbMarker);
            }

            foreach (var pair in readEvent.PhotoDict)
            {
                double longi = readEvent.PhotoDict[pair.Key].Longi;
                double lat = readEvent.PhotoDict[pair.Key].Lat;
                String text = readEvent.PhotoDict[pair.Key].FilePath;
                String date = "";
             

                Bitmap photoMarker = (Bitmap)Image.FromFile("img/photoIcon.png");

                Form1.addMarker(lat, longi, text, date, photoMarker);
            }

            foreach (var pair in readEvent.VideoDict)
            {
                double longi = readEvent.VideoDict[pair.Key].Longi;
                double lat = readEvent.VideoDict[pair.Key].Lat;
                String text = readEvent.VideoDict[pair.Key].FilePath;
                String date = "";


                Bitmap videoMarker = (Bitmap)Image.FromFile("img/vidIcon.png");

                Form1.addMarker(lat, longi, text, date, videoMarker);
            }

            foreach (var pair in readEvent.TrackLogDict)
            {
                Console.WriteLine("TRACKLOG");
                double longi = readEvent.TrackLogDict[pair.Key].Longi;
                double lat = readEvent.TrackLogDict[pair.Key].Lat;
                double longi2 = readEvent.TrackLogDict[pair.Key].Longi2;
                double lat2 = readEvent.TrackLogDict[pair.Key].Lat2;
                String text = readEvent.TrackLogDict[pair.Key].FilePath;
                //String date = "";


                Form1.addTracklog(lat, longi, lat2, longi2, text);
            }

            Application.Run(Form1);
        }
    }
}
