using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallwayInfoPanelGMH {
  class HTMLRenderer {

    private const string htmlBeginning = "<!DOCTYPE html><html><head><title>GMH Infopanel</title><meta charset=\"UTF-16\"><meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"><style>";
    private const string CSS = "body { font-family: Segoe UI, Arial, sans-serif;} .table-container { display: flex; flex-direction: column; align-items: center; margin-top: 5px;} .table-row { display: flex; justify-content: space-between; width: 100%; border-bottom: 1px solid #ccc; padding: 10px 0;}";
    private const string htmlMiddle = "</style></head><body>";
    private string body;
    private const string htmlEnding = "</body></html>";

    private CanteenMenuDownloader canteenMenuDownloader;

    private string pageTitle;
    public string htmlFileName { get; }

    public enum DisplayTypes {
      INFO, CLASSROOM_LIST, CANTEEN_MENU, WARNING, WEATHER, JOKE
    }

    public DisplayTypes type;

    public HTMLRenderer(DisplayTypes typ, string pageTitle, string body, string htmlFileName) {
      this.pageTitle = pageTitle;
      this.body = body;
      this.htmlFileName = htmlFileName;
    }


    public HTMLRenderer(Classroom[] classrooms, string htmlFileName) {

      this.type = DisplayTypes.CLASSROOM_LIST;
      this.htmlFileName = htmlFileName;


      body = "<div class=\"table-container\">";

      List<string> rowsList = new List<string>();
      foreach (var classroom in classrooms) {
        rowsList.Add()
      }




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
