namespace CurrencyConverter
{
    partial class FormCurrencyConverter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxFrom = new ComboBox();
            comboBoxTo = new ComboBox();
            buttonConvert = new Button();
            labelResult = new Label();
            listBoxHistory = new ListBox();
            textBoxAmount = new TextBox();
            panelInput = new Panel();
            labelAmount = new Label();
            labelTo = new Label();
            labelFrom = new Label();
            panelHistory = new Panel();
            labelHistoryTitle = new Label();
            panelInput.SuspendLayout();
            panelHistory.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxFrom
            // 
            comboBoxFrom.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFrom.FormattingEnabled = true;
            comboBoxFrom.Items.AddRange(new object[] { "USD", "EUR", "BRL", "GBP" });
            comboBoxFrom.Location = new Point(99, 8);
            comboBoxFrom.Name = "comboBoxFrom";
            comboBoxFrom.Size = new Size(60, 25);
            comboBoxFrom.TabIndex = 0;
            // 
            // comboBoxTo
            // 
            comboBoxTo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTo.FormattingEnabled = true;
            comboBoxTo.Items.AddRange(new object[] { "USD", "EUR", "BRL", "GBP" });
            comboBoxTo.Location = new Point(99, 39);
            comboBoxTo.Name = "comboBoxTo";
            comboBoxTo.Size = new Size(60, 25);
            comboBoxTo.TabIndex = 1;
            // 
            // buttonConvert
            // 
            buttonConvert.AutoSize = true;
            buttonConvert.BackColor = Color.DodgerBlue;
            buttonConvert.FlatStyle = FlatStyle.Flat;
            buttonConvert.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonConvert.ForeColor = Color.White;
            buttonConvert.Location = new Point(10, 101);
            buttonConvert.Name = "buttonConvert";
            buttonConvert.Size = new Size(149, 33);
            buttonConvert.TabIndex = 3;
            buttonConvert.Text = "Converter";
            buttonConvert.UseVisualStyleBackColor = false;
            buttonConvert.Click += ButtonConvert_Click;
            // 
            // labelResult
            // 
            labelResult.BackColor = Color.White;
            labelResult.BorderStyle = BorderStyle.FixedSingle;
            labelResult.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelResult.ForeColor = Color.DarkSlateGray;
            labelResult.Location = new Point(172, 7);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(149, 127);
            labelResult.TabIndex = 2;
            labelResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listBoxHistory
            // 
            listBoxHistory.Dock = DockStyle.Bottom;
            listBoxHistory.FormattingEnabled = true;
            listBoxHistory.ItemHeight = 17;
            listBoxHistory.Location = new Point(10, 34);
            listBoxHistory.Name = "listBoxHistory";
            listBoxHistory.Size = new Size(314, 123);
            listBoxHistory.TabIndex = 3;
            listBoxHistory.TabStop = false;
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(99, 70);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(60, 25);
            textBoxAmount.TabIndex = 2;
            // 
            // panelInput
            // 
            panelInput.BackColor = Color.White;
            panelInput.Controls.Add(buttonConvert);
            panelInput.Controls.Add(labelResult);
            panelInput.Controls.Add(textBoxAmount);
            panelInput.Controls.Add(labelAmount);
            panelInput.Controls.Add(comboBoxTo);
            panelInput.Controls.Add(labelTo);
            panelInput.Controls.Add(labelFrom);
            panelInput.Controls.Add(comboBoxFrom);
            panelInput.Dock = DockStyle.Top;
            panelInput.Location = new Point(0, 0);
            panelInput.Name = "panelInput";
            panelInput.Padding = new Padding(10, 11, 10, 11);
            panelInput.Size = new Size(334, 143);
            panelInput.TabIndex = 5;
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.Location = new Point(10, 73);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(83, 17);
            labelAmount.TabIndex = 2;
            labelAmount.Text = "Qunatidade: ";
            // 
            // labelTo
            // 
            labelTo.AutoSize = true;
            labelTo.Location = new Point(10, 42);
            labelTo.Name = "labelTo";
            labelTo.Size = new Size(41, 17);
            labelTo.TabIndex = 2;
            labelTo.Text = "Para: ";
            // 
            // labelFrom
            // 
            labelFrom.AutoSize = true;
            labelFrom.Location = new Point(10, 11);
            labelFrom.Name = "labelFrom";
            labelFrom.Size = new Size(31, 17);
            labelFrom.TabIndex = 2;
            labelFrom.Text = "De: ";
            // 
            // panelHistory
            // 
            panelHistory.BackColor = Color.WhiteSmoke;
            panelHistory.Controls.Add(labelHistoryTitle);
            panelHistory.Controls.Add(listBoxHistory);
            panelHistory.Dock = DockStyle.Fill;
            panelHistory.Location = new Point(0, 143);
            panelHistory.Name = "panelHistory";
            panelHistory.Padding = new Padding(10, 11, 10, 11);
            panelHistory.Size = new Size(334, 168);
            panelHistory.TabIndex = 6;
            // 
            // labelHistoryTitle
            // 
            labelHistoryTitle.Dock = DockStyle.Top;
            labelHistoryTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHistoryTitle.Location = new Point(10, 11);
            labelHistoryTitle.Name = "labelHistoryTitle";
            labelHistoryTitle.Size = new Size(314, 21);
            labelHistoryTitle.TabIndex = 2;
            labelHistoryTitle.Text = "Histórico";
            // 
            // FormCurrencyConverter
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 311);
            Controls.Add(panelHistory);
            Controls.Add(panelInput);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            MaximumSize = new Size(350, 350);
            MinimumSize = new Size(350, 350);
            Name = "FormCurrencyConverter";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Currency Converter";
            panelInput.ResumeLayout(false);
            panelInput.PerformLayout();
            panelHistory.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxFrom;
        private ComboBox comboBoxTo;
        private Button buttonConvert;
        private Label labelResult;
        private ListBox listBoxHistory;
        private TextBox textBoxAmount;
        private Panel panelInput;
        private Label labelFrom;
        private Panel panelHistory;
        private Label labelAmount;
        private Label labelTo;
        private Label labelHistoryTitle;
    }
}
