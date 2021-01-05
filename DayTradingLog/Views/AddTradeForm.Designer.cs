
using DayTradingLog.Classes;

namespace DayTradingLog.Views
{
    partial class AddTradeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tickerTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tickerDescTextBox = new System.Windows.Forms.TextBox();
            this.tradeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.qtyTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.purchasePriceTextBox = new System.Windows.Forms.TextBox();
            this.salePriceTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.tradeTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trade Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ticker Symbol";
            // 
            // tickerTextBox
            // 
            this.tickerTextBox.Location = new System.Drawing.Point(179, 82);
            this.tickerTextBox.Name = "tickerTextBox";
            this.tickerTextBox.Size = new System.Drawing.Size(217, 20);
            this.tickerTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ticker Description";
            // 
            // tickerDescTextBox
            // 
            this.tickerDescTextBox.Location = new System.Drawing.Point(179, 116);
            this.tickerDescTextBox.Multiline = true;
            this.tickerDescTextBox.Name = "tickerDescTextBox";
            this.tickerDescTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tickerDescTextBox.Size = new System.Drawing.Size(217, 63);
            this.tickerDescTextBox.TabIndex = 5;
            // 
            // tradeDateTimePicker
            // 
            this.tradeDateTimePicker.Location = new System.Drawing.Point(179, 201);
            this.tradeDateTimePicker.Name = "tradeDateTimePicker";
            this.tradeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.tradeDateTimePicker.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Trade Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Trade Qty";
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.Location = new System.Drawing.Point(179, 250);
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.Size = new System.Drawing.Size(217, 20);
            this.qtyTextBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Purchase Cost";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Sold At";
            // 
            // purchasePriceTextBox
            // 
            this.purchasePriceTextBox.Location = new System.Drawing.Point(179, 296);
            this.purchasePriceTextBox.Name = "purchasePriceTextBox";
            this.purchasePriceTextBox.Size = new System.Drawing.Size(217, 20);
            this.purchasePriceTextBox.TabIndex = 12;
            // 
            // salePriceTextBox
            // 
            this.salePriceTextBox.Location = new System.Drawing.Point(179, 340);
            this.salePriceTextBox.Name = "salePriceTextBox";
            this.salePriceTextBox.Size = new System.Drawing.Size(217, 20);
            this.salePriceTextBox.TabIndex = 13;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(179, 397);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 14;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // tradeTypeComboBox
            // 
            this.tradeTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tradeTypeComboBox.FormattingEnabled = true;
            this.tradeTypeComboBox.Location = new System.Drawing.Point(179, 49);
            this.tradeTypeComboBox.Name = "tradeTypeComboBox";
            this.tradeTypeComboBox.Size = new System.Drawing.Size(217, 21);
            this.tradeTypeComboBox.TabIndex = 15;
            // 
            // AddTradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 480);
            this.Controls.Add(this.tradeTypeComboBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.salePriceTextBox);
            this.Controls.Add(this.purchasePriceTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.qtyTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tradeDateTimePicker);
            this.Controls.Add(this.tickerDescTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tickerTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddTradeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Trade";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.addTradeFormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tickerTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tickerDescTextBox;
        private System.Windows.Forms.DateTimePicker tradeDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox qtyTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox purchasePriceTextBox;
        private System.Windows.Forms.TextBox salePriceTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.ComboBox tradeTypeComboBox;
    }
}