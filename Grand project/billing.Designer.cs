namespace Grand_project
{
    partial class billing
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.qty = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.billpgridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cust_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.datetxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.billpgridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(12, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 46);
            this.label3.TabIndex = 19;
            this.label3.Text = "Billing Form";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Panadol",
            "Tanzol",
            "Brufen",
            "Amoxil",
            "Ponstan"});
            this.comboBox1.Location = new System.Drawing.Point(38, 123);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(174, 31);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.Text = "Select Medicine";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // qty
            // 
            this.qty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.qty.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qty.ForeColor = System.Drawing.Color.Brown;
            this.qty.HintForeColor = System.Drawing.Color.Empty;
            this.qty.HintText = "";
            this.qty.isPassword = false;
            this.qty.LineFocusedColor = System.Drawing.Color.Brown;
            this.qty.LineIdleColor = System.Drawing.Color.Gray;
            this.qty.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.qty.LineThickness = 3;
            this.qty.Location = new System.Drawing.Point(38, 277);
            this.qty.Margin = new System.Windows.Forms.Padding(5);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(240, 49);
            this.qty.TabIndex = 21;
            this.qty.Text = "Quantity";
            this.qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "Available Stock :";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Brown;
            this.button9.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(90, 425);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(142, 51);
            this.button9.TabIndex = 23;
            this.button9.Text = "Add To Bill";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // billpgridview
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.billpgridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.billpgridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.billpgridview.BackgroundColor = System.Drawing.Color.White;
            this.billpgridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.billpgridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.billpgridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.billpgridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.billpgridview.ColumnHeadersHeight = 34;
            this.billpgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.billpgridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column6,
            this.Column5,
            this.Column3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.billpgridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.billpgridview.EnableHeadersVisualStyles = false;
            this.billpgridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.billpgridview.Location = new System.Drawing.Point(457, 12);
            this.billpgridview.Name = "billpgridview";
            this.billpgridview.RowHeadersVisible = false;
            this.billpgridview.RowHeadersWidth = 51;
            this.billpgridview.RowTemplate.Height = 24;
            this.billpgridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.billpgridview.Size = new System.Drawing.Size(730, 432);
            this.billpgridview.TabIndex = 24;
            this.billpgridview.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.billpgridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.billpgridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.billpgridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.billpgridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.billpgridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.billpgridview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.billpgridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.billpgridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Brown;
            this.billpgridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.billpgridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.billpgridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.billpgridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.billpgridview.ThemeStyle.HeaderStyle.Height = 34;
            this.billpgridview.ThemeStyle.ReadOnly = false;
            this.billpgridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.billpgridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.billpgridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.billpgridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.billpgridview.ThemeStyle.RowsStyle.Height = 24;
            this.billpgridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.billpgridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column1
            // 
            this.Column1.HeaderText = "MedID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "MedName";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Quantity";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "UnitPrice";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "TotalPrice";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 23);
            this.label2.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(558, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 46);
            this.label4.TabIndex = 26;
            this.label4.Text = "Total Amount";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Brown;
            this.button2.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(864, 482);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 46);
            this.button2.TabIndex = 27;
            this.button2.Text = "Print";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Brown;
            this.button3.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(113, 482);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 46);
            this.button3.TabIndex = 28;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cust_name
            // 
            this.cust_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cust_name.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_name.ForeColor = System.Drawing.Color.Brown;
            this.cust_name.HintForeColor = System.Drawing.Color.Empty;
            this.cust_name.HintText = "";
            this.cust_name.isPassword = false;
            this.cust_name.LineFocusedColor = System.Drawing.Color.Brown;
            this.cust_name.LineIdleColor = System.Drawing.Color.Gray;
            this.cust_name.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.cust_name.LineThickness = 3;
            this.cust_name.Location = new System.Drawing.Point(38, 218);
            this.cust_name.Margin = new System.Windows.Forms.Padding(5);
            this.cust_name.Name = "cust_name";
            this.cust_name.Size = new System.Drawing.Size(240, 49);
            this.cust_name.TabIndex = 29;
            this.cust_name.Text = "Name";
            this.cust_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cust_name.OnValueChanged += new System.EventHandler(this.cust_name_OnValueChanged);
            // 
            // datetxt
            // 
            this.datetxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.datetxt.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetxt.ForeColor = System.Drawing.Color.Brown;
            this.datetxt.HintForeColor = System.Drawing.Color.Empty;
            this.datetxt.HintText = "";
            this.datetxt.isPassword = false;
            this.datetxt.LineFocusedColor = System.Drawing.Color.Brown;
            this.datetxt.LineIdleColor = System.Drawing.Color.Gray;
            this.datetxt.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.datetxt.LineThickness = 3;
            this.datetxt.Location = new System.Drawing.Point(38, 349);
            this.datetxt.Margin = new System.Windows.Forms.Padding(5);
            this.datetxt.Name = "datetxt";
            this.datetxt.Size = new System.Drawing.Size(240, 49);
            this.datetxt.TabIndex = 30;
            this.datetxt.Text = "Date";
            this.datetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 578);
            this.Controls.Add(this.datetxt);
            this.Controls.Add(this.cust_name);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.billpgridview);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qty);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "billing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "billing";
            this.Load += new System.EventHandler(this.billing_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.billpgridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox qty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button9;
        private Guna.UI2.WinForms.Guna2DataGridView billpgridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cust_name;
        private Bunifu.Framework.UI.BunifuMaterialTextbox datetxt;
    }
}