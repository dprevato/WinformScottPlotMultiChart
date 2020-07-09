using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ScottPlot;
using WinformScottPlotMultiChart.Model;

namespace WinformScottPlotMultiChart
{
   public class ChartDTO
   {
      public ChartDTO()
      {
         ChartForm = new Model.ChartFormModel();
         GetData();
         GetAllReadings();
      }

      private IList<PlotPoint> AllData { get; set; }
      public Model.ChartFormModel ChartForm { get; set; }
      public IList<PlotPoint> PlotData { get; set; }

      private void GetAllReadings()
      {
         AllData =  File.ReadAllLines(@"Readings.txt").Select(FromTsv).ToList();
      }

      private PlotPoint FromTsv(string tsvLine)
      {
         string[] values = tsvLine.Split('\t');
         var pp = new PlotPoint();
         pp.Series = values[0];
         pp.XVal = Convert.ToDouble(values[1]);
         pp.YVal = Convert.ToDouble(values[2]);
         return pp;
      }


      private void GetData()
      {
         ChartForm = new Model.ChartFormModel
         {
            Id = 1,
            Title = "SAMPLE DATA",
            Subtitle = "SOMEWHERE DAM - Telecoordinometers (Section 4-5)",
            ChartNum = 4,
            Charts = new List<ChartModel>
            {
               new ChartModel
               {
                  FormId = 0,
                  Id = 0,
                  Title = null,
                  YAxisTitle = "<-V mm M->",
                  YMin = -5,
                  YMax = 15,
                  ShowLegend = true,
                  HeightQuote = 30f,
                  ChartData = new List<ChartDataModel>
                  {
                     new ChartDataModel
                     {
                        ChartId = 0,
                        Id = 0,
                        PlotType = PlotTypes.Scatter,
                        PlotColor = "Red",
                        Label = "Straight Pendulum",
                        Series = "Series2"
                     }
                  },
                  ChartNotes = new List<ChartNoteModel>()
               },
               new ChartModel
               {
                  FormId = 0,
                  Id = 1,
                  Title = null,
                  YAxisTitle = "<-L mm R->",
                  YMin = -10,
                  YMax = 10,
                  ShowLegend = false,
                  HeightQuote = 20f,
                  ChartData = new List<ChartDataModel>
                  {
                     new ChartDataModel
                     {
                        ChartId = 1,
                        Id = 1,
                        PlotType = PlotTypes.Scatter,
                        PlotColor = "Red",
                        Label = null,
                        Series = "Series1"
                     }
                  },
                  ChartNotes = new List<ChartNoteModel>
                  {
                     new ChartNoteModel
                     {
                        ChartId = 1,
                        Id = 0,
                        X = null,
                        Y = 8.84,
                        Tag = "Max value",
                        TextAlignment = TextAlignment.upperRight,
                        NoteColor = "Red"
                     },
                     new ChartNoteModel
                     {
                        ChartId = 1,
                        Id = 1,
                        X = null,
                        Y = -3.08,
                        Tag = "Min value",
                        TextAlignment = TextAlignment.upperRight,
                        NoteColor = "Red"
                     }
                  }
               },
               new ChartModel
               {
                  FormId = 0,
                  Id = 2,
                  Title = null,
                  YAxisTitle = "<-M mm V->",
                  YMin = -5,
                  YMax = 15,
                  ShowLegend = true,
                  HeightQuote = 30f,
                  ChartData = new List<ChartDataModel>
                  {
                     new ChartDataModel
                     {
                        ChartId = 2,
                        Id = 2,
                        PlotType = PlotTypes.Scatter,
                        PlotColor = "Green",
                        Label = "Reverse Pendulum",
                        Series = "Series4"
                     }
                  },
                  ChartNotes = new List<ChartNoteModel>
                  {
                     new ChartNoteModel
                     {
                        ChartId = 2,
                        Id = 0,
                        X = null,
                        Y = 0.70,
                        Tag = "Max value",
                        TextAlignment = TextAlignment.upperRight,
                        NoteColor = "Red"
                     },
                     new ChartNoteModel
                     {
                        ChartId = 2,
                        Id = 1,
                        X = null,
                        Y = -1.98,
                        Tag = "Min value",
                        TextAlignment = TextAlignment.upperRight,
                        NoteColor = "Red"
                     }
                  }
               },
               new ChartModel
               {
                  FormId = 0,
                  Id = 3,
                  Title = null,
                  YAxisTitle = "<-V mm M->",
                  YMin = -3,
                  YMax = 3,
                  ShowLegend = false,
                  HeightQuote = 20f,
                  ChartData = new List<ChartDataModel>
                  {
                     new ChartDataModel
                     {
                        ChartId = 3,
                        Id = 3,
                        PlotType = PlotTypes.Scatter,
                        PlotColor = "Green",
                        Label = null,
                        Series = "Series3"
                     }
                  },
                  ChartNotes = new List<ChartNoteModel>()
               }
            }
         };
      }

      public void GetReadings(string src)
      {
         PlotData = AllData.Where(x => x.Series.Equals(src, StringComparison.InvariantCultureIgnoreCase)).ToList();
      }
   }
}