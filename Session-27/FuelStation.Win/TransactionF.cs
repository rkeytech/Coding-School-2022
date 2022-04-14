using FuelStation.Blazor.Shared;
using FuelStation.Win.HelperFunctions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStation.Win
{
    public partial class TransactionF : Form
    {
        private uint _transactionID = 0;
        private TransactionEditViewModel _transaction;
        private readonly HttpClient _httpClient;
        private ControlsHelper _controlsHelper;


        public TransactionF(HttpClient httpClient)
        {
            InitializeComponent();
            _httpClient = httpClient;
            _controlsHelper = new ControlsHelper();
        }

        public TransactionF(HttpClient httpClient, uint id) : this(httpClient)
        {
            _transactionID = id;
        }

        private async void TransactionF_Load(object sender, EventArgs e)
        {
            _transaction = await _httpClient.GetFromJsonAsync<TransactionEditViewModel>($"transaction/{_transactionID}");

            bsTransaction.DataSource = _transaction;
            bsTransactionLines.DataSource = bsTransaction;
            bsTransactionLines.DataMember = "TransactionLines";

            grdTransactionLines.DataSource = bsTransactionLines;
            PopulateControls();
            SetDataBindings();
        }

        private async void PopulateControls()
        {
            var employees = await _httpClient.GetFromJsonAsync<List<EmployeeListViewModel>>("employee");
            
            if(employees is not null)
                _controlsHelper.PopulateEmployees(ctrlTransactionEmployee, employees);
            _controlsHelper.PopulatePaymentMethod(ctrlPaymentMethod);
        }

        private void SetDataBindings()
        {
            ctrlTransactionDate.DataBindings.Add(new Binding("Value", bsTransaction, "Date", true));
            ctrlTransactionEmployee.DataBindings.Add(new Binding("SelectedItem", bsTransaction, "EmployeeID", true));
            ctrlPaymentMethod.DataBindings.Add(new Binding("SelectedItem", bsTransaction, "PaymentMethod", true));
            ctrlTransactionTotalValue.DataBindings.Add(new Binding("Value", bsTransaction, "TotalValue", true));

        }

        private async void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response;
            if (_transactionID == 0)
            {
                response = await _httpClient.PostAsJsonAsync("transaction", _transaction);
            }
            else
            {
                response = await _httpClient.PutAsJsonAsync("transaction", _transaction);
            }
            response.EnsureSuccessStatusCode();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelCustomer_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        
    }
}
