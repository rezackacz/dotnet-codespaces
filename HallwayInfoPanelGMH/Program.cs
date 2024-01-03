using System.Linq;
using System.Text.Json;


namespace HallwayInfoPanelGMH {
  internal class Program {

    const string bakaServerURL = "";
    const string stravaCzURL = "https://www.strava.cz/strava5/Jidelnicky/XML?zarizeni=0059";



    static List<Classroom> classrooms = new List<Classroom>();
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
            classrooms.Add(new Classroom(i, classroom_dispNames[i]));
          }
          timeTableDownloader = new BakaDataGatherer(classrooms, "http://co2.gmh.cz");
          break;
        case "druhe_patro_rovne":
          //221,222,223,224,225
          classroom_count = 5;
          classroom_dispNames = new string[] { "221", "222", "223", "224", "225" };
          for (int i = 0; i < classroom_count; i++) {
            classrooms.Add(new Classroom(i, classroom_dispNames[i]));
          }
          timeTableDownloader = new BakaDataGatherer(classrooms, "http://co2.gmh.cz");
          break;
        case "druhe_patro_doprava":
          //219, 217, 213, 211, 210
          classroom_count = 5;
          classroom_dispNames = new string[] { "219", "217", "213", "211", "210" };
          for (int i = 0; i < classroom_count; i++) {
            classrooms.Add(new Classroom(i, classroom_dispNames[i]));
          }
          timeTableDownloader = new BakaDataGatherer(classrooms, "http://co2.gmh.cz");
          break;
        default:
          Console.Error.WriteLine("Usage: HallwayInfoPanelGMH {prvni_patro|druhe_patro_rovne|druhe_patro_doprava}");
          break;

      }
      


      var jidloStahovac = new CanteenMenuDownloader(stravaCzURL);

      //var foodRenderer = new HTMLRenderer();

      BakaDataGatherer classroom_downloader = new BakaDataGatherer(classrooms, bakaServerURL);
     

      HTMLRenderer classroomRenderer = new HTMLRenderer(classrooms, "classlist.html");


      while (true){
        //jidloStahovac.update();
        //foodRenderer.RenderAndSaveAsHTML(jidloStahovac);

        classrooms = classroom_downloader.getClassrooms();
        classroomRenderer.RenderAndSaveAsHTML(classroom_downloader.getClassrooms()) ;
      }

      return;


    }
  }
}