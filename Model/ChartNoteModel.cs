using ScottPlot;

namespace WinformScottPlotMultiChart.Model
{
  public class ChartNoteModel
  {
    public int ChartId { get; set; }

    public int Id { get; set; }

    public double? X { get; set; }
    public double? Y { get; set; } // is is not null, then it'll be an HORIZONTAL  annotation; otherwise it'll be VERTICAL
    public string Tag { get; set; } // text associated with the note
    public TextAlignment TextAlignment { get; set; }
    public string NoteColor { get; set; }
  }
}