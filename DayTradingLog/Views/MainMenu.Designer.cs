
namespace DayTradingLog
{
    partial class MainMenu
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
            this.addTradeButton = new System.Windows.Forms.Button();
            this.editTradeButton = new System.Windows.Forms.Button();
            this.deleteTradeButton = new System.Windows.Forms.Button();
            this.reportsButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.stockLogDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.stockLogDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addTradeButton
            // 
            this.addTradeButton.Location = new System.Drawing.Point(79, 46);
            this.addTradeButton.Name = "addTradeButton";
            this.addTradeButton.Size = new System.Drawing.Size(96, 36);
            this.addTradeButton.TabIndex = 0;
            this.addTradeButton.Text = "Add Trade";
            this.addTradeButton.UseVisualStyleBackColor = true;
            this.addTradeButton.Click += new System.EventHandler(this.addTradeButton_Click);
            // 
            // editTradeButton
            // 
            this.editTradeButton.Location = new System.Drawing.Point(247, 46);
            this.editTradeButton.Name = "editTradeButton";
            this.editTradeButton.Size = new System.Drawing.Size(96, 36);
            this.editTradeButton.TabIndex = 1;
            this.editTradeButton.Text = "Edit Trade";
            this.editTradeButton.UseVisualStyleBackColor = true;
            // 
            // deleteTradeButton
            // 
            this.deleteTradeButton.Location = new System.Drawing.Point(431, 46);
            this.deleteTradeButton.Name = "deleteTradeButton";
            this.deleteTradeButton.Size = new System.Drawing.Size(96, 36);
            this.deleteTradeButton.TabIndex = 2;
            this.deleteTradeButton.Text = "Delete Trade";
            this.deleteTradeButton.UseVisualStyleBackColor = true;
            // 
            // reportsButton
            // 
            this.reportsButton.Location = new System.Drawing.Point(608, 46);
            this.reportsButton.Name = "reportsButton";
            this.reportsButton.Size = new System.Drawing.Size(96, 36);
            this.reportsButton.TabIndex = 3;
            this.reportsButton.Text = "Reports";
            this.reportsButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(822, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 4;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(847, 53);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(96, 36);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // stockLogDataGridView
            // 
            this.stockLogDataGridView.AllowUserToAddRows = false;
            this.stockLogDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stockLogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockLogDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.stockLogDataGridView.Location = new System.Drawing.Point(12, 111);
            this.stockLogDataGridView.MultiSelect = false;
            this.stockLogDataGridView.Name = "stockLogDataGridView";
            this.stockLogDataGridView.Size = new System.Drawing.Size(1374, 513);
            this.stockLogDataGridView.TabIndex = 6;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 767);
            this.Controls.Add(this.stockLogDataGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.reportsButton);
            this.Controls.Add(this.deleteTradeButton);
            this.Controls.Add(this.editTradeButton);
            this.Controls.Add(this.addTradeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Day Trading Log - Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.stockLogDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addTradeButton;
        private System.Windows.Forms.Button editTradeButton;
        private System.Windows.Forms.Button deleteTradeButton;
        private System.Windows.Forms.Button reportsButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView stockLogDataGridView;
    }
}