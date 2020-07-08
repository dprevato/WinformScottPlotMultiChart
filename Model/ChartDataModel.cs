namespace WinformScottPlotMultiChart.Model
{
   public enum PlotTypes
   {
      Scatter,
      Bar
   }

   public class ChartDataModel
   {
      public int ChartId { get; set; }

      public int Id { get; set; } // key

      public PlotTypes PlotType { get; set; } 
      public string PlotColor { get; set; }
      public string Label { get; set; }
      public string Series { get; set; } // Id for the data series to load in the Plot
   }
}