using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Xml.Linq;


namespace HallwayInfoPanelGMH {
  internal class Program {

    static string bakaServerURL;
    static string stravaCzURL;

    static List<Classroom> classroomGroup1 = new List<Classroom>();
    static List<Classroom> classroomGroup2 = new List<Classroom>();
    static List<Classroom> classroomGroup3 = new List<Classroom>();
    static BakaDataGatherer? timeTableDownloader = null;

    static string htmlOutFolder;

    static void Main(string[] args) {

      if (args.Length < 1) { Console.WriteLine("Použití: HallwayInfoPanelGMH (cesta k config souboru)"); return; }

      XElement? config = XDocument.Load(args[0]).Element("InfopanelConfiguration");
      if (config == null) { throw new FileNotFoundException("konfiguracni soubor se nepovedlo nacist."); }

      stravaCzURL = config.Element("StravaURL").Value;
      htmlOutFolder = config.Element("HTMLFileFolder").Value;

      var jidloStahovac = new CanteenMenuDownloader(stravaCzURL);
      var foodRenderer = new HTMLRenderer(jidloStahovac, htmlOutFolder + "/jidelna.html");

      bakaServerURL = config.Element("BakalariURL").Value;

      
        




      //while (true) {
      //  jidloStahovac.update();
      //  foodRenderer.RenderAndSaveAsHTML(jidloStahovac);

      //  classrooms = classroom_downloader.getClassrooms();
      //  classroomRenderer.RenderAndSaveAsHTML(classroom_downloader.getClassrooms());
      //}

      return;


    }
  }
}