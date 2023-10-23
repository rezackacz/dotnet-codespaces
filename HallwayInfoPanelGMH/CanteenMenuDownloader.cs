using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.Data.Common;
using System.Runtime.CompilerServices;

namespace HallwayInfoPanelGMH {
  internal class CanteenMenuDownloader {

    private string URL;
    private XDocument xml;

    public CanteenMenuDownloader(string URL) {
      this.URL = URL;

      this.xml = XDocument.Load(URL);

      XNode jidenicek = (XElement)xml.FirstNode;
    }

    public class Today {
      public List<Jidlo> dnesniJidla = new List<Jidlo>();
    }

    public class Jidlo {
      public string nazev { get; set; }
      public string druh { get; set; }
    }


    public static void Main(string[] args) {
      CanteenMenuDownloader downloader = new CanteenMenuDownloader("https://www.strava.cz/strava5/Jidelnicky/XML?zarizeni=0059");
      return;
    }
  }
}


