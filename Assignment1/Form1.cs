using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using GMap;
using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initMap();   
        }
        public void initMap()
        {

            map.MapProvider = GMapProviders.GoogleMap;
            map.ShowCenter = false;
            map.Position = new PointLatLng(1.3521, 103.8198);
            map.DragButton = MouseButtons.Right;
            map.MinZoom = 2;
            map.MaxZoom = 22;
            map.Zoom = 12;

            



        }

        public void addMarker(double lat, double longi, String text, String date, Bitmap img)
        {
            PointLatLng point = new PointLatLng(lat, longi);
            Console.WriteLine(lat + " \n" + longi);
            GMapMarker marker = new GMarkerGoogle(point, img);
            GMapOverlay markers = new GMapOverlay("Markers");
            if (!date.Equals(""))
            {
                marker.ToolTipText = $"Text: {text} \n Date: {date}";
            }
            else
            {
                marker.ToolTipText = $"file path: {text}";
            }

            var toolTip = new GMapToolTip(marker);
            marker.ToolTip.Fill = Brushes.Black;
            marker.ToolTip.Foreground = Brushes.White;
            marker.ToolTip.Stroke = Pens.Black;
            marker.ToolTip.TextPadding = new Size(30, 30);


            markers.Markers.Add(marker);
            map.Overlays.Add(markers);

        }

        public void addTracklog(double lat, double longi, double lat2, double longi2, String text)
        {
            GMapOverlay polygons = new GMapOverlay("polygons");
            List<PointLatLng> points = new List<PointLatLng>();
            points.Add(new PointLatLng(lat, longi));
            points.Add(new PointLatLng(lat2, longi2));
            GMapPolygon polygon = new GMapPolygon(points, "tracklog");

            polygon.Stroke = new Pen(Color.Red, 1);

            PointLatLng point = new PointLatLng(lat, longi);
            PointLatLng point2 = new PointLatLng(lat2, longi2);
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_pushpin);
            GMapMarker marker2 = new GMarkerGoogle(point2, GMarkerGoogleType.red_pushpin);
            GMapOverlay markers = new GMapOverlay("Markers");
            marker.ToolTipText = $"Tracklog Name: {text}";
            
            var toolTip = new GMapToolTip(marker);
            marker.ToolTip.Fill = Brushes.Black;
            marker.ToolTip.Foreground = Brushes.White;
            marker.ToolTip.Stroke = Pens.Black;
            marker.ToolTip.TextPadding = new Size(30, 30);


            markers.Markers.Add(marker);
            markers.Markers.Add(marker2);
            map.Overlays.Add(markers);
            polygons.Polygons.Add(polygon);
            map.Overlays.Add(polygons);

        }


        private void click(object sender, MouseEventArgs e)
        {
            var point = map.FromLocalToLatLng(e.X, e.Y);
            double lat = point.Lat;
            double longi = point.Lng;
            if(e.Button == MouseButtons.Left)
            {
                Form f = new Form2(longi, lat);
                f.Show();
            }

        }
    }
}
