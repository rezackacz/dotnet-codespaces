using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallwayInfoPanelGMH {
  internal class Classroom {

    int id;
    string dispName;
    public string currentPeople;
    public string subject;
    public string currentTeacher;

    public Classroom(int id, string dispName) {
      this.id = id;
      this.dispName = dispName;
    }

    public void render() {
      return;
    }

  }
}
