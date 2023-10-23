using System.Linq;
using System.Xml.Linq;

namespace HallwayInfoPanelGMH {
  public class CanteenMenuDownloader {

    private string URL;
    private XDocument xml;
    private XElement today;

    public string PageTitle;

    public CanteenMenuDownloader(string URL) {
      this.URL = URL;

      try {
        this.xml = XDocument.Load(URL);
        XElement today = xml.Element("den");
      } catch (Exception e) {
        Console.Error.WriteLine("Couldn't load canteen's menu");
        PageTitle = "Jídelníček nemohl být načten.";
        Console.Error.WriteLine(e.Message);
      } finally {
        xml = XDocument.Load(URL);
        this.today = xml.Element("den");
      }
      string date = DateTime.Now.ToString("dd-MM-yyyy");

      if (!(today.Attribute("datum").Value.Equals(date))) {
        PageTitle = "Dnešní jídelníček neexistuje v databázi.";
      } else {
        PageTitle = "Jídelníček";
      }

    }

    public class Today {
      public List<Jidlo> dnesniJidla = new List<Jidlo>();
    }

    public class Jidlo {
      public string nazev { get; set; }
      public string druh { get; set; }
    }



  }
}


