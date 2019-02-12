namespace Kinderbijslag
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
            this.panelLayout = new System.Windows.Forms.Panel();
            this.buttonAddDates = new System.Windows.Forms.Button();
            this.panelAmount = new System.Windows.Forms.Panel();
            this.numericUpDownAmount1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAmount2 = new System.Windows.Forms.NumericUpDown();
            this.panelPrices = new System.Windows.Forms.Panel();
            this.labelPrice1 = new System.Windows.Forms.Label();
            this.labelPrice2 = new System.Windows.Forms.Label();
            this.panelSubscriptions = new System.Windows.Forms.Panel();
            this.labelSubscription1 = new System.Windows.Forms.Label();
            this.labelSubscription2 = new System.Windows.Forms.Label();
            this.panelYear = new System.Windows.Forms.Panel();
            this.numericUpDownYear1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDay1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMonth1 = new System.Windows.Forms.NumericUpDown();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelTicketsTotal = new System.Windows.Forms.Label();
            this.labelPriceTotal = new System.Windows.Forms.Label();
            this.listBoxDates = new System.Windows.Forms.ListBox();
            this.panelLayout.SuspendLayout();
            this.panelAmount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount2)).BeginInit();
            this.panelPrices.SuspendLayout();
            this.panelSubscriptions.SuspendLayout();
            this.panelYear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDay1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLayout
            // 
            this.panelLayout.Controls.Add(this.listBoxDates);
            this.panelLayout.Controls.Add(this.buttonAddDates);
            this.panelLayout.Controls.Add(this.panelAmount);
            this.panelLayout.Controls.Add(this.panelPrices);
            this.panelLayout.Controls.Add(this.panelSubscriptions);
            this.panelLayout.Controls.Add(this.panelYear);
            this.panelLayout.Controls.Add(this.numericUpDownDay1);
            this.panelLayout.Controls.Add(this.numericUpDownMonth1);
            this.panelLayout.Controls.Add(this.buttonCalculate);
            this.panelLayout.Controls.Add(this.labelTicketsTotal);
            this.panelLayout.Controls.Add(this.labelPriceTotal);
            this.panelLayout.Location = new System.Drawing.Point(12, 12);
            this.panelLayout.Name = "panelLayout";
            this.panelLayout.Size = new System.Drawing.Size(561, 215);
            this.panelLayout.TabIndex = 26;
            // 
            // buttonAddDates
            // 
            this.buttonAddDates.Location = new System.Drawing.Point(299, 3);
            this.buttonAddDates.Name = "buttonAddDates";
            this.buttonAddDates.Size = new System.Drawing.Size(75, 23);
            this.buttonAddDates.TabIndex = 56;
            this.buttonAddDates.Text = "add date";
            this.buttonAddDates.UseVisualStyleBackColor = true;
            this.buttonAddDates.Click += new System.EventHandler(this.ButtonAddDates_Click);
            // 
            // panelAmount
            // 
            this.panelAmount.Controls.Add(this.numericUpDownAmount1);
            this.panelAmount.Controls.Add(this.numericUpDownAmount2);
            this.panelAmount.Location = new System.Drawing.Point(212, 3);
            this.panelAmount.Name = "panelAmount";
            this.panelAmount.Size = new System.Drawing.Size(61, 51);
            this.panelAmount.TabIndex = 54;
            // 
            // numericUpDownAmount1
            // 
            this.numericUpDownAmount1.Location = new System.Drawing.Point(3, 0);
            this.numericUpDownAmount1.Name = "numericUpDownAmount1";
            this.numericUpDownAmount1.Size = new System.Drawing.Size(55, 22);
            this.numericUpDownAmount1.TabIndex = 0;
            // 
            // numericUpDownAmount2
            // 
            this.numericUpDownAmount2.Location = new System.Drawing.Point(3, 28);
            this.numericUpDownAmount2.Name = "numericUpDownAmount2";
            this.numericUpDownAmount2.Size = new System.Drawing.Size(55, 22);
            this.numericUpDownAmount2.TabIndex = 8;
            // 
            // panelPrices
            // 
            this.panelPrices.Controls.Add(this.labelPrice1);
            this.panelPrices.Controls.Add(this.labelPrice2);
            this.panelPrices.Location = new System.Drawing.Point(140, 4);
            this.panelPrices.Name = "panelPrices";
            this.panelPrices.Size = new System.Drawing.Size(45, 51);
            this.panelPrices.TabIndex = 53;
            // 
            // labelPrice1
            // 
            this.labelPrice1.AutoSize = true;
            this.labelPrice1.Location = new System.Drawing.Point(4, 3);
            this.labelPrice1.Name = "labelPrice1";
            this.labelPrice1.Size = new System.Drawing.Size(13, 17);
            this.labelPrice1.TabIndex = 6;
            this.labelPrice1.Text = "-";
            // 
            // labelPrice2
            // 
            this.labelPrice2.AutoSize = true;
            this.labelPrice2.Location = new System.Drawing.Point(4, 31);
            this.labelPrice2.Name = "labelPrice2";
            this.labelPrice2.Size = new System.Drawing.Size(13, 17);
            this.labelPrice2.TabIndex = 5;
            this.labelPrice2.Text = "-";
            // 
            // panelSubscriptions
            // 
            this.panelSubscriptions.Controls.Add(this.labelSubscription1);
            this.panelSubscriptions.Controls.Add(this.labelSubscription2);
            this.panelSubscriptions.Location = new System.Drawing.Point(3, 3);
            this.panelSubscriptions.Name = "panelSubscriptions";
            this.panelSubscriptions.Size = new System.Drawing.Size(131, 52);
            this.panelSubscriptions.TabIndex = 52;
            // 
            // labelSubscription1
            // 
            this.labelSubscription1.AutoSize = true;
            this.labelSubscription1.Location = new System.Drawing.Point(4, 4);
            this.labelSubscription1.Name = "labelSubscription1";
            this.labelSubscription1.Size = new System.Drawing.Size(13, 17);
            this.labelSubscription1.TabIndex = 6;
            this.labelSubscription1.Text = "-";
            // 
            // labelSubscription2
            // 
            this.labelSubscription2.AutoSize = true;
            this.labelSubscription2.Location = new System.Drawing.Point(4, 32);
            this.labelSubscription2.Name = "labelSubscription2";
            this.labelSubscription2.Size = new System.Drawing.Size(13, 17);
            this.labelSubscription2.TabIndex = 5;
            this.labelSubscription2.Text = "-";
            // 
            // panelYear
            // 
            this.panelYear.Controls.Add(this.numericUpDownYear1);
            this.panelYear.Location = new System.Drawing.Point(486, 2);
            this.panelYear.Name = "panelYear";
            this.panelYear.Size = new System.Drawing.Size(67, 23);
            this.panelYear.TabIndex = 25;
            // 
            // numericUpDownYear1
            // 
            this.numericUpDownYear1.Location = new System.Drawing.Point(1, 1);
            this.numericUpDownYear1.Maximum = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.numericUpDownYear1.Minimum = new decimal(new int[] {
            1819,
            0,
            0,
            0});
            this.numericUpDownYear1.Name = "numericUpDownYear1";
            this.numericUpDownYear1.ReadOnly = true;
            this.numericUpDownYear1.Size = new System.Drawing.Size(64, 22);
            this.numericUpDownYear1.TabIndex = 24;
            this.numericUpDownYear1.Value = new decimal(new int[] {
            1819,
            0,
            0,
            0});
            // 
            // numericUpDownDay1
            // 
            this.numericUpDownDay1.Location = new System.Drawing.Point(380, 3);
            this.numericUpDownDay1.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDownDay1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDay1.Name = "numericUpDownDay1";
            this.numericUpDownDay1.ReadOnly = true;
            this.numericUpDownDay1.Size = new System.Drawing.Size(47, 22);
            this.numericUpDownDay1.TabIndex = 26;
            this.numericUpDownDay1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownMonth1
            // 
            this.numericUpDownMonth1.Location = new System.Drawing.Point(433, 3);
            this.numericUpDownMonth1.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownMonth1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMonth1.Name = "numericUpDownMonth1";
            this.numericUpDownMonth1.ReadOnly = true;
            this.numericUpDownMonth1.Size = new System.Drawing.Size(47, 22);
            this.numericUpDownMonth1.TabIndex = 25;
            this.numericUpDownMonth1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(10, 167);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(89, 33);
            this.buttonCalculate.TabIndex = 23;
            this.buttonCalculate.Text = "show price";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // labelTicketsTotal
            // 
            this.labelTicketsTotal.AutoSize = true;
            this.labelTicketsTotal.Location = new System.Drawing.Point(7, 130);
            this.labelTicketsTotal.Name = "labelTicketsTotal";
            this.labelTicketsTotal.Size = new System.Drawing.Size(13, 17);
            this.labelTicketsTotal.TabIndex = 22;
            this.labelTicketsTotal.Text = "-";
            // 
            // labelPriceTotal
            // 
            this.labelPriceTotal.AutoSize = true;
            this.labelPriceTotal.Location = new System.Drawing.Point(7, 147);
            this.labelPriceTotal.Name = "labelPriceTotal";
            this.labelPriceTotal.Size = new System.Drawing.Size(13, 17);
            this.labelPriceTotal.TabIndex = 21;
            this.labelPriceTotal.Text = "-";
            // 
            // listBoxDates
            // 
            this.listBoxDates.FormattingEnabled = true;
            this.listBoxDates.ItemHeight = 16;
            this.listBoxDates.Location = new System.Drawing.Point(486, 31);
            this.listBoxDates.Name = "listBoxDates";
            this.listBoxDates.Size = new System.Drawing.Size(67, 180);
            this.listBoxDates.TabIndex = 57;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelLayout);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLayout.ResumeLayout(false);
            this.panelLayout.PerformLayout();
            this.panelAmount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount2)).EndInit();
            this.panelPrices.ResumeLayout(false);
            this.panelPrices.PerformLayout();
            this.panelSubscriptions.ResumeLayout(false);
            this.panelSubscriptions.PerformLayout();
            this.panelYear.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDay1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLayout;
        private System.Windows.Forms.Panel panelAmount;
        private System.Windows.Forms.NumericUpDown numericUpDownAmount1;
        private System.Windows.Forms.NumericUpDown numericUpDownAmount2;
        private System.Windows.Forms.Panel panelPrices;
        private System.Windows.Forms.Label labelPrice1;
        private System.Windows.Forms.Label labelPrice2;
        private System.Windows.Forms.Panel panelSubscriptions;
        private System.Windows.Forms.Label labelSubscription1;
        private System.Windows.Forms.Label labelSubscription2;
        private System.Windows.Forms.Panel panelYear;
        private System.Windows.Forms.NumericUpDown numericUpDownYear1;
        private System.Windows.Forms.NumericUpDown numericUpDownDay1;
        private System.Windows.Forms.NumericUpDown numericUpDownMonth1;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelTicketsTotal;
        private System.Windows.Forms.Label labelPriceTotal;
        private System.Windows.Forms.Button buttonAddDates;
        private System.Windows.Forms.ListBox listBoxDates;
    }
}

