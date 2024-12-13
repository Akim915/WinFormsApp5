
using System;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                decimal amount = decimal.Parse(txtAmount.Text);
                string fromCurrency = cbFrom.SelectedItem.ToString();
                string toCurrency = cbTo.SelectedItem.ToString();
                decimal result = ConvertCurrency(amount, fromCurrency, toCurrency);
                lblResult.Text = $"{amount} {fromCurrency} = {result:F2} {toCurrency}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Conversion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal ConvertCurrency(decimal amount, string fromCurrency, string toCurrency)
        {
            var rates = new System.Collections.Generic.Dictionary<string, decimal>
            {
                { "PLN", 1.0m },
                { "USD", 0.22m },
                { "RUB", 16.5m },
                { "EUR", 0.20m },
                { "BAT", 7.6m }
            };

            if (!rates.ContainsKey(fromCurrency) || !rates.ContainsKey(toCurrency))
                throw new Exception("Invalid currency selected.");

            decimal rateFromPLN = rates[fromCurrency];
            decimal rateToPLN = rates[toCurrency];

            return amount / rateFromPLN * rateToPLN;
        }
    }
}