using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HallwayInfoPanelGMH {
  public class BakaDataGatherer {

    int classroom_count;


    public BakaDataGatherer(List<Classroom> classrooms, string bakaServerURL){
      
      XElement roomXML = XDocument.Load(bakaServerURL +"/b/common/rooms").Element("BakalariDataInterface");

      XElement roomsXElement = roomXML.Elements().First(element => element.Name == "Rooms");

      
      foreach (Classroom classroom in classrooms){

        classroom.bakaID = roomsXElement.Descendants().First(room => (room?.Element("Abbrev")?.Value) == classroom.dispName).Element("ID").Value;
        classroom.roomURL = bakaServerURL + "/b/timetable/actual/room/" + classroom.bakaID;
        classroom.subject = "";
        classroom.currentTeacher = "";
        classroom.currentPeople = "";

        classroom_count++;
      }
    }

    public List<Classroom> getClassrooms(){
      List<Classroom> result = new();

      

      return result;
    }
  }
}
