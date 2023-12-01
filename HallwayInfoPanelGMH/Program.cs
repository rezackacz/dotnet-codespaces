

using System.ComponentModel;
using Microsoft.VisualBasic;

namespace HallwayInfoPanelGMH {
  internal class Program {

    static List<Classroom> classrooms = new List<Classroom>();
    static bool doWeWantClassrooms = true;
    static BakaDataGatherer? timeTableDownloader = null;

    static void Main(string[] args) {
      try {
        string arg0 = args[0];
      } catch {
        Console.Error.WriteLine("Usage: HallwayInfoPanelGMH {prvni_patro|druhe_patro_rovne|druhe_patro_doprava}");
        return;
      }
      if (args[0] == "--help" || args[0] == "-h") { Console.Error.WriteLine("Usage: HallwayInfoPanelGMH.exe {prvni_patro|druhe_patro_rovne|druhe_patro_doprava}"); return; }
      int classroom_count;
      string[] classroom_dispNames;
      

      switch (args[0]) {
        case "prvni_patro":
          //123,125,126,127,128,129,131
          classroom_count = 6;
          classroom_dispNames = new string[] { "123", "125", "126", "127", "128", "129", "131" };
          for (int i = 0; i < classroom_count; i++) {
            classrooms[i] = new Classroom(i, classroom_dispNames[i]);
          }
          timeTableDownloader = new BakaDataGatherer(classrooms, "https://znamky.gmh.cz/");
          break;
        case "druhe_patro_rovne":
          //221,222,223,224,225
          classroom_count = 5;
          classroom_dispNames = new string[] { "221", "222", "223", "224", "225" };
          for (int i = 0; i < classroom_count; i++) {
            classrooms[i] = new Classroom(i, classroom_dispNames[i]);
          }
          timeTableDownloader = new BakaDataGatherer(classrooms, "https://znamky.gmh.cz/");
          break;
        case "druhe_patro_doprava":
          //219, 217, 213, 211, 210
          classroom_count = 5;
          classroom_dispNames = new string[] { "219", "217", "213", "211", "210" };
          for (int i = 0; i < classroom_count; i++) {
            classrooms[i] = new Classroom(i, classroom_dispNames[i]);
          }
          timeTableDownloader = new BakaDataGatherer(classrooms, "https://znamky.gmh.cz/");
          break;
        default:
          Console.Error.WriteLine("Usage: HallwayInfoPanelGMH {prvni_patro|druhe_patro_rovne|druhe_patro_doprava}");
          doWeWantClassrooms = false;
          break;

      }

      
      if (doWeWantClassrooms) classrooms = timeTableDownloader.getClassrooms(); else classrooms = null; GC.Collect();
      


      var jidloStahovac = new CanteenMenuDownloader("https://www.strava.cz/strava5/Jidelnicky/XML?zarizeni=0059");

      var foodRenderer = new HTMLRenderer(jidloStahovac);

      return;


    }
  }
}