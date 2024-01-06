using Microsoft.VisualStudio.TestTools.UnitTesting;
using HallwayInfoPanelGMH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallwayInfoPanelGMH.Tests {
  [TestClass()]
  public class BakaDataGathererTests {
    [TestMethod()]
    public void BakaDataGathererTest() {
      int classroom_count = 6;
      string[] classroom_dispNames = new string[] { "123", "125", "126", "127", "128", "129", "131" };
      List<Classroom> classrooms = new();
      for (int i = 0; i < classroom_count; i++) {
        classrooms.Add(new Classroom(i, classroom_dispNames[i]));
      }

      BakaDataGatherer bakaDataGatherer = new(classrooms, "http://co2.gmh.cz");


      if (bakaDataGatherer == null) throw new NotImplementedException();
    }

    [TestMethod()]
    public void getClassroomsTest() {
      int classroom_count = 5;
      string[] classroom_dispNames = new string[] { "221", "222", "223", "224", "225" };
      List<Classroom> classrooms = new();

      for (int i = 0; i < classroom_count; i++) {
        classrooms.Add(new Classroom(i, classroom_dispNames[i]));
      }

      BakaDataGatherer gatherer = new(classrooms, "http://co2.gmh.cz");

      var output = gatherer.getClassrooms();
      if (output != null) {
        Console.WriteLine(output);
      } else {
        throw new NotImplementedException();
      }
      
    }


  }
}