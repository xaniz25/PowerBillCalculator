namespace PowerBillCalculator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.InputLabel = new System.Windows.Forms.Label();
            this.DropDown = new System.Windows.Forms.ComboBox();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.OffPeakLabel = new System.Windows.Forms.Label();
            this.OffPeakBox = new System.Windows.Forms.TextBox();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.ChargeLabel = new System.Windows.Forms.Label();
            this.ChargeBox = new System.Windows.Forms.TextBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.AcctBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AcctLabel = new System.Windows.Forms.Label();
            this.CustomerList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CustomersLabel = new System.Windows.Forms.Label();
            this.CustomersBox = new System.Windows.Forms.TextBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.IndustrialLabel = new System.Windows.Forms.Label();
            this.CommercialLabel = new System.Windows.Forms.Label();
            this.ResidentialLabel = new System.Windows.Forms.Label();
            this.TotalBox = new System.Windows.Forms.TextBox();
            this.IndustrialBox = new System.Windows.Forms.TextBox();
            this.CommercialBox = new System.Windows.Forms.TextBox();
            this.ResidentialBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerLabel.Location = new System.Drawing.Point(279, 36);
            this.CustomerLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(123, 20);
            this.CustomerLabel.TabIndex = 0;
            this.CustomerLabel.Text = "Customer Type";
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputLabel.Location = new System.Drawing.Point(6, 160);
            this.InputLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(83, 20);
            this.InputLabel.TabIndex = 1;
            this.InputLabel.Text = "Input kWh";
            // 
            // DropDown
            // 
            this.DropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropDown.FormattingEnabled = true;
            this.DropDown.Items.AddRange(new object[] {
            "Residential",
            "Commercial",
            "Industrial"});
            this.DropDown.Location = new System.Drawing.Point(283, 64);
            this.DropDown.Margin = new System.Windows.Forms.Padding(5);
            this.DropDown.Name = "DropDown";
            this.DropDown.Size = new System.Drawing.Size(229, 28);
            this.DropDown.TabIndex = 1;
            this.DropDown.SelectedIndexChanged += new System.EventHandler(this.DropDown_SelectedIndexChanged);
            // 
            // InputBox
            // 
            this.InputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputBox.Location = new System.Drawing.Point(11, 188);
            this.InputBox.Margin = new System.Windows.Forms.Padding(5);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(229, 26);
            this.InputBox.TabIndex = 3;
            // 
            // OffPeakLabel
            // 
            this.OffPeakLabel.AutoSize = true;
            this.OffPeakLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OffPeakLabel.Location = new System.Drawing.Point(279, 160);
            this.OffPeakLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.OffPeakLabel.Name = "OffPeakLabel";
            this.OffPeakLabel.Size = new System.Drawing.Size(113, 20);
            this.OffPeakLabel.TabIndex = 2;
            this.OffPeakLabel.Text = "Off-Peak kWh";
            // 
            // OffPeakBox
            // 
            this.OffPeakBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OffPeakBox.Location = new System.Drawing.Point(283, 188);
            this.OffPeakBox.Margin = new System.Windows.Forms.Padding(5);
            this.OffPeakBox.Name = "OffPeakBox";
            this.OffPeakBox.Size = new System.Drawing.Size(229, 26);
            this.OffPeakBox.TabIndex = 4;
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBtn.Location = new System.Drawing.Point(168, 292);
            this.CalculateBtn.Margin = new System.Windows.Forms.Padding(5);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(125, 35);
            this.CalculateBtn.TabIndex = 6;
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // ChargeLabel
            // 
            this.ChargeLabel.AutoSize = true;
            this.ChargeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChargeLabel.Location = new System.Drawing.Point(10, 222);
            this.ChargeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ChargeLabel.Name = "ChargeLabel";
            this.ChargeLabel.Size = new System.Drawing.Size(105, 20);
            this.ChargeLabel.TabIndex = 6;
            this.ChargeLabel.Text = "Total Charge";
            this.ChargeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChargeBox
            // 
            this.ChargeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChargeBox.Location = new System.Drawing.Point(11, 247);
            this.ChargeBox.Margin = new System.Windows.Forms.Padding(5);
            this.ChargeBox.Name = "ChargeBox";
            this.ChargeBox.ReadOnly = true;
            this.ChargeBox.Size = new System.Drawing.Size(218, 26);
            this.ChargeBox.TabIndex = 6;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.Location = new System.Drawing.Point(11, 292);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(5);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(125, 35);
            this.ClearBtn.TabIndex = 5;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(950, 363);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(5);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(125, 35);
            this.ExitBtn.TabIndex = 8;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.Location = new System.Drawing.Point(11, 123);
            this.NameBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(501, 27);
            this.NameBox.TabIndex = 2;
            // 
            // AcctBox
            // 
            this.AcctBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcctBox.Location = new System.Drawing.Point(11, 65);
            this.AcctBox.Margin = new System.Windows.Forms.Padding(4);
            this.AcctBox.Name = "AcctBox";
            this.AcctBox.Size = new System.Drawing.Size(229, 27);
            this.AcctBox.TabIndex = 0;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(6, 99);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(131, 20);
            this.NameLabel.TabIndex = 9;
            this.NameLabel.Text = "Customer Name";
            // 
            // AcctLabel
            // 
            this.AcctLabel.AutoSize = true;
            this.AcctLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcctLabel.Location = new System.Drawing.Point(7, 36);
            this.AcctLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AcctLabel.Name = "AcctLabel";
            this.AcctLabel.Size = new System.Drawing.Size(212, 20);
            this.AcctLabel.TabIndex = 10;
            this.AcctLabel.Text = "Customer Account Number";
            // 
            // CustomerList
            // 
            this.CustomerList.FormattingEnabled = true;
            this.CustomerList.ItemHeight = 20;
            this.CustomerList.Location = new System.Drawing.Point(10, 26);
            this.CustomerList.Name = "CustomerList";
            this.CustomerList.Size = new System.Drawing.Size(501, 164);
            this.CustomerList.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddBtn);
            this.groupBox1.Controls.Add(this.AcctLabel);
            this.groupBox1.Controls.Add(this.NameLabel);
            this.groupBox1.Controls.Add(this.AcctBox);
            this.groupBox1.Controls.Add(this.NameBox);
            this.groupBox1.Controls.Add(this.ClearBtn);
            this.groupBox1.Controls.Add(this.ChargeBox);
            this.groupBox1.Controls.Add(this.ChargeLabel);
            this.groupBox1.Controls.Add(this.CalculateBtn);
            this.groupBox1.Controls.Add(this.OffPeakBox);
            this.groupBox1.Controls.Add(this.OffPeakLabel);
            this.groupBox1.Controls.Add(this.InputBox);
            this.groupBox1.Controls.Add(this.DropDown);
            this.groupBox1.Controls.Add(this.InputLabel);
            this.groupBox1.Controls.Add(this.CustomerLabel);
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 343);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Charge";
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Location = new System.Drawing.Point(387, 291);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(5);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(125, 35);
            this.AddBtn.TabIndex = 7;
            this.AddBtn.Text = "Add to List";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CustomersLabel);
            this.groupBox2.Controls.Add(this.CustomersBox);
            this.groupBox2.Controls.Add(this.TotalLabel);
            this.groupBox2.Controls.Add(this.IndustrialLabel);
            this.groupBox2.Controls.Add(this.CommercialLabel);
            this.groupBox2.Controls.Add(this.ResidentialLabel);
            this.groupBox2.Controls.Add(this.TotalBox);
            this.groupBox2.Controls.Add(this.IndustrialBox);
            this.groupBox2.Controls.Add(this.CommercialBox);
            this.groupBox2.Controls.Add(this.ResidentialBox);
            this.groupBox2.Controls.Add(this.CustomerList);
            this.groupBox2.Location = new System.Drawing.Point(544, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(531, 343);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer List";
            // 
            // CustomersLabel
            // 
            this.CustomersLabel.AutoSize = true;
            this.CustomersLabel.Location = new System.Drawing.Point(10, 272);
            this.CustomersLabel.Name = "CustomersLabel";
            this.CustomersLabel.Size = new System.Drawing.Size(133, 20);
            this.CustomersLabel.TabIndex = 21;
            this.CustomersLabel.Text = "Total Customers";
            // 
            // CustomersBox
            // 
            this.CustomersBox.Location = new System.Drawing.Point(10, 296);
            this.CustomersBox.Name = "CustomersBox";
            this.CustomersBox.ReadOnly = true;
            this.CustomersBox.Size = new System.Drawing.Size(150, 27);
            this.CustomersBox.TabIndex = 20;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(185, 272);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(133, 20);
            this.TotalLabel.TabIndex = 19;
            this.TotalLabel.Text = "Customers Total";
            // 
            // IndustrialLabel
            // 
            this.IndustrialLabel.AutoSize = true;
            this.IndustrialLabel.Location = new System.Drawing.Point(361, 208);
            this.IndustrialLabel.Name = "IndustrialLabel";
            this.IndustrialLabel.Size = new System.Drawing.Size(119, 20);
            this.IndustrialLabel.TabIndex = 18;
            this.IndustrialLabel.Text = "Industrial Total";
            // 
            // CommercialLabel
            // 
            this.CommercialLabel.AutoSize = true;
            this.CommercialLabel.Location = new System.Drawing.Point(185, 208);
            this.CommercialLabel.Name = "CommercialLabel";
            this.CommercialLabel.Size = new System.Drawing.Size(141, 20);
            this.CommercialLabel.TabIndex = 17;
            this.CommercialLabel.Text = "Commercial Total";
            // 
            // ResidentialLabel
            // 
            this.ResidentialLabel.AutoSize = true;
            this.ResidentialLabel.Location = new System.Drawing.Point(10, 208);
            this.ResidentialLabel.Name = "ResidentialLabel";
            this.ResidentialLabel.Size = new System.Drawing.Size(134, 20);
            this.ResidentialLabel.TabIndex = 16;
            this.ResidentialLabel.Text = "Residential Total";
            // 
            // TotalBox
            // 
            this.TotalBox.Location = new System.Drawing.Point(189, 295);
            this.TotalBox.Name = "TotalBox";
            this.TotalBox.ReadOnly = true;
            this.TotalBox.Size = new System.Drawing.Size(322, 27);
            this.TotalBox.TabIndex = 15;
            // 
            // IndustrialBox
            // 
            this.IndustrialBox.Location = new System.Drawing.Point(361, 231);
            this.IndustrialBox.Name = "IndustrialBox";
            this.IndustrialBox.ReadOnly = true;
            this.IndustrialBox.Size = new System.Drawing.Size(150, 27);
            this.IndustrialBox.TabIndex = 14;
            // 
            // CommercialBox
            // 
            this.CommercialBox.Location = new System.Drawing.Point(185, 231);
            this.CommercialBox.Name = "CommercialBox";
            this.CommercialBox.ReadOnly = true;
            this.CommercialBox.Size = new System.Drawing.Size(150, 27);
            this.CommercialBox.TabIndex = 13;
            // 
            // ResidentialBox
            // 
            this.ResidentialBox.Location = new System.Drawing.Point(10, 231);
            this.ResidentialBox.Name = "ResidentialBox";
            this.ResidentialBox.ReadOnly = true;
            this.ResidentialBox.Size = new System.Drawing.Size(150, 27);
            this.ResidentialBox.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AcceptButton = this.CalculateBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitBtn;
            this.ClientSize = new System.Drawing.Size(1085, 412);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ExitBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.Text = "Power Bill Calculator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.ComboBox DropDown;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Label OffPeakLabel;
        private System.Windows.Forms.TextBox OffPeakBox;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.Label ChargeLabel;
        private System.Windows.Forms.TextBox ChargeBox;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox AcctBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label AcctLabel;
        private System.Windows.Forms.ListBox CustomerList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label IndustrialLabel;
        private System.Windows.Forms.Label CommercialLabel;
        private System.Windows.Forms.Label ResidentialLabel;
        private System.Windows.Forms.TextBox TotalBox;
        private System.Windows.Forms.TextBox IndustrialBox;
        private System.Windows.Forms.TextBox CommercialBox;
        private System.Windows.Forms.TextBox ResidentialBox;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label CustomersLabel;
        private System.Windows.Forms.TextBox CustomersBox;
    }
}

