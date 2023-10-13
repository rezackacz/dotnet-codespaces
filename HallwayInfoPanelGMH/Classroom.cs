using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallwayInfoPanelGMH {
  internal class Classroom {

    int id;
    string dispName;
    string currentPeople;
    string subject;
    string currentTeacher;

    Classroom(int id, string dispName, string currentPeople, string subject, string currentTeacher) {
      this.id = id;
      this.dispName = dispName;
      this.currentPeople = currentPeople;
      this.subject = subject;
      this.currentTeacher = currentTeacher;

    }

  }
}
