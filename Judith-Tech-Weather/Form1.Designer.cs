namespace Judith_Tech_Weather
{
    partial class Form1
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
            this.StartRequestBtn = new System.Windows.Forms.Button();
            this.StopRequestBtn = new System.Windows.Forms.Button();
            this.GetCurrentTempBtn = new System.Windows.Forms.Button();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.SecondeTextBox = new System.Windows.Forms.TextBox();
            this.CityTempResultC = new System.Windows.Forms.TextBox();
            this.CityTempResultsF = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TempC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TempF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // StartRequestBtn
            // 
            this.StartRequestBtn.Location = new System.Drawing.Point(28, 27);
            this.StartRequestBtn.Name = "StartRequestBtn";
            this.StartRequestBtn.Size = new System.Drawing.Size(139, 43);
            this.StartRequestBtn.TabIndex = 0;
            this.StartRequestBtn.Text = "Start Auto Request";
            this.StartRequestBtn.UseVisualStyleBackColor = true;
            this.StartRequestBtn.Click += new System.EventHandler(this.StartRequestBtn_Click);
            // 
            // StopRequestBtn
            // 
            this.StopRequestBtn.Location = new System.Drawing.Point(28, 76);
            this.StopRequestBtn.Name = "StopRequestBtn";
            this.StopRequestBtn.Size = new System.Drawing.Size(139, 43);
            this.StopRequestBtn.TabIndex = 1;
            this.StopRequestBtn.Text = "Stop Auto Request";
            this.StopRequestBtn.UseVisualStyleBackColor = true;
            this.StopRequestBtn.Click += new System.EventHandler(this.StopRequestBtn_Click);
            // 
            // GetCurrentTempBtn
            // 
            this.GetCurrentTempBtn.Location = new System.Drawing.Point(28, 125);
            this.GetCurrentTempBtn.Name = "GetCurrentTempBtn";
            this.GetCurrentTempBtn.Size = new System.Drawing.Size(201, 43);
            this.GetCurrentTempBtn.TabIndex = 2;
            this.GetCurrentTempBtn.Text = "Get Current Temperature from File";
            this.GetCurrentTempBtn.UseVisualStyleBackColor = true;
            this.GetCurrentTempBtn.Click += new System.EventHandler(this.GetCurrentTempBtn_Click);
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(199, 50);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(100, 20);
            this.CityTextBox.TabIndex = 3;
            this.CityTextBox.Text = "london";
            this.CityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SecondeTextBox
            // 
            this.SecondeTextBox.Location = new System.Drawing.Point(378, 50);
            this.SecondeTextBox.Name = "SecondeTextBox";
            this.SecondeTextBox.Size = new System.Drawing.Size(48, 20);
            this.SecondeTextBox.TabIndex = 4;
            this.SecondeTextBox.Text = "30";
            this.SecondeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CityTempResultC
            // 
            this.CityTempResultC.Location = new System.Drawing.Point(378, 148);
            this.CityTempResultC.Name = "CityTempResultC";
            this.CityTempResultC.Size = new System.Drawing.Size(104, 20);
            this.CityTempResultC.TabIndex = 5;
            this.CityTempResultC.Text = "Temp in Celsius";
            this.CityTempResultC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CityTempResultsF
            // 
            this.CityTempResultsF.Location = new System.Drawing.Point(506, 148);
            this.CityTempResultsF.Name = "CityTempResultsF";
            this.CityTempResultsF.Size = new System.Drawing.Size(104, 20);
            this.CityTempResultsF.TabIndex = 6;
            this.CityTempResultsF.Text = "Temp in Fahrenheit";
            this.CityTempResultsF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(28, 222);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(139, 43);
            this.AddBtn.TabIndex = 7;
            this.AddBtn.Text = "Add To List";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(199, 245);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Paris";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.City,
            this.TempC,
            this.TempF});
            this.dataGridView1.Location = new System.Drawing.Point(28, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(644, 171);
            this.dataGridView1.TabIndex = 10;
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(702, 416);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(139, 43);
            this.RefreshBtn.TabIndex = 11;
            this.RefreshBtn.Text = "Refresh List";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // City
            // 
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            this.City.Width = 200;
            // 
            // TempC
            // 
            this.TempC.HeaderText = "Temperature C°";
            this.TempC.Name = "TempC";
            this.TempC.ReadOnly = true;
            this.TempC.Width = 200;
            // 
            // TempF
            // 
            this.TempF.HeaderText = "Temperature F°";
            this.TempF.Name = "TempF";
            this.TempF.ReadOnly = true;
            this.TempF.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 471);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.CityTempResultsF);
            this.Controls.Add(this.CityTempResultC);
            this.Controls.Add(this.SecondeTextBox);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.GetCurrentTempBtn);
            this.Controls.Add(this.StopRequestBtn);
            this.Controls.Add(this.StartRequestBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartRequestBtn;
        private System.Windows.Forms.Button StopRequestBtn;
        private System.Windows.Forms.Button GetCurrentTempBtn;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.TextBox SecondeTextBox;
        private System.Windows.Forms.TextBox CityTempResultC;
        private System.Windows.Forms.TextBox CityTempResultsF;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn TempC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TempF;
    }
}

