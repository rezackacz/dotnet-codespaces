using Microsoft.VisualStudio.TestTools.UnitTesting;
using HallwayInfoPanelGMH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallwayInfoPanelGMH.Tests {
  [TestClass()]
  public class CanteenMenuDownloaderTests {
    [TestMethod()]
    public void CanteenMenuDownloaderTest() {
      CanteenMenuDownloader canteenMenu = new CanteenMenuDownloader("https://www.strava.cz/strava5/Jidelnicky/XML?zarizeni=0059");

      Assert.IsNotNull(canteenMenu);

      Console.WriteLine("PageTitle: "+canteenMenu.PageTitle);
      
    }
  }
}