﻿namespace ChartApp
{
    partial class Main
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.sysChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnCpu = new System.Windows.Forms.Button();
            this.btnMemory = new System.Windows.Forms.Button();
            this.btnDisk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sysChart)).BeginInit();
            this.SuspendLayout();
            // 
            // sysChart
            // 
            chartArea3.Name = "ChartArea1";
            this.sysChart.ChartAreas.Add(chartArea3);
            this.sysChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.sysChart.Legends.Add(legend3);
            this.sysChart.Location = new System.Drawing.Point(0, 0);
            this.sysChart.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.sysChart.Name = "sysChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.sysChart.Series.Add(series3);
            this.sysChart.Size = new System.Drawing.Size(1824, 1064);
            this.sysChart.TabIndex = 0;
            this.sysChart.Text = "sysChart";
            // 
            // btnCpu
            // 
            this.btnCpu.Location = new System.Drawing.Point(1515, 600);
            this.btnCpu.Name = "btnCpu";
            this.btnCpu.Size = new System.Drawing.Size(279, 92);
            this.btnCpu.TabIndex = 1;
            this.btnCpu.Text = "CPU (ON)";
            this.btnCpu.UseVisualStyleBackColor = true;
            this.btnCpu.Click += new System.EventHandler(this.btnCpu_Click);
            // 
            // btnMemory
            // 
            this.btnMemory.Location = new System.Drawing.Point(1515, 714);
            this.btnMemory.Name = "btnMemory";
            this.btnMemory.Size = new System.Drawing.Size(279, 92);
            this.btnMemory.TabIndex = 2;
            this.btnMemory.Text = "Memory (OFF)";
            this.btnMemory.UseVisualStyleBackColor = true;
            this.btnMemory.Click += new System.EventHandler(this.btnMemory_Click);
            // 
            // btnDisk
            // 
            this.btnDisk.Location = new System.Drawing.Point(1515, 829);
            this.btnDisk.Name = "btnDisk";
            this.btnDisk.Size = new System.Drawing.Size(279, 92);
            this.btnDisk.TabIndex = 3;
            this.btnDisk.Text = "Disk (OFF)";
            this.btnDisk.UseVisualStyleBackColor = true;
            this.btnDisk.Click += new System.EventHandler(this.btnDisk_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1824, 1064);
            this.Controls.Add(this.btnDisk);
            this.Controls.Add(this.btnMemory);
            this.Controls.Add(this.btnCpu);
            this.Controls.Add(this.sysChart);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Main";
            this.Text = "System Metrics";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sysChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart sysChart;
        private System.Windows.Forms.Button btnCpu;
        private System.Windows.Forms.Button btnMemory;
        private System.Windows.Forms.Button btnDisk;
    }
}

