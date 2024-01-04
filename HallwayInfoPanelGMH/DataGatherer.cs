using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HallwayInfoPanelGMH {
  public class BakaDataGatherer {

    int classroom_count;
    List<Classroom> classooms_copy;

    public BakaDataGatherer(List<Classroom> classrooms, string bakaServerURL) {

      XElement? roomListXML = XDocument.Load(bakaServerURL + "/b/common/rooms").Element("BakalariDataInterface");

      XElement? roomsXElement = roomListXML?.Elements().First(element => element.Name == "Rooms");


      foreach (Classroom classroom in classrooms) {

        classroom.bakaID = roomsXElement?.Descendants()?.First(room => (room?.Element("Abbrev")?.Value) == classroom.dispName)?.Element("ID")?.Value;
        classroom.roomURL = bakaServerURL + "/b/timetable/actual/room/" + classroom.bakaID;

        XElement timetable = XDocument.Load(classroom.roomURL).Element("BakalariDataInterface").Element("Cells");
        //TODO: get the specific timetable element we need


        classroom.subject = "";
        classroom.currentTeacher = "";
        classroom.currentPeople = "";

        classroom_count++;
      }
      classooms_copy = classrooms;
    }

    public List<Classroom> getClassrooms() {
      List<Classroom> result = new();

      foreach (Classroom classroom in classooms_copy) {

      }

      return result;
    }

    public static int ReturnCurrentHourIndex() {
      DateTime time = DateTime.Now;
      switch (time.Hour) {
        case 7:
          if (time.Minute < 30) return 0; else return 1;
        case 8:
          if (time.Minute < 45) { return 1; } else { return 2; }
          break;
        case 9:
          if (time.Minute < 40) { return 2; } else { return 3; }
        case 10:
          if (time.Minute < 40) { return 3; } else { return 4; }
        case 11:
          if (time.Minute < 35) { return 4; } else { return 5; }
        case 12:
          if (time.Minute < 30) { return 5; } else { return 6; }
        case 13:
          if (time.Minute < 20) { return 6; } else { return 7; }
        case 14:
          if (time.Minute < 10) { return 7; } else { return 8; }
        case 15:
          if (time.Minute == 00) { return 8; } else if (time.Minute > 50) { return -1; } else { return 9; };


        default: return -1;
      }

    }
  }
}