using System.Windows.Forms;
using ScottPlot;
using WinformScottPlotMultiChart.Model;

namespace WinformScottPlotMultiChart
{
   public partial class ChartForm : Form
   {
      private ChartDTO ChartDto { get; set; }

      public ChartForm(ChartDTO cdto)
      {
         ChartDto = cdto;
         InitializeComponent();
         Setup();
         Show();
      }

      private void Setup()
      {
         var ChartGroup = ChartDto.ChartForm;
         TitleLbl.Text = ChartGroup.Title;
         if (ChartGroup.Subtitle.Length > 0)
         {
            SepLbl.Visible = true;
            SubtitleLbl.Visible = true;
            SubtitleLbl.Text = ChartGroup.Subtitle;
         }
         else
         {
            SepLbl.Visible = false;
            SubtitleLbl.Visible = false;
         }

         for (var i = 0; i < ChartGroup.ChartNum; i++)
         {
            if (i == 0) // When i==0, there is already a panel in the TableLayoutPanel object
               TPanel.RowStyles[i].Height = HeightFor(ChartGroup.Charts[i].HeightQuote);
            else
               TPanel.RowStyles.Add(new RowStyle(SizeType.Percent, HeightFor(ChartGroup.Charts[i].HeightQuote))); // 

            // Instantiate a new object ChartControl and insert it in the new panel
            var chrt = new ChartControl(ChartGroup.Charts[i]);
            TPanel.Controls.Add(chrt, 0, i);
            chrt.Dock = DockStyle.Fill;
         }
      }

      private float HeightFor(float? quote)
      {
         if (quote.HasValue) return quote.Value;
         return 100f / ChartDto.ChartForm.Charts.Count;
      }
   }
}