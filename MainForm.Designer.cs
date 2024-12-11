namespace courseProject {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            lblTitle = new Label();
            lblIp = new Label();
            txtIpInput = new TextBox();
            btnSearch = new Button();
            ipLbl = new Label();
            countryLbl = new Label();
            latLbl = new Label();
            lonLbl = new Label();
            lblResultIp = new Label();
            lblResultCountry = new Label();
            lblResultLat = new Label();
            lblResultLon = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTitle.ForeColor = SystemColors.Window;
            lblTitle.Location = new Point(60, 60);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(315, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Определение местоположения по IP";
            // 
            // lblIp
            // 
            lblIp.AutoSize = true;
            lblIp.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblIp.ForeColor = SystemColors.Window;
            lblIp.Location = new Point(70, 222);
            lblIp.Name = "lblIp";
            lblIp.Size = new Size(295, 19);
            lblIp.TabIndex = 1;
            lblIp.Text = "Введите ниже IP-адрес в формате 1.1.1.1:";
            // 
            // txtIpInput
            // 
            txtIpInput.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtIpInput.ForeColor = Color.FromArgb(64, 64, 64);
            txtIpInput.Location = new Point(113, 253);
            txtIpInput.Name = "txtIpInput";
            txtIpInput.Size = new Size(208, 23);
            txtIpInput.TabIndex = 2;
            txtIpInput.Text = "192.168.0.1";
            txtIpInput.TextAlign = HorizontalAlignment.Center;
            txtIpInput.Click += TxtIpInput_Click;
            txtIpInput.KeyPress += TxtIpInput_KeyPress;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ControlLight;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnSearch.Location = new Point(113, 287);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(208, 31);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Узнать местоположение";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += BtnSearch_Click;
            // 
            // ipLbl
            // 
            ipLbl.AutoSize = true;
            ipLbl.Font = new Font("Calibri", 12F);
            ipLbl.ForeColor = SystemColors.Window;
            ipLbl.Location = new Point(70, 100);
            ipLbl.Name = "ipLbl";
            ipLbl.Size = new Size(25, 19);
            ipLbl.TabIndex = 4;
            ipLbl.Text = "IP:";
            // 
            // countryLbl
            // 
            countryLbl.AutoSize = true;
            countryLbl.Font = new Font("Calibri", 12F);
            countryLbl.ForeColor = SystemColors.Window;
            countryLbl.Location = new Point(70, 126);
            countryLbl.Name = "countryLbl";
            countryLbl.Size = new Size(61, 19);
            countryLbl.TabIndex = 5;
            countryLbl.Text = "Страна:";
            // 
            // latLbl
            // 
            latLbl.AutoSize = true;
            latLbl.Font = new Font("Calibri", 12F);
            latLbl.ForeColor = SystemColors.Window;
            latLbl.Location = new Point(70, 152);
            latLbl.Name = "latLbl";
            latLbl.Size = new Size(70, 19);
            latLbl.TabIndex = 6;
            latLbl.Text = "Ширина:";
            // 
            // lonLbl
            // 
            lonLbl.AutoSize = true;
            lonLbl.Font = new Font("Calibri", 12F);
            lonLbl.ForeColor = SystemColors.Window;
            lonLbl.Location = new Point(70, 178);
            lonLbl.Name = "lonLbl";
            lonLbl.Size = new Size(67, 19);
            lonLbl.TabIndex = 7;
            lonLbl.Text = "Долгота:";
            // 
            // lblResultIp
            // 
            lblResultIp.AutoSize = true;
            lblResultIp.Font = new Font("Calibri", 12F);
            lblResultIp.ForeColor = SystemColors.Window;
            lblResultIp.Location = new Point(148, 100);
            lblResultIp.Name = "lblResultIp";
            lblResultIp.Size = new Size(85, 19);
            lblResultIp.TabIndex = 4;
            lblResultIp.Text = "192.168.0.1";
            // 
            // lblResultCountry
            // 
            lblResultCountry.AutoSize = true;
            lblResultCountry.Font = new Font("Calibri", 12F);
            lblResultCountry.ForeColor = SystemColors.Window;
            lblResultCountry.Location = new Point(148, 126);
            lblResultCountry.Name = "lblResultCountry";
            lblResultCountry.Size = new Size(33, 19);
            lblResultCountry.TabIndex = 5;
            lblResultCountry.Text = "N/A";
            // 
            // lblResultLat
            // 
            lblResultLat.AutoSize = true;
            lblResultLat.Font = new Font("Calibri", 12F);
            lblResultLat.ForeColor = SystemColors.Window;
            lblResultLat.Location = new Point(148, 152);
            lblResultLat.Name = "lblResultLat";
            lblResultLat.Size = new Size(33, 19);
            lblResultLat.TabIndex = 6;
            lblResultLat.Text = "N/A";
            // 
            // lblResultLon
            // 
            lblResultLon.AutoSize = true;
            lblResultLon.Font = new Font("Calibri", 12F);
            lblResultLon.ForeColor = SystemColors.Window;
            lblResultLon.Location = new Point(148, 178);
            lblResultLon.Name = "lblResultLon";
            lblResultLon.Size = new Size(33, 19);
            lblResultLon.TabIndex = 7;
            lblResultLon.Text = "N/A";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(434, 379);
            Controls.Add(lblResultLon);
            Controls.Add(lonLbl);
            Controls.Add(lblResultLat);
            Controls.Add(lblResultCountry);
            Controls.Add(latLbl);
            Controls.Add(lblResultIp);
            Controls.Add(countryLbl);
            Controls.Add(ipLbl);
            Controls.Add(btnSearch);
            Controls.Add(txtIpInput);
            Controls.Add(lblIp);
            Controls.Add(lblTitle);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "IP Location Finder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblIp;
        private TextBox txtIpInput;
        private Button btnSearch;
        private Label ipLbl;
        private Label countryLbl;
        private Label latLbl;
        private Label lonLbl;
        private Label lblResultIp;
        private Label lblResultCountry;
        private Label lblResultLat;
        private Label lblResultLon;
    }
}
