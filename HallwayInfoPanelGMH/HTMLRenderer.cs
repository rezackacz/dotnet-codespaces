using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallwayInfoPanelGMH {
  class HTMLRenderer {

    public enum DisplayTypes {
      CLASSROOMS, INFO, WARNING
    }

    DisplayTypes type;

    public HTMLRenderer(DisplayTypes type) {

      this.type = type;

    }
  }
}
