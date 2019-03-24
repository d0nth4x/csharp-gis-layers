namespace lab6_gis_7902
{
    partial class mainForm
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
            this.bFile = new System.Windows.Forms.Button();
            this.bZoomIn = new System.Windows.Forms.Button();
            this.bZoomOut = new System.Windows.Forms.Button();
            this.bCenter = new System.Windows.Forms.Button();
            this.spatialDockManager1 = new DotSpatial.Controls.SpatialDockManager();
            this.uxLegend = new DotSpatial.Controls.Legend();
            this.uxMap = new DotSpatial.Controls.Map();
            this.uxGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spatialDockManager1)).BeginInit();
            this.spatialDockManager1.Panel1.SuspendLayout();
            this.spatialDockManager1.Panel2.SuspendLayout();
            this.spatialDockManager1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bFile
            // 
            this.bFile.Location = new System.Drawing.Point(1012, 12);
            this.bFile.Name = "bFile";
            this.bFile.Size = new System.Drawing.Size(75, 23);
            this.bFile.TabIndex = 1;
            this.bFile.Text = "Plik";
            this.bFile.UseVisualStyleBackColor = true;
            this.bFile.Click += new System.EventHandler(this.bFile_Click);
            // 
            // bZoomIn
            // 
            this.bZoomIn.Location = new System.Drawing.Point(1012, 42);
            this.bZoomIn.Name = "bZoomIn";
            this.bZoomIn.Size = new System.Drawing.Size(75, 23);
            this.bZoomIn.TabIndex = 2;
            this.bZoomIn.Text = "Widok +";
            this.bZoomIn.UseVisualStyleBackColor = true;
            this.bZoomIn.Click += new System.EventHandler(this.bZoomIn_Click);
            // 
            // bZoomOut
            // 
            this.bZoomOut.Location = new System.Drawing.Point(1012, 72);
            this.bZoomOut.Name = "bZoomOut";
            this.bZoomOut.Size = new System.Drawing.Size(75, 23);
            this.bZoomOut.TabIndex = 3;
            this.bZoomOut.Text = "Widok -";
            this.bZoomOut.UseVisualStyleBackColor = true;
            this.bZoomOut.Click += new System.EventHandler(this.bZoomOut_Click);
            // 
            // bCenter
            // 
            this.bCenter.Location = new System.Drawing.Point(1012, 102);
            this.bCenter.Name = "bCenter";
            this.bCenter.Size = new System.Drawing.Size(75, 23);
            this.bCenter.TabIndex = 4;
            this.bCenter.Text = "Wyśrodkuj";
            this.bCenter.UseVisualStyleBackColor = true;
            this.bCenter.Click += new System.EventHandler(this.bCenter_Click);
            // 
            // spatialDockManager1
            // 
            this.spatialDockManager1.Location = new System.Drawing.Point(12, 12);
            this.spatialDockManager1.Name = "spatialDockManager1";
            // 
            // spatialDockManager1.Panel1
            // 
            this.spatialDockManager1.Panel1.Controls.Add(this.uxLegend);
            // 
            // spatialDockManager1.Panel2
            // 
            this.spatialDockManager1.Panel2.Controls.Add(this.uxMap);
            this.spatialDockManager1.Size = new System.Drawing.Size(994, 440);
            this.spatialDockManager1.SplitterDistance = 331;
            this.spatialDockManager1.TabControl1 = null;
            this.spatialDockManager1.TabControl2 = null;
            this.spatialDockManager1.TabIndex = 5;
            // 
            // uxLegend
            // 
            this.uxLegend.BackColor = System.Drawing.Color.White;
            this.uxLegend.ControlRectangle = new System.Drawing.Rectangle(0, 0, 331, 440);
            this.uxLegend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxLegend.DocumentRectangle = new System.Drawing.Rectangle(0, 0, 187, 428);
            this.uxLegend.HorizontalScrollEnabled = true;
            this.uxLegend.Indentation = 30;
            this.uxLegend.IsInitialized = false;
            this.uxLegend.Location = new System.Drawing.Point(0, 0);
            this.uxLegend.MinimumSize = new System.Drawing.Size(5, 5);
            this.uxLegend.Name = "uxLegend";
            this.uxLegend.ProgressHandler = null;
            this.uxLegend.ResetOnResize = false;
            this.uxLegend.SelectionFontColor = System.Drawing.Color.Black;
            this.uxLegend.SelectionHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.uxLegend.Size = new System.Drawing.Size(331, 440);
            this.uxLegend.TabIndex = 0;
            this.uxLegend.Text = "uxLegend";
            this.uxLegend.VerticalScrollEnabled = true;
            this.uxLegend.MouseClick += new System.Windows.Forms.MouseEventHandler(this.uxLegend_MouseClick);
            // 
            // uxMap
            // 
            this.uxMap.AllowDrop = true;
            this.uxMap.BackColor = System.Drawing.Color.White;
            this.uxMap.CollectAfterDraw = false;
            this.uxMap.CollisionDetection = false;
            this.uxMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxMap.ExtendBuffer = false;
            this.uxMap.FunctionMode = DotSpatial.Controls.FunctionMode.None;
            this.uxMap.IsBusy = false;
            this.uxMap.IsZoomedToMaxExtent = false;
            this.uxMap.Legend = this.uxLegend;
            this.uxMap.Location = new System.Drawing.Point(0, 0);
            this.uxMap.Name = "uxMap";
            this.uxMap.ProgressHandler = null;
            this.uxMap.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt;
            this.uxMap.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt;
            this.uxMap.RedrawLayersWhileResizing = false;
            this.uxMap.SelectionEnabled = true;
            this.uxMap.Size = new System.Drawing.Size(659, 440);
            this.uxMap.TabIndex = 0;
            // 
            // uxGridView
            // 
            this.uxGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxGridView.Location = new System.Drawing.Point(12, 477);
            this.uxGridView.Name = "uxGridView";
            this.uxGridView.Size = new System.Drawing.Size(1075, 117);
            this.uxGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(526, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sterowanie mapą odbywa się za pomoca strzałek na klawiaturze";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 606);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxGridView);
            this.Controls.Add(this.spatialDockManager1);
            this.Controls.Add(this.bCenter);
            this.Controls.Add(this.bZoomOut);
            this.Controls.Add(this.bZoomIn);
            this.Controls.Add(this.bFile);
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "Lab 6 Paweł Drzewiecki 7902";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.spatialDockManager1.Panel1.ResumeLayout(false);
            this.spatialDockManager1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spatialDockManager1)).EndInit();
            this.spatialDockManager1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uxGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bFile;
        private System.Windows.Forms.Button bZoomIn;
        private System.Windows.Forms.Button bZoomOut;
        private System.Windows.Forms.Button bCenter;
        private DotSpatial.Controls.SpatialDockManager spatialDockManager1;
        private DotSpatial.Controls.Legend uxLegend;
        private DotSpatial.Controls.Map uxMap;
        private System.Windows.Forms.DataGridView uxGridView;
        private System.Windows.Forms.Label label1;
    }
}

