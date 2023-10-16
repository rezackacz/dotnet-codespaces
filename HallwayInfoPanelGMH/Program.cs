

namespace HallwayInfoPanelGMH {
  internal class Program {
    static void Main(string[] args) {
      try {
        string arg0 = args[0];
      } catch {
        Console.WriteLine("Usage: HallwayInfoPanelGMH.exe {prvni_patro|druhe_patro_rovne|druhe_patro_doprava}");
        return;
      }
      if (args[0] == "--help" || args[0] == "-h") { Console.WriteLine("Usage: HallwayInfoPanelGMH.exe {prvni_patro|druhe_patro_rovne|druhe_patro_doprava}"); return; }
      int classroom_count;

      switch (args[0]) {
        case "prvni_patro":
          //123, 125, 126, 127, 128, 129, 131
          classroom_count = 6;
          string[] classroom_dispNames = { "123", "125", "126", "127", "128", "129", "131" };
          Classroom[] classrooms = new Classroom[classroom_count];
          for (int i = 0; i < classroom_count; i++) {
            classrooms[i] = new Classroom(i, classroom_dispNames[i]);
          }
          break;
        case "druhe_patro_rovne":
          //221, 222, 223, 224, 225
          classroom_count = 5;
          break;
        case "druhe_patro_doprava":
          //219, 217, 213, 211, 210
          classroom_count = 5;
          break;
        default:
          Console.Error.WriteLine("Usage: HallwayInfoPanelGMH.exe {prvni_patro|druhe_patro_rovne|druhe_patro_doprava}");
          break;
      }

    }
  }
}