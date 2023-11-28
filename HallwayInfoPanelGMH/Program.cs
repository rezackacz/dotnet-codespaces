

namespace HallwayInfoPanelGMH {
  internal class Program {
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
      Classroom[] classrooms;

      switch (args[0]) {
        case "prvni_patro":
          //123,125,126,127,128,129,131
          classroom_count = 6;
          classroom_dispNames = new string[] { "123", "125", "126", "127", "128", "129", "131" };
          classrooms = new Classroom[classroom_count];
          for (int i = 0; i < classroom_count; i++) {
            classrooms[i] = new Classroom(i, classroom_dispNames[i]);
          }
          break;
        case "druhe_patro_rovne":
          //221,222,223,224,225
          classroom_count = 5;
          classroom_dispNames = new string[] { "221", "222", "223", "224", "225" };
          classrooms = new Classroom[classroom_count];
          for (int i = 0; i < classroom_count; i++) {
            classrooms[i] = new Classroom(i, classroom_dispNames[i]);
          }
          break;
        case "druhe_patro_doprava":
          //219, 217, 213, 211, 210
          classroom_count = 5;
          classroom_dispNames = new string[] { "219", "217", "213", "211", "210" };
          classrooms = new Classroom[classroom_count];
          for (int i = 0; i < classroom_count; i++) {
            classrooms[i] = new Classroom(i, classroom_dispNames[i]);
          }
          break;
        default:
          Console.Error.WriteLine("Usage: HallwayInfoPanelGMH {prvni_patro|druhe_patro_rovne|druhe_patro_doprava}");
          break;
      }

      CanteenMenuDownloader jidloStahovac = new CanteenMenuDownloader("https://www.strava.cz/strava5/Jidelnicky/XML?zarizeni=0059");

      return;


    }
  }
}