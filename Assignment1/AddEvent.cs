using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment1
{
    class AddEvent
    {
        XNamespace lle = "http://www.xyz.org/lifelogevents";
        XNamespace soapENV = "http://www.w3.org/2001/12/soap-envelope";

        String filePath = "..\\..\\lifelogevents.xml";
        String lastID = "";

        public void AddTweet(String text, String date, double mouseX, double mouseY)
        {
            //retrieve file and load
            XElement lifelogxml = XElement.Load(filePath);

            var events = lifelogxml.Descendants(lle + "Event").Reverse().Take(1);

            foreach(var evs in events)
            {
                lastID = evs.Element(lle + "eventid").Value;
            }

            var newIDNum = Int16.Parse(lastID.Substring(lastID.Length - 2, 2)) + 1;
            var newID = ("ID" + newIDNum);

            var newEvent = new XElement(lle + "Event",
                           new XElement(lle + "eventid", newID),
                           new XElement(lle + "tweet",
                           new XElement(lle + "text", text),
                           new XElement(lle + "location",
                           new XElement(lle + "lat", mouseY),
                           new XElement(lle + "long", mouseX)),
                           new XElement(lle + "datetimestamp", date)));

            

            lifelogxml.Descendants(soapENV + "Body").Single().Add(newEvent);
            lifelogxml.Save(filePath);

        }

        public void AddFacebook(String text, String date, double mouseX, double mouseY)
        {
            //retrieve file and load
            XElement lifelogxml = XElement.Load(filePath);

            var events = lifelogxml.Descendants(lle + "Event").Reverse().Take(1);

            foreach (var evs in events)
            {
                lastID = evs.Element(lle + "eventid").Value;
            }

            var newIDNum = Int16.Parse(lastID.Substring(lastID.Length - 2, 2)) + 1;
            var newID = ("ID" + newIDNum);

            var newEvent = new XElement(lle + "Event",
                           new XElement(lle + "eventid", newID),
                           new XElement(lle + "facebook-status",
                           new XElement(lle + "text", text),
                           new XElement(lle + "location",
                           new XElement(lle + "lat", mouseY),
                           new XElement(lle + "long", mouseX)),
                           new XElement(lle + "datetimestamp", date)));

            lifelogxml.Descendants(soapENV + "Body").Single().Add(newEvent);
            lifelogxml.Save(filePath);

        }

        public void AddPhoto(String text, double mouseX, double mouseY)
        {
            //retrieve file and load
            XElement lifelogxml = XElement.Load(filePath);

            var events = lifelogxml.Descendants(lle + "Event").Reverse().Take(1);

            foreach (var evs in events)
            {
                lastID = evs.Element(lle + "eventid").Value;
            }

            var newIDNum = Int16.Parse(lastID.Substring(lastID.Length - 2, 2)) + 1;
            var newID = ("ID" + newIDNum);

            var newEvent = new XElement(lle + "Event",
                           new XElement(lle + "eventid", newID),
                           new XElement(lle + "photo",
                           new XElement(lle + "filepath", text),
                           new XElement(lle + "location",
                           new XElement(lle + "lat", mouseY),
                           new XElement(lle + "long", mouseX))));

            lifelogxml.Descendants(soapENV + "Body").Single().Add(newEvent);
            lifelogxml.Save(filePath);

        }
        public void AddVideo(String text, double mouseX, double mouseY)
        {
            //retrieve file and load
            XElement lifelogxml = XElement.Load(filePath);

            var events = lifelogxml.Descendants(lle + "Event").Reverse().Take(1);

            foreach (var evs in events)
            {
                lastID = evs.Element(lle + "eventid").Value;
            }

            var newIDNum = Int16.Parse(lastID.Substring(lastID.Length - 2, 2)) + 1;
            var newID = ("ID" + newIDNum);

            var newEvent = new XElement(lle + "Event",
                           new XElement(lle + "eventid", newID),
                           new XElement(lle + "video",
                           new XElement(lle + "filepath", text),
                           new XElement(lle + "location",
                           new XElement(lle + "lat", mouseY),
                           new XElement(lle + "long", mouseX))));

            lifelogxml.Descendants(soapENV + "Body").Single().Add(newEvent);
            lifelogxml.Save(filePath);

        }

        public void AddTrackLog(String text, double mouseX, double mouseY, String lat2, String longi2)
        {
            //retrieve file and load
            XElement lifelogxml = XElement.Load(filePath);

            var events = lifelogxml.Descendants(lle + "Event").Reverse().Take(1);

            foreach (var evs in events)
            {
                lastID = evs.Element(lle + "eventid").Value;
            }

            var newIDNum = Int16.Parse(lastID.Substring(lastID.Length - 2, 2)) + 1;
            var newID = ("ID" + newIDNum);

            var newEvent = new XElement(lle + "Event",
                           new XElement(lle + "eventid", newID),
                           new XElement(lle + "tracklog",
                           new XElement(lle + "filepath", text),
                           new XElement(lle + "location",
                           new XElement(lle + "lat", mouseY),
                           new XElement(lle + "long", mouseX),
                           new XElement(lle + "lat2", lat2),
                           new XElement(lle + "longi2", longi2))));

            lifelogxml.Descendants(soapENV + "Body").Single().Add(newEvent);
            lifelogxml.Save(filePath);
        }
    }
}
