namespace Bwz.Rappi
{
    partial class TimeTableFormStepClear
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
            this.LblHeader = new System.Windows.Forms.Label();
            this.LblMasterFileData = new System.Windows.Forms.Label();
            this.LblFirstnameCaption = new System.Windows.Forms.Label();
            this.LblNameCaption = new System.Windows.Forms.Label();
            this.LblSalaryCaption = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbxDate = new System.Windows.Forms.TextBox();
            this.CmdDateOk = new System.Windows.Forms.Button();
            this.LblDateError = new System.Windows.Forms.Label();
            this.LblTimeTable = new System.Windows.Forms.Label();
            this.LbxFrom = new System.Windows.Forms.ListBox();
            this.LblFromCol = new System.Windows.Forms.Label();
            this.LbxTo = new System.Windows.Forms.ListBox();
            this.LbxTimeRange = new System.Windows.Forms.ListBox();
            this.LbxSalary = new System.Windows.Forms.ListBox();
            this.LblEquals = new System.Windows.Forms.Label();
            this.LblToCol = new System.Windows.Forms.Label();
            this.LblTimeRangeCol = new System.Windows.Forms.Label();
            this.LblSalaryCol = new System.Windows.Forms.Label();
            this.LblTotalCaption = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.CmdClearAll = new System.Windows.Forms.Button();
            this.CmdClearSingle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LblNewFrom = new System.Windows.Forms.Label();
            this.LblNewTo = new System.Windows.Forms.Label();
            this.NumFrom = new System.Windows.Forms.NumericUpDown();
            this.NumTo = new System.Windows.Forms.NumericUpDown();
            this.CmdInsert = new System.Windows.Forms.Button();
            this.LblInsertError = new System.Windows.Forms.Label();
            this.TbxFirstName = new System.Windows.Forms.TextBox();
            this.TbxLastName = new System.Windows.Forms.TextBox();
            this.TbxSalary = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumTo)).BeginInit();
            this.SuspendLayout();
            // 
            // LblHeader
            // 
            this.LblHeader.AutoSize = true;
            this.LblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeader.Location = new System.Drawing.Point(12, 9);
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Size = new System.Drawing.Size(180, 31);
            this.LblHeader.TabIndex = 0;
            this.LblHeader.Text = "Zeiterfassung";
            // 
            // LblMasterFileData
            // 
            this.LblMasterFileData.AutoSize = true;
            this.LblMasterFileData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMasterFileData.Location = new System.Drawing.Point(12, 64);
            this.LblMasterFileData.Name = "LblMasterFileData";
            this.LblMasterFileData.Size = new System.Drawing.Size(123, 25);
            this.LblMasterFileData.TabIndex = 1;
            this.LblMasterFileData.Text = "Stammdaten";
            // 
            // LblFirstnameCaption
            // 
            this.LblFirstnameCaption.AutoSize = true;
            this.LblFirstnameCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFirstnameCaption.Location = new System.Drawing.Point(15, 98);
            this.LblFirstnameCaption.Name = "LblFirstnameCaption";
            this.LblFirstnameCaption.Size = new System.Drawing.Size(68, 18);
            this.LblFirstnameCaption.TabIndex = 2;
            this.LblFirstnameCaption.Text = "Vorname";
            // 
            // LblNameCaption
            // 
            this.LblNameCaption.AutoSize = true;
            this.LblNameCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNameCaption.Location = new System.Drawing.Point(14, 123);
            this.LblNameCaption.Name = "LblNameCaption";
            this.LblNameCaption.Size = new System.Drawing.Size(80, 18);
            this.LblNameCaption.TabIndex = 3;
            this.LblNameCaption.Text = "Nachname";
            // 
            // LblSalaryCaption
            // 
            this.LblSalaryCaption.AutoSize = true;
            this.LblSalaryCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSalaryCaption.Location = new System.Drawing.Point(14, 148);
            this.LblSalaryCaption.Name = "LblSalaryCaption";
            this.LblSalaryCaption.Size = new System.Drawing.Size(90, 18);
            this.LblSalaryCaption.TabIndex = 4;
            this.LblSalaryCaption.Text = "Stundenlohn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Datum";
            // 
            // TbxDate
            // 
            this.TbxDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxDate.Location = new System.Drawing.Point(127, 173);
            this.TbxDate.MaxLength = 10;
            this.TbxDate.Name = "TbxDate";
            this.TbxDate.Size = new System.Drawing.Size(100, 22);
            this.TbxDate.TabIndex = 9;
            // 
            // CmdDateOk
            // 
            this.CmdDateOk.FlatAppearance.BorderSize = 0;
            this.CmdDateOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdDateOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdDateOk.ForeColor = System.Drawing.Color.Blue;
            this.CmdDateOk.Location = new System.Drawing.Point(233, 168);
            this.CmdDateOk.Name = "CmdDateOk";
            this.CmdDateOk.Size = new System.Drawing.Size(44, 30);
            this.CmdDateOk.TabIndex = 10;
            this.CmdDateOk.Text = "OK";
            this.CmdDateOk.UseVisualStyleBackColor = true;
            // 
            // LblDateError
            // 
            this.LblDateError.AutoSize = true;
            this.LblDateError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDateError.Location = new System.Drawing.Point(124, 198);
            this.LblDateError.Name = "LblDateError";
            this.LblDateError.Size = new System.Drawing.Size(0, 17);
            this.LblDateError.TabIndex = 11;
            // 
            // LblTimeTable
            // 
            this.LblTimeTable.AutoSize = true;
            this.LblTimeTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTimeTable.Location = new System.Drawing.Point(13, 231);
            this.LblTimeTable.Name = "LblTimeTable";
            this.LblTimeTable.Size = new System.Drawing.Size(66, 25);
            this.LblTimeTable.TabIndex = 13;
            this.LblTimeTable.Text = "Zeiten";
            // 
            // LbxFrom
            // 
            this.LbxFrom.Enabled = false;
            this.LbxFrom.FormatString = "0.00";
            this.LbxFrom.FormattingEnabled = true;
            this.LbxFrom.ItemHeight = 16;
            this.LbxFrom.Location = new System.Drawing.Point(15, 294);
            this.LbxFrom.Name = "LbxFrom";
            this.LbxFrom.Size = new System.Drawing.Size(120, 84);
            this.LbxFrom.TabIndex = 14;
            // 
            // LblFromCol
            // 
            this.LblFromCol.AutoSize = true;
            this.LblFromCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFromCol.Location = new System.Drawing.Point(15, 273);
            this.LblFromCol.Name = "LblFromCol";
            this.LblFromCol.Size = new System.Drawing.Size(54, 18);
            this.LblFromCol.TabIndex = 15;
            this.LblFromCol.Text = "Von [h]";
            // 
            // LbxTo
            // 
            this.LbxTo.Enabled = false;
            this.LbxTo.FormatString = "0.00";
            this.LbxTo.FormattingEnabled = true;
            this.LbxTo.ItemHeight = 16;
            this.LbxTo.Location = new System.Drawing.Point(141, 294);
            this.LbxTo.Name = "LbxTo";
            this.LbxTo.Size = new System.Drawing.Size(120, 84);
            this.LbxTo.TabIndex = 16;
            // 
            // LbxTimeRange
            // 
            this.LbxTimeRange.Enabled = false;
            this.LbxTimeRange.FormatString = "0.00";
            this.LbxTimeRange.FormattingEnabled = true;
            this.LbxTimeRange.ItemHeight = 16;
            this.LbxTimeRange.Location = new System.Drawing.Point(267, 294);
            this.LbxTimeRange.Name = "LbxTimeRange";
            this.LbxTimeRange.Size = new System.Drawing.Size(120, 84);
            this.LbxTimeRange.TabIndex = 17;
            // 
            // LbxSalary
            // 
            this.LbxSalary.FormatString = "0.00";
            this.LbxSalary.FormattingEnabled = true;
            this.LbxSalary.ItemHeight = 16;
            this.LbxSalary.Location = new System.Drawing.Point(463, 294);
            this.LbxSalary.Name = "LbxSalary";
            this.LbxSalary.Size = new System.Drawing.Size(120, 84);
            this.LbxSalary.TabIndex = 18;
            // 
            // LblEquals
            // 
            this.LblEquals.AutoSize = true;
            this.LblEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEquals.Location = new System.Drawing.Point(417, 327);
            this.LblEquals.Name = "LblEquals";
            this.LblEquals.Size = new System.Drawing.Size(17, 18);
            this.LblEquals.TabIndex = 19;
            this.LblEquals.Text = "=";
            // 
            // LblToCol
            // 
            this.LblToCol.AutoSize = true;
            this.LblToCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblToCol.Location = new System.Drawing.Point(138, 273);
            this.LblToCol.Name = "LblToCol";
            this.LblToCol.Size = new System.Drawing.Size(49, 18);
            this.LblToCol.TabIndex = 20;
            this.LblToCol.Text = "Bis [h]";
            // 
            // LblTimeRangeCol
            // 
            this.LblTimeRangeCol.AutoSize = true;
            this.LblTimeRangeCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTimeRangeCol.Location = new System.Drawing.Point(264, 273);
            this.LblTimeRangeCol.Name = "LblTimeRangeCol";
            this.LblTimeRangeCol.Size = new System.Drawing.Size(68, 18);
            this.LblTimeRangeCol.TabIndex = 21;
            this.LblTimeRangeCol.Text = "Dauer [h]";
            // 
            // LblSalaryCol
            // 
            this.LblSalaryCol.AutoSize = true;
            this.LblSalaryCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSalaryCol.Location = new System.Drawing.Point(460, 273);
            this.LblSalaryCol.Name = "LblSalaryCol";
            this.LblSalaryCol.Size = new System.Drawing.Size(84, 18);
            this.LblSalaryCol.TabIndex = 22;
            this.LblSalaryCol.Text = "Lohn [CHF]";
            // 
            // LblTotalCaption
            // 
            this.LblTotalCaption.AutoSize = true;
            this.LblTotalCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalCaption.Location = new System.Drawing.Point(12, 381);
            this.LblTotalCaption.Name = "LblTotalCaption";
            this.LblTotalCaption.Size = new System.Drawing.Size(41, 18);
            this.LblTotalCaption.TabIndex = 23;
            this.LblTotalCaption.Text = "Total";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(469, 381);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(36, 18);
            this.LblTotal.TabIndex = 24;
            this.LblTotal.Text = "0.00";
            // 
            // CmdClearAll
            // 
            this.CmdClearAll.FlatAppearance.BorderSize = 0;
            this.CmdClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdClearAll.ForeColor = System.Drawing.Color.Blue;
            this.CmdClearAll.Location = new System.Drawing.Point(463, 427);
            this.CmdClearAll.Name = "CmdClearAll";
            this.CmdClearAll.Size = new System.Drawing.Size(120, 30);
            this.CmdClearAll.TabIndex = 25;
            this.CmdClearAll.Text = "Alle löschen";
            this.CmdClearAll.UseVisualStyleBackColor = true;
            // 
            // CmdClearSingle
            // 
            this.CmdClearSingle.FlatAppearance.BorderSize = 0;
            this.CmdClearSingle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdClearSingle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdClearSingle.ForeColor = System.Drawing.Color.Blue;
            this.CmdClearSingle.Location = new System.Drawing.Point(319, 427);
            this.CmdClearSingle.Name = "CmdClearSingle";
            this.CmdClearSingle.Size = new System.Drawing.Size(138, 30);
            this.CmdClearSingle.TabIndex = 26;
            this.CmdClearSingle.Text = "Eintrag löschen";
            this.CmdClearSingle.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 498);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Erfassung";
            // 
            // LblNewFrom
            // 
            this.LblNewFrom.AutoSize = true;
            this.LblNewFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNewFrom.Location = new System.Drawing.Point(15, 535);
            this.LblNewFrom.Name = "LblNewFrom";
            this.LblNewFrom.Size = new System.Drawing.Size(54, 18);
            this.LblNewFrom.TabIndex = 30;
            this.LblNewFrom.Text = "Von [h]";
            // 
            // LblNewTo
            // 
            this.LblNewTo.AutoSize = true;
            this.LblNewTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNewTo.Location = new System.Drawing.Point(138, 535);
            this.LblNewTo.Name = "LblNewTo";
            this.LblNewTo.Size = new System.Drawing.Size(49, 18);
            this.LblNewTo.TabIndex = 31;
            this.LblNewTo.Text = "Bis [h]";
            // 
            // NumFrom
            // 
            this.NumFrom.DecimalPlaces = 2;
            this.NumFrom.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.NumFrom.Location = new System.Drawing.Point(18, 556);
            this.NumFrom.Maximum = new decimal(new int[] {
            2375,
            0,
            0,
            131072});
            this.NumFrom.Name = "NumFrom";
            this.NumFrom.Size = new System.Drawing.Size(117, 22);
            this.NumFrom.TabIndex = 32;
            // 
            // NumTo
            // 
            this.NumTo.DecimalPlaces = 2;
            this.NumTo.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.NumTo.Location = new System.Drawing.Point(141, 556);
            this.NumTo.Maximum = new decimal(new int[] {
            2375,
            0,
            0,
            131072});
            this.NumTo.Name = "NumTo";
            this.NumTo.Size = new System.Drawing.Size(120, 22);
            this.NumTo.TabIndex = 33;
            // 
            // CmdInsert
            // 
            this.CmdInsert.FlatAppearance.BorderSize = 0;
            this.CmdInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdInsert.ForeColor = System.Drawing.Color.Blue;
            this.CmdInsert.Location = new System.Drawing.Point(463, 551);
            this.CmdInsert.Name = "CmdInsert";
            this.CmdInsert.Size = new System.Drawing.Size(120, 30);
            this.CmdInsert.TabIndex = 34;
            this.CmdInsert.Text = "Einfügen";
            this.CmdInsert.UseVisualStyleBackColor = true;
            // 
            // LblInsertError
            // 
            this.LblInsertError.AutoSize = true;
            this.LblInsertError.Location = new System.Drawing.Point(15, 581);
            this.LblInsertError.Name = "LblInsertError";
            this.LblInsertError.Size = new System.Drawing.Size(0, 17);
            this.LblInsertError.TabIndex = 35;
            // 
            // TbxFirstName
            // 
            this.TbxFirstName.Location = new System.Drawing.Point(127, 98);
            this.TbxFirstName.Name = "TbxFirstName";
            this.TbxFirstName.Size = new System.Drawing.Size(100, 22);
            this.TbxFirstName.TabIndex = 36;
            // 
            // TbxLastName
            // 
            this.TbxLastName.Location = new System.Drawing.Point(127, 123);
            this.TbxLastName.Name = "TbxLastName";
            this.TbxLastName.Size = new System.Drawing.Size(100, 22);
            this.TbxLastName.TabIndex = 37;
            // 
            // TbxSalary
            // 
            this.TbxSalary.Location = new System.Drawing.Point(127, 148);
            this.TbxSalary.Name = "TbxSalary";
            this.TbxSalary.Size = new System.Drawing.Size(100, 22);
            this.TbxSalary.TabIndex = 38;
            // 
            // TimeTableFormStepClear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(595, 668);
            this.Controls.Add(this.TbxSalary);
            this.Controls.Add(this.TbxLastName);
            this.Controls.Add(this.TbxFirstName);
            this.Controls.Add(this.LblInsertError);
            this.Controls.Add(this.CmdInsert);
            this.Controls.Add(this.NumTo);
            this.Controls.Add(this.NumFrom);
            this.Controls.Add(this.LblNewTo);
            this.Controls.Add(this.LblNewFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmdClearSingle);
            this.Controls.Add(this.CmdClearAll);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.LblTotalCaption);
            this.Controls.Add(this.LblSalaryCol);
            this.Controls.Add(this.LblTimeRangeCol);
            this.Controls.Add(this.LblToCol);
            this.Controls.Add(this.LblEquals);
            this.Controls.Add(this.LbxSalary);
            this.Controls.Add(this.LbxTimeRange);
            this.Controls.Add(this.LbxTo);
            this.Controls.Add(this.LblFromCol);
            this.Controls.Add(this.LbxFrom);
            this.Controls.Add(this.LblTimeTable);
            this.Controls.Add(this.LblDateError);
            this.Controls.Add(this.CmdDateOk);
            this.Controls.Add(this.TbxDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblSalaryCaption);
            this.Controls.Add(this.LblNameCaption);
            this.Controls.Add(this.LblFirstnameCaption);
            this.Controls.Add(this.LblMasterFileData);
            this.Controls.Add(this.LblHeader);
            this.Name = "TimeTableFormStepClear";
            this.Text = "Time Recorder";
            ((System.ComponentModel.ISupportInitialize)(this.NumFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumTo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblHeader;
        private System.Windows.Forms.Label LblMasterFileData;
        private System.Windows.Forms.Label LblFirstnameCaption;
        private System.Windows.Forms.Label LblNameCaption;
        private System.Windows.Forms.Label LblSalaryCaption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbxDate;
        private System.Windows.Forms.Button CmdDateOk;
        private System.Windows.Forms.Label LblDateError;
        private System.Windows.Forms.Label LblTimeTable;
        private System.Windows.Forms.ListBox LbxFrom;
        private System.Windows.Forms.Label LblFromCol;
        private System.Windows.Forms.ListBox LbxTo;
        private System.Windows.Forms.ListBox LbxTimeRange;
        private System.Windows.Forms.ListBox LbxSalary;
        private System.Windows.Forms.Label LblEquals;
        private System.Windows.Forms.Label LblToCol;
        private System.Windows.Forms.Label LblTimeRangeCol;
        private System.Windows.Forms.Label LblSalaryCol;
        private System.Windows.Forms.Label LblTotalCaption;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Button CmdClearAll;
        private System.Windows.Forms.Button CmdClearSingle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblNewFrom;
        private System.Windows.Forms.Label LblNewTo;
        private System.Windows.Forms.NumericUpDown NumFrom;
        private System.Windows.Forms.NumericUpDown NumTo;
        private System.Windows.Forms.Button CmdInsert;
        private System.Windows.Forms.Label LblInsertError;
        private System.Windows.Forms.TextBox TbxFirstName;
        private System.Windows.Forms.TextBox TbxLastName;
        private System.Windows.Forms.TextBox TbxSalary;
    }
}

