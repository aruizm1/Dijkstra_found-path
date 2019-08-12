﻿namespace GrafosMap.Client
{
    partial class MapGrafo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
       
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapGrafo));
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.btnZoomM = new System.Windows.Forms.Button();
            this.btnZoomP = new System.Windows.Forms.Button();
            this.barMenu = new System.Windows.Forms.ToolStrip();
            this.btnMinWay = new System.Windows.Forms.ToolStripButton();
            this.btnReset = new System.Windows.Forms.ToolStripButton();
            this.btnMaxWay = new System.Windows.Forms.ToolStripButton();
            this.barMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gmap
            // 
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(17, 31);
            this.gmap.Margin = new System.Windows.Forms.Padding(4);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 18;
            this.gmap.MinZoom = 2;
            this.gmap.MouseWheelZoomEnabled = true;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(1232, 629);
            this.gmap.TabIndex = 0;
            this.gmap.Zoom = 13D;
            // 
            // btnZoomM
            // 
            this.btnZoomM.Location = new System.Drawing.Point(1175, 637);
            this.btnZoomM.Name = "btnZoomM";
            this.btnZoomM.Size = new System.Drawing.Size(75, 23);
            this.btnZoomM.TabIndex = 2;
            this.btnZoomM.Text = "Zoom -";
            this.btnZoomM.UseVisualStyleBackColor = true;
            this.btnZoomM.Click += new System.EventHandler(this.btnZoomM_Click);
            // 
            // btnZoomP
            // 
            this.btnZoomP.Location = new System.Drawing.Point(1175, 608);
            this.btnZoomP.Name = "btnZoomP";
            this.btnZoomP.Size = new System.Drawing.Size(75, 23);
            this.btnZoomP.TabIndex = 3;
            this.btnZoomP.Text = "Zoom +";
            this.btnZoomP.UseVisualStyleBackColor = true;
            this.btnZoomP.Click += new System.EventHandler(this.btnZoomP_Click);
            // 
            // barMenu
            // 
            this.barMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.barMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMinWay,
            this.btnMaxWay,
            this.btnReset});
            this.barMenu.Location = new System.Drawing.Point(0, 0);
            this.barMenu.Name = "barMenu";
            this.barMenu.Size = new System.Drawing.Size(1262, 27);
            this.barMenu.TabIndex = 4;
            this.barMenu.Text = "barMenu";
            // 
            // btnMinWay
            // 
            this.btnMinWay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnMinWay.Image = ((System.Drawing.Image)(resources.GetObject("btnMinWay.Image")));
            this.btnMinWay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMinWay.Name = "btnMinWay";
            this.btnMinWay.Size = new System.Drawing.Size(119, 24);
            this.btnMinWay.Text = "Camino Minimo";
            this.btnMinWay.Click += new System.EventHandler(this.btnMinWay_Click);
            // 
            // btnReset
            // 
            this.btnReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(49, 24);
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnMaxWay
            // 
            this.btnMaxWay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnMaxWay.Image = ((System.Drawing.Image)(resources.GetObject("btnMaxWay.Image")));
            this.btnMaxWay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMaxWay.Name = "btnMaxWay";
            this.btnMaxWay.Size = new System.Drawing.Size(106, 24);
            this.btnMaxWay.Text = "Camino Largo";
            this.btnMaxWay.Click += new System.EventHandler(this.btnMaxWay_Click);
            // 
            // MapGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.barMenu);
            this.Controls.Add(this.btnZoomP);
            this.Controls.Add(this.btnZoomM);
            this.Controls.Add(this.gmap);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MapGrafo";
            this.Text = "Map";
            this.barMenu.ResumeLayout(false);
            this.barMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public GMap.NET.WindowsForms.GMapControl gmap;
        public System.Windows.Forms.Button btnZoomM;
        public System.Windows.Forms.Button btnZoomP;
        public System.Windows.Forms.ToolStrip barMenu;
        public System.Windows.Forms.ToolStripButton btnMinWay;
        public System.Windows.Forms.ToolStripButton btnReset;
        private System.Windows.Forms.ToolStripButton btnMaxWay;
    }
}
