namespace Bwz.Rappi
{
    partial class FrmRistorante
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
            this.LblTopic = new System.Windows.Forms.Label();
            this.LblFood = new System.Windows.Forms.Label();
            this.LbxFood = new System.Windows.Forms.ListBox();
            this.LblSelection = new System.Windows.Forms.Label();
            this.LbxSelection = new System.Windows.Forms.ListBox();
            this.CmdSelection = new System.Windows.Forms.Button();
            this.CmdClear = new System.Windows.Forms.Button();
            this.LblOrderTopic = new System.Windows.Forms.Label();
            this.LblSumDescription = new System.Windows.Forms.Label();
            this.LblSum = new System.Windows.Forms.Label();
            this.CmdOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblTopic
            // 
            this.LblTopic.AutoSize = true;
            this.LblTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTopic.Location = new System.Drawing.Point(12, 9);
            this.LblTopic.Name = "LblTopic";
            this.LblTopic.Size = new System.Drawing.Size(156, 25);
            this.LblTopic.TabIndex = 0;
            this.LblTopic.Text = "Menü-Auswahl";
            // 
            // LblFood
            // 
            this.LblFood.AutoSize = true;
            this.LblFood.Location = new System.Drawing.Point(14, 41);
            this.LblFood.Name = "LblFood";
            this.LblFood.Size = new System.Drawing.Size(59, 17);
            this.LblFood.TabIndex = 1;
            this.LblFood.Text = "Speisen";
            // 
            // LbxFood
            // 
            this.LbxFood.FormattingEnabled = true;
            this.LbxFood.ItemHeight = 16;
            this.LbxFood.Items.AddRange(new object[] {
            "Spaghetti 15.-",
            "Canelloni 17.-",
            "Pizza 20.-"});
            this.LbxFood.Location = new System.Drawing.Point(17, 61);
            this.LbxFood.Name = "LbxFood";
            this.LbxFood.Size = new System.Drawing.Size(157, 84);
            this.LbxFood.TabIndex = 2;
            // 
            // LblSelection
            // 
            this.LblSelection.AutoSize = true;
            this.LblSelection.Location = new System.Drawing.Point(258, 41);
            this.LblSelection.Name = "LblSelection";
            this.LblSelection.Size = new System.Drawing.Size(60, 17);
            this.LblSelection.TabIndex = 3;
            this.LblSelection.Text = "Auswahl";
            // 
            // LbxSelection
            // 
            this.LbxSelection.FormattingEnabled = true;
            this.LbxSelection.ItemHeight = 16;
            this.LbxSelection.Location = new System.Drawing.Point(261, 61);
            this.LbxSelection.Name = "LbxSelection";
            this.LbxSelection.Size = new System.Drawing.Size(157, 84);
            this.LbxSelection.TabIndex = 4;
            // 
            // CmdSelection
            // 
            this.CmdSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdSelection.Location = new System.Drawing.Point(180, 92);
            this.CmdSelection.Name = "CmdSelection";
            this.CmdSelection.Size = new System.Drawing.Size(75, 26);
            this.CmdSelection.TabIndex = 5;
            this.CmdSelection.Text = ">>";
            this.CmdSelection.UseVisualStyleBackColor = true;
            this.CmdSelection.Click += new System.EventHandler(this.CmdSelection_Click);
            // 
            // CmdClear
            // 
            this.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdClear.Location = new System.Drawing.Point(261, 151);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(157, 26);
            this.CmdClear.TabIndex = 6;
            this.CmdClear.Text = "Alle Löschen";
            this.CmdClear.UseVisualStyleBackColor = true;
            this.CmdClear.Click += new System.EventHandler(this.CmdClear_Click);
            // 
            // LblOrderTopic
            // 
            this.LblOrderTopic.AutoSize = true;
            this.LblOrderTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOrderTopic.Location = new System.Drawing.Point(18, 227);
            this.LblOrderTopic.Name = "LblOrderTopic";
            this.LblOrderTopic.Size = new System.Drawing.Size(113, 25);
            this.LblOrderTopic.TabIndex = 7;
            this.LblOrderTopic.Text = "Bestellung";
            // 
            // LblSumDescription
            // 
            this.LblSumDescription.AutoSize = true;
            this.LblSumDescription.Location = new System.Drawing.Point(20, 260);
            this.LblSumDescription.Name = "LblSumDescription";
            this.LblSumDescription.Size = new System.Drawing.Size(166, 17);
            this.LblSumDescription.TabIndex = 8;
            this.LblSumDescription.Text = "Summe der Speisen total";
            // 
            // LblSum
            // 
            this.LblSum.AutoSize = true;
            this.LblSum.Location = new System.Drawing.Point(372, 260);
            this.LblSum.Name = "LblSum";
            this.LblSum.Size = new System.Drawing.Size(25, 17);
            this.LblSum.TabIndex = 9;
            this.LblSum.Text = "0.-";
            // 
            // CmdOrder
            // 
            this.CmdOrder.Enabled = false;
            this.CmdOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdOrder.Location = new System.Drawing.Point(261, 293);
            this.CmdOrder.Name = "CmdOrder";
            this.CmdOrder.Size = new System.Drawing.Size(157, 26);
            this.CmdOrder.TabIndex = 10;
            this.CmdOrder.Text = "Bestellen";
            this.CmdOrder.UseVisualStyleBackColor = true;
            this.CmdOrder.Click += new System.EventHandler(this.CmdOrder_Click);
            // 
            // FrmRistorante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(436, 332);
            this.Controls.Add(this.CmdOrder);
            this.Controls.Add(this.LblSum);
            this.Controls.Add(this.LblSumDescription);
            this.Controls.Add(this.LblOrderTopic);
            this.Controls.Add(this.CmdClear);
            this.Controls.Add(this.CmdSelection);
            this.Controls.Add(this.LbxSelection);
            this.Controls.Add(this.LblSelection);
            this.Controls.Add(this.LbxFood);
            this.Controls.Add(this.LblFood);
            this.Controls.Add(this.LblTopic);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmRistorante";
            this.Text = "Ristorante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTopic;
        private System.Windows.Forms.Label LblFood;
        private System.Windows.Forms.ListBox LbxFood;
        private System.Windows.Forms.Label LblSelection;
        private System.Windows.Forms.ListBox LbxSelection;
        private System.Windows.Forms.Button CmdSelection;
        private System.Windows.Forms.Button CmdClear;
        private System.Windows.Forms.Label LblOrderTopic;
        private System.Windows.Forms.Label LblSumDescription;
        private System.Windows.Forms.Label LblSum;
        private System.Windows.Forms.Button CmdOrder;
    }
}

