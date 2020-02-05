namespace FlightsStats
{
    partial class Interface
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.btOpenFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.split3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbAirlineID = new System.Windows.Forms.ComboBox();
            this.cbDestination = new System.Windows.Forms.ComboBox();
            this.cbOrigin = new System.Windows.Forms.ComboBox();
            this.cbDate = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbFlightID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.split2 = new System.Windows.Forms.Label();
            this.split1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btPanel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // gmap
            // 
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemory = 5;
            this.gmap.Location = new System.Drawing.Point(78, 12);
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
            this.gmap.Size = new System.Drawing.Size(671, 611);
            this.gmap.TabIndex = 0;
            this.gmap.Zoom = 5D;
            this.gmap.Load += new System.EventHandler(this.gMapControl1_Load);
            // 
            // btOpenFile
            // 
            this.btOpenFile.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btOpenFile.Location = new System.Drawing.Point(992, 192);
            this.btOpenFile.Name = "btOpenFile";
            this.btOpenFile.Size = new System.Drawing.Size(90, 36);
            this.btOpenFile.TabIndex = 1;
            this.btOpenFile.Text = "Open";
            this.btOpenFile.UseVisualStyleBackColor = true;
            this.btOpenFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 42F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(837, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(501, 62);
            this.label1.TabIndex = 2;
            this.label1.Text = "DIRECT TRAVEL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(779, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Load the data:";
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(784, 201);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(177, 20);
            this.tbPath.TabIndex = 4;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 635);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(3, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 635);
            this.splitter2.TabIndex = 6;
            this.splitter2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.Location = new System.Drawing.Point(769, 263);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(675, 328);
            this.dataGridView1.TabIndex = 7;
            // 
            // panelLateral
            // 
            this.panelLateral.Controls.Add(this.split3);
            this.panelLateral.Controls.Add(this.label11);
            this.panelLateral.Controls.Add(this.cbAirlineID);
            this.panelLateral.Controls.Add(this.cbDestination);
            this.panelLateral.Controls.Add(this.cbOrigin);
            this.panelLateral.Controls.Add(this.cbDate);
            this.panelLateral.Controls.Add(this.label10);
            this.panelLateral.Controls.Add(this.label9);
            this.panelLateral.Controls.Add(this.label8);
            this.panelLateral.Controls.Add(this.label7);
            this.panelLateral.Controls.Add(this.tbFlightID);
            this.panelLateral.Controls.Add(this.label6);
            this.panelLateral.Controls.Add(this.split2);
            this.panelLateral.Controls.Add(this.split1);
            this.panelLateral.Controls.Add(this.label3);
            this.panelLateral.Controls.Add(this.btPanel);
            this.panelLateral.Location = new System.Drawing.Point(-260, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(340, 635);
            this.panelLateral.TabIndex = 8;
            // 
            // split3
            // 
            this.split3.AutoSize = true;
            this.split3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.split3.Location = new System.Drawing.Point(-6, 499);
            this.split3.Name = "split3";
            this.split3.Size = new System.Drawing.Size(346, 13);
            this.split3.TabIndex = 16;
            this.split3.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(15, 432);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 23);
            this.label11.TabIndex = 15;
            this.label11.Text = "Flight ID:";
            // 
            // cbAirlineID
            // 
            this.cbAirlineID.FormattingEnabled = true;
            this.cbAirlineID.Location = new System.Drawing.Point(162, 289);
            this.cbAirlineID.Name = "cbAirlineID";
            this.cbAirlineID.Size = new System.Drawing.Size(150, 21);
            this.cbAirlineID.TabIndex = 14;
            // 
            // cbDestination
            // 
            this.cbDestination.FormattingEnabled = true;
            this.cbDestination.Location = new System.Drawing.Point(162, 243);
            this.cbDestination.Name = "cbDestination";
            this.cbDestination.Size = new System.Drawing.Size(150, 21);
            this.cbDestination.TabIndex = 13;
            // 
            // cbOrigin
            // 
            this.cbOrigin.FormattingEnabled = true;
            this.cbOrigin.Location = new System.Drawing.Point(162, 195);
            this.cbOrigin.Name = "cbOrigin";
            this.cbOrigin.Size = new System.Drawing.Size(150, 21);
            this.cbOrigin.TabIndex = 12;
            // 
            // cbDate
            // 
            this.cbDate.FormattingEnabled = true;
            this.cbDate.Location = new System.Drawing.Point(162, 148);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(150, 21);
            this.cbDate.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(15, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 23);
            this.label10.TabIndex = 10;
            this.label10.Text = "Airline ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(13, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 23);
            this.label9.TabIndex = 9;
            this.label9.Text = "Destination:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(13, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 23);
            this.label8.TabIndex = 8;
            this.label8.Text = "Origin:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(13, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Date:";
            // 
            // tbFlightID
            // 
            this.tbFlightID.Location = new System.Drawing.Point(128, 435);
            this.tbFlightID.Name = "tbFlightID";
            this.tbFlightID.Size = new System.Drawing.Size(184, 20);
            this.tbFlightID.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(13, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 33);
            this.label6.TabIndex = 5;
            this.label6.Text = "Search:";
            // 
            // split2
            // 
            this.split2.AutoSize = true;
            this.split2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.split2.Location = new System.Drawing.Point(-6, 355);
            this.split2.Name = "split2";
            this.split2.Size = new System.Drawing.Size(346, 13);
            this.split2.TabIndex = 4;
            this.split2.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------";
            // 
            // split1
            // 
            this.split1.AutoSize = true;
            this.split1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.split1.Location = new System.Drawing.Point(-3, 64);
            this.split1.Name = "split1";
            this.split1.Size = new System.Drawing.Size(346, 13);
            this.split1.TabIndex = 2;
            this.split1.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(13, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "Filters:";
            // 
            // btPanel
            // 
            this.btPanel.Location = new System.Drawing.Point(262, 3);
            this.btPanel.Name = "btPanel";
            this.btPanel.Size = new System.Drawing.Size(75, 47);
            this.btPanel.TabIndex = 0;
            this.btPanel.UseVisualStyleBackColor = true;
            this.btPanel.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1465, 635);
            this.Controls.Add(this.panelLateral);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btOpenFile);
            this.Controls.Add(this.gmap);
            this.Name = "Interface";
            this.Text = " Flights Data";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelLateral.ResumeLayout(false);
            this.panelLateral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.Button btOpenFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Button btPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label split1;
        private System.Windows.Forms.TextBox tbFlightID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label split2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbAirlineID;
        private System.Windows.Forms.ComboBox cbDestination;
        private System.Windows.Forms.ComboBox cbOrigin;
        private System.Windows.Forms.ComboBox cbDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label split3;
    }
}

