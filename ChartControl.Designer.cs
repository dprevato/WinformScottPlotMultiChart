namespace WinformScottPlotMultiChart
{
   partial class ChartControl
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      private ScottPlot.FormsPlot PlotControl;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Component Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         this.PlotControl = new ScottPlot.FormsPlot();
         this.SuspendLayout();
         //
         // PlotControl
         //
         this.PlotControl.Dock = System.Windows.Forms.DockStyle.Fill;
         this.PlotControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.PlotControl.Location = new System.Drawing.Point(0, 0);
         this.PlotControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.PlotControl.Name = "PlotControl";
         this.PlotControl.Size = new System.Drawing.Size(800, 450);
         this.PlotControl.TabIndex = 0;
         //
         // ChartControl
         //
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.PlotControl);
         this.Name = "ChartControl";
         this.Size = new System.Drawing.Size(800, 450);
         this.ResumeLayout(false);
      }

      #endregion Component Designer generated code
   }
}