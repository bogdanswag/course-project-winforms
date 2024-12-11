using Microsoft.Web.WebView2.WinForms;
using System.Text.RegularExpressions;


namespace courseProject {
    public partial class MainForm : Form {
        private readonly IpInfoService ipService;
        private WebView2? webView;

        public MainForm() {
            InitializeComponent();
            ipService = new IpInfoService();

            Size = new Size(450, 418);
        }

        private async Task FetchIpInfo() {
            var ip = txtIpInput.Text;

            if (string.IsNullOrWhiteSpace(ip)) {
                MessageBox.Show("Введите IP адрес!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var ipInfo = await IpInfoService.GetIpInfo(ip);
            if (ipInfo != null) {
                string latitude = ipInfo.Latitude.ToString().Replace(',', '.');
                string longitude = ipInfo.Longitude.ToString().Replace(',', '.');

                lblResultIp.Text = $"{ipInfo.Ip}";
                lblResultCountry.Text = $"{ipInfo.Country}";
                lblResultLat.Text = $"{latitude}";
                lblResultLon.Text = $"{longitude}";

                ExpandFormAndShowMap(latitude, longitude);
            } else {
                MessageBox.Show("Не удалось получить данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtIpInput_Click(object sender, EventArgs e) {
            int clickCount = 0;
            clickCount++;
            if (clickCount == 1) {
                return;
            } else {
                txtIpInput.Text = "";
                txtIpInput.ForeColor = Color.Black;
            }
        }

        private bool firstError = true;

        private void TxtIpInput_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Back) {
                return;
            }

            string currentText = txtIpInput.Text + e.KeyChar;

            if (currentText.Length > 15) {
                txtIpInput.Text = txtIpInput.Text.Substring(0, txtIpInput.Text.Length);
                txtIpInput.SelectionStart = txtIpInput.Text.Length;
                e.Handled = true;
                return;
            }

            if (string.IsNullOrEmpty(currentText)) {
                return;
            }

            string pattern = @"^(\d{1,3}\.){3}\d{1,3}$";
            Regex regex = new(pattern);

            if (!regex.IsMatch(currentText) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back) {
                e.Handled = true;

                if (firstError) {
                    MessageBox.Show("Некорректный символ!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    firstError = false;
                }
            }

            string[] parts = currentText.Split('.');
            foreach (var part in parts) {
                if (part.Length > 3) {
                    e.Handled = true;
                    if (firstError) {
                        MessageBox.Show("Каждая часть IP-адреса не может содержать больше 3 цифр!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        firstError = false;
                    }
                    break;
                }
            }
        }

        private async void BtnSearch_Click(object sender, EventArgs e) {
            await FetchIpInfo();
        }

        private void ExpandFormAndShowMap(string latitude, string longitude) {
            Size = new Size(950, 418);

            if (webView == null) {
                webView = new WebView2 {
                    Dock = DockStyle.Right,
                    Size = new Size(450, 418),
                };
                Controls.Add(webView);

                webView.Source = new Uri($"https://www.google.com/maps?q={latitude},{longitude}");
            } else {
                webView.Source = new Uri($"https://www.google.com/maps?q={latitude},{longitude}");
            }
        }

    }
}
