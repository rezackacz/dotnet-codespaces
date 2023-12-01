using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallwayInfoPanelGMH {
  internal class BakaDataGatherer {

    List<string> classroom_dispNames;



    public BakaDataGatherer(List<Classroom> classrooms, string bakaServerURL){
      //TODO: dowload data from server
      
      foreach (Classroom classroom in classrooms){
        classroom_dispNames.Add(classroom.dispName);
        
        classroom.subject = "";
        classroom.currentTeacher = "";
        classroom.currentPeople = "";


      }
    }

    public List<Classroom> getClassrooms(){
      return new List<Classroom>{};
      //TODO: update and return the classooms defined in the constructor
    }
  }
}
