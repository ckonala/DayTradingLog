
namespace DayTradingLog.Views
{
    partial class ReportsForm
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
            this.generatePLbyDateButton = new System.Windows.Forms.Button();
            this.showPLByTickerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.reportsDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // generatePLbyDateButton
            // 
            this.generatePLbyDateButton.Location = new System.Drawing.Point(218, 80);
            this.generatePLbyDateButton.Name = "generatePLbyDateButton";
            this.generatePLbyDateButton.Size = new System.Drawing.Size(75, 23);
            this.generatePLbyDateButton.TabIndex = 0;
            this.generatePLbyDateButton.Text = "Generate";
            this.generatePLbyDateButton.UseVisualStyleBackColor = true;
            this.generatePLbyDateButton.Click += new System.EventHandler(this.generatePLbyDateButton_Click);
            // 
            // showPLByTickerButton
            // 
            this.showPLByTickerButton.Location = new System.Drawing.Point(609, 80);
            this.showPLByTickerButton.Name = "showPLByTickerButton";
            this.showPLByTickerButton.Size = new System.Drawing.Size(75, 23);
            this.showPLByTickerButton.TabIndex = 1;
            this.showPLByTickerButton.Text = "Generate";
            this.showPLByTickerButton.UseVisualStyleBackColor = true;
            this.showPLByTickerButton.Click += new System.EventHandler(this.showPLByTickerButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Show P/L by Date";
            // 
            // reportsDataGridView
            // 
            this.reportsDataGridView.AllowUserToAddRows = false;
            this.reportsDataGridView.AllowUserToDeleteRows = false;
            this.reportsDataGridView.AllowUserToOrderColumns = true;
            this.reportsDataGridView.AllowUserToResizeColumns = false;
            this.reportsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reportsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.reportsDataGridView.Location = new System.Drawing.Point(11, 127);
            this.reportsDataGridView.MultiSelect = false;
            this.reportsDataGridView.Name = "reportsDataGridView";
            this.reportsDataGridView.ReadOnly = true;
            this.reportsDataGridView.Size = new System.Drawing.Size(1080, 450);
            this.reportsDataGridView.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(558, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Show P/L by Ticker";
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 609);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reportsDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showPLByTickerButton);
            this.Controls.Add(this.generatePLbyDateButton);
            this.MaximizeBox = false;
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.reportsFormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generatePLbyDateButton;
        private System.Windows.Forms.Button showPLByTickerButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView reportsDataGridView;
        private System.Windows.Forms.Label label2;
    }
}