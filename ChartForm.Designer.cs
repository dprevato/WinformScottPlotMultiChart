namespace WinformScottPlotMultiChart
{
  partial class ChartForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
         this.ToolStrip = new System.Windows.Forms.ToolStrip();
         this.TitleLbl = new System.Windows.Forms.ToolStripLabel();
         this.SepLbl = new System.Windows.Forms.ToolStripLabel();
         this.SubtitleLbl = new System.Windows.Forms.ToolStripLabel();
         this.TPanel = new System.Windows.Forms.TableLayoutPanel();
         this.ToolStrip.SuspendLayout();
         this.SuspendLayout();
         // 
         // ToolStrip
         // 
         this.ToolStrip.AutoSize = false;
         this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TitleLbl,
            this.SepLbl,
            this.SubtitleLbl});
         this.ToolStrip.Location = new System.Drawing.Point(0, 0);
         this.ToolStrip.Name = "ToolStrip";
         this.ToolStrip.Size = new System.Drawing.Size(1200, 30);
         this.ToolStrip.TabIndex = 0;
         this.ToolStrip.Text = "toolStrip1";
         // 
         // TitleLbl
         // 
         this.TitleLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.TitleLbl.Name = "TitleLbl";
         this.TitleLbl.Size = new System.Drawing.Size(149, 27);
         this.TitleLbl.Text = "toolStripLabel1";
         // 
         // SepLbl
         // 
         this.SepLbl.Name = "SepLbl";
         this.SepLbl.Size = new System.Drawing.Size(12, 27);
         this.SepLbl.Text = "-";
         // 
         // SubtitleLbl
         // 
         this.SubtitleLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.SubtitleLbl.Name = "SubtitleLbl";
         this.SubtitleLbl.Size = new System.Drawing.Size(119, 27);
         this.SubtitleLbl.Text = "toolStripLabel1";
         // 
         // TPanel
         // 
         this.TPanel.ColumnCount = 1;
         this.TPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.TPanel.Dock = System.Windows.Forms.DockStyle.Fill;
         this.TPanel.Location = new System.Drawing.Point(0, 30);
         this.TPanel.Name = "TPanel";
         this.TPanel.RowCount = 1;
         this.TPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.TPanel.Size = new System.Drawing.Size(1200, 770);
         this.TPanel.TabIndex = 1;
         // 
         // ChartForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1200, 800);
         this.Controls.Add(this.TPanel);
         this.Controls.Add(this.ToolStrip);
         this.Name = "ChartForm";
         this.Text = "ChartForm";
         this.ToolStrip.ResumeLayout(false);
         this.ToolStrip.PerformLayout();
         this.ResumeLayout(false);

    }

      #endregion

      private System.Windows.Forms.ToolStrip ToolStrip;
      private System.Windows.Forms.ToolStripLabel TitleLbl;
      private System.Windows.Forms.ToolStripLabel SepLbl;
      private System.Windows.Forms.ToolStripLabel SubtitleLbl;
      private System.Windows.Forms.TableLayoutPanel TPanel;
   }
}