
namespace HallwayInfoPanelGMH {
  internal class Program {
    static void Main(string[] args) {
      try{
        string arg0 = args[0];
      } catch {
        Console.WriteLine("Usage: HallwayInfoPanelGMH.exe <Hallway ID>");
        return;
      }
      if (args[0] == "--help" || args[0] == "-h") Console.WriteLine("Usage: HallwayInfoPanelGMH.exe <Hallway ID>"); return;


      
    }
  }
}