﻿namespace HW1_PegPuzzle
{
    partial class MainControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._tblInputs = new System.Windows.Forms.TableLayoutPanel();
            this._lblNValue = new System.Windows.Forms.Label();
            this._nudNValue = new System.Windows.Forms.NumericUpDown();
            this._btnGenerate = new System.Windows.Forms.Button();
            this._btnStartPoint = new System.Windows.Forms.Button();
            this._tblMain = new System.Windows.Forms.TableLayoutPanel();
            this._btnSearch = new System.Windows.Forms.Button();
            this._tblInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudNValue)).BeginInit();
            this._tblMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // _tblInputs
            // 
            this._tblInputs.ColumnCount = 5;
            this._tblInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this._tblInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this._tblInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this._tblInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this._tblInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this._tblInputs.Controls.Add(this._btnStartPoint, 3, 0);
            this._tblInputs.Controls.Add(this._lblNValue, 0, 0);
            this._tblInputs.Controls.Add(this._nudNValue, 1, 0);
            this._tblInputs.Controls.Add(this._btnGenerate, 2, 0);
            this._tblInputs.Controls.Add(this._btnSearch, 4, 0);
            this._tblInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tblInputs.Location = new System.Drawing.Point(3, 3);
            this._tblInputs.Name = "_tblInputs";
            this._tblInputs.RowCount = 1;
            this._tblInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tblInputs.Size = new System.Drawing.Size(887, 42);
            this._tblInputs.TabIndex = 0;
            // 
            // _lblNValue
            // 
            this._lblNValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lblNValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblNValue.Location = new System.Drawing.Point(3, 0);
            this._lblNValue.Name = "_lblNValue";
            this._lblNValue.Size = new System.Drawing.Size(92, 42);
            this._lblNValue.TabIndex = 0;
            this._lblNValue.Text = "N-Value: ";
            this._lblNValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _nudNValue
            // 
            this._nudNValue.AutoSize = true;
            this._nudNValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this._nudNValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._nudNValue.Location = new System.Drawing.Point(101, 3);
            this._nudNValue.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this._nudNValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._nudNValue.Name = "_nudNValue";
            this._nudNValue.Size = new System.Drawing.Size(191, 26);
            this._nudNValue.TabIndex = 1;
            this._nudNValue.ThousandsSeparator = true;
            this._nudNValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // _btnGenerate
            // 
            this._btnGenerate.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnGenerate.Location = new System.Drawing.Point(298, 3);
            this._btnGenerate.Name = "_btnGenerate";
            this._btnGenerate.Size = new System.Drawing.Size(191, 36);
            this._btnGenerate.TabIndex = 2;
            this._btnGenerate.Text = "Generate Puzzle";
            this._btnGenerate.UseVisualStyleBackColor = true;
            this._btnGenerate.Click += new System.EventHandler(this.OnClickGenerate);
            // 
            // _btnStartPoint
            // 
            this._btnStartPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btnStartPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnStartPoint.Location = new System.Drawing.Point(495, 3);
            this._btnStartPoint.Name = "_btnStartPoint";
            this._btnStartPoint.Size = new System.Drawing.Size(191, 36);
            this._btnStartPoint.TabIndex = 3;
            this._btnStartPoint.Text = "Choose Start Point";
            this._btnStartPoint.UseVisualStyleBackColor = true;
            this._btnStartPoint.Click += new System.EventHandler(this.OnClickChooseStart);
            // 
            // _tblMain
            // 
            this._tblMain.ColumnCount = 1;
            this._tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tblMain.Controls.Add(this._tblInputs, 0, 0);
            this._tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tblMain.Location = new System.Drawing.Point(0, 0);
            this._tblMain.Name = "_tblMain";
            this._tblMain.RowCount = 2;
            this._tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this._tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tblMain.Size = new System.Drawing.Size(893, 483);
            this._tblMain.TabIndex = 1;
            // 
            // _btnSearch
            // 
            this._btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnSearch.Location = new System.Drawing.Point(692, 3);
            this._btnSearch.Name = "_btnSearch";
            this._btnSearch.Size = new System.Drawing.Size(192, 36);
            this._btnSearch.TabIndex = 4;
            this._btnSearch.Text = "Search";
            this._btnSearch.UseVisualStyleBackColor = true;
            this._btnSearch.Click += new System.EventHandler(this.OnClickSearch);
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._tblMain);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(893, 483);
            this._tblInputs.ResumeLayout(false);
            this._tblInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudNValue)).EndInit();
            this._tblMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _tblInputs;
        private System.Windows.Forms.Button _btnStartPoint;
        private System.Windows.Forms.Label _lblNValue;
        private System.Windows.Forms.NumericUpDown _nudNValue;
        private System.Windows.Forms.Button _btnGenerate;
        private System.Windows.Forms.Button _btnSearch;
        private System.Windows.Forms.TableLayoutPanel _tblMain;
    }
}
