namespace StooqParser
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tbPicker = new System.Windows.Forms.TextBox();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtStop = new System.Windows.Forms.DateTimePicker();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.chrData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnParse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrData)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPicker
            // 
            this.tbPicker.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbPicker.Location = new System.Drawing.Point(30, 28);
            this.tbPicker.MaxLength = 3;
            this.tbPicker.Name = "tbPicker";
            this.tbPicker.Size = new System.Drawing.Size(90, 20);
            this.tbPicker.TabIndex = 0;
            // 
            // dtStart
            // 
            this.dtStart.Location = new System.Drawing.Point(126, 28);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(200, 20);
            this.dtStart.TabIndex = 1;
            // 
            // dtStop
            // 
            this.dtStop.Location = new System.Drawing.Point(332, 28);
            this.dtStop.Name = "dtStop";
            this.dtStop.Size = new System.Drawing.Size(200, 20);
            this.dtStop.TabIndex = 2;
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(30, 68);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(609, 164);
            this.dgvData.TabIndex = 3;
            // 
            // chrData
            // 
            chartArea2.Name = "ChartArea1";
            this.chrData.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chrData.Legends.Add(legend2);
            this.chrData.Location = new System.Drawing.Point(30, 257);
            this.chrData.Name = "chrData";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chrData.Series.Add(series2);
            this.chrData.Size = new System.Drawing.Size(609, 264);
            this.chrData.TabIndex = 4;
            this.chrData.Text = "chart1";
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(550, 24);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(89, 23);
            this.btnParse.TabIndex = 5;
            this.btnParse.Text = "Pobierz";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 554);
            this.Controls.Add(this.btnParse);
            this.Controls.Add(this.chrData);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.dtStop);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.tbPicker);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPicker;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.DateTimePicker dtStop;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrData;
        private System.Windows.Forms.Button btnParse;
    }
}

