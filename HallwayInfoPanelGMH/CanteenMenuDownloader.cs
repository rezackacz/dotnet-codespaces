using System.Linq;
using System.Xml.Linq;

namespace HallwayInfoPanelGMH
{
  public class CanteenMenuDownloader
  {
    /********************************
    věci které jsou relevantní v této classe jsou tady nahoře.
    (myslím těch 5 objektů Jidlo)
    co je který zač je snad jasné
    ********************************/

    Jidlo polevka;
    Jidlo jidlo1;
    Jidlo jidlo2;
    Jidlo jidlo3;
    Jidlo doplnek;


    private string URL;
    private XDocument xml;
    private XElement today;

    public string PageTitle;
    public List<Jidlo> dnesniJidla = new List<Jidlo>();

    public CanteenMenuDownloader(string URL)
    {
      this.URL = URL;

      try
      {
        this.xml = XDocument.Load(URL);
        XElement today = xml.Element("den");
      }
      catch (Exception e)
      {
        Console.Error.WriteLine("Couldn't load canteen's menu");
        PageTitle = "Jídelníček nemohl být načten.";
        Console.Error.WriteLine(e.Message);
      }
      finally
      {
        xml = XDocument.Load(URL);
        this.today = xml.Element("den");
      }
      string date = DateTime.Now.ToString("dd-MM-yyyy");

      if (!(today.Attribute("datum").Value.Equals(date))) {
        PageTitle = "Dnešní jídelníček neexistuje v databázi.";
        Console.Error.WriteLine("Error: today's menu doesn't exist in database.");

      } else {
        Jidlo polevka = vyfiltruj(today, "Polévka "); //soup gets the ID 0, because WHY THE F*CK NOT
        //pokud tyhle komentáře čtete během opravování této práce tak je prosím neřešte, nemám rád filtrování XML


      }

    }

    private static Jidlo vyfiltruj(XElement today, string druh) {
      Jidlo vysledek = new Jidlo();
      XElement xElement = today.Elements("jidlo").First(food => food.Attribute("druh").Value == druh);
      vysledek.druh = druh;
      vysledek.nazev = xElement.Attribute("nazev").Value;
      return vysledek;
    }



    public class Jidlo
    {
      public int ID;
      public string nazev { get; set; }
      public string druh { get; set; }

      public Jidlo()
      {
        
      }



    }

    private string stahniJidlo(int cislo)
    {
      switch (cislo)
      {
        case 1:
          today.Element("");
          ;
          return ("");

        case 2:
          return ("");

        case 3:
          return ("");

        default:
          return ("");


      }
    }

  }
}


