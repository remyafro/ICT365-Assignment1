using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Tweet
    {
        private String eventID;
        private String text;
        private double lat;
        private double longi;
        private String dateTimeStamp;

        public Tweet(String eventID, String text, double lat, double longi, String dateTimeStamp)
        {
            this.eventID = eventID;
            this.text = text;
            this.lat = lat;
            this.longi = longi;
            this.dateTimeStamp = dateTimeStamp;
        }

        public String EventID
        {
            get { return eventID; }
            set { eventID = value; }
        }

        public String Text
        {
            get { return text; }
            set { text = value; }
        }

        public double Lat
        {
            get { return lat; }
            set { lat = value; }
        }

        public double Longi
        {
            get { return longi; }
            set { longi = value; }
        }

        public String DateTimeStamp
        {
            get { return dateTimeStamp; }
            set { dateTimeStamp = value; }
        }
        public override string ToString()
        {
            return eventID + " " + text + " " + lat + " " + longi + " " + dateTimeStamp;
        }
    }

    class Facebook
    {
        private String eventID;
        private String text;
        private double lat;
        private double longi;
        private String dateTimeStamp;

        public Facebook(String eventID, String text, double lat, double longi, String dateTimeStamp)
        {
            this.eventID = eventID;
            this.text = text;
            this.lat = lat;
            this.longi = longi;
            this.dateTimeStamp = dateTimeStamp;
        }

        public String EventID
        {
            get { return eventID; }
            set { eventID = value; }
        }

        public String Text
        {
            get { return text; }
            set { text = value; }
        }

        public double Lat
        {
            get { return lat; }
            set { lat = value; }
        }

        public double Longi
        {
            get { return longi; }
            set { longi = value; }
        }

        public String DateTimeStamp
        {
            get { return dateTimeStamp; }
            set { dateTimeStamp = value; }
        }
        public override string ToString()
        {
            return eventID + " " + text + " " + lat + " " + longi + " " + dateTimeStamp;
        }
    }

    class Photo
    {
        private String eventID;
        private String filePath;
        private double lat;
        private double longi;

        public Photo(String eventID, String filePath, double lat, double longi)
        {
            this.eventID = eventID;
            this.filePath = filePath;
            this.lat = lat;
            this.longi = longi;
        }

        public String EventID
        {
            get { return eventID; }
            set { eventID = value; }
        }

        public String FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }

        public double Lat
        {
            get { return lat; }
            set { lat = value; }
        }

        public double Longi
        {
            get { return longi; }
            set { longi = value; }
        }

        public override string ToString()
        {
            return eventID + " " + filePath + " " + lat + " " + longi;
        }

    }

    class Video
    {
        private String eventID;
        private String filePath;
        private double lat;
        private double longi;

        public Video(String eventID, String filePath, double lat, double longi)
        {
            this.eventID = eventID;
            this.filePath = filePath;
            this.lat = lat;
            this.longi = longi;
        }

        public String EventID
        {
            get { return eventID; }
            set { eventID = value; }
        }

        public String FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }

        public double Lat
        {
            get { return lat; }
            set { lat = value; }
        }

        public double Longi
        {
            get { return longi; }
            set { longi = value; }
        }

        public override string ToString()
        {
            return eventID + " " + filePath + " " + lat + " " + longi;
        }

    }

    class Tracklog
    {
        private String eventID;
        private String filePath;
        private String data;
        private String[] dataPoints;
        private double lat;
        private double longi;
        private double lat2;
        private double longi2;


        public Tracklog(String eventID, String filePath, double lat, double longi, double lat2, double longi2)
        {
            this.eventID = eventID;
            this.filePath = filePath;
            this.lat = lat;
            this.longi = longi;
            this.lat2 = lat2;
            this.longi2 = longi2;
        }

        public String EventID
        {
            get { return eventID; }
            set { eventID = value; }
        }

        public String FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }

        public double Lat
        {
            get { return lat; }
            set { lat = value; }
        }

        public double Longi
        {
            get { return longi; }
            set { longi = value; }
        }

        public double Lat2
        {
            get { return lat2; }
            set { lat2 = value; }
        }

        public double Longi2
        {
            get { return longi2; }
            set { longi2 = value; }
        }

        public override string ToString()
        {
            return eventID + " " + filePath + " " + lat + " " + longi + " " + lat2 + " " + longi2;
        }

    }
}
