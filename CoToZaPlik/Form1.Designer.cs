﻿namespace CoToZaPlik
{
    partial class frmMain
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
            this.listFileInfo = new System.Windows.Forms.ListBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // listFileInfo
            // 
            this.listFileInfo.FormattingEnabled = true;
            this.listFileInfo.Location = new System.Drawing.Point(12, 12);
            this.listFileInfo.Name = "listFileInfo";
            this.listFileInfo.Size = new System.Drawing.Size(445, 342);
            this.listFileInfo.TabIndex = 0;
            // 
            // lblFileName
            // 
            this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFileName.Location = new System.Drawing.Point(12, 371);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(445, 56);
            this.lblFileName.TabIndex = 1;
            this.lblFileName.Text = "bla";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(171, 448);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(130, 33);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Pobierz info o pliku";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // ofdFile
            // 
            this.ofdFile.Filter = "Pliki TXT|*.txt";
            this.ofdFile.Title = "Wybierz plik";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 493);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.listFileInfo);
            this.Name = "frmMain";
            this.Text = "Co to za plik?";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listFileInfo;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.OpenFileDialog ofdFile;
    }
}

