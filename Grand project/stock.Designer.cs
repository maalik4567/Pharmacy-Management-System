namespace Grand_project
{
    partial class stock
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
            this.label1 = new System.Windows.Forms.Label();
            this.MdName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.MdQty = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.expiry = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medicine Stock";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MdName
            // 
            this.MdName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MdName.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MdName.ForeColor = System.Drawing.Color.Brown;
            this.MdName.HintForeColor = System.Drawing.Color.Empty;
            this.MdName.HintText = "";
            this.MdName.isPassword = false;
            this.MdName.LineFocusedColor = System.Drawing.Color.Brown;
            this.MdName.LineIdleColor = System.Drawing.Color.Gray;
            this.MdName.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.MdName.LineThickness = 3;
            this.MdName.Location = new System.Drawing.Point(49, 131);
            this.MdName.Margin = new System.Windows.Forms.Padding(5);
            this.MdName.Name = "MdName";
            this.MdName.Size = new System.Drawing.Size(250, 49);
            this.MdName.TabIndex = 1;
            this.MdName.Text = "MedicineName";
            this.MdName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MdName.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // SPrice
            // 
            this.SPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SPrice.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPrice.ForeColor = System.Drawing.Color.Brown;
            this.SPrice.HintForeColor = System.Drawing.Color.Empty;
            this.SPrice.HintText = "";
            this.SPrice.isPassword = false;
            this.SPrice.LineFocusedColor = System.Drawing.Color.Brown;
            this.SPrice.LineIdleColor = System.Drawing.Color.Gray;
            this.SPrice.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.SPrice.LineThickness = 3;
            this.SPrice.Location = new System.Drawing.Point(353, 240);
            this.SPrice.Margin = new System.Windows.Forms.Padding(5);
            this.SPrice.Name = "SPrice";
            this.SPrice.Size = new System.Drawing.Size(240, 49);
            this.SPrice.TabIndex = 2;
            this.SPrice.Text = "SellingPrice";
            this.SPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BPrice
            // 
            this.BPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BPrice.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BPrice.ForeColor = System.Drawing.Color.Brown;
            this.BPrice.HintForeColor = System.Drawing.Color.Empty;
            this.BPrice.HintText = "";
            this.BPrice.isPassword = false;
            this.BPrice.LineFocusedColor = System.Drawing.Color.Brown;
            this.BPrice.LineIdleColor = System.Drawing.Color.Gray;
            this.BPrice.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.BPrice.LineThickness = 3;
            this.BPrice.Location = new System.Drawing.Point(353, 131);
            this.BPrice.Margin = new System.Windows.Forms.Padding(5);
            this.BPrice.Name = "BPrice";
            this.BPrice.Size = new System.Drawing.Size(240, 49);
            this.BPrice.TabIndex = 3;
            this.BPrice.Text = "BuyingPrice";
            this.BPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // MdQty
            // 
            this.MdQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MdQty.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MdQty.ForeColor = System.Drawing.Color.Brown;
            this.MdQty.HintForeColor = System.Drawing.Color.Empty;
            this.MdQty.HintText = "";
            this.MdQty.isPassword = false;
            this.MdQty.LineFocusedColor = System.Drawing.Color.Brown;
            this.MdQty.LineIdleColor = System.Drawing.Color.Gray;
            this.MdQty.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.MdQty.LineThickness = 3;
            this.MdQty.Location = new System.Drawing.Point(353, 344);
            this.MdQty.Margin = new System.Windows.Forms.Padding(5);
            this.MdQty.Name = "MdQty";
            this.MdQty.Size = new System.Drawing.Size(240, 49);
            this.MdQty.TabIndex = 4;
            this.MdQty.Text = "Quantity";
            this.MdQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "PakMed",
            "MyMed LTD.",
            "Memon CO",
            "Mengrani\'s",
            "Oxinelad"});
            this.comboBox1.Location = new System.Drawing.Point(49, 360);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(240, 33);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "Manufacturer";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(91, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Brown;
            this.button2.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(273, 440);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 43);
            this.button2.TabIndex = 9;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Brown;
            this.button3.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(451, 440);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 43);
            this.button3.TabIndex = 10;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Brown;
            this.button4.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(273, 518);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 43);
            this.button4.TabIndex = 11;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 34;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(591, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(798, 554);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Brown;
            this.dataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.ThemeStyle.HeaderStyle.Height = 34;
            this.dataGridView1.ThemeStyle.ReadOnly = false;
            this.dataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // expiry
            // 
            this.expiry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.expiry.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiry.ForeColor = System.Drawing.Color.Brown;
            this.expiry.HintForeColor = System.Drawing.Color.Empty;
            this.expiry.HintText = "";
            this.expiry.isPassword = false;
            this.expiry.LineFocusedColor = System.Drawing.Color.Brown;
            this.expiry.LineIdleColor = System.Drawing.Color.Gray;
            this.expiry.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.expiry.LineThickness = 3;
            this.expiry.Location = new System.Drawing.Point(49, 240);
            this.expiry.Margin = new System.Windows.Forms.Padding(5);
            this.expiry.Name = "expiry";
            this.expiry.Size = new System.Drawing.Size(250, 49);
            this.expiry.TabIndex = 18;
            this.expiry.Text = "Expiry Date";
            this.expiry.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 578);
            this.Controls.Add(this.expiry);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.MdQty);
            this.Controls.Add(this.BPrice);
            this.Controls.Add(this.SPrice);
            this.Controls.Add(this.MdName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "stock";
            this.Load += new System.EventHandler(this.stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MdName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox SPrice;
        private Bunifu.Framework.UI.BunifuMaterialTextbox BPrice;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MdQty;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox expiry;
    }
}