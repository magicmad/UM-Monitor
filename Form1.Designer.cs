namespace UM_Monitor
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnCapture = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.labelVolt = new System.Windows.Forms.Label();
            this.labelAmp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelWatt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnCOM = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnUM24C = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ucFilter1 = new UM_Monitor.UcFilter();
            this.ucUM24Ccontrol1 = new UM_Monitor.UcUM24Ccontrol();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCapture
            // 
            this.btnCapture.Enabled = false;
            this.btnCapture.Location = new System.Drawing.Point(69, 12);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(75, 23);
            this.btnCapture.TabIndex = 0;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(12, 41);
            this.chart1.Name = "chart1";
            series7.BorderWidth = 4;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series7.Legend = "Legend1";
            series7.Name = "Voltage";
            series8.BorderWidth = 4;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Color = System.Drawing.Color.Red;
            series8.Legend = "Legend1";
            series8.Name = "Amperage";
            series9.BorderWidth = 4;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Color = System.Drawing.Color.Olive;
            series9.Legend = "Legend1";
            series9.Name = "Wattage";
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Series.Add(series9);
            this.chart1.Size = new System.Drawing.Size(892, 451);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 250;
            this.trackBar1.Location = new System.Drawing.Point(150, 11);
            this.trackBar1.Maximum = 2000;
            this.trackBar1.Minimum = 300;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(217, 45);
            this.trackBar1.SmallChange = 100;
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Value = 1000;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Voltage";
            // 
            // labelVolt
            // 
            this.labelVolt.AutoSize = true;
            this.labelVolt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVolt.Location = new System.Drawing.Point(62, 36);
            this.labelVolt.Name = "labelVolt";
            this.labelVolt.Size = new System.Drawing.Size(27, 20);
            this.labelVolt.TabIndex = 4;
            this.labelVolt.Text = "_0";
            this.labelVolt.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelAmp
            // 
            this.labelAmp.AutoSize = true;
            this.labelAmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmp.Location = new System.Drawing.Point(62, 106);
            this.labelAmp.Name = "labelAmp";
            this.labelAmp.Size = new System.Drawing.Size(27, 20);
            this.labelAmp.TabIndex = 6;
            this.labelAmp.Text = "_0";
            this.labelAmp.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Amperage";
            // 
            // labelWatt
            // 
            this.labelWatt.AutoSize = true;
            this.labelWatt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWatt.Location = new System.Drawing.Point(62, 163);
            this.labelWatt.Name = "labelWatt";
            this.labelWatt.Size = new System.Drawing.Size(27, 20);
            this.labelWatt.TabIndex = 8;
            this.labelWatt.Text = "_0";
            this.labelWatt.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Olive;
            this.label6.Location = new System.Drawing.Point(6, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Wattage";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(475, 11);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(46, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Location = new System.Drawing.Point(859, 11);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(45, 23);
            this.button7.TabIndex = 15;
            this.button7.Text = "pg";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // btnCOM
            // 
            this.btnCOM.Location = new System.Drawing.Point(12, 12);
            this.btnCOM.Name = "btnCOM";
            this.btnCOM.Size = new System.Drawing.Size(51, 23);
            this.btnCOM.TabIndex = 16;
            this.btnCOM.Text = "COM";
            this.btnCOM.UseVisualStyleBackColor = true;
            this.btnCOM.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(373, 12);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(45, 23);
            this.btnFilter.TabIndex = 21;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnUM24C
            // 
            this.btnUM24C.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUM24C.Image = global::UM_Monitor.Properties.Resources.um24c2;
            this.btnUM24C.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUM24C.Location = new System.Drawing.Point(817, 469);
            this.btnUM24C.Name = "btnUM24C";
            this.btnUM24C.Size = new System.Drawing.Size(87, 23);
            this.btnUM24C.TabIndex = 18;
            this.btnUM24C.Text = "UM24C";
            this.btnUM24C.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUM24C.UseVisualStyleBackColor = true;
            this.btnUM24C.Click += new System.EventHandler(this.btnUM24C_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelVolt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelAmp);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.labelWatt);
            this.groupBox1.Location = new System.Drawing.Point(776, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 199);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Data";
            // 
            // ucFilter1
            // 
            this.ucFilter1.Location = new System.Drawing.Point(373, 49);
            this.ucFilter1.Name = "ucFilter1";
            this.ucFilter1.Size = new System.Drawing.Size(195, 136);
            this.ucFilter1.TabIndex = 22;
            this.ucFilter1.Visible = false;
            // 
            // ucUM24Ccontrol1
            // 
            this.ucUM24Ccontrol1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ucUM24Ccontrol1.Location = new System.Drawing.Point(597, 415);
            this.ucUM24Ccontrol1.Name = "ucUM24Ccontrol1";
            this.ucUM24Ccontrol1.Size = new System.Drawing.Size(214, 77);
            this.ucUM24Ccontrol1.TabIndex = 24;
            this.ucUM24Ccontrol1.Visible = false;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(424, 11);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(45, 23);
            this.btnExport.TabIndex = 25;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 504);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.ucUM24Ccontrol1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ucFilter1);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnUM24C);
            this.Controls.Add(this.btnCOM);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.trackBar1);
            this.Name = "Form1";
            this.Text = "UM Series Monitor";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelVolt;
        private System.Windows.Forms.Label labelAmp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelWatt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnCOM;
        private System.Windows.Forms.Button btnUM24C;
        private System.Windows.Forms.Button btnFilter;
        private UcFilter ucFilter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private UcUM24Ccontrol ucUM24Ccontrol1;
        private System.Windows.Forms.Button btnExport;
    }
}

