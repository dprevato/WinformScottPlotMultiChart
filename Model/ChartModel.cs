using System.Collections.Generic;

namespace WinformScottPlotMultiChart.Model
{
  public class ChartModel
  {
    public int FormId { get; set; }
    public int Id { get; set; } // key

    public string Title { get; set; }
    public string YAxisTitle { get; set; }
    public double? YMin { get; set; }
    public double? YMax { get; set; }
    public bool ShowLegend { get; set; }
    public float? HeightQuote { get; set; }

    public IList<ChartDataModel> ChartData { get; set; }
    public IList<ChartNoteModel> ChartNotes { get; set; }
  }
}