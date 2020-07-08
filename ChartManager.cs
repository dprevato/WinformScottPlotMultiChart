using System;

namespace WinformScottPlotMultiChart
{
   public class ChartManager
   {
      #region Constructors

      public ChartManager()
      {
         BuildCharts();
      }

      #endregion Constructors

      #region Logic.

      private void BuildCharts()
      {
         _ = new ChartForm(new ChartDTO());
      }

      #endregion Logic
   }
}