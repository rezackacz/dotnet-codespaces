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

    private CanteenMenuDownloader canteenMenuDownloader;

    private string pageTitle;

    public enum DisplayTypes {
      INFO, CLASSROOM_LIST, CANTEEN_MENU, WARNING, WEATHER, JOKE
    }

    public DisplayTypes type;

    public HTMLRenderer(DisplayTypes typ, string pageTitle, string body) {
        this.pageTitle = pageTitle;
        this.body = body;

      }
    

    public HTMLRenderer(Classroom[] classrooms, int classroom_count) {

      this.type = DisplayTypes.CLASSROOM_LIST;



      //TODO intialize the renderer to use different elements based on the type

    }

    public HTMLRenderer(CanteenMenuDownloader canteenMenuDownloader) {
      this.type = DisplayTypes.CANTEEN_MENU;
      this.canteenMenuDownloader = canteenMenuDownloader;

      //TODO intialize the renderer to format a table with today's menu in the canteen



    }

    public void Render() {
      switch (type) {
        case DisplayTypes.INFO: { break; }
        case DisplayTypes.CLASSROOM_LIST: { break; }
        case DisplayTypes.CANTEEN_MENU: { break; }
        case DisplayTypes.WARNING: { break; }
        case DisplayTypes.WEATHER: { break; }
        case DisplayTypes.JOKE: { break; }
      }
    }
  }
}
