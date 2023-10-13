using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallwayInfoPanelGMH {
  class HTMLRenderer {

    private const string htmlBeginning = "<!DOCTYPE html><html><head><title>GMH Infopanel</title><meta charset=\"UTF-16\"><meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"><style>";
    private string CSS;
    private const string htmlMiddle = "</style><body>";
    private string body;
    private const string htmlEnding = "</body></html>";

    public enum DisplayTypes {
      CLASSROOMS, INFO, WARNING
    }

    DisplayTypes type;

    public HTMLRenderer(DisplayTypes type) {

      this.type = type;

      //TODO intialize the renderer to use different elements based on the type

    }

    public void Render() {
      switch (type) {
        case DisplayTypes.CLASSROOMS:
          break;
        case DisplayTypes.INFO:
          break;
        case DisplayTypes.WARNING:
          break;
        default:
          break; //TODO fill in the switch to render different values depending on the thing we wanna render
      }
    }
  }
}
