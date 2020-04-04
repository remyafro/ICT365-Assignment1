using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment1
{
    class ReadEvent
    {
        //Dictionary
        Dictionary<String, Tweet> tweetDict = new Dictionary<String, Tweet>();
        Dictionary<String, Facebook> facebookDict = new Dictionary<String, Facebook>();
        Dictionary<String, Photo> photoDict = new Dictionary<String, Photo>();
        Dictionary<String, Video> videoDict = new Dictionary<String, Video>();
        Dictionary<String, Tracklog> tracklogDict = new Dictionary<string, Tracklog>();

        public Dictionary<String, Tweet> TweetDict { get => tweetDict; set => tweetDict = value; }
        public Dictionary<String, Facebook> FacebookDict { get => facebookDict; set => facebookDict = value; }
        public Dictionary<String, Photo> PhotoDict { get => photoDict; set => photoDict = value; }
        public Dictionary<String, Video> VideoDict { get => videoDict; set => videoDict = value; }
        public Dictionary<String, Tracklog> TrackLogDict { get => tracklogDict; set => tracklogDict = value; }

        public void ReadXML()
        {
            XNamespace lle = "http://www.xyz.org/lifelogevents";

            var filePath = "..\\..\\lifelogevents.xml";

            XElement lifelogxml = XElement.Load(filePath);
            IEnumerable<XElement> eList = lifelogxml.Elements();

            //Adding each event element
            foreach (var e1 in eList.Descendants(lle + "Event"))
            {
                //if tweet
                foreach (var e2 in e1.Descendants(lle + "tweet"))
                {
                    double lat = 000;
                    double longi = 000;
                    foreach (var e3 in e1.Descendants(lle + "location"))
                    {
                        lat = Double.Parse(e3.Element(lle + "lat").Value.Replace(',', '.'), CultureInfo.InvariantCulture);
                        longi = Double.Parse(e3.Element(lle + "long").Value.Replace(',', '.'), CultureInfo.InvariantCulture);
                    }
                    //Console.WriteLine(e1.Element(lle + "eventid").Value + "\n" + e2.Element(lle + "text" ).Value);
                    Tweet tweetEv = new Tweet(e1.Element(lle + "eventid").Value, e2.Element(lle + "text").Value, lat, longi, e2.Element(lle + "datetimestamp").Value);

                    TweetDict.Add(e1.Element(lle + "eventid").Value, tweetEv);
                }

                //if facebook
                foreach (var e2 in e1.Descendants(lle + "facebook-status"))
                {
                    double lat = 000;
                    double longi = 000;
                    foreach (var e3 in e1.Descendants(lle + "location"))
                    {
                        lat = Double.Parse(e3.Element(lle + "lat").Value.Replace(',', '.'), CultureInfo.InvariantCulture);
                        longi = Double.Parse(e3.Element(lle + "long").Value.Replace(',', '.'), CultureInfo.InvariantCulture);
                    }
                    Facebook facebookEv = new Facebook(
               e1.Element(lle + "eventid").Value,
                       e2.Element(lle + "text").Value,
                       lat,
                        longi,
                        e2.Element(lle + "datetimestamp").Value);

                    FacebookDict.Add(e1.Element(lle + "eventid").Value, facebookEv);
                }

                foreach (var e2 in e1.Descendants(lle + "photo"))
                {
                    double lat = 000;
                    double longi = 000;
                    foreach (var e3 in e1.Descendants(lle + "location"))
                    {
                        lat = Double.Parse(e3.Element(lle + "lat").Value.Replace(',', '.'), CultureInfo.InvariantCulture);
                        longi = Double.Parse(e3.Element(lle + "long").Value.Replace(',', '.'), CultureInfo.InvariantCulture);
                    }
                    Photo photoEv = new Photo(e1.Element(lle + "eventid").Value, e2.Element(lle + "filepath").Value, lat, longi);

                    PhotoDict.Add(e1.Element(lle + "eventid").Value, photoEv);
                }

                foreach (var e2 in e1.Descendants(lle + "video"))
                {
                    double lat = 000;
                    double longi = 000;
                    foreach (var e3 in e1.Descendants(lle + "location"))
                    {
                        lat = Double.Parse(e3.Element(lle + "lat").Value.Replace(',', '.'), CultureInfo.InvariantCulture);
                        longi = Double.Parse(e3.Element(lle + "long").Value.Replace(',', '.'), CultureInfo.InvariantCulture);
                    }
                    Video videoEv = new Video(e1.Element(lle + "eventid").Value, e2.Element(lle + "filepath").Value, lat, longi);

                    VideoDict.Add(e1.Element(lle + "eventid").Value, videoEv);
                }

                foreach (var e2 in e1.Descendants(lle + "tracklog"))
                {
                    double lat = 000;
                    double longi = 000;
                    double lat2 = 0;
                    double longi2 = 0;

                    foreach (var e3 in e1.Descendants(lle + "location"))
                    {
                        lat = Double.Parse(e3.Element(lle + "lat").Value.Replace(',', '.'), CultureInfo.InvariantCulture);
                        longi = Double.Parse(e3.Element(lle + "long").Value.Replace(',', '.'), CultureInfo.InvariantCulture);
                        lat2 = Double.Parse(e3.Element(lle + "lat2").Value.Replace(',', '.'), CultureInfo.InvariantCulture);
                        longi2 = Double.Parse(e3.Element(lle + "longi2").Value.Replace(',', '.'), CultureInfo.InvariantCulture);
                    }

                    Tracklog tracklogEv = new Tracklog(e1.Element(lle + "eventid").Value, e2.Element(lle + "filepath").Value, lat, longi, lat2, longi2);

                    tracklogDict.Add(e1.Element(lle + "eventid").Value, tracklogEv);
                }

            }

        }
    }

}
