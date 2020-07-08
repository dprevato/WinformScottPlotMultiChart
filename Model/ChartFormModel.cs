using System.Collections.Generic;

namespace WinformScottPlotMultiChart.Model
{
  public class ChartFormModel
  {
    public int Id { get; set; } //key

    public string Title { get; set; }
    public string Subtitle { get; set; }
    public int ChartNum { get; set; }

    public IList<ChartModel> Charts { get; set; }
  }
}