using System.Text.Json;

namespace CurrencyConverter
{
    public partial class FormCurrencyConverter : Form
    {
        private const string ApiUrl = "https://api.exchangerate-api.com/v4/latest/";

        public FormCurrencyConverter()
        {
            InitializeComponent();
        }

        private async void ButtonConvert_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBoxAmount.Text, out decimal amount))
            {
                string fromCurrency = comboBoxFrom.SelectedItem.ToString();
                string toCurrency = comboBoxTo.SelectedItem.ToString();

                try
                {
                    decimal rate = await GetExchangeRate(fromCurrency, toCurrency);
                    decimal convertedAmount = amount * rate;

                    labelResult.Text = $"{convertedAmount:F2} {toCurrency}";

                    listBoxHistory.Items.Add($"{amount} {fromCurrency} = {convertedAmount:F2} {toCurrency}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Por favor entre com uma quatidade válida.");
            }
        }

        private static async Task<decimal> GetExchangeRate(string from, string to)
        {
            using HttpClient client = new();
            HttpResponseMessage response = await client.GetAsync($"{ApiUrl}{from}");

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                JsonDocument doc = JsonDocument.Parse(json);
                JsonElement rates = doc.RootElement.GetProperty("rates");

                if (rates.TryGetProperty(to, out JsonElement rate))
                {
                    return rate.GetDecimal();
                }
            }

            throw new Exception("Falha ao recuperar a taxa de câmbio.");
        }
    }
}
