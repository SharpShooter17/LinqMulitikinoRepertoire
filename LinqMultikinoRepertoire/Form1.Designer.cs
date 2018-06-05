namespace LinqMultikinoRepertoire
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchText1 = new System.Windows.Forms.TextBox();
            this.comboBoxType1 = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.dataSet1 = new System.Data.DataSet();
            this.multikinoData = new System.Windows.Forms.DataGridView();
            this.searchText2 = new System.Windows.Forms.TextBox();
            this.comboBoxType2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multikinoData)).BeginInit();
            this.SuspendLayout();
            // 
            // searchText1
            // 
            this.searchText1.Location = new System.Drawing.Point(12, 12);
            this.searchText1.Name = "searchText1";
            this.searchText1.Size = new System.Drawing.Size(334, 20);
            this.searchText1.TabIndex = 0;
            // 
            // comboBoxType1
            // 
            this.comboBoxType1.FormattingEnabled = true;
            this.comboBoxType1.Items.AddRange(new object[] {
            "None",
            "Cinema",
            "Location",
            "Title",
            "Year",
            "Time",
            "Version"});
            this.comboBoxType1.Location = new System.Drawing.Point(352, 11);
            this.comboBoxType1.Name = "comboBoxType1";
            this.comboBoxType1.Size = new System.Drawing.Size(121, 21);
            this.comboBoxType1.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(910, 9);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "SEARCH";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // multikinoData
            // 
            this.multikinoData.AllowUserToAddRows = false;
            this.multikinoData.AllowUserToDeleteRows = false;
            this.multikinoData.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.multikinoData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.multikinoData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.multikinoData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.multikinoData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.multikinoData.Location = new System.Drawing.Point(12, 38);
            this.multikinoData.Name = "multikinoData";
            this.multikinoData.ReadOnly = true;
            this.multikinoData.Size = new System.Drawing.Size(984, 679);
            this.multikinoData.TabIndex = 3;
            // 
            // searchText2
            // 
            this.searchText2.Location = new System.Drawing.Point(479, 12);
            this.searchText2.Name = "searchText2";
            this.searchText2.Size = new System.Drawing.Size(298, 20);
            this.searchText2.TabIndex = 4;
            // 
            // comboBoxType2
            // 
            this.comboBoxType2.FormattingEnabled = true;
            this.comboBoxType2.Items.AddRange(new object[] {
            "None",
            "Cinema",
            "Location",
            "Title",
            "Year",
            "Time",
            "Version"});
            this.comboBoxType2.Location = new System.Drawing.Point(783, 11);
            this.comboBoxType2.Name = "comboBoxType2";
            this.comboBoxType2.Size = new System.Drawing.Size(121, 21);
            this.comboBoxType2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.comboBoxType2);
            this.Controls.Add(this.searchText2);
            this.Controls.Add(this.multikinoData);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.comboBoxType1);
            this.Controls.Add(this.searchText1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multikinoData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchText1;
        private System.Windows.Forms.ComboBox comboBoxType1;
        private System.Windows.Forms.Button searchButton;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.DataGridView multikinoData;
        private System.Windows.Forms.TextBox searchText2;
        private System.Windows.Forms.ComboBox comboBoxType2;
    }
}

