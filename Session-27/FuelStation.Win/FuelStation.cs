using FuelStation.Blazor.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStation.Win
{
    public partial class FuelStation : Form
    {
        private readonly HttpClient _httpClient;
        private readonly UserAuthenticatedViewModel _user;

        public FuelStation(UserAuthenticatedViewModel user=null)
        {
            InitializeComponent();
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:7254");
            _user = user;
        }

        private void FuelStation_Load(object sender, EventArgs e)
        {

        }

        

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new ItemsF(_httpClient));

        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new CustomersF(_httpClient));
        }
        
        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new TransactionsF(_httpClient));
        }

        private void ShowForm(Form form)
        {
            form.ShowDialog();
        }

    }
}
