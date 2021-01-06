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
    public partial class SearchFormResults : Form
    {
        private Login Login { get; set; }

        private readonly MainMenu mainmenuForm;

        private readonly string searchTerm;

        private BindingSource bindingSource1 = new BindingSource();

        public SearchFormResults(Login login, MainMenu mainmenuForm, string searchTerm)
        {
            InitializeComponent();
            this.Login = login;
            this.mainmenuForm = mainmenuForm;
            this.searchTerm = searchTerm;
            Owner = mainmenuForm;
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            try
            {
                    bindingSource1.DataSource = Queries.Search(Login, searchTerm);
                    searchDataGridView.DataSource = bindingSource1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Cannot Fill Data Grid", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Hide();
                Owner.Show();
            }
        }

        private void searchFormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Owner.Show();
        }
    }
}
