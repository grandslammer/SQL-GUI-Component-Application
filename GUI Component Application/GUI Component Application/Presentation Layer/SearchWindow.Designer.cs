namespace GUI_Component_Application.Presentation_Layer
{
    partial class SearchWindow
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gradientPanel1 = new GUI_Component_Application.Presentation_Layer.GradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboAvailable = new System.Windows.Forms.ComboBox();
            this.cboField2 = new System.Windows.Forms.ComboBox();
            this.txtFilter3 = new System.Windows.Forms.TextBox();
            this.cboField1 = new System.Windows.Forms.ComboBox();
            this.txtFilter2 = new System.Windows.Forms.TextBox();
            this.cboField3 = new System.Windows.Forms.ComboBox();
            this.txtFilter1 = new System.Windows.Forms.TextBox();
            this.cboOperators1 = new System.Windows.Forms.ComboBox();
            this.cboOperators2 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.cboOperators3 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 275);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 163);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.colorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(209)))), ((int)(((byte)(220)))));
            this.gradientPanel1.colorTop = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(134)))), ((int)(((byte)(229)))));
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Controls.Add(this.Close);
            this.gradientPanel1.Controls.Add(this.btnReset);
            this.gradientPanel1.Controls.Add(this.btnSearch);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.cboAvailable);
            this.gradientPanel1.Controls.Add(this.cboField2);
            this.gradientPanel1.Controls.Add(this.txtFilter3);
            this.gradientPanel1.Controls.Add(this.cboField1);
            this.gradientPanel1.Controls.Add(this.txtFilter2);
            this.gradientPanel1.Controls.Add(this.cboField3);
            this.gradientPanel1.Controls.Add(this.txtFilter1);
            this.gradientPanel1.Controls.Add(this.cboOperators1);
            this.gradientPanel1.Controls.Add(this.cboOperators2);
            this.gradientPanel1.Controls.Add(this.dateTimePicker3);
            this.gradientPanel1.Controls.Add(this.cboOperators3);
            this.gradientPanel1.Controls.Add(this.dateTimePicker2);
            this.gradientPanel1.Controls.Add(this.dateTimePicker1);
            this.gradientPanel1.Location = new System.Drawing.Point(-5, -3);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(810, 459);
            this.gradientPanel1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(307, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 30);
            this.label2.TabIndex = 20;
            this.label2.Text = "Select Search Filters";
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(89)))), ((int)(((byte)(100)))));
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(716, 249);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 15;
            this.Close.Text = "<<";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(89)))), ((int)(((byte)(100)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(15, 249);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(89)))), ((int)(((byte)(100)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(346, 225);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(115, 47);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Run Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(343, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Available?";
            // 
            // cboAvailable
            // 
            this.cboAvailable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAvailable.FormattingEnabled = true;
            this.cboAvailable.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cboAvailable.Location = new System.Drawing.Point(346, 199);
            this.cboAvailable.Name = "cboAvailable";
            this.cboAvailable.Size = new System.Drawing.Size(67, 21);
            this.cboAvailable.TabIndex = 18;
            // 
            // cboField2
            // 
            this.cboField2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboField2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboField2.FormattingEnabled = true;
            this.cboField2.Items.AddRange(new object[] {
            "SKU",
            "Name",
            "Description",
            "Price",
            "Category",
            "SubCategory",
            "Date First In Stock",
            "Available"});
            this.cboField2.Location = new System.Drawing.Point(346, 58);
            this.cboField2.Name = "cboField2";
            this.cboField2.Size = new System.Drawing.Size(120, 21);
            this.cboField2.TabIndex = 2;
            this.cboField2.SelectedIndexChanged += new System.EventHandler(this.CboField2_SelectedIndexChanged);
            this.cboField2.SelectedValueChanged += new System.EventHandler(this.CboField2_SelectedValueChanged);
            // 
            // txtFilter3
            // 
            this.txtFilter3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter3.Location = new System.Drawing.Point(590, 149);
            this.txtFilter3.Name = "txtFilter3";
            this.txtFilter3.Size = new System.Drawing.Size(118, 22);
            this.txtFilter3.TabIndex = 9;
            // 
            // cboField1
            // 
            this.cboField1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboField1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboField1.FormattingEnabled = true;
            this.cboField1.Items.AddRange(new object[] {
            "SKU",
            "Name",
            "Description",
            "Price",
            "Category",
            "SubCategory",
            "Date First In Stock",
            "Available"});
            this.cboField1.Location = new System.Drawing.Point(102, 58);
            this.cboField1.Name = "cboField1";
            this.cboField1.Size = new System.Drawing.Size(122, 21);
            this.cboField1.TabIndex = 17;
            this.cboField1.SelectedIndexChanged += new System.EventHandler(this.CboField1_SelectedIndexChanged_1);
            // 
            // txtFilter2
            // 
            this.txtFilter2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter2.Location = new System.Drawing.Point(346, 149);
            this.txtFilter2.Name = "txtFilter2";
            this.txtFilter2.Size = new System.Drawing.Size(117, 22);
            this.txtFilter2.TabIndex = 8;
            // 
            // cboField3
            // 
            this.cboField3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboField3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboField3.FormattingEnabled = true;
            this.cboField3.Items.AddRange(new object[] {
            "SKU",
            "Name",
            "Description",
            "Price",
            "Category",
            "SubCategory",
            "Date First In Stock",
            "Available"});
            this.cboField3.Location = new System.Drawing.Point(589, 58);
            this.cboField3.Name = "cboField3";
            this.cboField3.Size = new System.Drawing.Size(119, 21);
            this.cboField3.TabIndex = 3;
            this.cboField3.SelectedIndexChanged += new System.EventHandler(this.CboField3_SelectedIndexChanged);
            this.cboField3.SelectedValueChanged += new System.EventHandler(this.CboField3_SelectedValueChanged);
            // 
            // txtFilter1
            // 
            this.txtFilter1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter1.Location = new System.Drawing.Point(103, 146);
            this.txtFilter1.Name = "txtFilter1";
            this.txtFilter1.Size = new System.Drawing.Size(121, 22);
            this.txtFilter1.TabIndex = 7;
            // 
            // cboOperators1
            // 
            this.cboOperators1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOperators1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOperators1.FormattingEnabled = true;
            this.cboOperators1.Location = new System.Drawing.Point(102, 102);
            this.cboOperators1.Name = "cboOperators1";
            this.cboOperators1.Size = new System.Drawing.Size(122, 21);
            this.cboOperators1.TabIndex = 4;
            // 
            // cboOperators2
            // 
            this.cboOperators2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOperators2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOperators2.FormattingEnabled = true;
            this.cboOperators2.Location = new System.Drawing.Point(346, 102);
            this.cboOperators2.Name = "cboOperators2";
            this.cboOperators2.Size = new System.Drawing.Size(120, 21);
            this.cboOperators2.TabIndex = 5;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker3.Location = new System.Drawing.Point(590, 149);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(118, 22);
            this.dateTimePicker3.TabIndex = 14;
            this.dateTimePicker3.ValueChanged += new System.EventHandler(this.DateTimePicker3_ValueChanged);
            // 
            // cboOperators3
            // 
            this.cboOperators3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOperators3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOperators3.FormattingEnabled = true;
            this.cboOperators3.Location = new System.Drawing.Point(589, 102);
            this.cboOperators3.Name = "cboOperators3";
            this.cboOperators3.Size = new System.Drawing.Size(119, 21);
            this.cboOperators3.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(346, 149);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(117, 22);
            this.dateTimePicker2.TabIndex = 13;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.DateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(103, 146);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 22);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // SearchWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gradientPanel1);
            this.Name = "SearchWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchWindow";
            this.Load += new System.EventHandler(this.SearchWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cboField2;
        private System.Windows.Forms.ComboBox cboField3;
        private System.Windows.Forms.ComboBox cboOperators1;
        private System.Windows.Forms.ComboBox cboOperators2;
        private System.Windows.Forms.ComboBox cboOperators3;
        private System.Windows.Forms.TextBox txtFilter1;
        private System.Windows.Forms.TextBox txtFilter2;
        private System.Windows.Forms.TextBox txtFilter3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cboField1;
        private System.Windows.Forms.ComboBox cboAvailable;
        private System.Windows.Forms.Label label1;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Label label2;
    }
}