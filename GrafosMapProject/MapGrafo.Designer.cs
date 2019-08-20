namespace GrafosMap.Client
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
            this.btnMaxWay = new System.Windows.Forms.ToolStripButton();
            this.btnAdyacents = new System.Windows.Forms.ToolStripButton();
            this.btnReset = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPointA = new System.Windows.Forms.Label();
            this.lblPointB = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDistance = new System.Windows.Forms.RichTextBox();
            this.barMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gmap
            // 
            this.gmap.BackColor = System.Drawing.Color.Maroon;
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(182, -4);
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
            this.gmap.Size = new System.Drawing.Size(1080, 629);
            this.gmap.TabIndex = 0;
            this.gmap.Zoom = 13D;
            // 
            // btnZoomM
            // 
            this.btnZoomM.BackColor = System.Drawing.Color.Transparent;
            this.btnZoomM.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.btnZoomM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnZoomM.Location = new System.Drawing.Point(1185, 554);
            this.btnZoomM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZoomM.Name = "btnZoomM";
            this.btnZoomM.Size = new System.Drawing.Size(47, 43);
            this.btnZoomM.TabIndex = 2;
            this.btnZoomM.Text = "-";
            this.btnZoomM.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnZoomM.UseVisualStyleBackColor = false;
            this.btnZoomM.Click += new System.EventHandler(this.btnZoomM_Click);
            // 
            // btnZoomP
            // 
            this.btnZoomP.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.btnZoomP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnZoomP.Location = new System.Drawing.Point(1185, 506);
            this.btnZoomP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZoomP.Name = "btnZoomP";
            this.btnZoomP.Size = new System.Drawing.Size(47, 43);
            this.btnZoomP.TabIndex = 3;
            this.btnZoomP.Text = "+";
            this.btnZoomP.UseVisualStyleBackColor = true;
            this.btnZoomP.Click += new System.EventHandler(this.btnZoomP_Click);
            // 
            // barMenu
            // 
            this.barMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.barMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMinWay,
            this.btnMaxWay,
            this.btnAdyacents,
            this.btnReset});
            this.barMenu.Location = new System.Drawing.Point(0, 0);
            this.barMenu.Name = "barMenu";
            this.barMenu.Size = new System.Drawing.Size(1373, 31);
            this.barMenu.TabIndex = 4;
            this.barMenu.Text = "barMenu";
            this.barMenu.Visible = false;
            // 
            // btnMinWay
            // 
            this.btnMinWay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnMinWay.Image = ((System.Drawing.Image)(resources.GetObject("btnMinWay.Image")));
            this.btnMinWay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMinWay.Name = "btnMinWay";
            this.btnMinWay.Size = new System.Drawing.Size(119, 28);
            this.btnMinWay.Text = "Camino Minimo";
            // 
            // btnMaxWay
            // 
            this.btnMaxWay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnMaxWay.Image = ((System.Drawing.Image)(resources.GetObject("btnMaxWay.Image")));
            this.btnMaxWay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMaxWay.Name = "btnMaxWay";
            this.btnMaxWay.Size = new System.Drawing.Size(106, 28);
            this.btnMaxWay.Text = "Camino Largo";
            // 
            // btnAdyacents
            // 
            this.btnAdyacents.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAdyacents.Image = ((System.Drawing.Image)(resources.GetObject("btnAdyacents.Image")));
            this.btnAdyacents.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdyacents.Name = "btnAdyacents";
            this.btnAdyacents.Size = new System.Drawing.Size(86, 28);
            this.btnAdyacents.Text = "Adjacentes";
            // 
            // btnReset
            // 
            this.btnReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(70, 28);
            this.btnReset.Text = "Reiniciar";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(209)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1448, 27);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "Camino Largo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(209)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1282, 27);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 50);
            this.button2.TabIndex = 9;
            this.button2.Text = "Camino Corto";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(191)))), ((int)(((byte)(100)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1282, 85);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(324, 34);
            this.button3.TabIndex = 10;
            this.button3.Text = "Mostrar Adyacentes";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(1282, 127);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(324, 34);
            this.button4.TabIndex = 11;
            this.button4.Text = "Reiniciar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1278, 256);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Destino:";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistance.ForeColor = System.Drawing.Color.White;
            this.lblDistance.Location = new System.Drawing.Point(1300, 337);
            this.lblDistance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(0, 23);
            this.lblDistance.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1278, 201);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Inicio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1278, 315);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Distancia:";
            // 
            // lblPointA
            // 
            this.lblPointA.AutoSize = true;
            this.lblPointA.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic);
            this.lblPointA.ForeColor = System.Drawing.Color.White;
            this.lblPointA.Location = new System.Drawing.Point(1300, 220);
            this.lblPointA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPointA.Name = "lblPointA";
            this.lblPointA.Size = new System.Drawing.Size(0, 23);
            this.lblPointA.TabIndex = 16;
            // 
            // lblPointB
            // 
            this.lblPointB.AutoSize = true;
            this.lblPointB.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic);
            this.lblPointB.ForeColor = System.Drawing.Color.White;
            this.lblPointB.Location = new System.Drawing.Point(1300, 277);
            this.lblPointB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPointB.Name = "lblPointB";
            this.lblPointB.Size = new System.Drawing.Size(0, 23);
            this.lblPointB.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(152)))), ((int)(((byte)(209)))));
            this.panel1.Location = new System.Drawing.Point(-1, 623);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1625, 10);
            this.panel1.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GrafosMapProject.Properties.Resources.UCenfotec_logo_horizontal_blanco;
            this.pictureBox1.Location = new System.Drawing.Point(1336, 507);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(-1, -4);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(180, 629);
            this.txtDistance.TabIndex = 20;
            this.txtDistance.Text = "";
            // 
            // MapGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1623, 635);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPointB);
            this.Controls.Add(this.lblPointA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.barMenu);
            this.Controls.Add(this.btnZoomP);
            this.Controls.Add(this.btnZoomM);
            this.Controls.Add(this.gmap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MapGrafo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dijkstra algorithm";
            this.barMenu.ResumeLayout(false);
            this.barMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ToolStripButton btnAdyacents;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPointA;
        private System.Windows.Forms.Label lblPointB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox txtDistance;
    }
}

