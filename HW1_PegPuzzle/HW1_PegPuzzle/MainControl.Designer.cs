namespace HW1_PegPuzzle
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
            this._btnGoalPoint = new System.Windows.Forms.Button();
            this._btnStartPoint = new System.Windows.Forms.Button();
            this._lblNValue = new System.Windows.Forms.Label();
            this._nudNValue = new System.Windows.Forms.NumericUpDown();
            this._btnGenerate = new System.Windows.Forms.Button();
            this._btnSearch = new System.Windows.Forms.Button();
            this._tblMain = new System.Windows.Forms.TableLayoutPanel();
            this._tblPegBoard = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._tblOutput = new System.Windows.Forms.TableLayoutPanel();
            this._btnReset = new System.Windows.Forms.Button();
            this._tblSolutionTable = new System.Windows.Forms.TableLayoutPanel();
            this._tblInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudNValue)).BeginInit();
            this._tblMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this._tblOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // _tblInputs
            // 
            this._tblInputs.ColumnCount = 6;
            this._tblInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this._tblInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this._tblInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this._tblInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this._tblInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this._tblInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this._tblInputs.Controls.Add(this._btnGoalPoint, 4, 0);
            this._tblInputs.Controls.Add(this._btnStartPoint, 3, 0);
            this._tblInputs.Controls.Add(this._lblNValue, 0, 0);
            this._tblInputs.Controls.Add(this._nudNValue, 1, 0);
            this._tblInputs.Controls.Add(this._btnGenerate, 2, 0);
            this._tblInputs.Controls.Add(this._btnSearch, 5, 0);
            this._tblInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tblInputs.Location = new System.Drawing.Point(3, 3);
            this._tblInputs.Name = "_tblInputs";
            this._tblInputs.RowCount = 1;
            this._tblInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tblInputs.Size = new System.Drawing.Size(892, 33);
            this._tblInputs.TabIndex = 0;
            // 
            // _btnGoalPoint
            // 
            this._btnGoalPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btnGoalPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnGoalPoint.Location = new System.Drawing.Point(595, 3);
            this._btnGoalPoint.Name = "_btnGoalPoint";
            this._btnGoalPoint.Size = new System.Drawing.Size(142, 27);
            this._btnGoalPoint.TabIndex = 5;
            this._btnGoalPoint.Text = "Choose Goal";
            this._btnGoalPoint.UseVisualStyleBackColor = true;
            this._btnGoalPoint.Click += new System.EventHandler(this.OnClickChooseGoal);
            // 
            // _btnStartPoint
            // 
            this._btnStartPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btnStartPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnStartPoint.Location = new System.Drawing.Point(447, 3);
            this._btnStartPoint.Name = "_btnStartPoint";
            this._btnStartPoint.Size = new System.Drawing.Size(142, 27);
            this._btnStartPoint.TabIndex = 3;
            this._btnStartPoint.Text = "Choose Start Point";
            this._btnStartPoint.UseVisualStyleBackColor = true;
            this._btnStartPoint.Click += new System.EventHandler(this.OnClickChooseStart);
            // 
            // _lblNValue
            // 
            this._lblNValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lblNValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblNValue.Location = new System.Drawing.Point(3, 0);
            this._lblNValue.Name = "_lblNValue";
            this._lblNValue.Size = new System.Drawing.Size(142, 33);
            this._lblNValue.TabIndex = 0;
            this._lblNValue.Text = "N-Value: ";
            this._lblNValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _nudNValue
            // 
            this._nudNValue.AutoSize = true;
            this._nudNValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this._nudNValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._nudNValue.Location = new System.Drawing.Point(151, 3);
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
            this._nudNValue.Size = new System.Drawing.Size(142, 26);
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
            this._btnGenerate.Location = new System.Drawing.Point(299, 3);
            this._btnGenerate.Name = "_btnGenerate";
            this._btnGenerate.Size = new System.Drawing.Size(142, 27);
            this._btnGenerate.TabIndex = 2;
            this._btnGenerate.Text = "Generate Puzzle";
            this._btnGenerate.UseVisualStyleBackColor = true;
            this._btnGenerate.Click += new System.EventHandler(this.OnClickGenerate);
            // 
            // _btnSearch
            // 
            this._btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnSearch.Location = new System.Drawing.Point(743, 3);
            this._btnSearch.Name = "_btnSearch";
            this._btnSearch.Size = new System.Drawing.Size(146, 27);
            this._btnSearch.TabIndex = 4;
            this._btnSearch.Text = "Search";
            this._btnSearch.UseVisualStyleBackColor = true;
            this._btnSearch.Click += new System.EventHandler(this.OnClickSearch);
            // 
            // _tblMain
            // 
            this._tblMain.ColumnCount = 1;
            this._tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tblMain.Controls.Add(this._tblInputs, 0, 0);
            this._tblMain.Controls.Add(this._tblPegBoard, 0, 1);
            this._tblMain.Controls.Add(this.groupBox1, 0, 2);
            this._tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tblMain.Location = new System.Drawing.Point(0, 0);
            this._tblMain.Name = "_tblMain";
            this._tblMain.RowCount = 3;
            this._tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this._tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this._tblMain.Size = new System.Drawing.Size(898, 529);
            this._tblMain.TabIndex = 1;
            // 
            // _tblPegBoard
            // 
            this._tblPegBoard.ColumnCount = 1;
            this._tblPegBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._tblPegBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tblPegBoard.Location = new System.Drawing.Point(9, 48);
            this._tblPegBoard.Margin = new System.Windows.Forms.Padding(9);
            this._tblPegBoard.Name = "_tblPegBoard";
            this._tblPegBoard.RowCount = 1;
            this._tblPegBoard.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tblPegBoard.Size = new System.Drawing.Size(880, 316);
            this._tblPegBoard.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._tblOutput);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 376);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(892, 150);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output";
            // 
            // _tblOutput
            // 
            this._tblOutput.ColumnCount = 2;
            this._tblOutput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this._tblOutput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this._tblOutput.Controls.Add(this._btnReset, 1, 0);
            this._tblOutput.Controls.Add(this._tblSolutionTable, 0, 0);
            this._tblOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tblOutput.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this._tblOutput.Location = new System.Drawing.Point(3, 16);
            this._tblOutput.Margin = new System.Windows.Forms.Padding(10);
            this._tblOutput.Name = "_tblOutput";
            this._tblOutput.RowCount = 1;
            this._tblOutput.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tblOutput.Size = new System.Drawing.Size(886, 131);
            this._tblOutput.TabIndex = 0;
            // 
            // _btnReset
            // 
            this._btnReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btnReset.Location = new System.Drawing.Point(800, 3);
            this._btnReset.Name = "_btnReset";
            this._btnReset.Size = new System.Drawing.Size(83, 125);
            this._btnReset.TabIndex = 0;
            this._btnReset.Text = "Reset";
            this._btnReset.UseVisualStyleBackColor = true;
            this._btnReset.Click += new System.EventHandler(this.OnClickReset);
            // 
            // _tblSolutionTable
            // 
            this._tblSolutionTable.ColumnCount = 1;
            this._tblSolutionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._tblSolutionTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._tblSolutionTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tblSolutionTable.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this._tblSolutionTable.Location = new System.Drawing.Point(3, 3);
            this._tblSolutionTable.Name = "_tblSolutionTable";
            this._tblSolutionTable.RowCount = 1;
            this._tblSolutionTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tblSolutionTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._tblSolutionTable.Size = new System.Drawing.Size(791, 125);
            this._tblSolutionTable.TabIndex = 1;
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._tblMain);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(898, 529);
            this._tblInputs.ResumeLayout(false);
            this._tblInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudNValue)).EndInit();
            this._tblMain.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this._tblOutput.ResumeLayout(false);
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
        private System.Windows.Forms.Button _btnGoalPoint;
        private System.Windows.Forms.TableLayoutPanel _tblPegBoard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel _tblOutput;
        private System.Windows.Forms.Button _btnReset;
        private System.Windows.Forms.TableLayoutPanel _tblSolutionTable;
    }
}
