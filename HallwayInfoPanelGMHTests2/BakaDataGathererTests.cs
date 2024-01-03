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
      throw new NotImplementedException();
    }
  }
}