using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DayTradingLog.Database;

namespace DayTradingLog.Views
{
    public partial class ReportsForm : Form
    {
        private Login Login { get; set; }

        private readonly MainMenu mainmenuForm;

        private BindingSource bindingSource1 = new BindingSource();

        public ReportsForm(Login login, MainMenu mainmenuForm)
        {
            InitializeComponent();
            this.Login = login;
            this.mainmenuForm = mainmenuForm;
        }

        private void generatePLbyDateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var temp = Queries.ShowPLByDate(Login);
                if (temp.Rows.Count != 0)
                {
                    bindingSource1.DataSource = temp;
                    reportsDataGridView.DataSource = bindingSource1;
                }
                else
                {
                    MessageBox.Show("No Search Results to Display", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Fill Data Grid", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Hide();
                Owner.Show();
            }

        }

        private void showPLByTickerButton_Click(object sender, EventArgs e)
        {
            try
            {
                var temp = Queries.ShowPLByTicker(Login);
                if (temp.Rows.Count != 0)
                {
                    bindingSource1.DataSource = temp;
                    reportsDataGridView.DataSource = bindingSource1;
                }
                else
                {
                    MessageBox.Show("No Search Results to Display", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Fill Data Grid", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Hide();
                Owner.Show();
            }

        }

        private void reportsFormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Owner.Show();
        }

       
    }
}
