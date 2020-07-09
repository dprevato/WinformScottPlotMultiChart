using ScottPlot;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WinformScottPlotMultiChart.Model;

namespace WinformScottPlotMultiChart
{
   public partial class ChartControl : UserControl
   {
      private ChartModel Chart { get; }

      public ChartControl(ChartModel chart)
      {
         Chart = chart;
         InitializeComponent();
         Populate();
      }

      private void Populate()
      {
         var repo = new ChartDTO(); // is used only for get readings data

         foreach (var data in Chart.ChartData)
         {
            repo.GetReadings(data.Series);
            var readings = repo.PlotData;
            var xs = readings.Select(x => x.XVal).ToArray();
            var ys = readings.Select(x => x.YVal).ToArray();
            if (data.PlotType == PlotTypes.Scatter)
            {
               PlotControl.plt.PlotScatter(xs, ys, Color.FromName(data.PlotColor));
            }
            else if (data.PlotType == PlotTypes.Bar)
            {
               PlotControl.plt.PlotBar(xs, ys, outlineColor: Color.FromName(data.PlotColor), fillColor: Color.FromName(data.PlotColor));
            }

            foreach (var note in Chart.ChartNotes) // Traccio tutte le note nel grafico
            {
               if (note.X.HasValue) // è una nota verticale
               {
                  if (note.X.Value > xs.Min() && note.X.Value < xs.Max()) // se la data della nota ricade nell'intervallo
                  {
                     PlotControl.plt.PlotVLine(note.X.Value, color: Color.FromName(note.NoteColor), draggable: false, lineStyle: LineStyle.Solid);
                     if (note.Tag != null) PlotControl.plt.PlotText(note.Tag, note.X.Value, PlotControl.plt.Axis()[3], alignment: TextAlignment.middleRight);
                  }
               }
               else if (note.Y.HasValue)
               {
                  PlotControl.plt.PlotHLine(note.Y.Value, color: Color.FromName(note.NoteColor), draggable: false, lineStyle: LineStyle.Solid);
                  if (note.Tag != null) PlotControl.plt.PlotText(note.Tag, PlotControl.plt.Axis()[0], note.Y.Value, alignment: TextAlignment.upperLeft);
               }
            }
         }

         //? If I put this block of code BEFORE the foreach block, the curves (only them) won't get plotted. I can't understand why...
         if (Chart.Title != null) PlotControl.plt.Title(Chart.Title);
         if (Chart.YAxisTitle != null) PlotControl.plt.YLabel(Chart.YAxisTitle, fontSize: 12); // 12 pt, experimental
         if (Chart.YMin.HasValue) PlotControl.plt.GetSettings().axes.y.min = Chart.YMin.Value; // forcing min Y
         if (Chart.YMax.HasValue) PlotControl.plt.GetSettings().axes.y.max = Chart.YMax.Value; // forcing max Y
         if (Chart.ShowLegend) PlotControl.plt.Legend(enableLegend: true, location: legendLocation.upperCenter);                                       // show legend
         //? Till here

         PlotControl.plt.Ticks(dateTimeX: true); // L'asse X riporta date
         //! 20200708: Thanks to Scott, I'm trying this for gain space for curves...
         double titleH;
         if (Chart.Title != null) titleH = Chart.Title.Length == 0 ? 10d : 50d;
         else titleH = 10d;
         PlotControl.plt.Layout(titleHeight: titleH, xLabelHeight: 0);
         //! And it works like a charm, once found the optimal height for a void chart title... 
         PlotControl.Render();
      }
   }
}